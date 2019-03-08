using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace hongbao.IOExtension
{
    /// <summary>
    /// 流片断写出类，用于写部分流的数据到目的流中；
    /// </summary>
    public class StreamPieceWriter : IStreamWriter
    {
        private int start;
        private int length;
        private Stream stream;

        /// <summary>
        /// 流片断写出类　的构造函数；
        /// </summary>
        /// <param name="start">起始位置</param>
        /// <param name="length">写出数据长度</param>
        /// <param name="stream">原始流</param>
        public StreamPieceWriter(int start, int length, Stream stream)
        {
            this.start = start;
            this.length = length;
            this.stream = stream;
        }



        /// <summary>
        /// 将本片段流中的内容写出到给定的文件流中
        /// </summary>
        /// <param name="destStream"></param>
        /// <returns>返回成功写出的字节数量，因为目的流可能中断，所以必须返回成功写入的数据数量</returns>
        public int write(Stream destStream)
        {
            return StreamUtil.WriteStream(destStream, stream, start, length);
        }

        /// <summary>
        /// 关闭流
        /// </summary>        
        public void close()
        {
            if (stream != null) stream.Close();
        }

    }
}
