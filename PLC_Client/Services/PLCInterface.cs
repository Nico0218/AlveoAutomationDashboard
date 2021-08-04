using Sharp7;
using System;

namespace PLC_Client.Services {
    //http://snap7.sourceforge.net/sharp7.html
    public class PLCInterface {
        private S7Client client;
        public PLCInterface() {
            client = new S7Client();
        }

        public void Connect(string IP, int Rack = 0, int Slot = 1) {
            try {
                client.ConnectTo(IP, Rack, Slot);
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

        public string ReadArea(int startOffeset, int amount, S7WordLength s7WordLength = S7WordLength.Word, S7Area s7Area = S7Area.MK, int dbNumber = 0) {
            try {
                int area = (int)s7Area;
                int wordLength = (int)s7WordLength;
                byte[] buffer = new byte[getBufferSize(wordLength, amount)];
                client.ReadArea(area, dbNumber, startOffeset, amount, wordLength, buffer);
                switch (s7WordLength) {
                    case S7WordLength.Bit:
                        return S7.GetBitAt(buffer, 0, 1).ToString();
                    case S7WordLength.Byte:
                        return S7.GetByteAt(buffer, 0).ToString();
                    case S7WordLength.Char:
                        return S7.GetCharsAt(buffer, 0, 1).ToString();
                    case S7WordLength.Word:
                        return S7.GetWordAt(buffer, 0).ToString();
                    case S7WordLength.Int:
                        return S7.GetIntAt(buffer, 0).ToString();
                    case S7WordLength.DWord:
                        return S7.GetDWordAt(buffer, 0).ToString();
                    case S7WordLength.DInt:
                        return S7.GetDIntAt(buffer, 0).ToString();
                    case S7WordLength.Real:
                        return S7.GetRealAt(buffer, 0).ToString();
                    case S7WordLength.Timer:
                        return S7.GetS7TimerAt(buffer, 0).ToString();
                    case S7WordLength.Counter:
                    default:
                        throw new NotImplementedException("Not supported data type.");
                }
            } catch (Exception ex) {
                throw ex;
            }
        }

        private int getBufferSize(int wordSize, int amount) {
            return wordSize * amount;
        }
    }
}
