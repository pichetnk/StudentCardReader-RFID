using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace checkName
{
    class rfidReader
    {
        [DllImport("kernel32.dll")]
        static extern void Sleep(int dwMilliseconds);

        [DllImport("MasterRD.dll")]
        static extern int lib_ver(ref uint pVer);

        [DllImport("MasterRD.dll")]
        static extern int rf_init_com(int port, int baud);

        [DllImport("MasterRD.dll")]
        static extern int rf_ClosePort();

        [DllImport("MasterRD.dll")]
        static extern int rf_antenna_sta(short icdev, byte mode);

        [DllImport("MasterRD.dll")]
        static extern int rf_init_type(short icdev, byte type);

        [DllImport("MasterRD.dll")]
        static extern int rf_request(short icdev, byte mode, ref ushort pTagType);

        [DllImport("MasterRD.dll")]
        static extern int rf_anticoll(short icdev, byte bcnt, IntPtr pSnr, ref byte pRLength);

        [DllImport("MasterRD.dll")]
        static extern int rf_select(short icdev, IntPtr pSnr, byte srcLen, ref sbyte Size);

        [DllImport("MasterRD.dll")]
        static extern int rf_halt(short icdev);

        [DllImport("MasterRD.dll")]
        static extern int rf_M1_authentication2(short icdev, byte mode, byte secnr, IntPtr key);

        [DllImport("MasterRD.dll")]
        static extern int rf_M1_initval(short icdev, byte adr, Int32 value);

        [DllImport("MasterRD.dll")]
        static extern int rf_M1_increment(short icdev, byte adr, Int32 value);

        [DllImport("MasterRD.dll")]
        static extern int rf_M1_decrement(short icdev, byte adr, Int32 value);

        [DllImport("MasterRD.dll")]
        static extern int rf_M1_readval(short icdev, byte adr, ref Int32 pValue);

        [DllImport("MasterRD.dll")]
        static extern int rf_M1_read(short icdev, byte adr, IntPtr pData, ref byte pLen);

        [DllImport("MasterRD.dll")]
        static extern int rf_M1_write(short icdev, byte adr, IntPtr pData);
        
        public bool bConnectedDevice;
        int portDevice,baudDevice;
        string keyA = "xxxxxxxxxx";
        //string keyB = "xxxxxxxxx";
        string cardID = "";
        static char[] hexDigits = { 
            '0','1','2','3','4','5','6','7',
            '8','9','A','B','C','D','E','F'};

        public rfidReader(int port,int baud)
        {

           // if (File.Exists("MasterRD.dll") == true)
           // {

            //    MessageBox.Show("OKOKOKOK");
           // }
            this.portDevice = port;
            this.baudDevice = baud;
            
        }
        private static byte GetHexBitsValue(byte ch)
        {
            byte sz = 0;
            if (ch <= '9' && ch >= '0')
                sz = (byte)(ch - 0x30);
            if (ch <= 'F' && ch >= 'A')
                sz = (byte)(ch - 0x37);
            if (ch <= 'f' && ch >= 'a')
                sz = (byte)(ch - 0x57);

            return sz;
        }
        public static string ToHexString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length * 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                int b = bytes[i];
                chars[i * 2] = hexDigits[b >> 4];
                chars[i * 2 + 1] = hexDigits[b & 0xF];
            }

            return new string(chars);
        }
        private static byte[] ToDigitsBytes(string theHex)
        {
            byte[] bytes = new byte[theHex.Length / 2 + (((theHex.Length % 2) > 0) ? 1 : 0)];
            for (int i = 0; i < bytes.Length; i++)
            {
                char lowbits = theHex[i * 2];
                char highbits;

                if ((i * 2 + 1) < theHex.Length)
                    highbits = theHex[i * 2 + 1];
                else
                    highbits = '0';

                int a = (int)GetHexBitsValue((byte)lowbits);
                int b = (int)GetHexBitsValue((byte)highbits);
                bytes[i] = (byte)((a << 4) + b);
            }

            return bytes;
        }
        public void disconnectDevice()
        {
            if (this.bConnectedDevice)
            {
                rf_ClosePort();
                this.bConnectedDevice = false;
            }
        }


        public void connectDevice()
        {
            if (!this.bConnectedDevice)
            {
                int port = 0;
                int baud = 0;
                int status;

                port = Convert.ToInt32(portDevice);
                baud = Convert.ToInt32(baudDevice);
         
                status = rf_init_com(port, baud);
                if (0 == status)
                {
                    //tsbtnConnect.Text = "Disconnect";
                    this.bConnectedDevice = true;
                    //MessageBox.Show("Connect device success!");
                }
                else
                {
                    string strError;
                    strError = "Connect device failed";
                    this.bConnectedDevice = false;
                    MessageBox.Show(strError, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }
        
        public void requestCard()
        {
            short icdev = 0x0000;
            int status;
            byte type = (byte)'A';//mifare one 
            byte mode = 0x52;
            ushort TagType = 0;
            byte bcnt = 0x04;//mifare 
            IntPtr pSnr;
            byte len = 255;
            sbyte size = 0;


            if (!bConnectedDevice)
            {
                MessageBox.Show("Not connect to device!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pSnr = Marshal.AllocHGlobal(1024);

            for (int i = 0; i < 2; i++)
            {
                status = rf_antenna_sta(icdev, 0);//ปิดเสาอากาศ
                if (status != 0)
                    continue;

                Sleep(20);
                status = rf_init_type(icdev, type);
                if (status != 0)
                    continue;

                Sleep(20);
                status = rf_antenna_sta(icdev, 1);//เสาอากาศ start-up
                if (status != 0)
                    continue;

                Sleep(50);
                status = rf_request(icdev, mode, ref TagType);//ค้นหาบัตรทั้งหมด
                if (status != 0)
                    continue;

                status = rf_anticoll(icdev, bcnt, pSnr, ref len);//ส่งกลับหมายเลขของบัตร
                if (status != 0)
                    continue;

                status = rf_select(icdev, pSnr, len, ref size);//ในการล็อค ISO14443-3 บัตร TYPE_A
                if (status != 0)
                    continue;

                byte[] szBytes = new byte[len + 1];
                string str = Marshal.PtrToStringAnsi(pSnr);

                for (int j = 0; j < len; j++)
                {
                    szBytes[j] = (byte)str[j];
                }
               this.cardID= ToHexString(szBytes);
                break;
            }

            Marshal.FreeHGlobal(pSnr);
        }

        public string searchCard()
        {
            short icdev = 0x0000;
            int status;
            IntPtr pSnr;
            //byte type = (byte)'A';//mifare one 
            byte mode = 0x52;
            ushort TagType = 0;
            //byte bcnt = 0x04;//mifare 
            //byte len = 255;
            //sbyte size = 0;

            pSnr = Marshal.AllocHGlobal(1024);
             
          //  for(int i=0 ;i<1;i==) {
           //     status = rf_antenna_sta(icdev, 0);//ปิดเสาอากาศ
            //    if (status != 0)
           //         continue;

          //      Sleep(20);
          //      status = rf_init_type(icdev, type);
          //      if (status != 0)
          //          continue;

          //      Sleep(20);
         //       status = rf_antenna_sta(icdev, 1);//เสาอากาศ start-up
         //       if (status != 0)
         //           continue;

               // Sleep(50);
                status = rf_request(icdev, mode, ref TagType);//ค้นหาบัตรทั้งหมด ถ้าพบบัตรจะคืนค่าเท่ากับ 0
                if (status != 0){
                    return "nor found";
                }else {
                    return "found";
                }
            //        continue;
                

             //   status = rf_anticoll(icdev, bcnt, pSnr, ref len);//ส่งกลับหมายเลขของบัตร
             //   if (status != 0)
             //       continue;

             //   status = rf_select(icdev, pSnr, len, ref size);//ในการล็อค ISO14443-3 บัตร TYPE_A
             //   if (status != 0)
             //       continue;
            //}
                Marshal.FreeHGlobal(pSnr);
        }
        private string readSector(int sector, int block)
        {

            short icdev = 0x0000;
            int status;
            byte mode = 0x60; // is use keyA that use keyB mode = 0x61
            byte secnr = 0x00;
            string fail = "fail";

            if (!this.bConnectedDevice)
            {
                MessageBox.Show("Not connect to device!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return fail;   
            }
            
            secnr = Convert.ToByte(sector);

            IntPtr keyBuffer = Marshal.AllocHGlobal(256);

            byte[] bytesKey = ToDigitsBytes(this.keyA);
            for (int i = 0; i < bytesKey.Length; i++)
                Marshal.WriteByte(keyBuffer, i * Marshal.SizeOf(typeof(Byte)), bytesKey[i]);
            status = rf_M1_authentication2(icdev, mode, (byte)(secnr * 4), keyBuffer);
            Marshal.FreeHGlobal(keyBuffer);
            if (status != 0)
            {
                MessageBox.Show("rf_M1_authentication2 failed!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return fail;
            }

            //
            IntPtr dataBuffer = Marshal.AllocHGlobal(256);
           
                int j;
                byte cLen = 0;
                status = rf_M1_read(icdev, (byte)((secnr * 4) + block), dataBuffer, ref cLen);

                if (status != 0 || cLen != 16)
                {
                    MessageBox.Show("rf_M1_read failed!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Marshal.FreeHGlobal(dataBuffer);
                    return fail;
                }

                byte[] bytesData = new byte[16];
                for (j = 0; j < bytesData.Length; j++)
                    bytesData[j] = Marshal.ReadByte(dataBuffer, j);
             
               string result = System.Text.Encoding.GetEncoding("TIS-620").GetString(bytesData);
               //txtBoxDataOne2.Text = result;
               //txtBoxDataOne2.Text = ToHexString(bytesData);
                
            
            Marshal.FreeHGlobal(dataBuffer);

            return result;
        }
        public string getCradID()
        {
            return this.cardID;
        }
        public string getStudentID(){
            return readSector(0, 1);
        }
        public string getIDCard(){
            return readSector(0, 2);
        }
        public string getStudentNameTH() {
            return readSector(1, 0);
        }
        public string getStudentLNameTH(){
            return readSector(2, 0);
        }
        public string getStudentNameEN(){
            return readSector(3, 0);
        }
        public string getStudentLNameEN(){
            return readSector(4, 0);
        }
    }
}
