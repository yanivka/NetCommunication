using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NetComm.ByteArray
{
    public class CircularStreamReader: Stream
    {
        private readonly byte[] _data;
        private long _index;
        public CircularStreamReader(byte[] data, int startIndex = 0)
        {
            this._data = data;
            this._index = startIndex;
        }

        public override bool CanRead => true;

        public override bool CanSeek => false;

        public override bool CanWrite => false;

        public override long Length => this._data.LongLength;

        public override long Position { get => this._index; set => this._index = (int)(value % this._data.Length); }

        public override void Flush(){}

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin) { throw new NotImplementedException(); }
        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }
    }
}
