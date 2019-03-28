using System.Collections.Generic;
using System.IO;

namespace com.youzan.open.sdk.model
{
    ////using ContentType = org.apache.http.entity.ContentType;

    ////using ByteArrayBody = org.apache.http.entity.mime.content.ByteArrayBody;

    ////using ContentBody = org.apache.http.entity.mime.content.ContentBody;

    ////using FileBody = org.apache.http.entity.mime.content.FileBody;

    ////using InputStreamBody = org.apache.http.entity.mime.content.InputStreamBody;



    /// <summary>
    /// @author ph0ly
    /// @time 2016-11-29
    /// </summary>
    public class ByteWrapper
	{
		private string name;
		private KeyValuePair<string, string> contentBody;

        private ByteWrapper()
        {
            this.contentBody = new KeyValuePair<string, string>();
        }


		public ByteWrapper(string filePath): this(new FileInfo(filePath).Name, filePath)
		{
            //this.contentBody = new KeyValuePair<string, string>(filename, filePath);
		}

        public ByteWrapper(string name, string filePath) : this()
        {
            this.contentBody = new KeyValuePair<string, string>(name, filePath);
        }

        /*public ByteWrapper(string filePath, ContentType contentType)
		{
			contentBody = new FileBody(new File(filePath), contentType);
		}*/

        ////public ByteWrapper(File file)
        ////{	

        ////}

        //public ByteWrapper(File file, ContentType contentType)
        //{
        //	contentBody = new FileBody(file, contentType);
        //}

        //public ByteWrapper(string name, sbyte[] data)
        //{
        //	contentBody = new ByteArrayBody(data, name);
        //}

        //public ByteWrapper(string name, sbyte[] data, ContentType contentType)
        //{
        //	contentBody = new ByteArrayBody(data, contentType, name);
        //}

        //public ByteWrapper(string name, System.IO.Stream stream)
        //{
        //	contentBody = new InputStreamBody(stream, name);
        //}

        //public ByteWrapper(string name, System.IO.Stream stream, ContentType contentType)
        //{
        //	contentBody = new InputStreamBody(stream, contentType, name);
        //}

        public virtual string Name
		{
			get
			{
				return name;
			}
			set
			{
				this.name = value;
			}
		}


		public virtual KeyValuePair<string, string> Data
		{
			get
			{
				return this.contentBody;
			}
		}

	}

}