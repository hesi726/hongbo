using System;

namespace youzan.com.youzan.push
{
    /// <summary>
    /// https://www.youzanyun.com/docs/guide/3401/3456
    /// msg包含data和change_fields两部分，
    /// data返回字段名称及字段最新值，change_fields返回发生变更字段的名称，比如{"data":"{"item_id":344692686,"alias":"3nrnrvzymwlv8","kdt_id":164932,"is_display":0}",
    /// "change_fields":"["is_display"]"}
    /// </summary>
    public class PushMessage_ItemState
    {
        public PushMessage_ItemStateDetail data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string[] change_fields { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class PushMessage_ItemStateDetail
    {
        ///<sumary>
        ///商品Id
        ///E20171234567890123456789
        ///</sumary>
        public long item_id { get; set; }
        ///<sumary>
        ///商品别名
        ///123455532
        ///</sumary>
        public String alias { get; set; }
        ///<sumary>
        ///店铺id
        ///4
        ///</sumary>
        public long kdt_id { get; set; }
        ///<sumary>
        ///标题 只删除事件返回此字段
        ///1212312312312
        ///</sumary>
        public String title { get; set; }
        ///<sumary>
        ///1:出售中 2:已售罄 3:部分售罄 只售罄事件返回此字段
        ///42874.4166666667
        ///</sumary>
        public int sold_status { get; set; }
        ///<sumary>
        ///是否显示 0:下架 1: 上架 只上下架事件返回此字段
        ///
        ///</sumary>
        public int is_display { get; set; }


    }
}
