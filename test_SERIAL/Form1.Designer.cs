
namespace test_SERIAL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.serialComm = new System.IO.Ports.SerialPort(this.components);
            this.lbl_sistem1_GyroZ = new System.Windows.Forms.Label();
            this.lbl_SAYAC_payload = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sistem1_enlem = new System.Windows.Forms.Label();
            this.lbl_sistem1_boylam = new System.Windows.Forms.Label();
            this.lbl_sistem1_Gpsirtifa = new System.Windows.Forms.Label();
            this.lbl_sistem1_irtifa = new System.Windows.Forms.Label();
            this.lbl_TakimID = new System.Windows.Forms.Label();
            this.lbl_CRC = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_Payload_irtifa = new System.Windows.Forms.Label();
            this.lbl_Payload_enlem = new System.Windows.Forms.Label();
            this.lbl_Payload_boylam = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_sistem2_GyroZ = new System.Windows.Forms.Label();
            this.lbl_sistem2_irtifa = new System.Windows.Forms.Label();
            this.lbl_sistem2_Enlem = new System.Windows.Forms.Label();
            this.lbl_sistem2_Gpsirtifa = new System.Windows.Forms.Label();
            this.lbl_sistem2_Boylam = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_Payload_Basinc = new System.Windows.Forms.Label();
            this.lbl_Payload_Sicaklik = new System.Windows.Forms.Label();
            this.lbl_Payload_Nem = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_SAYAC_rocket = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gMapControl2 = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lbl_port_payload = new System.Windows.Forms.Label();
            this.lbl_Sistem1_durum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1573, 572);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Haberleşmeye Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialComm
            // 
            this.serialComm.BaudRate = 19200;
            this.serialComm.PortName = "COM7";
            // 
            // lbl_sistem1_GyroZ
            // 
            this.lbl_sistem1_GyroZ.AutoSize = true;
            this.lbl_sistem1_GyroZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sistem1_GyroZ.ForeColor = System.Drawing.Color.White;
            this.lbl_sistem1_GyroZ.Location = new System.Drawing.Point(12, 48);
            this.lbl_sistem1_GyroZ.Name = "lbl_sistem1_GyroZ";
            this.lbl_sistem1_GyroZ.Size = new System.Drawing.Size(86, 25);
            this.lbl_sistem1_GyroZ.TabIndex = 1;
            this.lbl_sistem1_GyroZ.Text = "Gyro-Z:";
            // 
            // lbl_SAYAC_payload
            // 
            this.lbl_SAYAC_payload.AutoSize = true;
            this.lbl_SAYAC_payload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SAYAC_payload.ForeColor = System.Drawing.Color.White;
            this.lbl_SAYAC_payload.Location = new System.Drawing.Point(15, 101);
            this.lbl_SAYAC_payload.Name = "lbl_SAYAC_payload";
            this.lbl_SAYAC_payload.Size = new System.Drawing.Size(243, 29);
            this.lbl_SAYAC_payload.TabIndex = 2;
            this.lbl_SAYAC_payload.Text = "Paket Sayısı Payload:";
            this.lbl_SAYAC_payload.Click += new System.EventHandler(this.lbl_SAYAC_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1692, 499);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1692, 639);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1592, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alıcı Port:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1577, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Verici Port:";
            // 
            // lbl_sistem1_enlem
            // 
            this.lbl_sistem1_enlem.AutoSize = true;
            this.lbl_sistem1_enlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sistem1_enlem.ForeColor = System.Drawing.Color.White;
            this.lbl_sistem1_enlem.Location = new System.Drawing.Point(12, 79);
            this.lbl_sistem1_enlem.Name = "lbl_sistem1_enlem";
            this.lbl_sistem1_enlem.Size = new System.Drawing.Size(79, 25);
            this.lbl_sistem1_enlem.TabIndex = 8;
            this.lbl_sistem1_enlem.Text = "Enlem:";
            // 
            // lbl_sistem1_boylam
            // 
            this.lbl_sistem1_boylam.AutoSize = true;
            this.lbl_sistem1_boylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sistem1_boylam.ForeColor = System.Drawing.Color.White;
            this.lbl_sistem1_boylam.Location = new System.Drawing.Point(12, 111);
            this.lbl_sistem1_boylam.Name = "lbl_sistem1_boylam";
            this.lbl_sistem1_boylam.Size = new System.Drawing.Size(90, 25);
            this.lbl_sistem1_boylam.TabIndex = 9;
            this.lbl_sistem1_boylam.Text = "Boylam:";
            // 
            // lbl_sistem1_Gpsirtifa
            // 
            this.lbl_sistem1_Gpsirtifa.AutoSize = true;
            this.lbl_sistem1_Gpsirtifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sistem1_Gpsirtifa.ForeColor = System.Drawing.Color.White;
            this.lbl_sistem1_Gpsirtifa.Location = new System.Drawing.Point(12, 144);
            this.lbl_sistem1_Gpsirtifa.Name = "lbl_sistem1_Gpsirtifa";
            this.lbl_sistem1_Gpsirtifa.Size = new System.Drawing.Size(112, 25);
            this.lbl_sistem1_Gpsirtifa.TabIndex = 10;
            this.lbl_sistem1_Gpsirtifa.Text = "GPS İrtifa:";
            // 
            // lbl_sistem1_irtifa
            // 
            this.lbl_sistem1_irtifa.AutoSize = true;
            this.lbl_sistem1_irtifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sistem1_irtifa.ForeColor = System.Drawing.Color.White;
            this.lbl_sistem1_irtifa.Location = new System.Drawing.Point(12, 178);
            this.lbl_sistem1_irtifa.Name = "lbl_sistem1_irtifa";
            this.lbl_sistem1_irtifa.Size = new System.Drawing.Size(132, 25);
            this.lbl_sistem1_irtifa.TabIndex = 11;
            this.lbl_sistem1_irtifa.Text = "Basinç İrtifa:";
            // 
            // lbl_TakimID
            // 
            this.lbl_TakimID.AutoSize = true;
            this.lbl_TakimID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TakimID.ForeColor = System.Drawing.Color.White;
            this.lbl_TakimID.Location = new System.Drawing.Point(15, 55);
            this.lbl_TakimID.Name = "lbl_TakimID";
            this.lbl_TakimID.Size = new System.Drawing.Size(115, 29);
            this.lbl_TakimID.TabIndex = 12;
            this.lbl_TakimID.Text = "Takım ID:";
            // 
            // lbl_CRC
            // 
            this.lbl_CRC.AutoSize = true;
            this.lbl_CRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CRC.ForeColor = System.Drawing.Color.White;
            this.lbl_CRC.Location = new System.Drawing.Point(15, 176);
            this.lbl_CRC.Name = "lbl_CRC";
            this.lbl_CRC.Size = new System.Drawing.Size(202, 29);
            this.lbl_CRC.TabIndex = 13;
            this.lbl_CRC.Text = "Cheksum Hesabı:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1573, 675);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "Portları Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Payload_irtifa
            // 
            this.lbl_Payload_irtifa.AutoSize = true;
            this.lbl_Payload_irtifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Payload_irtifa.ForeColor = System.Drawing.Color.White;
            this.lbl_Payload_irtifa.Location = new System.Drawing.Point(16, 139);
            this.lbl_Payload_irtifa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Payload_irtifa.Name = "lbl_Payload_irtifa";
            this.lbl_Payload_irtifa.Size = new System.Drawing.Size(73, 25);
            this.lbl_Payload_irtifa.TabIndex = 19;
            this.lbl_Payload_irtifa.Text = "İrtifa : ";
            this.lbl_Payload_irtifa.Click += new System.EventHandler(this.lbl_Payload_irtifa_Click);
            // 
            // lbl_Payload_enlem
            // 
            this.lbl_Payload_enlem.AutoSize = true;
            this.lbl_Payload_enlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Payload_enlem.ForeColor = System.Drawing.Color.White;
            this.lbl_Payload_enlem.Location = new System.Drawing.Point(16, 74);
            this.lbl_Payload_enlem.Name = "lbl_Payload_enlem";
            this.lbl_Payload_enlem.Size = new System.Drawing.Size(79, 25);
            this.lbl_Payload_enlem.TabIndex = 22;
            this.lbl_Payload_enlem.Text = "Enlem:";
            // 
            // lbl_Payload_boylam
            // 
            this.lbl_Payload_boylam.AutoSize = true;
            this.lbl_Payload_boylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Payload_boylam.ForeColor = System.Drawing.Color.White;
            this.lbl_Payload_boylam.Location = new System.Drawing.Point(16, 107);
            this.lbl_Payload_boylam.Name = "lbl_Payload_boylam";
            this.lbl_Payload_boylam.Size = new System.Drawing.Size(90, 25);
            this.lbl_Payload_boylam.TabIndex = 23;
            this.lbl_Payload_boylam.Text = "Boylam:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(19, 44);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(230, 29);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1. Aviyonik ve Payload";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(19, 79);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(230, 29);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2. Aviyonik ve Payload";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Sistem1_durum);
            this.groupBox1.Controls.Add(this.lbl_sistem1_GyroZ);
            this.groupBox1.Controls.Add(this.lbl_sistem1_enlem);
            this.groupBox1.Controls.Add(this.lbl_sistem1_boylam);
            this.groupBox1.Controls.Add(this.lbl_sistem1_Gpsirtifa);
            this.groupBox1.Controls.Add(this.lbl_sistem1_irtifa);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(28, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(387, 252);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1.Sistem";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbl_sistem2_GyroZ);
            this.groupBox2.Controls.Add(this.lbl_sistem2_irtifa);
            this.groupBox2.Controls.Add(this.lbl_sistem2_Enlem);
            this.groupBox2.Controls.Add(this.lbl_sistem2_Gpsirtifa);
            this.groupBox2.Controls.Add(this.lbl_sistem2_Boylam);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(515, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(387, 252);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2.Sistem";
            // 
            // lbl_sistem2_GyroZ
            // 
            this.lbl_sistem2_GyroZ.AutoSize = true;
            this.lbl_sistem2_GyroZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sistem2_GyroZ.ForeColor = System.Drawing.Color.White;
            this.lbl_sistem2_GyroZ.Location = new System.Drawing.Point(16, 49);
            this.lbl_sistem2_GyroZ.Name = "lbl_sistem2_GyroZ";
            this.lbl_sistem2_GyroZ.Size = new System.Drawing.Size(86, 25);
            this.lbl_sistem2_GyroZ.TabIndex = 14;
            this.lbl_sistem2_GyroZ.Text = "Gyro-Z:";
            // 
            // lbl_sistem2_irtifa
            // 
            this.lbl_sistem2_irtifa.AutoSize = true;
            this.lbl_sistem2_irtifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sistem2_irtifa.ForeColor = System.Drawing.Color.White;
            this.lbl_sistem2_irtifa.Location = new System.Drawing.Point(16, 180);
            this.lbl_sistem2_irtifa.Name = "lbl_sistem2_irtifa";
            this.lbl_sistem2_irtifa.Size = new System.Drawing.Size(132, 25);
            this.lbl_sistem2_irtifa.TabIndex = 19;
            this.lbl_sistem2_irtifa.Text = "Basinç İrtifa:";
            // 
            // lbl_sistem2_Enlem
            // 
            this.lbl_sistem2_Enlem.AutoSize = true;
            this.lbl_sistem2_Enlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sistem2_Enlem.ForeColor = System.Drawing.Color.White;
            this.lbl_sistem2_Enlem.Location = new System.Drawing.Point(16, 80);
            this.lbl_sistem2_Enlem.Name = "lbl_sistem2_Enlem";
            this.lbl_sistem2_Enlem.Size = new System.Drawing.Size(79, 25);
            this.lbl_sistem2_Enlem.TabIndex = 16;
            this.lbl_sistem2_Enlem.Text = "Enlem:";
            // 
            // lbl_sistem2_Gpsirtifa
            // 
            this.lbl_sistem2_Gpsirtifa.AutoSize = true;
            this.lbl_sistem2_Gpsirtifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sistem2_Gpsirtifa.ForeColor = System.Drawing.Color.White;
            this.lbl_sistem2_Gpsirtifa.Location = new System.Drawing.Point(16, 148);
            this.lbl_sistem2_Gpsirtifa.Name = "lbl_sistem2_Gpsirtifa";
            this.lbl_sistem2_Gpsirtifa.Size = new System.Drawing.Size(112, 25);
            this.lbl_sistem2_Gpsirtifa.TabIndex = 18;
            this.lbl_sistem2_Gpsirtifa.Text = "GPS İrtifa:";
            // 
            // lbl_sistem2_Boylam
            // 
            this.lbl_sistem2_Boylam.AutoSize = true;
            this.lbl_sistem2_Boylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sistem2_Boylam.ForeColor = System.Drawing.Color.White;
            this.lbl_sistem2_Boylam.Location = new System.Drawing.Point(15, 112);
            this.lbl_sistem2_Boylam.Name = "lbl_sistem2_Boylam";
            this.lbl_sistem2_Boylam.Size = new System.Drawing.Size(90, 25);
            this.lbl_sistem2_Boylam.TabIndex = 17;
            this.lbl_sistem2_Boylam.Text = "Boylam:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_Payload_Basinc);
            this.groupBox3.Controls.Add(this.lbl_Payload_Sicaklik);
            this.groupBox3.Controls.Add(this.lbl_Payload_Nem);
            this.groupBox3.Controls.Add(this.lbl_Payload_irtifa);
            this.groupBox3.Controls.Add(this.lbl_Payload_enlem);
            this.groupBox3.Controls.Add(this.lbl_Payload_boylam);
            this.groupBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(1029, 97);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(387, 252);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Görev Yükü";
            // 
            // lbl_Payload_Basinc
            // 
            this.lbl_Payload_Basinc.AutoSize = true;
            this.lbl_Payload_Basinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Payload_Basinc.ForeColor = System.Drawing.Color.White;
            this.lbl_Payload_Basinc.Location = new System.Drawing.Point(16, 170);
            this.lbl_Payload_Basinc.Name = "lbl_Payload_Basinc";
            this.lbl_Payload_Basinc.Size = new System.Drawing.Size(84, 25);
            this.lbl_Payload_Basinc.TabIndex = 26;
            this.lbl_Payload_Basinc.Text = "Basınç:";
            // 
            // lbl_Payload_Sicaklik
            // 
            this.lbl_Payload_Sicaklik.AutoSize = true;
            this.lbl_Payload_Sicaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Payload_Sicaklik.ForeColor = System.Drawing.Color.White;
            this.lbl_Payload_Sicaklik.Location = new System.Drawing.Point(16, 41);
            this.lbl_Payload_Sicaklik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Payload_Sicaklik.Name = "lbl_Payload_Sicaklik";
            this.lbl_Payload_Sicaklik.Size = new System.Drawing.Size(94, 25);
            this.lbl_Payload_Sicaklik.TabIndex = 24;
            this.lbl_Payload_Sicaklik.Text = "Sıcaklık:";
            this.lbl_Payload_Sicaklik.Click += new System.EventHandler(this.lbl_Payload_Sicaklik_Click);
            // 
            // lbl_Payload_Nem
            // 
            this.lbl_Payload_Nem.AutoSize = true;
            this.lbl_Payload_Nem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Payload_Nem.ForeColor = System.Drawing.Color.White;
            this.lbl_Payload_Nem.Location = new System.Drawing.Point(16, 201);
            this.lbl_Payload_Nem.Name = "lbl_Payload_Nem";
            this.lbl_Payload_Nem.Size = new System.Drawing.Size(63, 25);
            this.lbl_Payload_Nem.TabIndex = 25;
            this.lbl_Payload_Nem.Text = "Nem:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_SAYAC_rocket);
            this.groupBox4.Controls.Add(this.lbl_SAYAC_payload);
            this.groupBox4.Controls.Add(this.lbl_TakimID);
            this.groupBox4.Controls.Add(this.lbl_CRC);
            this.groupBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(1520, 97);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(345, 226);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Paket Verileri";
            // 
            // lbl_SAYAC_rocket
            // 
            this.lbl_SAYAC_rocket.AutoSize = true;
            this.lbl_SAYAC_rocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SAYAC_rocket.ForeColor = System.Drawing.Color.White;
            this.lbl_SAYAC_rocket.Location = new System.Drawing.Point(15, 140);
            this.lbl_SAYAC_rocket.Name = "lbl_SAYAC_rocket";
            this.lbl_SAYAC_rocket.Size = new System.Drawing.Size(231, 29);
            this.lbl_SAYAC_rocket.TabIndex = 14;
            this.lbl_SAYAC_rocket.Text = "Paket Sayısı Rocket:";
            this.lbl_SAYAC_rocket.Click += new System.EventHandler(this.lbl_SAYAC_rocket_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton1);
            this.groupBox7.Controls.Add(this.radioButton2);
            this.groupBox7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(1520, 357);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(345, 128);
            this.groupBox7.TabIndex = 37;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Seriport Yazdırma Kanalı";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 71);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1851, 12);
            this.button3.TabIndex = 43;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(453, 101);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(11, 226);
            this.button4.TabIndex = 41;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(959, 81);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(13, 671);
            this.button5.TabIndex = 47;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1464, 81);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(13, 671);
            this.button6.TabIndex = 48;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 33.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1144, 69);
            this.label1.TabIndex = 49;
            this.label1.Text = "🚀  FALCON ROKET TAKIMI  🚀";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(583, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 34);
            this.label4.TabIndex = 50;
            this.label4.Text = "Roket Konumu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1064, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 34);
            this.label5.TabIndex = 51;
            this.label5.Text = "Görev Yükü Konumu";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(73, 793);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(329, 182);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 54;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(458, 793);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(313, 182);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 53;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1671, 793);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(195, 182);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(791, 777);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(290, 198);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::test_SERIAL.Properties.Resources.MAHUK;
            this.pictureBox2.Location = new System.Drawing.Point(1445, 793);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackgroundImage = global::test_SERIAL.Properties.Resources.GPS_Ground;
            this.groupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox6.Controls.Add(this.gMapControl2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(1029, 393);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(387, 350);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            // 
            // gMapControl2
            // 
            this.gMapControl2.AutoScroll = true;
            this.gMapControl2.Bearing = 0F;
            this.gMapControl2.CanDragMap = true;
            this.gMapControl2.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl2.GrayScaleMode = false;
            this.gMapControl2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl2.LevelsKeepInMemory = 5;
            this.gMapControl2.Location = new System.Drawing.Point(13, 28);
            this.gMapControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gMapControl2.MarkersEnabled = false;
            this.gMapControl2.MaxZoom = 10;
            this.gMapControl2.MinZoom = 20;
            this.gMapControl2.MouseWheelZoomEnabled = true;
            this.gMapControl2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl2.Name = "gMapControl2";
            this.gMapControl2.NegativeMode = false;
            this.gMapControl2.PolygonsEnabled = true;
            this.gMapControl2.RetryLoadTile = 0;
            this.gMapControl2.RoutesEnabled = true;
            this.gMapControl2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl2.ShowTileGridLines = false;
            this.gMapControl2.Size = new System.Drawing.Size(364, 309);
            this.gMapControl2.TabIndex = 31;
            this.gMapControl2.Zoom = 20D;
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = global::test_SERIAL.Properties.Resources.GPS_Ground;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.gMapControl1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(515, 383);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(387, 359);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            // 
            // gMapControl1
            // 
            this.gMapControl1.AutoScroll = true;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(13, 28);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gMapControl1.MarkersEnabled = false;
            this.gMapControl1.MaxZoom = 10;
            this.gMapControl1.MinZoom = 20;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(364, 309);
            this.gMapControl1.TabIndex = 15;
            this.gMapControl1.Zoom = 20D;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1120, 777);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(1692, 533);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 55;
            // 
            // lbl_port_payload
            // 
            this.lbl_port_payload.AutoSize = true;
            this.lbl_port_payload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_port_payload.ForeColor = System.Drawing.Color.White;
            this.lbl_port_payload.Location = new System.Drawing.Point(1529, 534);
            this.lbl_port_payload.Name = "lbl_port_payload";
            this.lbl_port_payload.Size = new System.Drawing.Size(146, 20);
            this.lbl_port_payload.TabIndex = 56;
            this.lbl_port_payload.Text = "Alıcı Port Payload:";
            this.lbl_port_payload.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_Sistem1_durum
            // 
            this.lbl_Sistem1_durum.AutoSize = true;
            this.lbl_Sistem1_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sistem1_durum.ForeColor = System.Drawing.Color.White;
            this.lbl_Sistem1_durum.Location = new System.Drawing.Point(12, 214);
            this.lbl_Sistem1_durum.Name = "lbl_Sistem1_durum";
            this.lbl_Sistem1_durum.Size = new System.Drawing.Size(82, 25);
            this.lbl_Sistem1_durum.TabIndex = 12;
            this.lbl_Sistem1_durum.Text = "Durum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1895, 1025);
            this.Controls.Add(this.lbl_port_payload);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Tesseract Roket Takımı Yer İstasyonu Arayüzü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialComm;
        private System.Windows.Forms.Label lbl_sistem1_GyroZ;
        private System.Windows.Forms.Label lbl_SAYAC_payload;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sistem1_enlem;
        private System.Windows.Forms.Label lbl_sistem1_boylam;
        private System.Windows.Forms.Label lbl_sistem1_Gpsirtifa;
        private System.Windows.Forms.Label lbl_sistem1_irtifa;
        private System.Windows.Forms.Label lbl_TakimID;
        private System.Windows.Forms.Label lbl_CRC;
        private System.Windows.Forms.Button button2;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label lbl_Payload_irtifa;
        private System.Windows.Forms.Label lbl_Payload_enlem;
        private System.Windows.Forms.Label lbl_Payload_boylam;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_sistem2_GyroZ;
        private System.Windows.Forms.Label lbl_sistem2_irtifa;
        private System.Windows.Forms.Label lbl_sistem2_Enlem;
        private System.Windows.Forms.Label lbl_sistem2_Gpsirtifa;
        private System.Windows.Forms.Label lbl_sistem2_Boylam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_Payload_Sicaklik;
        private System.Windows.Forms.Label lbl_Payload_Nem;
        private System.Windows.Forms.Label lbl_Payload_Basinc;
        private System.Windows.Forms.GroupBox groupBox4;
        private GMap.NET.WindowsForms.GMapControl gMapControl2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lbl_port_payload;
        private System.Windows.Forms.Label lbl_SAYAC_rocket;
        private System.Windows.Forms.Label lbl_Sistem1_durum;
    }
}

