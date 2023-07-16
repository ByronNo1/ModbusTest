using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modbus
{
    internal static class MyConvert
    {
        //Function Codes Supported by Controllers                          
        //01 Read Coil Status                              //01 讀取線圈狀態              
        //02 Read Input Status                             //02 讀取輸入狀態              
        //03 Read Holding Registers                        //03 讀取保持寄存器              
        //04 Read Input Registers                          //04 讀取輸入寄存器               
        //05 Force Single Coil                             //05 寫入 強制單線圈               
        //06 Preset Single Register                        //06 單一變數寫入 預設單個寄存器                
        //07 Read Exception Status                         //07 讀取異常狀態             
        //11 (0B Hex) Fetch Comm Event Ctr                 //11 (0B Hex) 獲取通訊事件中心               
        //12 (0C Hex) Fetch Comm Event Log                 //12 (0C Hex) 獲取通訊事件日誌              
        //15 (0F Hex) Force Multiple Coils                 //15 (0F Hex) 強制多個線圈                  
        //16 (10 Hex) Preset Multiple Regs                 //16 (10 Hex) 多個變數寫入 預設多個寄存器                 
        //17 (11 Hex) Report Slave ID                      //17（11 十六進制）報告從站 ID                
        //20 (14Hex) Read General Reference                //20 (14Hex) 讀取通用參考               
        //21 (15Hex) Write General Reference               //21 (15Hex) 寫入通用參考                
        //22 (16Hex) Mask Write 4X Register                //22 (16Hex) 掩碼寫入 4X 寄存器                
        //23 (17Hex) Read/Write 4X Registers               //23 (17Hex) 讀/寫 4X 寄存器                
        //24 (18Hex) Read FIFO Queue                       //24 (18Hex) 讀取 FIFO 隊列 

        //---------------------------TCPIP--------------------------------
        //https://dotblogs.com.tw/Leo_CodeSpace/2018/12/26/185411
        //在學習 Modbus協定之前，我們需要先了解每一個Byte各代表的意思為何
        //以下為 Modbus TCP request 的封包格式：
        //TCP Header    Address       Function Code   Start register addr         data
        //6bytes	    1byte	    1byte	        2byte                       N bytes
        //TCP Header
        //其中我們會發現 TCP Header 一共佔了6Byte。

        //這6個Byte主要是由三個欄位所組成，每一個欄位都佔2Byte。

        //本次通訊的識別碼（Transaction ID）：會產生2個Byte的隨機值，用來識別該次通訊。

        //通訊方式（Protocal ID）：基本上都是0，用來表示採用哪種通訊協定。0表示為 Modbus / TCP

        //資料長度（Length）：用來定義從Address開始 ~data欄位結束，所佔的總長度為何。

        //Address
        //共佔1Byte，用來記錄該次通訊要存取 slave端位址

        //Function Code
        //共佔1Byte，用來定義該次通訊是要做哪種操作。

        //其中常見的Function Code有以下幾種：

        //01: 讀取當前 digital out status

        //02: 讀取當前 digital input status

        //03: 讀取當前 analog out status

        //04: 讀取當前 analog input status

        //05: 寫入單個 digital out value

        //06: 寫入單個 analog out value

        //15: 寫入多個 digital out value

        //16: 寫入多個 analog out value

        //Start register addr
        //共佔2Byte，用來定義暫存器起始位址

        //data
        //長度為非固定，由傳送的資料長度而定。


        //---------------------------TCPIP--------------------------------
        //https://ozeki.hu/p_5882-mobdbus-function-code-15-write-multiple-coils.html

        public static string ToHexString(byte[] bytes) // 0xae00cf => "AE00CF "
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder strB = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    strB.Append(bytes[i].ToString("X2"));
                }
                hexString = strB.ToString();
            }
            return hexString;
        }

        public static string LRC(string STR)
        {
            try
            {
                int checksum = 0;
                for (int i = 0; i < STR.Length; i += 2)
                {
                    checksum = checksum + Convert.ToInt32(STR.Substring(i, 2), 16);
                }
                int result = 65535 - checksum + 1;
                return (result.ToString("X2").Substring(2, 2));
            }
            catch
            {
                return "";
            }
        }

        public static byte[] GetBytes(string HexString)
        {
            int byteLength = HexString.Length / 2;
            byte[] bytes = new byte[byteLength];
            byte[] bytes_2 = new byte[byteLength + 2];
            string hex;
            int j = 0;
            try
            {

                for (int i = 0; i < bytes.Length; i++)
                {
                    hex = new String(new Char[] { HexString[j], HexString[j + 1] });
                    bytes[i] = HexToByte(hex);
                    bytes_2[i] = HexToByte(hex);
                    j = j + 2;
                }
                return bytes;
                /*----------------以下是加入CRC檢查碼----------------*/
                //byte[] bytes_temp = new byte[2];
                //bytes_temp = get_CRC16_C(bytes);
                //bytes_2[bytes.Length] = bytes_temp[0];
                //bytes_2[bytes.Length + 1] = bytes_temp[1];
                //return bytes_2;
            }
            catch
            {
                return bytes;
                //return bytes_2;
            }
        }

        public static byte HexToByte(string hex)
        {
            try
            {
                if (hex.Length > 2 || hex.Length <= 0)
                    throw new ArgumentException("hex must be 1 or 2 characters in length");
                byte newByte = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                return newByte;
            }
            catch
            {
                return 0;
            }
        }

        public static UInt16 ModRTU_CRC(byte[] buf, int len)
        {
            UInt16 crc = 0xFFFF;
            try
            {
                for (int pos = 0; pos < len; pos++)
                {
                    crc ^= (UInt16)buf[pos];          // XOR byte into least sig. byte of crc

                    for (int i = 8; i != 0; i--)
                    {    // Loop over each bit
                        if ((crc & 0x0001) != 0)
                        {      // If the LSB is set
                            crc >>= 1;                    // Shift right and XOR 0xA001
                            crc ^= 0xA001;
                        }
                        else                            // Else LSB is not set
                            crc >>= 1;                    // Just shift right
                    }
                }
                // Note, this number has low and high bytes swapped, so use it accordingly (or swap bytes)
                return crc;
            }
            catch
            {
                return 0;
            }
        }

        public static byte[] get_CRC16_C(byte[] data)
        {
            byte num = 0xff;
            byte num2 = 0xff;

            byte num3 = 1;
            byte num4 = 160;
            byte[] buffer = data;
            try
            {
                for (int i = 0; i < buffer.Length; i++)
                {
                    //位异或运算
                    num = (byte)(num ^ buffer[i]);

                    for (int j = 0; j <= 7; j++)
                    {
                        byte num5 = num2;
                        byte num6 = num;

                        //位右移运算
                        num2 = (byte)(num2 >> 1);
                        num = (byte)(num >> 1);

                        //位与运算
                        if ((num5 & 1) == 1)
                        {
                            //位或运算
                            num = (byte)(num | 0x80);
                        }
                        if ((num6 & 1) == 1)
                        {
                            num2 = (byte)(num2 ^ num4);
                            num = (byte)(num ^ num3);
                        }
                    }
                }
                byte[] buffer_1 = { num, num2 };
                return buffer_1;
            }
            catch
            {
                byte[] buffer_1 = new byte[1];
                return buffer_1;
            }

        }
        public static string ToHexString() // 0xae00cf => "AE00CF "
        {
            string hexString = string.Empty;

            //    BinaryFormatter bfA = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);

            //BinaryFormatter bfB = new BinaryFormatter();
            //p = bfB.Deserialize();

            //JavaScriptSerializer js = new JavaScriptSerializer();
            //string jsonData = js.Serialize(stu);//序列化
            //Console.WriteLine(jsonData);
            //反序列化的方式1

            //string desJson = jsonData;
            //Student model = js.Deserialize<Student>(desJson);// //反序列化
            //string message = string.Format("ID={0},Name={1},Age={2},Sex={3}", model.ID, model.Name, model.Age, model.Sex);
            return hexString;

        }


    }

}
