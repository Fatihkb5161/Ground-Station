using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using AvionicsInstrumentControlDemo;
using System.Data.Entity.ModelConfiguration.Configuration;
using GMap.NET.WindowsPresentation;
using GMapMarker = GMap.NET.WindowsForms.GMapMarker;
using Ground_Station.Properties;
using Python.Runtime;
using System.Configuration;
using System.Net.Mime;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Text.Json;

namespace Ground_Station
{
    public partial class Form1 : Form
    {
        /*--------------------Variables------------------*/

        bool yardimIha = false, imhaIha = false;
        List<int> ids = new List<int>();
        string[] portlar = SerialPort.GetPortNames();
        string alt, lat, lon, irtifa, basinc, sicak, pilGer, pitch, roll, heading, relAlt, rollSpeed, ygyro, gps;
        double HedefLat, HedefLon;
        string ihaBaudRate, ihaPortName;
        string url = "https://api.thingspeak.com/channels/2461285/feeds.json?results=1";
        GMapOverlay ihaMarker = new GMapOverlay("Markers");

        int saniye, dakika, saat;
        int Ucussaniye = 10;

        Dictionary<string, string> myDict;

        static string argument;

        PointLatLng ihaPoint;

        int paketNo = 0, mapCounter = 0;
        int counter1 = 0, counter2 = 0, counter3 = 0, counter4 = 0;
        int counter;
        int messageCounter = 0;

        private void imhaDurBtn_Click(object sender, EventArgs e)
        {
            programWorking = false;
        }


        float turnRate;

        Thread thrd, thrd1, thrd2, thrd3, thrd4, thrd5;

        private void manuelBtn_Click(object sender, EventArgs e)
        {
            PythonEngine.Initialize();
            using (Py.GIL())
            {
                PyObject vehicle = null;
                dynamic sys = Py.Import("sys");
                sys.path.append(@"..\\..\\..\\Ground Station");


                var pythonScript = Py.Import("connection");

                vehicle = pythonScript.InvokeMethod("get_iha");
                pythonScript.InvokeMethod("mode_manuel", new PyObject[] { vehicle });


            }
        }

        static HashSet<int> printedIds = new HashSet<int>();
        private void messageTimer_Tick(object sender, EventArgs e)
        {
            
            Ucussaniye -= 1;
            ucusSnLbl.Text = Ucussaniye.ToString();

            if(Ucussaniye == 0)
            {
                thrd3 = new Thread(() =>
                {
                    PythonEngine.Initialize();
                    using (Py.GIL())
                    {
                        PyObject vehicle = null;
                        dynamic sys = Py.Import("sys");
                        sys.path.append(@"C:\Users\mefat\OneDrive\Masaüstü\AkdoganYerIstasyonu\Ground Station");



                        var connection = Py.Import("connection");
                        var arm = Py.Import("arm");

                        var uav = connection.InvokeMethod("get_iha");
                        arm.InvokeMethod("ihaMove", new PyObject[] { uav });


                    }
                });
                thrd3.Start();
                messageTimer.Stop();
                ucusSnLbl.ForeColor = Color.Green;
                ucusSnLbl.Text = "Uçuş Başlıyor!";
            }

        }

        double ihaLat, ihaLon;
        int checker = 0;
        


        bool programWorking = true, ihaHedefeGit, ihaDur, ihaEveDon, ihaInisYap;
        Bitmap flagLogo     = (Bitmap)Image.FromFile(@"..\\..\\..\\Resources\\Türk bayrağı.png");
        Bitmap imhaLogo     = (Bitmap)Image.FromFile(@"..\\..\\..\\Resources\\imhaLogo.png");
        Bitmap yardimLogo   = (Bitmap)Image.FromFile(@"..\\..\\..\\Resources\\yardımlogo.png");

        GMapOverlay markers = new GMapOverlay("Markers");

        /*---------------------Form----------------------*/
        public Form1()
        {
            InitializeComponent();
            Runtime.PythonDLL = @"C:\Users\mefat\AppData\Local\Programs\Python\Python311-32\python311.dll";

            thrd5 = new Thread(() =>
            {
                message();
            });
            thrd5.Start();

            map.Overlays.Add(ihaMarker);
            thrd = new Thread(() =>
            {
                
               while (programWorking)
                {
                    pymavlink();
                    try 
                    {
                        if (mapCounter != 1)
                        {
                            map.Manager.Mode = AccessMode.ServerOnly;
                            GMapProvider.WebProxy = null;
                            map.Position = ihaPoint;
                            map.Zoom = 17;
                            mapCounter++;
                        }
                    }
                    catch { }

                    if (counter1 == 0 && ihaHedefeGit == true)
                    {
                        counter1++;
                    }
                    else
                    {
                        ihaHedefeGit = false;
                        counter1 = 0;
                    }
                    if (counter2 == 0 && ihaEveDon == true)
                    {
                            
                        counter2++;
                    }
                    else
                    {
                        ihaEveDon = false;
                        counter2 = 0;
                    }
                    if (counter3 == 0 && ihaDur == true)
                    {
                            
                        counter3++;
                    }
                    else
                    {
                        ihaDur = false;
                        counter3 = 0;
                    }
                    if (counter4 == 0 && ihaInisYap == true)
                    {
                            
                        counter4++;
                    }
                    else
                    {
                        ihaInisYap = false;
                        counter4 = 0;
                    }


                }

            });

            thrd1 = new Thread(() => {

                while (programWorking)
                {
                    mapControl();
                }
            });

        }

        public class Channel
        {
            public int id { get; set; }
            public string name { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
            public string field1 { get; set; }
            public string field2 { get; set; }
            public string field3 { get; set; }
            public string field4 { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public int last_entry_id { get; set; }
        }

        public class Feed
        {
            public string created_at { get; set; }
            public int entry_id { get; set; }
            public double field1 { get; set; }
            public double field2 { get; set; }
            public string field3 { get; set; }
            public string field4 { get; set; }
        }

        public class Root
        {
            public Channel channel { get; set; }
            public List<Feed> feeds { get; set; }
        }

        private async Task message()
        {
            
            while (true)
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage clockMessage = await client.GetAsync(url);
                clockMessage.EnsureSuccessStatusCode();
                var messages = await clockMessage.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Root>(messages);
                clock(Convert.ToInt32(data.feeds[0].field4));
                string selectedIha = "";
                if (data != null && !printedIds.Contains(data.feeds[0].entry_id))
                {
                    if (data.feeds[0].field3 == "0")
                    {
                        checkedListBox1.Items.Add($"İha: İmha, lat: {Convert.ToDouble(data.feeds[0].field1) / 1000000}, lon: {Convert.ToDouble(data.feeds[0].field2) / 1000000}, Saat: {saat}.{dakika}.{saniye}");
                        HedefLatTxt.Text =(Convert.ToDouble(data.feeds[0].field1) / 1000000).ToString();
                        HedefLonTxt.Text =(Convert.ToDouble(data.feeds[0].field2) / 1000000).ToString();
                        selectedIha = "0";
                        this.Invoke((MethodInvoker)delegate {
                            // 'this' refers to the form in this context
                            messageTimer.Start();
                        });
                    }
                    else if (data.feeds[0].field3 == "1")
                    {
                        checkedListBox1.Items.Add($"İha: Destek, lat: {Convert.ToDouble(data.feeds[0].field1) / 1000000}, lon: {Convert.ToDouble(data.feeds[0].field2) / 1000000}, Saat: {saat}.{dakika}.{saniye}");
                        HedefLatTxt.Text = (Convert.ToDouble(data.feeds[0].field1) / 1000000).ToString();
                        HedefLonTxt.Text = (Convert.ToDouble(data.feeds[0].field2) / 1000000).ToString();
                        selectedIha = "1";
                        this.Invoke((MethodInvoker)delegate {
                            // 'this' refers to the form in this context
                            messageTimer.Start();
                        });

                    }
                    else
                    {
                        selectedIha = "2";
                    }

                    printedIds.Add(data.feeds[0].entry_id);
                }
                
                    
            }
                

        }

        private void clock(int clockTime)
        {
            saniye = clockTime % 60;
            clockTime /= 60;
            dakika = clockTime % 60;
            saat = clockTime / 60;
        }

        /*----------------------Control------------------*/
        private void GitBtn_Click(object sender, EventArgs e)
        {
            HedefLat = Convert.ToDouble(HedefLatTxt.Text);
            HedefLon = Convert.ToDouble(HedefLonTxt.Text);
            thrd3 = new Thread(() =>
            {
                PythonEngine.Initialize();
                using (Py.GIL())
                {
                    PyObject vehicle = null;
                    dynamic sys = Py.Import("sys");
                    sys.path.append(@"..\\..\\..\\Ground Station");



                    var connection = Py.Import("connection");
                    var arm = Py.Import("arm");

                    var uav = connection.InvokeMethod("get_iha");
                    arm.InvokeMethod("ihaMove", new PyObject[] { uav });


                }
            });
            thrd3.Start();

        }


        private void EveDonBtn_Click(object sender, EventArgs e)
        {
            thrd3 = new Thread(() =>
            {
                PythonEngine.Initialize();
                using (Py.GIL())
                {
                    PyObject vehicle = null;
                    dynamic sys = Py.Import("sys");
                    sys.path.append(@"..\\..\\..\\Ground Station");

                    var connection = Py.Import("connection");
                    var uav = connection.InvokeMethod("return_iha");


                }
            });
            thrd3.Start();
        }

        private void DurBtn_Click(object sender, EventArgs e)
        {
            ihaDur = true;
        }

        private void InisBtn_Click(object sender, EventArgs e)
        {
            ihaInisYap = true;
        }

        private void YazBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ihaPortName = ihaPort.SelectedItem.ToString();
                ihaBaudRate = ihaBaud.SelectedItem.ToString();
                thrd.Start();
                //thrd1.Start();
            }
            catch (Exception except)
            {
                MessageBox.Show("YazBtn:" + except.Message);
            }
        }



        /*---------------Form Load-----------------------*/
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            map.ShowCenter = false;
            foreach (string port in portlar)
            {
                ihaPort.Items.Add(port);
            }
            ihaPort.SelectedIndex = 0;
            ihaBaud.SelectedIndex = 0;
        }

        public void mapControl()
        {
            

        }

        public void pymavlink()
        {

            /*var psi = new ProcessStartInfo();
            
            psi.FileName = @"C:\Users\mefat\AppData\Local\Programs\Python\Python311-32\python.exe";
            
            var script = @"C:\\Users\\mefat\\OneDrive\\Masaüstü\\AkdoganYerIstasyonu\\connection.py";
            
            psi.Arguments = string.Format(@"{0} {1}", script, arg);
            
            
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            
            var errors = "";
            var results = "";

            try
            {
                using (var process = Process.Start(psi))
                {
                    errors = process.StandardError.ReadToEnd();
                    results = process.StandardOutput.ReadToEnd();
                    //process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("process:" + ex.Message);
            }
            
            //5) Display output
            Console.WriteLine("ERRORS:");
            Console.WriteLine(errors);
            Console.WriteLine("RESULTS:");
            Console.WriteLine(results);
            */

            
            PythonEngine.Initialize();
            string results = null;
            using (Py.GIL())
            {
                PyObject vehicle = null;
                dynamic sys = Py.Import("sys");
                sys.path.append(@"..\\..\\..\\Ground Station");


                var pythonScript = Py.Import("connection");
                
                //var message = new PyString(argument);
                results = pythonScript.InvokeMethod("messages").ToString();
                

            }

            try
            {
                alt = results.Split(':')[0].Replace('.', ',');
                lat = results.Split(':')[1].Replace('.', ',');
                lon = results.Split(':')[2].Replace('.', ',');
                irtifa = results.Split(':')[3];
                basinc = results.Split(':')[4];
                sicak = results.Split(':')[5];
                pilGer = results.Split(':')[6];
                pitch = results.Split(':')[7];
                roll = results.Split(':')[8];
                heading = results.Split(':')[9];
                relAlt = results.Split(':')[10];
                rollSpeed = results.Split(':')[11];
                ygyro = results.Split(':')[12];
                gps = results.Split(':')[13];
            }
            catch (Exception except)
            { 
                MessageBox.Show("alt = result:" + except.Message);
            }

            try
            {
                paketValue.Text = paketNo.ToString();
                altValue.Text = alt.ToString();
                latValue.Text = lat.ToString();
                lonValue.Text = lon.ToString();
                sicaklikValue.Text = sicak;
                irtifaValue.Text = irtifa;
                basincValue.Text = basinc;
                pilValue.Text = pilGer;
                paketNo += 1;
                rollValue.Text = roll;
                pitchValue.Text = pitch;
                rollSpeedValue.Text = rollSpeed;

            }
            catch (Exception except)
            {
                MessageBox.Show("paketValue.Text = paketNo:" + except.Message);
            }


            try
            {
                altimeter.SetAltimeterParameters(Convert.ToInt32(relAlt.Split('.')[0]));
            }
            catch (Exception ex)
            {
                MessageBox.Show("altimeter" + ex);
            }

            try
            {
                attitude.SetAttitudeIndicatorParameters(Convert.ToInt32(pitch.Split('.')[0]), Convert.ToInt32(roll.Split('.')[0])); //   
            }
            catch (Exception ex)
            {
                MessageBox.Show("attitude" + ex);
            }

            try
            {
                turnRate = float.Parse(rollSpeed.Replace('.', ','));
                turnControl.SetTurnCoordinatorParameters(turnRate, Convert.ToInt32(ygyro));
            }
            catch (Exception ex)
            {
                MessageBox.Show("turn control" + ex);
            }


            try
            {
                headingControl.SetHeadingIndicatorParameters(Convert.ToInt32(heading));
            }
            catch (Exception ex)
            {
                MessageBox.Show("attitude" + ex);
            }

            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleSatelliteMap;
            //map.Overlays.Clear();
            try
            {

                ihaLat = Convert.ToDouble(lat);
                ihaLon = Convert.ToDouble(lon);
                ihaPoint = new PointLatLng(ihaLat, ihaLon);
                GMapMarker yardimMarker = new GMarkerGoogle(ihaPoint, yardimLogo);
                ihaMarker.Markers.Clear();
                ihaMarker.Markers.Add(yardimMarker);
                if (ihaMarker.Markers.Count > 1)
                {
                    ihaMarker.Markers.RemoveAt(0);
                }




            }
            catch (Exception except)
            {
                MessageBox.Show("ihaLat = Convert:" + except.Message);
            }
            map.Refresh();
            map.MinZoom = 3;
            map.MaxZoom = 24;


        }



        /*---------------Form Close-----------------------*/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           programWorking = false;
           thrd.Abort();
           messageTimer.Stop();
        }

    }
}
