using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using CheckBox = System.Windows.Forms.CheckBox;

namespace Modbus
{
    public partial class Form1 : Form
    {
        public SerialPort gSerialPort;//連接
        List<byte> gListLastTime = new List<byte>();
        DateTime gDateTimeLastTime;

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
            // Thread.Sleep(100);
            try
            {

                if (sender != null)
                {
                    int n = ((SerialPort)sender).BytesToRead;
                    byte[] buf = new byte[n];
                    ((SerialPort)sender).Read(buf, 0, n);//读取缓冲数据  
                    #region listReceived ADD
                    if (listReceived.InvokeRequired)
                    {
                        listReceived.Invoke((EventHandler)delegate
                        {
                            if (listReceived.Items.Count > 100)
                            {
                                listReceived.Items.Clear();
                            }
                            listReceived.Items.Add(MyConvert.ToHexString(buf));
                        });
                    }
                    else
                    {
                        if (listReceived.Items.Count > 100)
                        {
                            listReceived.Items.Clear();
                        }
                        listReceived.Items.Add(MyConvert.ToHexString(buf));
                    }
                    #endregion
                    gDateTimeLastTime = DateTime.Now;
                    ParseDataReceived(buf);
                }

            }
            catch { }
        }

        private void ParseDataReceived(byte[] _bytes)
        {
            List<byte> tmpList = new List<byte>();
            if (DateTime.Now.Subtract(gDateTimeLastTime).TotalMilliseconds > 500) //距離上次收到值超過0.5秒，清空上次殘留的值
            {
                gListLastTime = new List<byte>();
            }

            gListLastTime.AddRange(_bytes);
            tmpList = new List<byte>(gListLastTime);
            ParseDataReceivedRecursive(ref tmpList);
            if (tmpList.Count > 0)
            {
                gListLastTime = new List<byte>(tmpList);
            }
            else
            {
                gListLastTime = new List<byte>();
            }



        }

        private void ParseDataReceivedRecursive(ref List<byte> _tmpList)
        {
            int index = 0;
            string StrMessage;
            string StrSlaveAddress;
            string StrFunction;
            int intFunction;
            string StrByteCount;
            string StrCRC;
            int intDataCount;
            string StrData;
            List<byte> _tmpNowList = new List<byte>();
            if (_tmpList.Count >= 3)
            {
                StrSlaveAddress = _tmpList[0].ToString("X2");
                _tmpNowList.Add(_tmpList[0]);
                StrFunction = _tmpList[1].ToString("X2");
                intFunction = _tmpList[1];
                _tmpNowList.Add(_tmpList[1]);
                StrByteCount = _tmpList[2].ToString("X2");
                intDataCount = _tmpList[2];
                _tmpNowList.Add(_tmpList[2]);
                StrData = "";
                if (_tmpList.Count >= 3 + intDataCount + 2) //後面的資料要夠多 不然值會有問題
                {
                    ;//代表這次會使用到多少DATA  3(前三碼) + intDataCount(資料個數) + 2(CRC)
                    for (int i = 0; i < intDataCount; i++)
                    {
                        index = 3 + i;
                        _tmpNowList.Add(_tmpList[index]);
                        StrData += _tmpList[index].ToString("X2");
                    }

                    StrCRC = "";
                    StrCRC = _tmpList[3 + intDataCount].ToString("X2") + _tmpList[3 + intDataCount + 1].ToString("X2");
                    _tmpNowList.Add(_tmpList[3 + intDataCount]);
                    _tmpNowList.Add(_tmpList[3 + intDataCount + 1]);
                    if (isCheckCRC(_tmpNowList.ToArray()))
                    {
                        StrMessage = StrSlaveAddress + StrFunction + StrByteCount + StrData + StrCRC;
                        ParseSingleFunction(StrMessage);
                        ParseSingleFunction(_tmpNowList);
                    }
                    else
                    {
                        //收到異常資料 可以記錄並且清除 這些資料，但是不用分析
                    }
                    if (_tmpList.Count == 3 + intDataCount + 2)
                    {  //數量跟這次取的一樣代表已經取完了
                        _tmpList.Clear();
                        return;
                    }
                    else
                    {   //還有其他資料判斷是不是還有資料
                        _tmpList.RemoveRange(0, 3 + intDataCount + 2);
                        ParseDataReceivedRecursive(ref _tmpList);  //遞迴
                        return;
                    }
                }


            }
            else
            {
                return;
            }
        }
        private void ParseSingleFunction(string _Str)
        {
            byte[] _tmpArray = null;
            _tmpArray = MyConvert.GetBytes(_Str);
            ParseSingleFunction(_tmpArray.ToList());
        }
        private void ParseSingleFunction(List<byte> _tmpList)
        {

            string StrFunction;
            int intFunction;

            List<byte> _tmpNowList = new List<byte>();
            if (_tmpList.Count >= 3)
            {
                StrFunction = _tmpList[1].ToString("X2");
                intFunction = _tmpList[1];
                switch (StrFunction)
                {
                    case "01":
                        ParseFunc01ReadCoils(_tmpNowList.ToArray());
                        break;


                }

            }

        }


        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            DisConnectFun();
            btnConnect.Enabled = true;
            btnConnect.BackColor = Control.DefaultBackColor;
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
            void listSendadd(string _str = "")
            {
                if (listSend.Items.Count > 100)
                {
                    listSend.Items.Clear();
                }
                listSend.Items.Add(MyConvert.ToHexString(_bytes) + _str);
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
            else
            {
                listSendadd(",SerialPort No Open NoSend");
            }
        }
        private void RS232Send(string _Str)
        {

        }

        private void btnModbusSend_Click(object sender, EventArgs e)
        {
            string[] _StrArr;
            byte[] _ByteSend = null;
            byte[] _ByteTmp = null;
            string StrSlaveAddress = "", StrRegisterAddress = "", StrRegisterLength = "";
            ComboBox tmpComboBox = null;
            if (((Button)sender).Name == "btnModbusSend_01")
            {
                tmpComboBox = comBFunctionCode;
                StrSlaveAddress = txtSlaveAddress.Text;
                StrRegisterAddress = txtRegisterAddress.Text;
                StrRegisterLength = txtRegisterLength.Text;
            }
            else if (((Button)sender).Name == "btnModbusSend_02")
            {
                tmpComboBox = comBFunctionCode_02;
                StrSlaveAddress = txtSlaveAddress_02.Text;
                StrRegisterAddress = txtRegisterAddress_02.Text;
                StrRegisterLength = txtRegisterLength_02.Text;
            }


            if (tmpComboBox != null && tmpComboBox.SelectedIndex >= 0)
            {
                _StrArr = tmpComboBox.SelectedItem.ToString().Split('-');
                if (_StrArr.Length == 2)
                {
                    switch (_StrArr[0])
                    {
                        case "01":
                        case "02":
                        case "03":
                        case "04":
                        case "05":
                        case "06":
                            _ByteSend = SendFuncQuery01to06(StrSlaveAddress, StrRegisterAddress, StrRegisterLength, _StrArr[0]);
                            break;

                    }
                }
            }
            if (_ByteSend != null)
            {
                _ByteTmp = CRC.CRC16(_ByteSend);
                Array.Resize(ref _ByteSend, _ByteSend.Length + 2);
                _ByteSend[_ByteSend.Length - 2] = _ByteTmp[1];  // 要交換前後
                _ByteSend[_ByteSend.Length - 1] = _ByteTmp[0];  // 要交換前後
                Console.WriteLine(MyConvert.ToHexString(_ByteSend));
                RS232Send(_ByteSend);
            }

        }

        /// <summary>
        /// SendFuncQuery01to06
        /// </summary>
        /// <param name="_SlaveAddressHex">站點 slave device </param>
        /// <param name="_FuncCodeHex"> 功能碼</param>
        /// <param name="_RegisterAddressHex"> 戰存器 地址 Hi Lo</param>
        /// <param name="_RegisterLengthValueHex">01-04 長度，05 06 寫值 </param>
        /// <returns></returns>
        private byte[] SendFuncQuery01to06(string _SlaveAddressHex, string _FuncCodeHex, string _RegisterAddressHex, string _RegisterLengthValueHex)
        {
            #region 01 Read Coil Status
            //--------------------- 01 Read Coil Status
            //Slave Address 11
            //Function 01
            //Starting Address Hi 00
            //Starting Address Lo 13
            //No.of Points Hi 00
            //No.of Points Lo 25
            //Error Check(LRC or CRC) 
            #endregion
            #region  02 Read Input Status
            //--------------------- 02 Read Input Status
            //Slave Address 11
            //Function 02
            //Starting Address Hi 00
            //Starting Address Lo C4
            //No.of Points Hi 00
            //No.of Points Lo 16
            //Error Check(LRC or CRC) –
            #endregion
            #region 03 Read Holding Registers
            //-------------------- 03 Read Holding Registers
            //Slave Address 11
            //Function 03
            //Starting Address Hi 00
            //Starting Address Lo 6B
            //No.of Points Hi 00
            //No.of Points Lo 03
            //Error Check(LRC or CRC) ––
            #endregion
            #region 04 Read Input Registers
            //-------------------- 04 Read Input Registers
            //Slave Address 11
            //Function 04
            //Starting Address Hi 00
            //Starting Address Lo 08
            //No.of Points Hi 00
            //No.of Points Lo 01
            //Error Check(LRC or CRC) ––
            #endregion
            //https://ozeki.hu/p_5881-mobdbus-function-code-6-write-single-holding-register.html
            #region 05 Force Single Coil
            //0B: The Slave Address(0B hex = address 11)
            //05: The Function Code 5(Write Single Coil)
            //00BF: The Data Address of the coil(coil# 192 - 1 offset = 191 = BF hex).
            //0000: The status to write(FF00 = ON, 0000 = OFF).
            //FC84: The CRC(Cyclic Redundancy Check) for error checking.
            //Slave Address 11
            //Function 05
            //Coil Address Hi 00
            //Coil Address Lo AC
            //Force Data Hi FF
            //Force Data Lo 00
            //Error Check(LRC or CRC) ––
            #endregion
            #region 06 Preset Single Register
            //0B: The Slave Address(0B hex = address 11)
            //06: The Function Code 6(Write Single Holding Register)
            //0004: The Data Address of the register(0004 hex = 4, +40001 offset = register #40005).
            //ABCD: The value to write.
            //7604: The CRC(Cyclic Redundancy Check) for error checking.

            //Slave Address 11
            //Function 06
            //Register Address Hi 00
            //Register Address Lo 01
            //Preset Data Hi 00
            //Preset Data Lo 03
            //Error Check(LRC or CRC) ––
            #endregion
            string[] StrArrayCheckFunctionCode = { "01", "02", "03", "04", "05", "06" };

            byte[] _ByteSend;
            string _StrTmp = "";
            if (_SlaveAddressHex.Length <= 2 && _SlaveAddressHex != "")
            {
                _StrTmp += _SlaveAddressHex.PadLeft(2, '0');
            }
            else
            {
                return null;
            }
            if (_FuncCodeHex.Length <= 2 && _FuncCodeHex != "")
            {
                if (StrArrayCheckFunctionCode.Contains(_FuncCodeHex.PadLeft(2, '0'))) //判斷有沒有 在裡面
                {
                    _StrTmp += _FuncCodeHex.PadLeft(2, '0');
                }
                else
                {
                    return null;
                }

            }
            else
            {
                return null;
            }
            if (_RegisterAddressHex.Length <= 4 && _RegisterAddressHex != "")
            {
                _StrTmp += _RegisterAddressHex.PadLeft(4, '0');
            }
            else
            {
                return null;
            }
            if (_RegisterLengthValueHex.Length <= 4 && _RegisterLengthValueHex != "")
            {
                _StrTmp += _RegisterLengthValueHex.PadLeft(4, '0');
            }
            else
            {
                return null;
            }
            _ByteSend = MyConvert.GetBytes(_StrTmp);

            return _ByteSend;
        }


        private byte[] SendFuncQuery070B0C(string _SlaveAddressHex, string _FuncCodeHex)
        {
            #region 07 Read Exception Status
            //--------------------- 07 Read Exception Status
            //Slave Address 11
            //Function 07
            //Error Check(LRC or CRC) ––
            #endregion
            #region  11 (0B Hex) Fetch Comm Event Counter
            //---------------------11 (0B Hex) Fetch Comm Event Counter
            //Slave Address 11
            //Function 0B
            //Error Check(LRC or CRC) ––
            #endregion
            #region 12 (0C Hex) Fetch Comm Event Log
            //-------------------- 12 (0C Hex) Fetch Comm Event Log
            //Slave Address 11
            //Function 0C
            //Error Check(LRC or CRC) ––
            #endregion
            string[] StrArrayCheckFunctionCode = { "07", "0B", "0C" };

            byte[] _ByteSend;
            string _StrTmp = "";

            if (_SlaveAddressHex.Length <= 2 && _SlaveAddressHex != "")
            {
                _StrTmp += _SlaveAddressHex.PadLeft(2, '0');
            }
            else
            {
                return null;
            }
            if (_FuncCodeHex.Length <= 2 && _FuncCodeHex != "")
            {
                if (StrArrayCheckFunctionCode.Contains(_FuncCodeHex.PadLeft(2, '0'))) //判斷有沒有 在裡面
                {
                    _StrTmp += _FuncCodeHex.PadLeft(2, '0');
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
            _ByteSend = MyConvert.GetBytes(_StrTmp);

            return _ByteSend;
        }


        private byte[] SendFuncQuery0F_ForceMultipleCoils(string _SlaveAddressHex, string _RegisterAddressHex, byte[] _BytesForceData)
        {
            #region 15 (0F Hex) Force Multiple Coils
            //------------------------------
            //0B: The Slave Address(0B hex = address 11)
            //0F: The Function Code 15(Write Multiple Coils, 15 = 0F hex)
            //001B: The Data Address of the first coil(001B hex = 27, +1 offset = coil #28).
            //0009: The number of coils to written(09 hex = 9)
            //02: The number of data bytes to follow(9 Coils = 1 byte + 1 bits + 7 space holders = 2 bytes)
            //4D: Coils 35 - 28(0100 1101)
            //01: 7 space holders & Coil 36(0000 0001)
            //6CA7: The CRC(Cyclic Redundancy Check) for error checking.
            //-------------------------------------------------------------------------------------------------------
            //Bit:  1   1   0   0   1   1   0   1       0   0   0   0   0   0   0   1
            //Coil: 27  26  25  24  23  22  21  20      -   -   -   -   -   -   29  28
            //Slave Address 11
            //Function 0F
            //Coil Address Hi 00
            //Coil Address Lo 13
            //Quantity of Coils Hi 00
            //Quantity of Coils Lo 0A             <<<<< 注意 要設定 10個數量的coils  
            //Byte Count 02                       <<<<< 注意 後續有兩個Byte
            //Force Data (Coils 27 - 20) CD
            //Force Data (Coils 29 - 28) 01
            //Error Check(LRC or CRC) ––
            //----------------------------------Response---------------------------------
            //Slave Address 11
            //Function 0F
            //Coil Address Hi 00
            //Coil Address Lo 13
            //Quantity of Coils Hi 00
            //Quantity of Coils Lo 0A
            //Error Check(LRC or CRC) ––
            #endregion
            string _FuncCodeHex = "0F";

            byte[] _ByteSend;
            string _StrTmp = "";
            int NumberOfCoils = 0;
            if (_SlaveAddressHex.Length <= 2 && _SlaveAddressHex != "")
            {
                _StrTmp += _SlaveAddressHex.PadLeft(2, '0');
            }
            else
            {
                return null;
            }
            if (_FuncCodeHex.Length <= 2 && _FuncCodeHex != "")
            {

                _StrTmp += _FuncCodeHex.PadLeft(2, '0');
            }
            else
            {
                return null;
            }
            if (_RegisterAddressHex.Length <= 4 && _RegisterAddressHex != "")
            {
                _StrTmp += _RegisterAddressHex.PadLeft(4, '0');
            }
            else
            {
                return null;
            }

            if (_BytesForceData != null && _BytesForceData.Length > 0)
            {
                NumberOfCoils = _BytesForceData.Length * 8; //代表要寫入幾個Coils byte 轉 bit 乘8，不給寫一半的
                _StrTmp += NumberOfCoils.ToString("X4");
                _StrTmp += _BytesForceData.Length.ToString("X2");
            }
            else
            {
                return null;
            }

            for (int i = 0; i < _BytesForceData.Length; i++)
            {
                _StrTmp += _BytesForceData[i].ToString("X2");
            }
            _ByteSend = MyConvert.GetBytes(_StrTmp);

            return _ByteSend;
        }

        private byte[] SendFuncQuery0F_ForceMultipleCoils(string _SlaveAddressHex, string _RegisterAddressHex, int _intForceData)
        {
            List<byte> _bytes = new List<byte>();
            int _int = 0;
            int intQuotient = _intForceData;

            while (intQuotient > 0)
            {
                if (intQuotient > 255)
                {
                    _int = intQuotient % 256;
                    intQuotient /= 256;
                }
                else
                {
                    _int = intQuotient;
                    intQuotient = 0;
                }
                _bytes.Add((byte)_int);
            }


            return SendFuncQuery0F_ForceMultipleCoils(_SlaveAddressHex, _RegisterAddressHex, _bytes.ToArray());
        }


        private byte[] SendFuncQuery10_PresetMultipleRegisters(string _SlaveAddressHex, string _RegisterAddressHex, string[] _BytesRegistersValue)
        {
            //https://ozeki.hu/p_5883-mobdbus-function-code-16-write-multiple-holding-registers.html
            #region  16 (10 Hex) Preset Multiple Registers
            //Request
            //Function code   1 Byte  0x10
            //Starting Address    2 Bytes 0x0000 to 0xFFFF
            //Quantity of Registers   2 Bytes 0x0001 to 0x007B
            //Byte Count  1 Byte  2 x N*
            //Registers Value N*x 2 Bytes value
            //This command is writing the contents of two analog output holding registers # 40019 & 40020 to the slave device with address 11. Each holding register can store 16 bits.

            //0B 10 0012 0002 04 0B0A C102 A0D5

            //0B: The Slave Address(0B hex = address 11)
            //10: The Function Code 16(Write Multiple Holding Registers, 16 = 10 hex)
            //0012: The Data Address of the first register(0012 hex = 18, +40001 offset = register #40019).
            //0002: The number of registers to write.
            //04: The number of data bytes to follow(2 registers x 2 bytes each = 4 bytes).
            //0B0A: The value to write to register 40019
            //C102: The value to write to register 40020
            //A0D5: The CRC(Cyclic Redundancy Check) for error checking.

            //--------------------- 16 (10 Hex) Preset Multiple Registers
            //Here is an example of a request to preset two registers starting at 40002 to 00 0A and 01 02 hex, in slave device 17:
            //Slave Address 11
            //Function 10
            //Starting Address Hi 00
            //Starting Address Lo 01
            //No.of Registers Hi 00
            //No.of Registers Lo 02
            //Byte Count 04
            //Data Hi 00
            //Data Lo 0A
            //Data Hi 01
            //Data Lo 02
            //Error Check(LRC or CRC) ––
            //----------------------------------Response---------------------------------
            //Slave Address 11
            //Function 10
            //Starting Address Hi 00
            //Starting Address Lo 01
            //No.of Registers Hi 00
            //No.of Registers Lo 02
            //Error Check(LRC or CRC) ––
            #endregion
            string _FuncCodeHex = "10";
            byte[] _ByteSend;
            string _StrTmp = "";
            if (_SlaveAddressHex.Length <= 2 && _SlaveAddressHex != "")
            {
                _StrTmp += _SlaveAddressHex.PadLeft(2, '0');
            }
            else
            {
                return null;
            }
            _StrTmp += _FuncCodeHex.PadLeft(2, '0');

            if (_RegisterAddressHex.Length <= 4 && _RegisterAddressHex != "")
            {
                _StrTmp += _RegisterAddressHex.PadLeft(4, '0');
            }
            else
            {
                return null;
            }
            if (_BytesRegistersValue.Length > 0)
            {
                _StrTmp += _BytesRegistersValue.Length.ToString("X4");
                _StrTmp += (_BytesRegistersValue.Length * 2).ToString("X2");
            }
            else
            {
                return null;
            }

            for (int i = 0; i < _BytesRegistersValue.Length; i++)
            {
                _StrTmp += _BytesRegistersValue[i].PadLeft(4, '0');
            }


            _ByteSend = MyConvert.GetBytes(_StrTmp);

            return _ByteSend;
        }


        private void ParseFunc01ReadCoils(string _StrMessage)
        {
            byte[] ByteMessage;
            ByteMessage = MyConvert.GetBytes(_StrMessage);
            ParseFunc01ReadCoils(ByteMessage);
        }

        private void ParseFunc01ReadCoils(byte[] ByteMessage)
        {
            //Slave Address 11
            //Function 01
            //Byte Count 05
            //Data(Coils 27–20) CD
            //Data(Coils 35–28) 6B
            //Data(Coils 43–36) B2
            //Data(Coils 51–44) 0E
            //Data(Coils 56–52) 1B
            //Error Check(LRC or CRC) ––
            string StrSlaveAddress;
            string StrByteCount;
            int intDataCount;
            bool[] IO_Y = new bool[8];


            if (isCheckCRC(ByteMessage))
            {
                StrSlaveAddress = ByteMessage[0].ToString("X2");
                // ByteMessage[1] //Function
                StrByteCount = ByteMessage[2].ToString("X2");
                intDataCount = ByteMessage[2];
                if (ByteMessage.Length - 3 == intDataCount)
                {
                    for (int i = 3; i < ByteMessage.Length; i++)
                    {
                        GetOut(ByteMessage[i], ref IO_Y);
                    }
                }
                else
                {
                    //Error DATA 數量對不起來
                    return;
                }
            }
            else
            {
                return;
            }


        }

        private void GetOut(byte _byte, ref bool[] _IOBool)
        {
            ushort _Ushort = _byte;
            for (int i = 0; i < 8; i++)
            {
                if (((_Ushort >> i) & 1) == 1)
                {
                    _IOBool[i] = true;
                }
                else
                {
                    _IOBool[i] = false;
                }
            }

            //string _str = Convert.ToString(_byte, 2);
            //for (int i = 0; i < 8; i++)
            //{
            //    if (_str[_str.Length - i - 1] == '1')
            //    {
            //        _IOBool[i] = true;
            //    }
            //    else
            //    {
            //        _IOBool[i] = false;
            //    }
            //}

        }

        private void ParseFunc02ReadInputStatus(string _StrMessage)
        {
            //Example  110203ACDB352018
            //Field Name(Hex)
            //Slave Address 11
            //Function 02
            //Byte Count 03
            //Data(Inputs 10204–10197) AC
            //Data(Inputs 10212–10205) DB
            //Data(Inputs 10218–10213) 35
            //Error Check(LRC or CRC) ––
            //RESPONSE
            string StrSlaveAddress;
            string StrByteCount;
            int intDataCount;
            byte[] ByteMessage;
            bool[] IO_Y = new bool[8];

            ByteMessage = MyConvert.GetBytes(_StrMessage);

            if (isCheckCRC(ByteMessage))
            {
                StrSlaveAddress = ByteMessage[0].ToString("X2");
                // ByteMessage[1] //Function
                StrByteCount = ByteMessage[2].ToString("X2");
                intDataCount = ByteMessage[2];
                if (ByteMessage.Length - 3 == intDataCount)
                {
                    for (int i = 3; i < ByteMessage.Length; i++)
                    {
                        GetOut(ByteMessage[i], ref IO_Y);
                    }
                }
                else
                {
                    //Error DATA 數量對不起來
                    return;
                }
            }
            else
            {
                return;
            }


        }

        private bool isCheckCRC(byte[] _bytes)
        {

            byte[] ByteMessage;
            byte[] ByteTmpCRC = new byte[2];
            byte[] ByteCheckCRC = new byte[2];


            ByteMessage = _bytes;
            ByteTmpCRC[0] = ByteMessage[ByteMessage.Length - 2];
            ByteTmpCRC[1] = ByteMessage[ByteMessage.Length - 1];
            Array.Resize(ref ByteMessage, ByteMessage.Length - 2); //拿掉CRC 兩個
            ByteCheckCRC = CRC.CRC16(ByteMessage);
            if (ByteTmpCRC[0] == ByteCheckCRC[1] && ByteTmpCRC[1] == ByteCheckCRC[0])
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string StrX = 1020.ToString("X4");
            SendFuncQuery0F_ForceMultipleCoils("01", "111", 1020);
            //ParseFunc01ReadCoils("110105CD68B20E1B45A2");
            //ParseFunc01ReadCoils("110203ACDB352018");
            //byte[] buf = new byte[] { 0x11, 0x02, 0x03, 0xAC, 0xDB, 0x35, 0x20, 0x18, 0x01, 0x01, };
            //ParseDataReceived(buf);

        }

        private void btnModbusSend_03_Click(object sender, EventArgs e)
        {
            string[] _StrArr;
            byte[] _ByteSend = null;
            byte[] _ByteTmp = null;
            string StrSlaveAddress, StrRegisterAddress; //, StrRegisterLength
            StrSlaveAddress = txtSlaveAddress_03.Text;
            StrRegisterAddress = txtRegisterAddress_03.Text;
            // StrRegisterLength = txtRegisterLength_03.Text; // 被IO點取代
            byte[] bytes = new byte[4];
            string[] strArray;
            //string[] StrArrSend = new string[4];
            ushort[] ushorts = new ushort[4];
            int[] int2 = new int[4];

            char[] chars;
            int i = 0;
            int j = 0;
            string StrTmp;
            try
            {


                for (int k = 0; k < bytes.Length; k++)
                {
                    bytes[k] = 0;
                    //StrArrSend[k] = "00000000";
                    ushorts[k] = 0;
                    int2[k] = 0;
                }
                foreach (var item in panel_IO_001.Controls)
                {
                    if (item is System.Windows.Forms.CheckBox)
                    {
                        //chkIO_Y_0_0
                        StrTmp = ((CheckBox)item).Name.Replace("chkIO_Y_", "");
                        strArray = StrTmp.Split('_');
                        i = Convert.ToInt16(strArray[0]);
                        j = Convert.ToInt16(strArray[1]);
                        if (((CheckBox)item).Checked)
                        {
                            bytes[i] += (byte)(1 << j); // 用位移方式 加上
                            //chars = StrArrSend[i].ToArray(); // 用字串
                            //chars[7 - j] = '1';
                            //StrArrSend[i] = new string(chars);
                            ushorts[i] += (ushort)Math.Pow(2, j); // 用平方方式相加
                            int2[i] = int2[i] | (1 << j); // 用位移方式 加上
                        }

                    }
                }

                SendFuncQuery0F_ForceMultipleCoils(StrSlaveAddress, StrRegisterAddress, bytes);

            }
            catch (Exception)
            {

            }




        }

        private void btnModbusSend_04_Click(object sender, EventArgs e)
        {
            string[] _StrArr;
            ushort Tushort = 0;
            string StrSlaveAddress, StrRegisterAddress; //, StrRegisterLength
            StrSlaveAddress = txtSlaveAddress_04.Text;
            StrRegisterAddress = txtRegisterAddress_04.Text;
            // StrRegisterLength = txtRegisterLength_04.Text; // 被IO點取代
            List<string> strings = new List<string>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null &&
                    ushort.TryParse(dataGridView1.Rows[i].Cells[0].Value.ToString(), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out Tushort)
                    && Tushort <= 0xFFFF )
                {
                    strings.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
                else
                {
                    return;
                }
            }
            SendFuncQuery10_PresetMultipleRegisters(StrSlaveAddress, StrRegisterAddress, strings.ToArray()); ;
        }




    }

}
