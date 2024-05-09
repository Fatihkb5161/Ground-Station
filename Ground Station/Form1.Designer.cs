namespace Ground_Station
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel41 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpsNumberLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rollSpeedValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pitchValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rollValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pilValue = new System.Windows.Forms.Label();
            this.basincValue = new System.Windows.Forms.Label();
            this.sicaklikValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.irtifaValue = new System.Windows.Forms.Label();
            this.altValue = new System.Windows.Forms.Label();
            this.latValue = new System.Windows.Forms.Label();
            this.lonValue = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.paketValue = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.imhaDurBtn = new System.Windows.Forms.Button();
            this.ihaPort = new System.Windows.Forms.ComboBox();
            this.YazBtn = new System.Windows.Forms.Button();
            this.ihaBaud = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manuelBtn = new System.Windows.Forms.Button();
            this.HedefAltTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HedefLatTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.InisBtn = new System.Windows.Forms.Button();
            this.DurBtn = new System.Windows.Forms.Button();
            this.GitBtn = new System.Windows.Forms.Button();
            this.EveDonBtn = new System.Windows.Forms.Button();
            this.HedefLonTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.messageTimer = new System.Windows.Forms.Timer(this.components);
            this.altimeter = new AvionicsInstrumentControlDemo.AltimeterInstrumentControl();
            this.attitude = new AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl();
            this.headingControl = new AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl();
            this.turnControl = new AvionicsInstrumentControlDemo.TurnCoordinatorInstrumentControl();
            this.label10 = new System.Windows.Forms.Label();
            this.ucusSnLbl = new System.Windows.Forms.Label();
            this.panel41.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.tabControl1);
            this.panel41.Controls.Add(this.groupBox4);
            this.panel41.Controls.Add(this.pictureBox2);
            this.panel41.Controls.Add(this.pictureBox1);
            this.panel41.Controls.Add(this.panel2);
            this.panel41.Controls.Add(this.groupBox2);
            this.panel41.Controls.Add(this.groupBox6);
            this.panel41.Controls.Add(this.groupBox1);
            this.panel41.Controls.Add(this.map);
            this.panel41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel41.Location = new System.Drawing.Point(0, 0);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(1924, 1055);
            this.panel41.TabIndex = 45;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 501);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(351, 464);
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.tabPage1.Controls.Add(this.ucusSnLbl);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.gpsNumberLbl);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(343, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uçuş Öncesi";
            // 
            // gpsNumberLbl
            // 
            this.gpsNumberLbl.AutoSize = true;
            this.gpsNumberLbl.ForeColor = System.Drawing.Color.Red;
            this.gpsNumberLbl.Location = new System.Drawing.Point(189, 36);
            this.gpsNumberLbl.Name = "gpsNumberLbl";
            this.gpsNumberLbl.Size = new System.Drawing.Size(41, 16);
            this.gpsNumberLbl.TabIndex = 1;
            this.gpsNumberLbl.Text = "0 >= 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(26, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Verify GPS:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(343, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.groupBox4.Controls.Add(this.tableLayoutPanel1);
            this.groupBox4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox4.Location = new System.Drawing.Point(466, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(900, 235);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Göstergeler";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.altimeter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.attitude, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.headingControl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.turnControl, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(894, 214);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1388, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1660, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(12, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 468);
            this.panel2.TabIndex = 53;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.groupBox3.Controls.Add(this.rollSpeedValue);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.pitchValue);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rollValue);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pilValue);
            this.groupBox3.Controls.Add(this.basincValue);
            this.groupBox3.Controls.Add(this.sicaklikValue);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.irtifaValue);
            this.groupBox3.Controls.Add(this.altValue);
            this.groupBox3.Controls.Add(this.latValue);
            this.groupBox3.Controls.Add(this.lonValue);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.paketValue);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 468);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yardım Telemetri Verileri";
            // 
            // rollSpeedValue
            // 
            this.rollSpeedValue.AutoSize = true;
            this.rollSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rollSpeedValue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rollSpeedValue.Location = new System.Drawing.Point(146, 436);
            this.rollSpeedValue.Name = "rollSpeedValue";
            this.rollSpeedValue.Size = new System.Drawing.Size(18, 20);
            this.rollSpeedValue.TabIndex = 28;
            this.rollSpeedValue.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Roll Speed:";
            // 
            // pitchValue
            // 
            this.pitchValue.AutoSize = true;
            this.pitchValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pitchValue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pitchValue.Location = new System.Drawing.Point(146, 406);
            this.pitchValue.Name = "pitchValue";
            this.pitchValue.Size = new System.Drawing.Size(18, 20);
            this.pitchValue.TabIndex = 26;
            this.pitchValue.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(27, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Pitch:";
            // 
            // rollValue
            // 
            this.rollValue.AutoSize = true;
            this.rollValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rollValue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rollValue.Location = new System.Drawing.Point(146, 370);
            this.rollValue.Name = "rollValue";
            this.rollValue.Size = new System.Drawing.Size(18, 20);
            this.rollValue.TabIndex = 24;
            this.rollValue.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Roll:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Paket No:";
            // 
            // pilValue
            // 
            this.pilValue.AutoSize = true;
            this.pilValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pilValue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pilValue.Location = new System.Drawing.Point(146, 336);
            this.pilValue.Name = "pilValue";
            this.pilValue.Size = new System.Drawing.Size(18, 20);
            this.pilValue.TabIndex = 18;
            this.pilValue.Text = "0";
            // 
            // basincValue
            // 
            this.basincValue.AutoSize = true;
            this.basincValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basincValue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.basincValue.Location = new System.Drawing.Point(146, 252);
            this.basincValue.Name = "basincValue";
            this.basincValue.Size = new System.Drawing.Size(18, 20);
            this.basincValue.TabIndex = 17;
            this.basincValue.Text = "0";
            // 
            // sicaklikValue
            // 
            this.sicaklikValue.AutoSize = true;
            this.sicaklikValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sicaklikValue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.sicaklikValue.Location = new System.Drawing.Point(146, 301);
            this.sicaklikValue.Name = "sicaklikValue";
            this.sicaklikValue.Size = new System.Drawing.Size(18, 20);
            this.sicaklikValue.TabIndex = 16;
            this.sicaklikValue.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(26, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pil Gerilimi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(26, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sıcaklık:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(26, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Basınç:";
            // 
            // irtifaValue
            // 
            this.irtifaValue.AutoSize = true;
            this.irtifaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.irtifaValue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.irtifaValue.Location = new System.Drawing.Point(146, 206);
            this.irtifaValue.Name = "irtifaValue";
            this.irtifaValue.Size = new System.Drawing.Size(18, 20);
            this.irtifaValue.TabIndex = 12;
            this.irtifaValue.Text = "0";
            // 
            // altValue
            // 
            this.altValue.AutoSize = true;
            this.altValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.altValue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.altValue.Location = new System.Drawing.Point(146, 79);
            this.altValue.Name = "altValue";
            this.altValue.Size = new System.Drawing.Size(18, 20);
            this.altValue.TabIndex = 11;
            this.altValue.Text = "0";
            // 
            // latValue
            // 
            this.latValue.AutoSize = true;
            this.latValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.latValue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.latValue.Location = new System.Drawing.Point(146, 120);
            this.latValue.Name = "latValue";
            this.latValue.Size = new System.Drawing.Size(18, 20);
            this.latValue.TabIndex = 10;
            this.latValue.Text = "0";
            // 
            // lonValue
            // 
            this.lonValue.AutoSize = true;
            this.lonValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lonValue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lonValue.Location = new System.Drawing.Point(146, 159);
            this.lonValue.Name = "lonValue";
            this.lonValue.Size = new System.Drawing.Size(18, 20);
            this.lonValue.TabIndex = 9;
            this.lonValue.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label18.Location = new System.Drawing.Point(26, 206);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 20);
            this.label18.TabIndex = 8;
            this.label18.Text = "İrtifa Farkı:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label19.Location = new System.Drawing.Point(26, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 20);
            this.label19.TabIndex = 6;
            this.label19.Text = "Longtitude:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label20.Location = new System.Drawing.Point(26, 120);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 20);
            this.label20.TabIndex = 4;
            this.label20.Text = "Latitude:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label21.Location = new System.Drawing.Point(26, 79);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 20);
            this.label21.TabIndex = 2;
            this.label21.Text = "Altitude:";
            // 
            // paketValue
            // 
            this.paketValue.AutoSize = true;
            this.paketValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paketValue.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.paketValue.Location = new System.Drawing.Point(146, 41);
            this.paketValue.Name = "paketValue";
            this.paketValue.Size = new System.Drawing.Size(18, 20);
            this.paketValue.TabIndex = 1;
            this.paketValue.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.Location = new System.Drawing.Point(1388, 492);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 186);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Akıllı Saat Bilgisi";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 18);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(482, 165);
            this.checkedListBox1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.groupBox6.Controls.Add(this.imhaDurBtn);
            this.groupBox6.Controls.Add(this.ihaPort);
            this.groupBox6.Controls.Add(this.YazBtn);
            this.groupBox6.Controls.Add(this.ihaBaud);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox6.Location = new System.Drawing.Point(1626, 319);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(250, 167);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "İHA Bağlantı";
            // 
            // imhaDurBtn
            // 
            this.imhaDurBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imhaDurBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.imhaDurBtn.Location = new System.Drawing.Point(147, 110);
            this.imhaDurBtn.Name = "imhaDurBtn";
            this.imhaDurBtn.Size = new System.Drawing.Size(97, 38);
            this.imhaDurBtn.TabIndex = 11;
            this.imhaDurBtn.Text = "Dur";
            this.imhaDurBtn.UseVisualStyleBackColor = false;
            this.imhaDurBtn.Click += new System.EventHandler(this.imhaDurBtn_Click);
            // 
            // ihaPort
            // 
            this.ihaPort.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ihaPort.FormattingEnabled = true;
            this.ihaPort.Items.AddRange(new object[] {
            "udpin:0.0.0.0:14550",
            "COM6"});
            this.ihaPort.Location = new System.Drawing.Point(106, 27);
            this.ihaPort.Name = "ihaPort";
            this.ihaPort.Size = new System.Drawing.Size(138, 24);
            this.ihaPort.TabIndex = 6;
            // 
            // YazBtn
            // 
            this.YazBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YazBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.YazBtn.Location = new System.Drawing.Point(24, 110);
            this.YazBtn.Name = "YazBtn";
            this.YazBtn.Size = new System.Drawing.Size(96, 39);
            this.YazBtn.TabIndex = 10;
            this.YazBtn.Text = "Yaz";
            this.YazBtn.UseVisualStyleBackColor = false;
            this.YazBtn.Click += new System.EventHandler(this.YazBtn_Click);
            // 
            // ihaBaud
            // 
            this.ihaBaud.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ihaBaud.FormattingEnabled = true;
            this.ihaBaud.Items.AddRange(new object[] {
            "115200",
            "57600",
            "9600",
            "4800",
            "",
            ""});
            this.ihaBaud.Location = new System.Drawing.Point(106, 57);
            this.ihaBaud.Name = "ihaBaud";
            this.ihaBaud.Size = new System.Drawing.Size(138, 24);
            this.ihaBaud.TabIndex = 7;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label35.Location = new System.Drawing.Point(21, 56);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(29, 16);
            this.label35.TabIndex = 9;
            this.label35.Text = "Hız:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label36.Location = new System.Drawing.Point(21, 30);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(34, 16);
            this.label36.TabIndex = 8;
            this.label36.Text = "Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.groupBox1.Controls.Add(this.manuelBtn);
            this.groupBox1.Controls.Add(this.HedefAltTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.HedefLatTxt);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.InisBtn);
            this.groupBox1.Controls.Add(this.DurBtn);
            this.groupBox1.Controls.Add(this.GitBtn);
            this.groupBox1.Controls.Add(this.EveDonBtn);
            this.groupBox1.Controls.Add(this.HedefLonTxt);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(1388, 696);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 269);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontrol Merkezi";
            // 
            // manuelBtn
            // 
            this.manuelBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manuelBtn.Location = new System.Drawing.Point(177, 195);
            this.manuelBtn.Name = "manuelBtn";
            this.manuelBtn.Size = new System.Drawing.Size(136, 33);
            this.manuelBtn.TabIndex = 36;
            this.manuelBtn.Text = "Manuel";
            this.manuelBtn.UseVisualStyleBackColor = true;
            this.manuelBtn.Click += new System.EventHandler(this.manuelBtn_Click);
            // 
            // HedefAltTxt
            // 
            this.HedefAltTxt.Location = new System.Drawing.Point(332, 75);
            this.HedefAltTxt.Name = "HedefAltTxt";
            this.HedefAltTxt.Size = new System.Drawing.Size(146, 22);
            this.HedefAltTxt.TabIndex = 35;
            this.HedefAltTxt.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(328, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Altitude:";
            // 
            // HedefLatTxt
            // 
            this.HedefLatTxt.ForeColor = System.Drawing.Color.Black;
            this.HedefLatTxt.Location = new System.Drawing.Point(15, 75);
            this.HedefLatTxt.Name = "HedefLatTxt";
            this.HedefLatTxt.Size = new System.Drawing.Size(146, 22);
            this.HedefLatTxt.TabIndex = 31;
            this.HedefLatTxt.Text = "35,42";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label15.Location = new System.Drawing.Point(11, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Latitude:";
            // 
            // InisBtn
            // 
            this.InisBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InisBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.InisBtn.Location = new System.Drawing.Point(266, 129);
            this.InisBtn.Name = "InisBtn";
            this.InisBtn.Size = new System.Drawing.Size(88, 47);
            this.InisBtn.TabIndex = 2;
            this.InisBtn.Text = "İniş Yap";
            this.InisBtn.UseVisualStyleBackColor = false;
            this.InisBtn.Click += new System.EventHandler(this.InisBtn_Click);
            // 
            // DurBtn
            // 
            this.DurBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DurBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DurBtn.Location = new System.Drawing.Point(147, 129);
            this.DurBtn.Name = "DurBtn";
            this.DurBtn.Size = new System.Drawing.Size(97, 47);
            this.DurBtn.TabIndex = 3;
            this.DurBtn.Text = "Durdur";
            this.DurBtn.UseVisualStyleBackColor = false;
            this.DurBtn.Click += new System.EventHandler(this.DurBtn_Click);
            // 
            // GitBtn
            // 
            this.GitBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GitBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GitBtn.Location = new System.Drawing.Point(374, 129);
            this.GitBtn.Name = "GitBtn";
            this.GitBtn.Size = new System.Drawing.Size(89, 47);
            this.GitBtn.TabIndex = 4;
            this.GitBtn.Text = "Koordinata Git";
            this.GitBtn.UseVisualStyleBackColor = false;
            this.GitBtn.Click += new System.EventHandler(this.GitBtn_Click);
            // 
            // EveDonBtn
            // 
            this.EveDonBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EveDonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EveDonBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.EveDonBtn.Location = new System.Drawing.Point(24, 129);
            this.EveDonBtn.Name = "EveDonBtn";
            this.EveDonBtn.Size = new System.Drawing.Size(90, 47);
            this.EveDonBtn.TabIndex = 1;
            this.EveDonBtn.Text = "Eve Dön";
            this.EveDonBtn.UseVisualStyleBackColor = false;
            this.EveDonBtn.Click += new System.EventHandler(this.EveDonBtn_Click);
            // 
            // HedefLonTxt
            // 
            this.HedefLonTxt.Location = new System.Drawing.Point(167, 75);
            this.HedefLonTxt.Name = "HedefLonTxt";
            this.HedefLonTxt.Size = new System.Drawing.Size(146, 22);
            this.HedefLonTxt.TabIndex = 33;
            this.HedefLonTxt.Text = "43,23";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label16.Location = new System.Drawing.Point(163, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "Longtitude:";
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1924, 1055);
            this.map.TabIndex = 54;
            this.map.Zoom = 0D;
            // 
            // messageTimer
            // 
            this.messageTimer.Interval = 1000;
            this.messageTimer.Tick += new System.EventHandler(this.messageTimer_Tick);
            // 
            // altimeter
            // 
            this.altimeter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altimeter.Location = new System.Drawing.Point(3, 3);
            this.altimeter.Name = "altimeter";
            this.altimeter.Size = new System.Drawing.Size(217, 208);
            this.altimeter.TabIndex = 0;
            this.altimeter.Text = "altimeterInstrumentControl1";
            // 
            // attitude
            // 
            this.attitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attitude.Location = new System.Drawing.Point(226, 3);
            this.attitude.Name = "attitude";
            this.attitude.Size = new System.Drawing.Size(217, 208);
            this.attitude.TabIndex = 1;
            this.attitude.Text = "attitudeIndicatorInstrumentControl1";
            // 
            // headingControl
            // 
            this.headingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headingControl.Location = new System.Drawing.Point(449, 3);
            this.headingControl.Name = "headingControl";
            this.headingControl.Size = new System.Drawing.Size(217, 208);
            this.headingControl.TabIndex = 2;
            this.headingControl.Text = "headingIndicatorInstrumentControl1";
            // 
            // turnControl
            // 
            this.turnControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnControl.Location = new System.Drawing.Point(672, 3);
            this.turnControl.Name = "turnControl";
            this.turnControl.Size = new System.Drawing.Size(219, 208);
            this.turnControl.TabIndex = 3;
            this.turnControl.Text = "turnCoordinatorInstrumentControl1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(26, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Uçuşa Kalan Süre:";
            // 
            // ucusSnLbl
            // 
            this.ucusSnLbl.AutoSize = true;
            this.ucusSnLbl.ForeColor = System.Drawing.Color.Red;
            this.ucusSnLbl.Location = new System.Drawing.Point(189, 70);
            this.ucusSnLbl.Name = "ucusSnLbl";
            this.ucusSnLbl.Size = new System.Drawing.Size(21, 16);
            this.ucusSnLbl.TabIndex = 3;
            this.ucusSnLbl.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel41);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel41.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel41;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button imhaDurBtn;
        private System.Windows.Forms.ComboBox ihaPort;
        private System.Windows.Forms.Button YazBtn;
        private System.Windows.Forms.ComboBox ihaBaud;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox HedefLatTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button InisBtn;
        private System.Windows.Forms.Button DurBtn;
        private System.Windows.Forms.Button GitBtn;
        private System.Windows.Forms.Button EveDonBtn;
        private System.Windows.Forms.TextBox HedefLonTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pilValue;
        private System.Windows.Forms.Label basincValue;
        private System.Windows.Forms.Label sicaklikValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label irtifaValue;
        private System.Windows.Forms.Label altValue;
        private System.Windows.Forms.Label latValue;
        private System.Windows.Forms.Label lonValue;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label paketValue;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AvionicsInstrumentControlDemo.AltimeterInstrumentControl altimeter;
        private AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl attitude;
        private AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl headingControl;
        private AvionicsInstrumentControlDemo.TurnCoordinatorInstrumentControl turnControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pitchValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label rollValue;
        private System.Windows.Forms.Label rollSpeedValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HedefAltTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label gpsNumberLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer messageTimer;
        private System.Windows.Forms.Button manuelBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ucusSnLbl;
    }
}

