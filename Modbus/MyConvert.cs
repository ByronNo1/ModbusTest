using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modbus
{
    internal static class MyConvert
    {

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
                /*----------------以下是加入CRC後戳檢查碼----------------*/
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
