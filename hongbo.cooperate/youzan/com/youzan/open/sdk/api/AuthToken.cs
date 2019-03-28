using System;

namespace youzan.com.youzan.open.sdk
{

    /// <summary>
    /// 有赞的令牌类;
    /// </summary>
    public class YouzanAuthToken
    {
        /// <summary>
        /// 访问令牌
        /// </summary>
        public string access_token { get; set; }

        private long _expire;
        private DateTime expireDatetime;
        /// <summary>
        /// 过期时间
        /// </summary>
        public long expires_in
        {
            get
            {
                return _expire;
            }
            set
            {
                this._expire = value;
                this.expireDatetime = DateTime.Now.AddSeconds(value - 300);

            }
        }

        /// <summary>
        /// 范围
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        /// 是否已经过期;
        /// </summary>
        public bool isExpired
        {
            get
            {
                return this.expireDatetime <= DateTime.Now;
            }
        }
    }


    

}
