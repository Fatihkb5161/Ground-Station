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

namespace Ground_Station
{
    public partial class Form1 : Form
    {
        /*--------------------Variables------------------*/
        string[] portlar = SerialPort.GetPortNames();
        string alt, lat, lon, irtifa, basinc, sicak, pilGer, pitch, roll, heading, relAlt, rollSpeed;
        double HedefLat, HedefLon;
        string ihaBaudRate, ihaPortName;
        GMapOverlay ihaMarker = new GMapOverlay("Markers");

        static string argument;

        PointLatLng ihaPoint;

        int paketNo = 0, mapCounter = 0;
        int counter1 = 0, counter2 = 0, counter3 = 0, counter4 = 0;
        int counter;

        private void imhaDurBtn_Click(object sender, EventArgs e)
        {
            programWorking = false;
        }


        float turnRate;

        Thread thrd, thrd1;

        

        double ihaLat, ihaLon;


        bool programWorking = true, ihaHedefeGit, ihaDur, ihaEveDon, ihaInisYap;
        Bitmap flagLogo = (Bitmap)Image.FromFile("C:\\Users\\mefat\\OneDrive\\Masaüstü\\AkdoganYerIstasyonu\\logos\\Türk bayrağı.png");
        Bitmap imhaLogo = (Bitmap)Image.FromFile("..\\logos\\imhalogo.png");
        Bitmap yardimLogo = (Bitmap)Image.FromFile("C:\\Users\\mefat\\OneDrive\\Masaüstü\\AkdoganYerIstasyonu\\logos\\yardımlogo.png");

        GMapOverlay markers = new GMapOverlay("Markers");

        /*---------------------Form----------------------*/
        public Form1()
        {
            InitializeComponent();
            map.Overlays.Add(ihaMarker);
            turnControl.SetTurnCoordinatorParameters(0, 0);
            thrd1 = new Thread(() => 
            {
                counter++;
                label9.Text = counter.ToString();
            });
            thrd = new Thread(() =>
            {
                
                while (programWorking)
                {
                    argument = $"\"{ihaPortName}\" \"{ihaBaudRate}\" \"{ihaHedefeGit}\" \"{ihaDur}\" \"{ihaEveDon}\" \"{ihaInisYap}\" \"{HedefLat}\" \"{HedefLon}\"";
                    pymavlink(argument);
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
        }
        /*----------------------Control------------------*/
        private void GitBtn_Click(object sender, EventArgs e)
        {
            HedefLat = Convert.ToDouble(HedefLatTxt.Text);
            HedefLon = Convert.ToDouble(HedefLonTxt.Text);
            ihaHedefeGit = true;
        }


        private void EveDonBtn_Click(object sender, EventArgs e)
        {
            ihaEveDon = true;
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

            thrd1.Start();

        }

        public void pymavlink(string arg)
        {
            var psi = new ProcessStartInfo();

            psi.FileName = @"C:\Users\mefat\AppData\Local\Programs\Python\Python311\python.exe";

            var script = @"C:\Users\mefat\OneDrive\Masaüstü\AkdoganYerIstasyonu\connection.py";

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
                    process.WaitForExit();
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

            try
            {
                alt = results.Split(':')[0];
                lat = results.Split(':')[1];
                lon = results.Split(':')[2];
                irtifa = results.Split(':')[3];
                basinc = results.Split(':')[4];
                sicak = results.Split(':')[5];
                pilGer = results.Split(':')[6];
                pitch = results.Split(':')[7];
                roll = results.Split(':')[8];
                heading = results.Split(':')[9];
                relAlt = results.Split(':')[10];
                rollSpeed = results.Split(':')[11];
            }
            catch (Exception except)
            { 
                MessageBox.Show("alt = result:" + except.Message);
            }

            try
            {
                paketValue.Text = paketNo.ToString();
                altValue.Text = Convert.ToString(Convert.ToDouble(alt) / 10000000);
                latValue.Text = Convert.ToString(Convert.ToDouble(lat) / 10000000);
                lonValue.Text = Convert.ToString(Convert.ToDouble(lon) / 10000000);
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
                this.sicaklikChart.Series[0].Points.AddY(sicak);
                this.basincChart.Series[0].Points.AddY(basinc);
            }
            catch (Exception except)
            {
                MessageBox.Show("sicaklikChart.Series:" + except.Message);
            }

            map.DragButton = MouseButtons.Left; 
            map.MapProvider = GMapProviders.GoogleMap;
            //map.Overlays.Clear();

           
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
                Console.WriteLine(turnRate);
                turnControl.SetTurnCoordinatorParameters(turnRate, 0);
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

            try
            {
                
                ihaLat = Convert.ToDouble(lat) / 10000000;
                ihaLon = Convert.ToDouble(lon) / 10000000;
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

        }

    }
}
