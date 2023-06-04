using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.UaFx.Client;
using System;
using System.Configuration;
using System.IO.Ports;
using System.Data.SqlClient;

namespace ClientUSB
{
    public partial class Form1 : Form
    {
        OpcClient client = new OpcClient("opc.tcp://localhost:4840/");
        string strcon = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double sensorValue;
            int state_operating = 0;                    // 0-pause  1-start   2-stop    3-alarm
            txt_Pro.Text = "in timer";
            sensorValue = ReadSensorData();
            OpcWrite(sensorValue);
            try
            {
                if (serialPort1.IsOpen)
                {
                    txtRec.Text = serialPort1.ReadExisting();
                    string data = txtRec.Text;
                    string[] values = data.Split(';');

                    double voltage = double.Parse(values[0]);
                    double elapsed = double.Parse(values[1]);
                    double temp = double.Parse(values[2]);
                    int rst_cnt = int.Parse(values[3]);

                    txtVol.Text = voltage.ToString();
                    txtElap.Text = elapsed.ToString();
                    string power_status_r1 = "OK".ToString();
                    if (voltage > 5.5 || Convert.ToInt16(temp) > 70)
                    {
                        power_status_r1 = "High voltage detected!".ToString();
                        state_operating = 3;
                        client.WriteNode("ns=4;s=Robot1/Status_R1", "Alarm");

                    }
                    else if (voltage < 4.5)
                    {
                        power_status_r1 = "Low voltage detected!".ToString();
                        state_operating = 3;
                        client.WriteNode("ns=4;s=Robot1/Status_R1", "Alarm");
                    }
                    else
                    {
                        state_operating = 0;
                        client.WriteNode("ns=4;s=Robot1/Status_R1", "Pause");
                    }

                    client.WriteNode("ns=4;s=Robot1/Power_Status_R1", power_status_r1);
                    client.WriteNode("ns=4;s=Robot1/Time_Op_R1", elapsed);
                    client.WriteNode("ns=4;s=Robot1/Temperature", temp);
                    client.WriteNode("ns=4;s=Robot1/Reset_Cnt_R1", rst_cnt);
                }
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand countCommand = new SqlCommand($"SELECT COUNT(*) FROM Job_Schedule", con);
                int rowCount = (int)countCommand.ExecuteScalar();
                txt_Pro.Text = "connect";
                if (rowCount > 0)
                {
                    txt_Pro.Text = ">0";
                   // Retrieve the first row
                   SqlCommand selectCommand = new SqlCommand($"SELECT TOP 1 * FROM Job_Schedule", con);
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    reader.Read();

                    // Do something with the data (access the columns by name or by index)
                    string program = reader.GetString(1);
                    DateTime myDateTimeVar = reader.GetDateTime(2);
                    DateTime myDateTimeVar_End = reader.GetDateTime(3);
                    DateTime dateTimeVar = DateTime.Now;

                    if (dateTimeVar >= myDateTimeVar_End)
                    {
                        state_operating = 0;
                        txt_Pro.Text = "End " + program;
                        if (serialPort1.IsOpen)
                        {
                            serialPort1.WriteLine("E" + "; " + program + Environment.NewLine);
                        }
                    }
                    else if (dateTimeVar >= myDateTimeVar)
                    {
                        state_operating = 1;
                        txt_Pro.Text = "Start " + program;
                        client.WriteNode("ns=4;s=Robot1/Status_R1", "Run");
                        if (serialPort1.IsOpen)
                        {
                            serialPort1.WriteLine("S" + "; " + program + Environment.NewLine);
                        }
                    }
                    else
                    {
                        state_operating = 0;
                        txt_Pro.Text = "Prepare " + program;
                        //serialPort1.WriteLine("Request" + "; " + Environment.NewLine);
                    }


                    string time_start = myDateTimeVar.ToString("yyyy-MM-dd HH:mm:ss");
                    string time_end = myDateTimeVar_End.ToString("yyyy-MM-dd HH:mm:ss");
                    //txt_Pro.Text = program;
                    txtTime_Start.Text = time_start;
                    txtTime_End.Text = time_end;
                    reader.Close();
                    //SqlCommand deleteCommand = new SqlCommand($"DELETE TOP(1) FROM Job_Schedule", con);
                    //deleteCommand.ExecuteNonQuery();
                }
                else
                {
                    serialPort1.WriteLine("Request" + "; " + Environment.NewLine);
                }

                con.Close();

            }
            catch (Exception ex)
            {
                
            }
        }
        void OpcWrite(double sensorValue)
        {
            //string tagName = "ns=4;s=Robot1/theta";
            //string tagName = "ns=4;s=Robot1/x";
            //client.WriteNode(tagName, sensorValue);

            //tagName = "ns=2;s=Motor/Name";
            //client.WriteNode(tagName, "Machine 1");

            client.WriteNode("ns=4;s=Robot1/ToolNumber", 25);
            client.WriteNode("ns=4;s=Robot1/JogSpeed", 2);
            client.WriteNode("ns=4;s=Robot1/Coordinate", 3);
            client.WriteNode("ns=4;s=Robot1/ServoStt", false);
            client.WriteNode("ns=4;s=Robot1/SystemStt", 1);
            client.WriteNode("ns=4;s=Robot1/LockRBC", false);
            client.WriteNode("ns=4;s=Robot1/Mode", true);
            client.WriteNode("ns=4;s=Robot1/SecLevel", 2);
            //client.WriteNode("ns=4;s=Robot1/Status_R1", "Pause");
            //client.WriteNode("ns=4;s=Robot1/Time_Op_R1", 2.5);
            //client.WriteNode("ns=4;s=Robot1/Power_Status_R1", "Medium");
            //client.WriteNode("ns=4;s=Robot1/Temperature", 66.3156);

            //client.WriteNode("ns=4;s=Robot1/Temperature", sensorValue);

            //client.WriteNode("ns=4;s=Robot1/Reset_Cnt_R1", 7);

            client.WriteNode("ns=4;s=Robot2/ToolNumber", 20);
            client.WriteNode("ns=4;s=Robot2/JogSpeed", 3);
            client.WriteNode("ns=4;s=Robot2/Coordinate", 1);
            client.WriteNode("ns=4;s=Robot2/ServoStt", true);
            client.WriteNode("ns=4;s=Robot2/SystemStt", 2);
            client.WriteNode("ns=4;s=Robot2/LockRBC", false);
            client.WriteNode("ns=4;s=Robot2/Mode", true);
            client.WriteNode("ns=4;s=Robot2/SecLevel", 1);

        }

        double ReadSensorData()
        {
            var rand = new Random();
            int minValue = 50, maxValue = 70;
            double sensorValue;

            //Generate SensorValue
            sensorValue = rand.NextDouble() * (maxValue - minValue) + minValue;
            txtSensorValue.Text = sensorValue.ToString("#.##");
            DateTime sensorDateTime = DateTime.Now;
            txtTimeStamp.Text = sensorDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            return sensorValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Connect();
            timer1.Start();
            try
            {
                serialPort1.PortName = "COM3";
                serialPort1.Open();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (client != null)
                client.Disconnect();
            lblStatusMessage.Text = "Logging Stopped and Disconnected from OPC Server";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
