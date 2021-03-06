using Sharp7;
using System;

namespace PLC_Client.Services {
    //http://snap7.sourceforge.net/sharp7.html
    public class PLCInterface {
        private S7Client client;
        public PLCInterface() {
            client = new S7Client();
        }

        public void Connect() {
            try {
                client.ConnectTo("192.168.1.5", 0, 1);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void Disconnect() {
            try {
                client.Disconnect();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool isConnected() {
            if (client.Connect() == 0)
                return true;
            return false;
        }

        public void WriteWord(int startOffeset, ushort wordValue, int amount = 1, S7WordLength s7WordLength = S7WordLength.Word, S7Area s7Area = S7Area.MK, int dbNumber = 0) {
            try {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                S7.SetWordAt(buffer, 0, wordValue);
                client.WriteArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public string ReadWord(int startOffeset, int amount = 1, S7WordLength s7WordLength = S7WordLength.Word, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                client.ReadArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
                return S7.GetWordAt(buffer, 0).ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void WriteBit(int startOffeset, int bit, int amount = 1, S7WordLength s7WordLength = S7WordLength.Bit, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                client.ReadArea(area, dbNumber, (startOffeset * 8) , amount, wordLength, buffer);
                bool result = S7.GetBitAt(buffer, 0, bit);
                if (result == true)
                {
                    S7.SetBitAt(buffer, 0, bit, false);
                    client.WriteArea(area, dbNumber, (startOffeset * 8), amount, wordLength, buffer);
                }
                else
                {
                    S7.SetBitAt(buffer, 0, bit, true);
                    client.WriteArea(area, dbNumber, (startOffeset * 8), amount, wordLength, buffer);
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ReadBit(int startOffeset, int bit, int amount = 80, S7WordLength s7WordLength = S7WordLength.Bit, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                client.ReadArea(area, dbNumber, (startOffeset * 8), amount, wordLength, buffer);
                return S7.GetBitAt(buffer, 0, bit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void WriteByte(int startOffeset, byte byteValue, int amount = 1, S7WordLength s7WordLength = S7WordLength.Byte, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                S7.SetByteAt(buffer, 0, byteValue);
                client.WriteArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public byte ReadByte(int startOffeset, int amount = 1, S7WordLength s7WordLength = S7WordLength.Byte, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                client.ReadArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
                return S7.GetByteAt(buffer, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void WriteChars(int startOffeset, string charsValue, int amount = 1, S7WordLength s7WordLength = S7WordLength.Char, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                S7.SetCharsAt(buffer, 0, charsValue);
                client.WriteArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ReadChars(int startOffeset, int size, int amount = 1, S7WordLength s7WordLength = S7WordLength.Byte, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                client.ReadArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
                return S7.GetCharsAt(buffer, 0, size);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void WriteInt(int startOffeset, short intValue, int amount = 1, S7WordLength s7WordLength = S7WordLength.Int, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                S7.SetIntAt(buffer, 0, intValue);
                client.WriteArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ReadInt(int startOffeset, int amount = 1, S7WordLength s7WordLength = S7WordLength.Int, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                client.ReadArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
                return S7.GetIntAt(buffer, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void WriteDWord(int startOffeset, uint dWordValue, int amount = 1, S7WordLength s7WordLength = S7WordLength.DWord, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                S7.SetDWordAt(buffer, 0, dWordValue);
                client.WriteArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public uint ReadDWord(int startOffeset, int amount = 1, S7WordLength s7WordLength = S7WordLength.DWord, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                client.ReadArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
                return S7.GetDWordAt(buffer, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void WriteDInt(int startOffeset, int dIntValue, int amount = 1, S7WordLength s7WordLength = S7WordLength.DInt, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                S7.SetDIntAt(buffer, 0, dIntValue);
                client.WriteArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ReadDInt(int startOffeset, int amount = 1, S7WordLength s7WordLength = S7WordLength.DInt, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                client.ReadArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
                return S7.GetDIntAt(buffer, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void WriteReal(int startOffeset, float realValue, int amount = 1, S7WordLength s7WordLength = S7WordLength.Real, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                S7.SetRealAt(buffer, 0, realValue);
                client.WriteArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public float ReadReal(int startOffeset, int amount = 1, S7WordLength s7WordLength = S7WordLength.Real, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                client.ReadArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
                return S7.GetRealAt(buffer, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Need to use GetAgBlockInfo to always have size of DB being read
        public byte[] ReadDB(int dbSize, int dbNumber)
        {
            try
            {
                byte[] buffer = new byte[dbSize];
                client.DBRead(dbNumber, 0, dbSize, buffer);
                return buffer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void intDbWrite(int dbNumber, int position, short value, int amount = 1, S7WordLength s7WordLength = S7WordLength.Word)
        {
            try
            {
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                S7.SetIntAt(buffer, 0, value);
                client.DBWrite(dbNumber, position, wordLength, buffer);
            }
            catch (Exception ex)
            {
            throw ex;
            }

        }

        public void timeDbWrite(int dbNumber, int position, int value, int amount = 1, S7WordLength s7WordLength = S7WordLength.Word)
        {
            try
            {
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                S7.SetDIntAt(buffer, 0, value);
                client.DBWrite(dbNumber, position, wordLength, buffer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void realDbWrite(int dbNumber, int position, float value, int amount = 1, S7WordLength s7WordLength = S7WordLength.Word)
        {
            try
            {
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                S7.SetRealAt(buffer, 0, value);
                client.DBWrite(dbNumber, position, wordLength, buffer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void wordDbWrite(int dbNumber, int position, ushort value, int amount = 1, S7WordLength s7WordLength = S7WordLength.Word)
        {
            try
            {
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                S7.SetWordAt(buffer, 0, value);
                client.DBWrite(dbNumber, position, wordLength, buffer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void dIntDbWrite(int dbNumber, int position, ushort value, int amount = 1, S7WordLength s7WordLength = S7WordLength.Word)
        {
            try
            {
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                S7.SetDIntAt(buffer, 0, value);
                client.DBWrite(dbNumber, position, wordLength, buffer);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void bitChangeDB(int dbNumber, int position, int bit, int amount = 1, S7WordLength s7WordLength = S7WordLength.Bit)
        {
            try
            {
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                byte[] result = ReadDB((position + 1), dbNumber);
                bool currentState = S7.GetBitAt(result, position, bit);
                if (currentState == true)
                {
                    S7.SetBitAt(result, position, bit, false);
                }
                else
                {
                    S7.SetBitAt(result, position, bit, true);
                }
                client.DBWrite(dbNumber, position, wordLength, result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public S7Timer ReadTimer(int startOffeset, int amount = 1, S7WordLength s7WordLength = S7WordLength.Timer, S7Area s7Area = S7Area.MK, int dbNumber = 0)
        {
            try
            {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                client.ReadArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
                return S7.GetS7TimerAt(buffer, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int getBufferSize(int wordSize, int amount) {
            return wordSize * amount;
        }
    }
}
