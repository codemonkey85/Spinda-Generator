using System;

namespace Spinda
{
    public class SpindaPk5 : BaseSpinda
    {
        protected new const int PidOffset = 0x00;
        protected new const int ChecksumOffset = 0x06;
        protected new const int DataSize = 136;

        public SpindaPk5()
        {
            Data = new byte[DataSize];
        }

        public SpindaPk5(byte[] data)
        {
            if (data.Length != DataSize)
                throw new Exception("Incorrect data format!");
            Data = new byte[DataSize];
            Array.Copy(data, 0, Data, 0, data.Length);
        }

        protected override void SetChecksum()
        {
            var checksumBytes = BitConverter.GetBytes(CalculateChecksum());
            Array.Copy(checksumBytes, 0, Data, ChecksumOffset, 2);
        }

        public override void SetPid(uint pid)
        {
            var pidBytes = BitConverter.GetBytes(pid);
            Array.Copy(pidBytes, 0, Data, PidOffset, 4);
            SetChecksum();
        }
    }
}