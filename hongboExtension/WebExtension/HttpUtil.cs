using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
//using System.Threading.Tasks;
using System.Text.RegularExpressions;
using hongbao.IOExtension;
using hongbao.CollectionExtension;
using hongbao.SystemExtension;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace hongbao.WebExtension
{
    /// <summary>
    /// 通过HTTP进行操作的工具类；
    /// </summary>
    public static class HttpUtil
    {
        #region PostRawData, 通过流写入方式提交数据, content-type 为 application/x-www-form-urlencoded
        ///// <summary>
        ///// 通过 POST 提交某些内容到服务器，并读取响应结果； 默认下将使用 utf8 编解码；
        ///// 注意，将通过流写入方式提交数据, content-type 为 application/x-www-form-urlencoded;
        ///// </summary>
        ///// <param name="url">提交的url</param>
        ///// <param name="postContent">需要提交的内容</param>
        ///// <param name="filePath"></param>
        ///// <returns></returns>
        //public static void PostRawDataAndSaveToFile(string url, string postContent, string filePath)
        //{
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //    request.ContentType = "application/x-www-form-urlencoded";
        //    request.Method = "POST";
            
        //    Stream responseStream = request.GetRequestStream();
        //    StreamUtil.WriteStreamToFile(filePath, responseStream);
        //    responseStream.Close();
            
        //}

        /// <summary>
        /// 通过 POST 提交某些内容到服务器，并读取响应结果； 默认下将使用 utf8 编解码；
        /// 注意，将通过流写入方式提交数据, content-type 为 application/x-www-form-urlencoded;
        /// </summary>
        /// <param name="url">提交的url</param>
        /// <param name="postContent">需要提交的内容</param>
        /// <returns></returns>
        public static T PostRawDataAndGetResult<T>(string url, string postContent)
        {
            var result = PostRawDataAndGetResult(url, postContent, Encoding.UTF8);
            if (string.IsNullOrEmpty(result)) return default(T);
            return JsonConvert.DeserializeObject<T>(result);
        }

        /// <summary>
        /// 通过 POST 提交某些内容到服务器，并读取响应结果； 默认下将使用 utf8 编解码；
        /// 注意，content-type 为 application/x-www-form-urlencoded;
        /// 即将 请求参数编码为 client_id=testclient&client_secret=testclientsecret 的形式并 Post
        /// </summary>
        /// <param name="url">提交的url</param>
        /// <param name="postContent">需要提交的内容</param>
        /// <returns></returns>
        public static async Task<T> FormUrlEncodedPostGetResult<T>(string url, IEnumerable<KeyValuePair<string,string>> postContent)
        {
            System.Net.Http.FormUrlEncodedContent content = new System.Net.Http.FormUrlEncodedContent(postContent);
            content.Headers.Add("conent-type", "application/x-www-form-urlencoded");
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            var asyncResult = await client.PostAsync(url, content);
            var result = await asyncResult.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(result)) return default(T);
            return JsonConvert.DeserializeObject<T>(result);
        }


        ///// <summary>
        ///// </summary>
        ///// <param name="url">提交的url</param>
        ///// <param name="postContent">需要提交的内容</param>
        ///// <param name="encoder">编码，默认为 Utf8 </param>
        ///// <returns></returns>
        //public static string PostRawDataAndGetResult(string url, string postContent, System.Text.Encoding encoder = null)
        //{
        //    return PostRawDataAndGetResult(url, postContent, encoder?? Encoding.UTF8);
        //}

        /// <summary>
        /// 通过 POST 提交某些内容到服务器，并读取响应结果； 默认下将使用 utf8 编解码；
        /// 注意，将通过流写入方式提交数据, content-type 为 application/x-www-form-urlencoded;
        /// </summary>
        /// <param name="url">提交的url</param>
        /// <param name="postObject">需要提交的对象</param>
        /// <param name="encoder">对象序列化后字符串转换成字节流时的编码形式；默认为 utf8; </param>
        /// <returns></returns>
        public static string PostRawDataAndGetResult<T>(string url, T postObject, System.Text.Encoding encoder = null)
        {
            var postContent = JsonConvert.SerializeObject(postObject);
            return PostRawDataAndGetResult(url, postContent, Encoding.UTF8);
        }

        /// <summary>
        /// 通过 POST 提交某些内容到服务器，并读取响应结果； 默认下将使用 utf8 编解码；
        /// 注意，将通过流写入方式提交数据, content-type 为 application/x-www-form-urlencoded;
        /// </summary>
        /// <param name="url">提交的url</param>
        /// <param name="postObject">需要提交的对象</param>
        /// <param name="encoder">对象序列化后字符串转换成字节流时的编码形式；默认为 utf8; </param>
        /// <returns></returns>
        public static TResult PostRawDataAndGetResult<TPostObject, TResult>(string url, TPostObject postObject, System.Text.Encoding encoder = null)
        {
            var postContent = JsonConvert.SerializeObject(postObject);
            var result = PostRawDataAndGetResult(url, postContent, encoder);
            if (string.IsNullOrEmpty(result)) return default(TResult);
            return JsonConvert.DeserializeObject<TResult>(result);

        }

        /// <summary>
        /// 通过 POST 提交某些内容到服务器，并读取响应结果； 
        /// 注意，将通过流写入方式提交数据, content-type 为 application/json
        /// </summary>
        /// <param name="url">提交的url</param>
        /// <param name="postContent">需要提交的内容</param>
        /// <param name="encoder">字符串转换成字节流时的编码形式；默认为 utf8; </param>
        /// <returns></returns>
        public static string PostRawDataAndGetResult(string url, string postContent, System.Text.Encoding encoder = null)
        {
            encoder = encoder ?? Encoding.UTF8;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            // request.ContentType = "application/x-www-form-urlencoded";
            request.ContentType = "application/json";
            request.Method = "POST";
            
            Stream myRequestStream = request.GetRequestStream();
            byte[] bytes = encoder.GetBytes(postContent);
            myRequestStream.Write(bytes, 0, bytes.Length);
            myRequestStream.Close();
           
            return ReadResponse(request, encoder);
        }
        #endregion

        /// <summary>
        /// 读取相应，变化为字符串形式；
        /// </summary>
        /// <param name="request"></param>
        /// <param name="encoder"></param>
        /// <returns></returns>
        private static string ReadResponse(HttpWebRequest request, Encoding encoder)
        {
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (Stream myResponseStream = response.GetResponseStream())
            {
                using (StreamReader myStreamReader = new StreamReader(myResponseStream, encoder))
                {
                    return myStreamReader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// 用　POST 方式提交请求，注意，存在附件需要一起提交；
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="queryString">请求的参数, 将附加到 URL上 </param>
        /// <param name="attachFile">文件附件，注意，不是 Post的参数</param>
        /// <returns></returns>
        public static string PostAndGetResult(string uri, string queryString, Dictionary<string, string> attachFile)
        {
            return PostAndGetResult(uri, queryString, attachFile, Encoding.UTF8);
        }

        /// <summary>
        /// 用　POST 方式提交请求，注意，存在附件需要一起提交；
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="queryString">请求的参数,将附加到 URL上 </param>
        /// <param name="attachFile"></param>
        /// <param name="encoding">文件附件，注意，不是 Post的参数</param>
        /// <returns></returns>
        public static string PostAndGetResult(string uri, string queryString, Dictionary<string, string> attachFile, Encoding encoding)
        {
            uri = uri + (queryString.Length == 0 ? "" : ((uri.IndexOf("?") > 0 ? "&" : "?") + queryString));
            return PostAndGetResult(uri, (Dictionary<string, string>) null, attachFile, Encoding.UTF8, "text/xml");
        }

        // <summary>
        // 用　POST 方式提交请求，注意，存在附件需要一起提交；
        // </summary>
        // <param name="ybUrl"></param>
        // <param name="postContent"></param>
        // <param name="attachFile"></param>
        // <returns></returns>
        /*public static string PostAndGetResult(string url, Dictionary<string, string> postContent, Dictionary<string, string> attachFile, System.Text.Encoding encoder)
        {
            StringBuilder sb = new StringBuilder(); // content = "";
            foreach(var xx in postContent)
            {
                sb.Append(xx.Key + "=" + HttpUtility.UrlEncode(xx.Value, encoder) + "&");
            }
            return PostAndGetResult(url, sb.ToString(), attachFile, encoder);
        }*/



        #region 6.0 上传多个文件和参数
        /// <summary>
        /// HttpUploadFile,http://www.cnblogs.com/zoro-zero/p/4268000.html
        /// </summary>
        /// <param name="url">Url</param>
        /// <param name="files">Post的文件附件</param>
        /// <param name="data">Post的参数</param>
        /// <param name="encoding">Post的内容编码</param>
        /// <param name="contentType">貌似没有作用</param>
        /// <returns></returns>
        public static string PostAndGetResult(string url, Dictionary<string, string> data, Dictionary<string,string> files,  
            Encoding encoding, string contentType=null)
        {
            //必须
            string boundary = DateTime.Now.Ticks.ToString("X");
            //必须的

            //form 开始标志
            byte[] boundarybytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

            //form 结尾标志
            byte[] endbytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");

            //1.HttpWebRequest
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.ContentType = "multipart/form-data;charset=utf-8;boundary=" + boundary;
            request.Method = "POST";
            // if (!string.IsNullOrEmpty(contentType)) request.ContentType = "text/xml";
            request.KeepAlive = true;
            // request.Credentials = CredentialCache.DefaultCredentials;

            using (Stream stream = request.GetRequestStream())
            {
                //传递参数模板 Content-Disposition:form-data;name=\"{0}\"\r\n\r\n{1}
                //1.1 key/value
                string formdataTemplate = "Content-Disposition:form-data;name=\"{0}\"\r\n\r\n{1}";
                //传递参数
                if (data != null)
                {
                    foreach (string key in data.Keys)
                    {
                        //传递参数开始标识
                        stream.Write(boundarybytes, 0, boundarybytes.Length);
                        string formitem = string.Format(formdataTemplate, key, data[key]);
                        byte[] formitembytes = encoding.GetBytes(formitem);
                        stream.Write(formitembytes, 0, formitembytes.Length);
                    }
                }

                //上传文件模板
                //1.2 file
                string headerTemplate = "Content-Disposition:form-data;name=\"{0}\";filename=\"{1}\"\r\nContent-Type:application/octet-stream\r\n\r\n";

                if (files != null)
                {
                    byte[] buffer = new byte[6 * 1024 * 1024];
                    foreach (var pair in files)
                    {
                        //上传文件标识
                        stream.Write(boundarybytes, 0, boundarybytes.Length);

                        string header = string.Format(headerTemplate, pair.Key, Path.GetFileName(pair.Key));
                        byte[] headerbytes = encoding.GetBytes(header);

                        stream.Write(headerbytes, 0, headerbytes.Length);

                        //将文件流读入到请求流中
                        using (FileStream fileStream = new FileStream(pair.Value, FileMode.Open, FileAccess.Read))
                        {
                            int r = fileStream.Read(buffer, 0, buffer.Length);
                            stream.Write(buffer, 0, r);
                        }
                    }
                }

                //form 结束标志
                //1.3 form end
                stream.Write(endbytes, 0, endbytes.Length);
            }
            
            //2.WebResponse
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {

                string result = stream.ReadToEnd();
                return result;
            }
        }

        #endregion

        // <summary>
        // 以Post 形式提交数据到 uri, 但是  C# WEB服务器接收不到； 
        // </summary>
        // <param name="uri"></param>
        // <param name="postContent"> postContent - 必须已经进行了 URLEncode 编码；  </param>
        // <param name="attachFile">附件文件</param>
        // <param name="encoder">编码； </param>
        // <returns></returns>
       /* public static string PostAndGetResult(string uri, string postContent, Dictionary<string, string> attachFile, System.Text.Encoding encoder)
        {
            uri = uri +  (postContent.Length==0?"":((uri.IndexOf("?")>0?"&":  "?") + postContent));            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            string boundary = DateTime.Now.Ticks.ToString("x");
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            request.Method = "POST";
            request.KeepAlive = true;

            byte[] content = null;
            using (MemoryStream stream = new MemoryStream())
            {
                string fformat = "---{2}\r\nContent-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: application/octet-stream\r\nContent-Transfer-Encoding: binary\r\n\r\n";
                foreach (var filePair in attachFile)
                {
                    ///写multipart的头部； 
                    string s = string.Format(fformat, filePair.Key, filePair.Key, boundary);
                    byte[] fileBoundaryHead = Encoding.UTF8.GetBytes(s);
                    stream.Write(fileBoundaryHead, 0, fileBoundaryHead.Length);

                    byte[] fileContent = FileUtil.readFileBinaryContent(filePair.Value);
                    ///写文件内容；
                    stream.Write(fileContent, 0, fileContent.Length);
                    //再写两个个回车换行；
                    stream.Write(Encoding.ASCII.GetBytes("\r\n"), 0, 2);
                    stream.Write(Encoding.ASCII.GetBytes("\r\n"), 0, 2);
                }
                //结尾的 boundary ; 
                byte[] tailBoundary = Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
                stream.Write(tailBoundary, 0, tailBoundary.Length);
                content = stream.ToArray();
            }
            request.ContentLength = content.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(content, 0, content.Length);
            requestStream.Close();

            return ReadResponse(request, encoder); 
        }
       */
        /// <summary>
        /// 读取内容并保存到文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path"></param>
        public static void ReadBinaryWebAndSaveToFile(string url, string path)
        {
            if (File.Exists(path)) File.Delete(path);
            ReadWebStreamAndAction(url, (stream)=>{StreamUtil.WriteStreamToFile(path, stream);});
        }

        /// <summary>
        /// 读取内容并保存到文件
        /// </summary>
        /// <param name="url"></param>
        public static byte[] ReadBinary(string url)
        {
            MemoryStream ms = new MemoryStream();
            ReadWebStreamAndAction(url, (stream) => { StreamUtil.WriteStream(ms, stream); });
            return ms.ToArray();
        }

        /// <summary>
        /// 读取 URL的流内容并对流进行操作；
        /// </summary>
        /// <param name="url"></param>
        /// <param name="actionStream"></param>
        public static void ReadWebStreamAndAction(string url, Action<Stream> actionStream)
        {
            var request = HttpWebRequest.Create(url);
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    actionStream(stream);
                }
            }
        }

        /// <summary>
        /// 获得网页的所有内容,将根据Response中的content-type读取网页内容编码，默认为 GBK;
        /// 但如果HTTP响应的头中标记了utf-8或者utf8，则转换为 UTF8 编码；
        /// </summary>
        /// <param name="url">网页的url</param>
        /// <param name="referer"></param>
        /// <returns>网页的所有内容</returns>
        public static string ReadWeb(string url, string referer = null)
        {
                string result = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest) HttpWebRequest.Create(url);
               // request.Connection = "close";  // 抛出异常;
                if (referer != null)
                {
                    request.Referer = referer;
                    //request.Headers.Set(HttpRequestHeader.Referer, referer);
                }
                using (var response = request.GetResponse())
                {
                    var contentType = response.ContentType.ToLower();
                    var enc = Encoding.GetEncoding("GBK");
                    if (contentType.IndexOf("utf-8") >= 0 || contentType.IndexOf("utf8") >= 0)
                    {
                        enc = Encoding.UTF8;
                    }
                    using (var stream = response.GetResponseStream())
                    {
                        using (StreamReader sr = new StreamReader(stream, enc))
                        {
                            result = sr.ReadToEnd();
                        }
                    }
                }
                // request.Abort();
            }
            catch (Exception exp)
            {
                System.Console.WriteLine(exp.StackTrace);
            }
            return result;
        }

        /// <summary>
        /// 获得网页的所有内容,将根据Response中的content-type读取网页内容编码，默认为 GBK;
        /// 但如果HTTP响应的头中标记了utf-8或者utf8，则转换为 UTF8 编码；
        /// </summary>
        /// <param name="url">网页的url</param>
        /// <param name="enc">网页的所有编码</param>
        /// <returns>网页的所有内容</returns>
        public static string ReadWeb(string url, Encoding enc)
        {
            string result = "";
            try
            {
                var request = HttpWebRequest.Create(url);
                using (var response = request.GetResponse())
                {
                    MemoryStream ms = new MemoryStream();
                    using (var stream = response.GetResponseStream())
                    {
                        StreamUtil.WriteStream(ms, stream);                        
                    }
                    byte[] bytes = ms.ToArray();
                    return enc.GetString(bytes);
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
            }
            return result;
        }

        /// <summary>
        /// 获得网页的所有内容,并返回第第一个匹配正则表达式的匹配对象；
        /// </summary>
        /// <param name="url">网页的url</param>
        /// <param name="regexMatch"></param>
        /// <returns>网页的所有内容</returns>
        public static Match ReadWebAndFindFirstMatch(string url, string regexMatch)
        {
            string urlContent = ReadWeb(url);
            if (urlContent == null) return null;

            var regex = new Regex(regexMatch);
            var match = regex.Match(urlContent);
            if (match == null) return null;
            return match;
        }

        /// <summary>
        /// 获得网页的所有内容,并返回所有匹配正则表达式的匹配对象；
        /// </summary>
        /// <param name="url">网页的url</param>
        /// <param name="regexMatch"></param>
        /// <returns>网页的所有内容</returns>
        public static MatchCollection ReadWebAndFindAllMatch(string url, string regexMatch)
        {
            string urlContent = ReadWeb(url);
            if (urlContent == null) return null;

            var regex = new Regex(regexMatch);
            return  regex.Matches(urlContent);
        }

        /// <summary>
        /// 读取网页内容，并对读取的内容进行给定的操作；
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        public static void ReadWebAndAction(string url, Action<string> content)
        {
            var result = ReadWeb(url);
            content(result);
        }

        /// <summary>
        /// 读取WEB的内容，将其用正则表达式进行解析，第1个分组为有效数据，
        /// 然后，进行拆分，将拆分后的分组设置到给定对象的 属性中；
        /// </summary>
        /// <param name="url">网页的url</param>
        /// <param name="dataRegex">从url的网页内容中截取有效数据的正则表达式，注意，只管第1个分组的数据；</param>
        /// <param name="dataSplit">截取到有效数据后，对有效数据进行划分的正则表达式；</param>
        /// <param name="entityInstance">给定对象</param>
        /// <param name="fillProperties">要填充的属性数组，如果某个属性为null或者空字符串，则跳过该属性；</param>
        public static void ReadWebAndSetToObject(string url, string dataRegex, string dataSplit, object entityInstance,
            string[] fillProperties)
        {
            Func<string,int,bool> func =(aPropValue, index)=>{
                    if (fillProperties.Length > index )
                    {
                        if (!string.IsNullOrEmpty(fillProperties[index])) 
                        {
                            try
                            {
                                aPropValue = aPropValue.Replace("%", "");
                                entityInstance.SetProperty(fillProperties[index], aPropValue);
                            }
                            catch (Exception exx)
                            {
                                Console.WriteLine(exx.StackTrace);
                                throw exx;
                            }
                        }
                        return true;
                    }
                return false;
            };
            Action<string[]> groupsAction = (groups) =>
            {
                groups.ForEach(func);
            };
            ReadWebAndSplitAndAction(url, dataRegex, dataSplit, groupsAction);
        }

        /// <summary>
        /// 读取web内容，利用正则表达式获得有效内容，然后进行拆分，对于拆分的数组，
        /// 注意，对于正则表达式，总是取最后一个分组的内容；
        /// 用给定的函数进行处理；
        /// </summary>
        /// <param name="url"></param>
        /// <param name="dataRegex"></param>
        /// <param name="dataSplit"></param>
        /// <param name="actionGroups"></param>
        public static void ReadWebAndSplitAndAction(string url, string dataRegex, string dataSplit, Action<string[]> actionGroups)
        {
            Action<string> action = (content) =>
            {
                var regex = new Regex(dataRegex);
                var match = regex.Match(content);
                if (match == null) return;
                var matchData = match.Groups[match.Groups.Count - 1].Value;
                var datas = new string[] { matchData };
                if (dataSplit != null)
                {
                    var splitRegex = new Regex(dataSplit);
                    datas = splitRegex.Split(matchData);
                }
                actionGroups(datas);
            };
            ReadWebAndAction(url, action);
        }

        /// <summary>
        /// 读取web内容，利用正则表达式获得有效内容，然后进行拆分，对于拆分的数组，
        /// 注意，对于正则表达式，总是取最后一个分组的内容；
        /// 用给定的函数进行处理；
        /// </summary>
        /// <param name="url"></param>
        /// <param name="dataRegex"></param>
        /// <param name="actionGroups"></param>
        public static void ReadWebAndGrepAndAction(string url, string dataRegex, Action<string> actionGroups)
        {
            Action<string> action = (content) =>
            {
                var regex = new Regex(dataRegex);
                var match = regex.Match(content);
                if (match == null) return;
                var matchData = match.Groups[match.Groups.Count - 1].Value;
                actionGroups(matchData);
            };
            ReadWebAndAction(url, action);
        }
    }
}
