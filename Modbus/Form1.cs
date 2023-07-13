using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Modbus
{
    public partial class Form1 : Form
    {
        public SerialPort gSerialPort;//連接

        public Form1()
        {
            InitializeComponent();
        }

        private void GetComPortNamelist()
        {
            comBPortName.Items.Clear();
            string[] COMPorts = SerialPort.GetPortNames(); //取得電腦的COMPORT
            comBPortName.Items.AddRange(COMPorts);
            if (comBPortName.Items.Count >= 1)
            {
                comBPortName.SelectedIndex = 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetComPortNamelist();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectFun(sender);
        }
        private void ConnectFun(object sender = null)
        {
            if (sender == null)
            {
                sender = btnConnect;
            }
            if (comBPortName.SelectedItem != null) //判斷選擇的不是空集合
            {
                ((Button)sender).Enabled = false;//按鈕關閉 避免被一直案
                if (IsConnect(comBPortName.SelectedItem.ToString()))//開始連線，且判斷是否連線成功
                {
                    ((Button)sender).BackColor = Color.Green;//改變按鈕顏色
                    ((Button)sender).Text = gSerialPort.PortName;//改變按鈕顯示的字
                }
                else//連線失敗
                {
                    ((Button)sender).Enabled = true;
                }
            }
        }

        public bool IsConnect(string COM = "")//連線PORT，並且回傳True/false
        {
            bool F_temp = false;//建立需要回傳的

            int baudRate = 0;
            Parity parity = Parity.None;
            int dataBits = 0;
            StopBits stopBits = StopBits.None;

            if (int.TryParse(comBBaudrate.Text, out baudRate)
                && Enum.TryParse(comBParity.Text, out parity)
                && int.TryParse(comBDataBits.Text, out dataBits)
                && Enum.TryParse(comBStopBits.Text, out stopBits))
            {

            }
            else
            {
                return F_temp;
            }
            try
            {
                if (COM != "")//判斷輸入不為空
                {
                    if (gSerialPort == null)
                    {
                        gSerialPort = new SerialPort(COM, baudRate, parity, dataBits, stopBits);//建立物件，以及連線規則
                        gSerialPort.Handshake = System.IO.Ports.Handshake.None;//連線規則
                        gSerialPort.DataReceived += new SerialDataReceivedEventHandler(gSerialPortDataReceived);//指定回傳觸發的事件，但是如果資料會連續傳，請自己開線程，不然CPU使用率會過高
                        gSerialPort.Open();//開啟連線，通常有異常都是在這一步
                    }
                    if (gSerialPort.IsOpen)//判斷是否開啟成功
                    {
                        return F_temp = true; //回傳TRUE，並且離開此程序
                    }
                }
            }
            catch
            {
            }
            if (gSerialPort != null)
            {
                gSerialPort.Close();
                gSerialPort.Dispose();
                gSerialPort = null;
            }
            return F_temp;

        }

        private void gSerialPortDataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            DisConnectFun();
        }

        public void DisConnectFun()
        {
            if (gSerialPort != null)//判斷是否為空集合
            {//不是空集合
                string str = gSerialPort.PortName;//取得PORT的名字
                gSerialPortDataReceived(null, null);//讀取緩存區將資料清空
                gSerialPort.Close();//關閉PROT
                gSerialPort.Dispose();//釋放
                gSerialPort = null;//完全消失
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] _bytes;
            if (txtSendString.Visible)
            {

                if (txtSendString.Text != "")
                {                
                    //ASCIIEncoding ascii = new ASCIIEncoding();
                    //int byteCount = ascii.GetByteCount(txtSendString.Text.ToCharArray(), 0, txtSendString.Text.Length);
                    //_bytes = new Byte[byteCount];
                    //int bytesEncodedCount = ascii.GetBytes(txtSendString.Text.ToCharArray(), 0, txtSendString.Text.Length, _bytes, 0);
                    _bytes = System.Text.Encoding.ASCII.GetBytes(txtSendString.Text);
                }
               
            }
            else
            {
                if (txtSendByte.Text != "")
                {
                    _bytes = MyConvert.GetBytes(txtSendByte.Text);
                }
            }


        }

        private void RS232Send(byte[] _bytes)
        {
            void listSendadd()
            {
                if (listSend.Items.Count > 100)
                {
                    listSend.Items.Clear();
                }
                listSend.Items.Add(MyConvert.ToHexString(_bytes));
            }

            if (gSerialPort != null && gSerialPort.IsOpen)//
            {
                gSerialPort.Write(_bytes, 0, _bytes.GetUpperBound(0));//傳送出資料
                if (listSend.InvokeRequired)
                {
                    listSend.Invoke(new EventHandler(delegate
                    {
                        listSendadd();
                    }));
                }
                else
                {
                    listSendadd();
                }
                  

            }
        }
        private void RS232Send(string _Str)
        {

        }



    }

}
