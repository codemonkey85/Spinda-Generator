using System;

namespace Spinda
{
    public class BaseSpinda
    {
        protected const int PidOffset = 0x00;
        protected byte[] Data;
        protected const int ChecksumOffset = 0x00;
        protected const int DataSize = 0;

        protected virtual void SetChecksum()
        {
        }

        public virtual void SetPid(uint pid)
        {
        }

        public ushort CalculateChecksum()
        {
            ushort chk = 0;
            for (var i = 8; i < DataSize; i += 2)
            {
                chk += BitConverter.ToUInt16(Data, i);
            }
            return chk;
        }

        public byte[] GetData() => Data;

        public string GetPidHex() => (Data != null && Data.Length >= DataSize)
                ? Data[PidOffset].ToString("x8")
                : string.Empty;
    }
}
