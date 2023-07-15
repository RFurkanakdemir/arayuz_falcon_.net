using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Drawing.Drawing2D;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Timers;




namespace test_SERIAL
{
    public partial class Form1 : Form
    {
        string[] portlar = SerialPort.GetPortNames();
        SerialPort alici = new SerialPort(); // Seri port nesnesi oluşturuyoruz       
        SerialPort verici = new SerialPort(); // Seri port nesnesi oluşturuyoruz
        SerialPort alici_payload = new SerialPort(); //görev yükü seri port nesnesi
        public Form1()
        {
            InitializeComponent();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Roket_t
        {
            public float irtifa;
            public float roket_gps_irtifa;
            public float roket_gps_enlem;
            public float roket_gps_boylam;
            public float gyro_x;
            public float gyro_y;
            public float gyro_z;
            public float acc_x;
            public float acc_y;
            public float acc_z;
            public float angle;
            public byte status;

        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Payload_t
        {
            public float payload_gps_irtifa;
            public float payload_gps_enlem;
            public float payload_gps_boylam;
            public float payload_nem;
            public float payload_basinc;
            public float payload_sicaklik;
            public float payload_accelz1;
            public float payload_accelz2;

        };


        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct GCS_ROCKET_t
        {

            public byte unused_1;
            public byte unused_2;
            public byte unused_3;
            public byte unused_4;
            public byte TAKIM_ID;
            public byte SAYAC;
            public Roket_t roket_node;
            public Roket_t roket_node_2;
            public byte CRC;
            public byte unused_5;
            public byte unused_6;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct GCS_PAYLOAD_t
        {

            public byte unused_1;
            public byte unused_2;
            public byte unused_3;
            public byte unused_4;
            public byte TAKIM_ID;
            public byte SAYAC;
            public Payload_t payload_node;
            public byte CRC;
            public byte unused_5;
            public byte unused_6;
        };



        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct HyiPacket
        {
            public byte unused_1;
            public byte unused_2;
            public byte unused_3;
            public byte unused_4;
            public byte TAKIM_ID;
            public byte SAYAC;
            public float irtifa;
            public float roket_gps_irtifa; // 4.38383838382 => 4 BYTE
            public float roket_gps_enlem;
            public float roket_gps_boylam;
            public float payload_gps_irtifa;
            public float payload_gps_enlem;
            public float payload_gps_boylam;
            public float kademe_irtifa;
            public float kademe_enlem;
            public float kademe_boylam;
            public float gyro_x;
            public float gyro_y;
            public float gyro_z;
            public float acc_x;
            public float acc_y;
            public float acc_z;
            public float angle;
            public byte status;
            public byte CRC;
            public byte unused_5;
            public byte unused_6;
        };



        public static GCS_ROCKET_t gcs_rocket_packet;
        public static HyiPacket GonderilecekPaket;
        public static GCS_PAYLOAD_t gcs_payload_packet;

        public static byte[] packetArr_rocket = new byte[255];

        public static int packetArrCt_rocket = 0;
        
        public static byte[] packetArr_payload = new byte[255];

        public static int packetArrCt_payload = 0;


        public static int sizeofgcsrocket = Marshal.SizeOf(gcs_rocket_packet);
        public static int sizeofgcspayload = Marshal.SizeOf(gcs_payload_packet);
        public static int sizeofHYIPaket = Marshal.SizeOf(GonderilecekPaket);
        public static byte[] hyiPacketArr = new byte[sizeofHYIPaket];

        public static bool readingAll = true;

        public void clearBUFFER_rocket()
        {
            for (byte i = 0; i < 255; i++)
            {
                packetArr_rocket[i] = 0;
            }
        }
        public void clearBUFFER_payload()
        {
            for (byte i = 0; i < 255; i++)
            {
                packetArr_payload[i] = 0;
            }
        }

        byte[] durum = new byte[2];
        public string file_text = @"C:\Users\rfrkn\Desktop\falcon\arayz\FC - Copy\test_SERIAL\Resources\veri.txt";
        public string payload_text = @"C:\Users\rfrkn\Desktop\falcon\arayz\FC - Copy\test_SERIAL\Resources\payload_data.txt";
        public string bilimsel_text = @"C:\Users\rfrkn\Desktop\falcon\arayz\FC - Copy\test_SERIAL\Resources\bilimsel.txt";

        public unsafe void threadFunction()
        {
            try
            {
                bool gelmedurum_rocket = false;
                bool gelmedurum_payload = false;

                bool allpaketcame_rocket = false;
                bool allpaketcame_payload = false;

                bool wrongpacket_rocket = false;
                bool wrongpacket_payload = false;


                Stopwatch timePassedWatchVideo = new Stopwatch();
                Stopwatch timePassedWatchVideo_2 = new Stopwatch();
                Stopwatch timePassedWatchVideo_3 = new Stopwatch();
                bool watchActivated = false;
                bool watchActivated_2 = false;
                bool watchActivated_3 = false;
                
                bool gonderimdurum_rocket = true;
                bool gonderimdurum_payload = true;

                StreamWriter dosya_rocket = new StreamWriter(file_text); ;
                StreamWriter dosya_payload = new StreamWriter(payload_text); ;
                StreamWriter dosya_bilimsel = new StreamWriter(bilimsel_text); ;

                for (; ; )
                {

                    if (!watchActivated)
                    {
                        timePassedWatchVideo.Reset();
                        timePassedWatchVideo.Start();
                        watchActivated = true;
                    }
                    if (!watchActivated_2)
                    {
                        timePassedWatchVideo_2.Reset();
                        timePassedWatchVideo_2.Start();
                        watchActivated_2 = true;
                    }
                    if (!watchActivated_3)
                    {
                        timePassedWatchVideo_3.Reset();
                        timePassedWatchVideo_3.Start();
                        watchActivated_3 = true;
                    }

                    if (alici.BytesToRead > 0)
                    {
                        durum[0] = 0;
                        byte data_rocket = (byte)alici.ReadByte();
                        packetArr_rocket[packetArrCt_rocket] = data_rocket;
                        if (packetArrCt_rocket == 3)
                        {
                            if (packetArr_rocket[0] == 255 && packetArr_rocket[1] == 255 && packetArr_rocket[2] == 84 && packetArr_rocket[3] == 82)
                            {
                                gelmedurum_rocket = true;
                            }
                            else
                            {   
                                //packetArrCt_rocket = 0;
                                wrongpacket_rocket = true;
                                clearBUFFER_rocket();
                            }
                        }
                        if (gelmedurum_rocket == true && packetArrCt_rocket == sizeofgcsrocket - 1)
                        {
                            float RoketNodeOldGPS_IRTIFA = gcs_rocket_packet.roket_node.roket_gps_irtifa;
                            float RoketNode_2_OldGPS_IRTIFA = gcs_rocket_packet.roket_node_2.roket_gps_irtifa;
                            IntPtr emptyPointer_rocket = Marshal.AllocHGlobal(packetArrCt_rocket);
                            //IntPtr hyiEmptyPointer = Marshal.AllocHGlobal(sizeofHYIPaket);
                            Marshal.Copy(packetArr_rocket, 0, emptyPointer_rocket, packetArrCt_rocket);
                            gcs_rocket_packet = (GCS_ROCKET_t)Marshal.PtrToStructure(emptyPointer_rocket, gcs_rocket_packet.GetType());
                            
                            
                            structaYaz(gonderimdurum_rocket);

                            allpaketcame_rocket = true;

                            if (radioButton1.Checked == true)
                            {
                                gonderimdurum_rocket = true;
                                if (RoketNodeOldGPS_IRTIFA != gcs_rocket_packet.roket_node.roket_gps_irtifa)
                                {
                                    timePassedWatchVideo_2.Stop();
                                    Console.WriteLine($" Elapsed Time to Come Data Avionic 1 : {timePassedWatchVideo_2.ElapsedMilliseconds}");
                                    watchActivated_2 = false;
                                }
                                KonumBul(gcs_rocket_packet.roket_node.roket_gps_enlem, gcs_rocket_packet.roket_node.roket_gps_boylam);
                                roketaci(gcs_rocket_packet.roket_node.gyro_z);
                                radioButton2.Checked = false;
                            }
                            if (radioButton2.Checked == true)
                            {
                                gonderimdurum_rocket = false;
                                if (RoketNode_2_OldGPS_IRTIFA != gcs_rocket_packet.roket_node_2.roket_gps_irtifa)
                                {
                                    timePassedWatchVideo.Stop();
                                    Console.WriteLine($" Elapsed Time to Come Data Avionic 2  : {timePassedWatchVideo.ElapsedMilliseconds}");
                                    watchActivated = false;
                                }
                                KonumBul(gcs_rocket_packet.roket_node_2.roket_gps_enlem, gcs_rocket_packet.roket_node_2.roket_gps_boylam);
                                roketaci(gcs_rocket_packet.roket_node_2.gyro_z);
                                radioButton1.Checked = false;
                            }
                            dosya_rocket.Write("BİRİNCİ SİSTEM: "); dosya_rocket.Write("Gyro-Z :"); dosya_rocket.Write(gcs_rocket_packet.roket_node.gyro_z); dosya_rocket.Write(" Basınç İrtifa :"); dosya_rocket.Write(gcs_rocket_packet.roket_node.irtifa); dosya_rocket.Write(" Enlem :"); dosya_rocket.Write(gcs_rocket_packet.roket_node.roket_gps_enlem); dosya_rocket.Write(" Boylam :"); dosya_rocket.Write(gcs_rocket_packet.roket_node.roket_gps_boylam); dosya_rocket.Write(" GPS İrtifa :"); dosya_rocket.Write(gcs_rocket_packet.roket_node.roket_gps_irtifa); dosya_rocket.Write("\n");
                            //dosya.Write("PAYLOAD: "); dosya.Write("Sıcaklık :"); dosya.Write(gcs_rocket_packet.payload_node.payload_sicaklik); dosya.Write(" Basınç :"); dosya.Write(gcs_rocket_packet.payload_node.payload_basinc); dosya.Write(" Nem:"); dosya.Write(gcs_rocket_packet.payload_node.payload_nem); dosya.Write(" Enlem :"); dosya.Write(gcs_rocket_packet.payload_node.payload_gps_enlem); dosya.Write(" Boylam:"); dosya.Write(gcs_rocket_packet.payload_node.payload_gps_boylam); dosya.Write(" İrtifa:"); dosya.Write(gcs_rocket_packet.payload_node.payload_gps_irtifa); dosya.Write("\n");
                            dosya_rocket.Write("İKİNCİ SİSTEM: "); dosya_rocket.Write("Gyro-Z :"); dosya_rocket.Write(gcs_rocket_packet.roket_node_2.gyro_z); dosya_rocket.Write(" Basınç İrtifa :"); dosya_rocket.Write(gcs_rocket_packet.roket_node_2.irtifa); dosya_rocket.Write(" Enlem :"); dosya_rocket.Write(gcs_rocket_packet.roket_node_2.roket_gps_enlem); dosya_rocket.Write(" Boylam :"); dosya_rocket.Write(gcs_rocket_packet.roket_node_2.roket_gps_boylam); dosya_rocket.Write(" GPS İrtifa :"); dosya_rocket.Write(gcs_rocket_packet.roket_node_2.roket_gps_irtifa); dosya_rocket.Write("\n");
                            //gorevYukuKonumBul(gcs_rocket_packet.payload_node.payload_gps_enlem, gcs_rocket_packet.payload_node.payload_gps_boylam);
                            lbl_sistem2_GyroZ.Text = $"Gyro Z: {gcs_rocket_packet.roket_node_2.gyro_z}";
                            lbl_sistem2_Boylam.Text = $"Boylam: {gcs_rocket_packet.roket_node_2.roket_gps_boylam}";
                            lbl_sistem2_Enlem.Text = $"Enlem: {gcs_rocket_packet.roket_node_2.roket_gps_enlem}";
                              
                            
                            
                             lbl_sistem2_Gpsirtifa.Text = $"Gps İrtifa: {gcs_rocket_packet.roket_node_2.roket_gps_irtifa}";
                            lbl_sistem2_irtifa.Text = $"Basınç İrtifa: {gcs_rocket_packet.roket_node_2.irtifa}";
                            lbl_sistem1_GyroZ.Text = $"Gyro Z: {gcs_rocket_packet.roket_node.gyro_z}";
                            lbl_sistem1_boylam.Text = $"Boylam: {gcs_rocket_packet.roket_node.roket_gps_boylam}";
                            lbl_sistem1_enlem.Text = $"Enlem: {gcs_rocket_packet.roket_node.roket_gps_enlem}";
                            lbl_sistem1_Gpsirtifa.Text = $"Gps İrtifa: {gcs_rocket_packet.roket_node.roket_gps_irtifa}";
                            lbl_sistem1_irtifa.Text = $"Basınç İrtifa: {gcs_rocket_packet.roket_node.irtifa}";
                            lbl_SAYAC_rocket.Text = $"Paket sayisi: {gcs_rocket_packet.SAYAC}";
                            lbl_CRC.Text = $"Checksum Hesabi: {gcs_rocket_packet.CRC}";
                            lbl_TakimID.Text = $"Takım ID: {gcs_rocket_packet.TAKIM_ID}";
                            lbl_Sistem1_durum.Text = $"Durum: {gcs_rocket_packet.roket_node.status}";


                            Marshal.FreeHGlobal(emptyPointer_rocket);
                            //packetArrCt_rocket = 0;
                            if (checksumHesapla_rocket() == gcs_rocket_packet.CRC)
                            {
                                allpaketcame_rocket = true;
                                clearBUFFER_rocket();
                            }
                            else
                            {
                                durum[0] = 1;
                                clearBUFFER_rocket();
                            }
                           
                        }
                        packetArrCt_rocket++;
                    }

                    if (alici_payload.BytesToRead >0)
                    {
                        durum[1] = 0;
                        byte data_payload = (byte)alici_payload.ReadByte();
                        packetArr_payload[packetArrCt_payload] = data_payload;
                        if (packetArrCt_payload == 3)
                        {
                            if (packetArr_payload[0] == 255 && packetArr_payload[1] == 255 && packetArr_payload[2] == 84 && packetArr_payload[3] == 82)
                            {
                                gelmedurum_payload = true;
                            }
                            else
                            {   
                                wrongpacket_payload = true;
                                //packetArrCt_payload = 0;
                                clearBUFFER_payload();
                            }
                        }
                        
                        if (gelmedurum_payload == true && packetArrCt_payload == sizeofgcspayload - 1)
                            {
                                

                                IntPtr emptyPointer_payload = Marshal.AllocHGlobal(packetArrCt_payload);
                                
                                Marshal.Copy(packetArr_payload, 0, emptyPointer_payload, packetArrCt_payload);

                                gcs_payload_packet = (GCS_PAYLOAD_t)Marshal.PtrToStructure(emptyPointer_payload, gcs_payload_packet.GetType());
                                structaYaz_payload(gonderimdurum_payload);
                                //Marshal.StructureToPtr(GonderilecekPaket, hyiEmptyPointer, true);
                                //Marshal.Copy(hyiEmptyPointer, hyiPacketArr, 0, sizeofHYIPaket);
                                //HyiGonderim();

                                lbl_Payload_boylam.Text = $"Boylam : {gcs_payload_packet.payload_node.payload_gps_boylam}";
                                lbl_Payload_enlem.Text = $"Enlem : {gcs_payload_packet.payload_node.payload_gps_enlem}";
                                lbl_Payload_irtifa.Text = $"İrtifa : {gcs_payload_packet.payload_node.payload_gps_irtifa}";
                                lbl_Payload_Basinc.Text = $"Basınç : {gcs_payload_packet.payload_node.payload_basinc}";
                                lbl_Payload_Sicaklik.Text = $"Sıcaklık  : {gcs_payload_packet.payload_node.payload_sicaklik}";
                                lbl_Payload_Nem.Text = $"Nem : {gcs_payload_packet.payload_node.payload_nem}";
                                lbl_SAYAC_payload.Text = $"Paket Sayısı Payload : {gcs_payload_packet.SAYAC}";


                                dosya_payload.Write("PAYLOAD: "); dosya_payload.Write("Sıcaklık :"); dosya_payload.Write(gcs_payload_packet.payload_node.payload_sicaklik); dosya_payload.Write(" Basınç :"); dosya_payload.Write(gcs_payload_packet.payload_node.payload_basinc); dosya_payload.Write(" Nem:"); dosya_payload.Write(gcs_payload_packet.payload_node.payload_nem); dosya_payload.Write(" Enlem :"); dosya_payload.Write(gcs_payload_packet.payload_node.payload_gps_enlem); dosya_payload.Write(" Boylam:"); dosya_payload.Write(gcs_payload_packet.payload_node.payload_gps_boylam); dosya_payload.Write(" İrtifa:"); dosya_payload.Write(gcs_payload_packet.payload_node.payload_gps_irtifa); dosya_payload.Write("\n");
                                dosya_bilimsel.Write("Accelz1=");dosya_bilimsel.Write(gcs_payload_packet.payload_node.payload_accelz1); dosya_bilimsel.Write(",Accelz2="); dosya_bilimsel.Write(gcs_payload_packet.payload_node.payload_accelz2); dosya_bilimsel.Write("\n");
                                gorevYukuKonumBul(gcs_payload_packet.payload_node.payload_gps_enlem, gcs_payload_packet.payload_node.payload_gps_boylam);
                            //  packetArrCt_payload = 0;
                                Marshal.FreeHGlobal(emptyPointer_payload);
                                
                                if (checksumHesapla_payload() == gcs_payload_packet.CRC)
                                {   
                                    allpaketcame_payload = true;
                                    clearBUFFER_payload();
                                }
                                else
                                {
                                    durum[1] = 1;
                                    clearBUFFER_payload();
                                }
                                
                                
                        }
                            packetArrCt_payload++;


                        
                    }
                    if (allpaketcame_payload == true || wrongpacket_payload == true)
                    {   
                        wrongpacket_payload = false;
                        packetArrCt_payload = 0;

                    }
                    if (allpaketcame_rocket == true || wrongpacket_rocket == true)
                    {   
                        wrongpacket_rocket = false;
                        packetArrCt_rocket = 0;

                    }


                    if (allpaketcame_payload == true || allpaketcame_rocket == true)
                    {

                        IntPtr hyiEmptyPointer = Marshal.AllocHGlobal(sizeofHYIPaket);
                        Marshal.StructureToPtr(GonderilecekPaket, hyiEmptyPointer, true);
                        Marshal.Copy(hyiEmptyPointer, hyiPacketArr, 0, sizeofHYIPaket);
                        //HyiGonderim();
                        allpaketcame_payload = false;
                        allpaketcame_rocket = false;
                        //continue;
                        Marshal.FreeHGlobal(hyiEmptyPointer);
                    }


                }
            }
            catch (Exception)
            {

            }


        }
        void structaYaz_payload(bool durum)
        {
            if (durum == true)
            {
                GonderilecekPaket.unused_1 = 0xFF;
                GonderilecekPaket.unused_2 = 0xFF;
                GonderilecekPaket.unused_3 = 0x54;
                GonderilecekPaket.unused_4 = 0x52;
                GonderilecekPaket.TAKIM_ID = gcs_payload_packet.TAKIM_ID;
                GonderilecekPaket.SAYAC = gcs_payload_packet.SAYAC;
                GonderilecekPaket.payload_gps_boylam = gcs_payload_packet.payload_node.payload_gps_boylam;
                GonderilecekPaket.payload_gps_enlem = gcs_payload_packet.payload_node.payload_gps_enlem;
                GonderilecekPaket.payload_gps_irtifa = gcs_payload_packet.payload_node.payload_gps_irtifa;
                GonderilecekPaket.unused_5 = 0x0D;
                GonderilecekPaket.unused_6 = 0x0A;

            }
            else
            {
               
            }
           


        }
        void structaYaz(bool durum)
        {
            if (durum == true)
            {
                GonderilecekPaket.TAKIM_ID = gcs_rocket_packet.TAKIM_ID;
                GonderilecekPaket.irtifa = gcs_rocket_packet.roket_node.irtifa;
                GonderilecekPaket.acc_x = gcs_rocket_packet.roket_node.acc_x;
                GonderilecekPaket.acc_y = gcs_rocket_packet.roket_node.acc_y;
                GonderilecekPaket.acc_z = gcs_rocket_packet.roket_node.acc_z;
                GonderilecekPaket.gyro_x = gcs_rocket_packet.roket_node.gyro_x;
                GonderilecekPaket.gyro_y = gcs_rocket_packet.roket_node.gyro_y;
                GonderilecekPaket.gyro_z = gcs_rocket_packet.roket_node.gyro_z;
                GonderilecekPaket.status = gcs_rocket_packet.roket_node.status;
                GonderilecekPaket.angle = gcs_rocket_packet.roket_node.angle;
                GonderilecekPaket.roket_gps_boylam = gcs_rocket_packet.roket_node.roket_gps_boylam;
                GonderilecekPaket.roket_gps_enlem = gcs_rocket_packet.roket_node.roket_gps_enlem;
                GonderilecekPaket.roket_gps_irtifa = gcs_rocket_packet.roket_node.roket_gps_irtifa;
                
                GonderilecekPaket.payload_gps_boylam = gcs_payload_packet.payload_node.payload_gps_boylam;
            }
            else
            {
                GonderilecekPaket.TAKIM_ID = gcs_rocket_packet.TAKIM_ID;
                GonderilecekPaket.irtifa = gcs_rocket_packet.roket_node_2.irtifa;
                GonderilecekPaket.acc_x =  gcs_rocket_packet.roket_node_2.acc_x;
                GonderilecekPaket.acc_y =  gcs_rocket_packet.roket_node_2.acc_y;
                GonderilecekPaket.acc_z =  gcs_rocket_packet.roket_node_2.acc_z;
                GonderilecekPaket.gyro_x = gcs_rocket_packet.roket_node_2.gyro_x;
                GonderilecekPaket.gyro_y = gcs_rocket_packet.roket_node_2.gyro_y;
                GonderilecekPaket.gyro_z = gcs_rocket_packet.roket_node_2.gyro_z;
                GonderilecekPaket.status = gcs_rocket_packet.roket_node_2.status;
                GonderilecekPaket.angle = gcs_rocket_packet.roket_node_2.angle;
                GonderilecekPaket.roket_gps_boylam = gcs_rocket_packet.roket_node_2.roket_gps_boylam;
                GonderilecekPaket.roket_gps_enlem = gcs_rocket_packet.roket_node_2.roket_gps_enlem;
                GonderilecekPaket.roket_gps_irtifa = gcs_rocket_packet.roket_node_2.roket_gps_irtifa;
            }
          


        }

        public void HyiGonderim()
        {
            hyiPacketArr[sizeofHYIPaket - 1 - 2] = checksumHesapla_New(ref hyiPacketArr, 4, (sizeofHYIPaket - 3));
            verici.Write(hyiPacketArr, 0, sizeofHYIPaket);

        }

        public byte checksumHesapla_New(ref byte[] arr, int startPos, int endPos)
        {
            uint checksum = 0;
            for (int i = startPos; i < endPos; i++)
            {
                checksum += arr[i];
            }
            return (byte)checksum;
        }
        public int checksumHesapla_rocket()
        {
            int checksum = 0;
            for (int i = 4; i < sizeofgcsrocket-7; i++)
            {
                checksum += packetArr_rocket[i];
            }
            return Convert.ToByte(checksum % 256);
        }

        public int checksumHesapla_payload()
        {
            int checksum = 0;
            for (int i = 4; i < sizeofgcspayload-3; i++)
            {
                checksum += packetArr_payload[i];
            }
            return Convert.ToByte(checksum % 256);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            alici.PortName = comboBox1.SelectedItem.ToString(); // Kullanacağımız seri port adını seçiyoruz (String)
            alici.BaudRate = 115200;  // Seri haberleşme hızını seçiyoruz (int32)
            alici.DataBits = 8; // göndereceğimiz bilginin kaç bitten oluşacağını bildiriyoruz (int32).
            alici.Parity = Parity.None; // Eşlik bitidir. Gönderilen verinin doğruluğunu kontrol etmek için kullanılır. 
            alici.StopBits = StopBits.One; // Stop bitinin kaç bit olacağını belirtir.

            alici_payload.PortName = comboBox3.SelectedItem.ToString(); // Kullanacağımız seri port adını seçiyoruz (String)
            alici_payload.BaudRate = 19200;  // Seri haberleşme hızını seçiyoruz (int32)
            alici_payload.DataBits = 8; // göndereceğimiz bilginin kaç bitten oluşacağını bildiriyoruz (int32).
            alici_payload.Parity = Parity.None; // Eşlik bitidir. Gönderilen verinin doğruluğunu kontrol etmek için kullanılır. 
            alici_payload.StopBits = StopBits.One; // Stop bitinin kaç bit olacağını belirtir.
            /*
            verici.PortName = comboBox2.SelectedItem.ToString(); // Kullanacağımız seri port adını seçiyoruz (String)
            verici.BaudRate = 19200;  // Seri haberleşme hızını seçiyoruz (int32)
            verici.DataBits = 8; // göndereceğimiz bilginin kaç bitten oluşacağını bildiriyoruz (int32).
            verici.Parity = Parity.None; // Eşlik bitidir. Gönderilen verinin doğruluğunu kontrol etmek için kullanılır. 
            verici.StopBits = StopBits.One; // Stop bitinin kaç bit olacağını belirtir.
            */

            alici.Open();
            alici_payload.Open();
            //verici.Open();

            Thread pollingSerialFunc = new Thread(new ThreadStart(threadFunction));
            pollingSerialFunc.Start();
        }
        private void KonumBul(float enlem, float boylam)
        {
            gMapControl1.Position = new GMap.NET.PointLatLng(enlem, boylam);
        }
        private void roketaci(float gyro) 
        {
            try
            {
                angle = Convert.ToInt32(gyro) - 90;
                Invalidate();
            }
            catch (Exception)
            {
                angle = 0;
            }
        }
        private void gorevYukuKonumBul(float enlem, float boylam)
        {
            gMapControl2.Position = new GMap.NET.PointLatLng(enlem, boylam);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try {

                radioButton1.Checked = true;
                gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
                gMapControl2.MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
                gMapControl1.CacheLocation = @"C:\Users\rfrkn\Desktop\falcon\arayz\FC - Copy\test_SERIAL\Resources\Cache";
                gMapControl2.CacheLocation = @"C:\Users\rfrkn\Desktop\falcon\arayz\FC - Copy\test_SERIAL\Resources\Cache";
                gMapControl1.Position = new GMap.NET.PointLatLng(38.8561394, 33.1281446);
                gMapControl2.Position = new GMap.NET.PointLatLng(38.8561394, 33.1281446);
                Control.CheckForIllegalCrossThreadCalls = false;
                foreach (string item in portlar)
                {
                    comboBox1.Items.Add(item);
                    comboBox2.Items.Add(item);
                    comboBox3.Items.Add(item);
                }
            }
            catch (Exception)
            {

            }
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            alici.Close();
            verici.Close();
            alici_payload.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            alici.Close();
            verici.Close();
            alici_payload.Close();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
        Bitmap roket = Properties.Resources.r21;
        int angle;
        int a = 180, b = 450, c = 60, d = 250;

        private void lbl_Payload_Sicaklik_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SAYAC_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Payload_irtifa_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SAYAC_rocket_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.RotateTransform(angle);
            g.TranslateTransform(a, b, MatrixOrder.Append);
            g.DrawImage(roket, -c / 2, -d / 2, c, d);
        }
        
        
        
    }
}
