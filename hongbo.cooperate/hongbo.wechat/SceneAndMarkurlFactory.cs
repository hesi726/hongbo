using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hongbao.SystemExtension;
using hongbao.DrawingExtension;
using StackExchange.Redis;
using Newtonsoft.Json;

namespace hongbao.Wechat
{
    /// <summary>
    /// 微信公众号的场景和场景对应关注Url工厂类;
    /// </summary>
    public class SceneAndMarkurlFactory
    {
        WechatMpApp app;
        bool needPrecache;
        long precacheCount;
        IPrecache<SceneAndMarkurl> precache;        
        Action<string> log = null;
        bool trycache;
        string scenePrefix;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="scenePrefix"></param>
        /// <param name="trycache">当无法获取缓存到的数据时，是否视图获取 场景和关注Url 到缓存;</param>
        /// <param name="precache">预缓存接口</param>
        /// <param name="log"></param>
        /// <param name="precacheCount">预缓存的数量,当数量减少到此数量的一半时，再次获取直到预缓存数量到达此数量；</param>
        public SceneAndMarkurlFactory(WechatMpApp app,  string scenePrefix, bool trycache, long precacheCount, IPrecache<SceneAndMarkurl> precache = null, Action<string> log = null)
        {
            this.scenePrefix = scenePrefix;
            this.trycache = trycache;
            this.app = app;
            this.needPrecache = precache != null;
            this.precacheCount = precacheCount;
            this.precache = precache;
            this.log = log;
        }

        List<Task> taskList = new List<Task>();
        /// <summary>
        /// 启动任务以便获取关注场景的二维码链接并放入到缓存中：
        /// </summary>
        /// <param name="getcount"></param>
        private Task StartTask(long getcount)
        {
            if (!this.trycache) return null;
            int batchCount = 100;
            var batchList = new List<SceneAndMarkurl>();
            if (taskList.Count > 0) return null;
            lock (taskList)
            {
                if (taskList.Count > 0) return null;
                var task = Task.Factory.StartNew(() =>
                {
                    for (var index = 0; index < getcount; index++)
                    {
                        var result = InternalGetMarkUrl(index, (int) getcount);
                        batchList.Add(result);
                        if (batchList.Count % batchCount == 0)
                        {
                            precache.Push(batchList);
                            batchList.Clear();
                        }
                    }
                    if (batchList.Count > 0)
                    {
                        precache.Push(batchList);
                    }
                });
                taskList.Add(task);
                task.ContinueWith((ta) =>
                {
                    taskList.Clear();
                });
                return task;
            }
         }

        /// <summary>
        /// 获取关注场景的Url,
        /// </summary>
        /// <returns></returns>
        public SceneAndMarkurl GetMarkUrl()
        {
            var result = GetMarkUrl(1);
            if (result == null) return null;
            return result[0];
        }

        /// <summary>
        /// 获取关注场景的Url,
        /// </summary>
        /// <param name="count"></param>
        /// <param name="wait">是否等待，默认不等待; 当数量不足时，直接返回null;</param>
        /// <returns></returns>
        public List<SceneAndMarkurl> GetMarkUrl(int count)
        {
            List<SceneAndMarkurl> result = null;
            if (!needPrecache)
            {
                result = new List<SceneAndMarkurl>();
                for (var index = 0; index < count; index++)
                {
                    result.Add(InternalGetMarkUrl(index, count));
                }
                return result;
            }
            else
            {
                var cacheCount = precache.CacheCount;
                if (cacheCount < precacheCount / 2)
                {
                    StartTask(precacheCount - cacheCount);
                }
                if (cacheCount < count)
                {
                    return null;
                }
                result = precache.Pop(count);
                return result;
            }
        }

        /// <summary>
        /// 通过微信接口获取关注场景和场景对应的Url;
        /// </summary>
        /// <returns></returns>
        private SceneAndMarkurl InternalGetMarkUrl(int index, int totalCount)
        {
             string guid = scenePrefix + GuidUtil.NewGuid();
            /*  return new SceneAndMarkurl { Url = "http://www.max-media.cc", Scene = guid, ExpiredDateTime = DateTime.Now.AddDays(30) }; 
              */
            DateTime expire = DateTime.Now.AddDays(30);
             var markImageUrl = app.GetQrCodeUrl(guid, 2591999);  //二维码有效日期 30天
             var markUrl = QrcodeUtil.Scan(markImageUrl);            
             log?.Invoke(string.Format("获取公众号:{4} 扫码场景:{2}/{3}, 场景:{0},Url:{1}", guid, markUrl, index, totalCount, app.Config.Name));
             return new SceneAndMarkurl { Url = markUrl, Scene = guid, ExpiredDateTime = expire };
             
        }
    }

    /// <summary>
    /// 对象预缓存接口;
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPrecache<T>
    {
        /// <summary>
        /// 已经缓存的数量
        /// </summary>
        long CacheCount { get;  }

        /// <summary>
        /// 获取下一个对象
        /// </summary>
        /// <returns></returns>
        T Pop();

        /// <summary>
        /// 弹出给定数量
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<T> Pop(int count);

        /// <summary>
        /// 在右侧存入新的对象;
        /// </summary>
        /// <param name="element"></param>
        void Push(T element);

        /// <summary>
        /// 在右侧存入多个新的对象;
        /// </summary>
        /// <param name="element"></param>
        void Push(List<T> element);

        /// <summary>
        /// 在左侧存入新的对象;
        /// </summary>
        /// <param name="element"></param>
        void LeftPush(List<T> element);
    }

    /// <summary>
    /// 场景和此场景对应的关注Url
    /// </summary>
    public class SceneAndMarkurl
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SceneAndMarkurl()
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="url"></param>
        /// <param name="scene"></param>
        public SceneAndMarkurl(string url, string scene)
        {
            this.Url = url;
            this.Scene = scene;
        }

        /// <summary>
        /// 关注的Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 场景字符串;
        /// </summary>
        public string Scene { get; set; }

        /// <summary>
        /// 二维码过期时间;
        /// </summary>
        public DateTime ExpiredDateTime { get; set; }
        

        /// <summary>
        /// 用户定义的其他字段;
        /// </summary>
        public string OtherData { get; set; }

        /// <summary>
        /// 转换为字符串;
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Scene + "," + Url;
        }

        /// <summary>
        /// 隐式转换为 HashEntry;
        /// </summary>
        /// <param name="content"></param>
        public static implicit operator HashEntry(SceneAndMarkurl content)
        {
            return new HashEntry(content.Scene, JsonConvert.SerializeObject(content));
        }

        /// <summary>
        /// 从 SceneAndMarkurl 隐式转换为 字符串;
        /// </summary>
        /// <param name="content"></param>
        public static implicit operator string(SceneAndMarkurl content)
        {
            return JsonConvert.SerializeObject(content);
        }
        /// <summary>
        /// 从字符串 隐式转换为 SceneAndMarkurl;
        /// </summary>
        /// <param name="content"></param>
        public static implicit operator SceneAndMarkurl(string content)
        {
            return JsonConvert.DeserializeObject<SceneAndMarkurl>(content);
        }

    }
}
