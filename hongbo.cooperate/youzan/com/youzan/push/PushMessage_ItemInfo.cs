using System;

namespace youzan.com.youzan.push
{

    /// <summary>
    /// https://www.youzanyun.com/docs/guide/3401/3456
    /// 商品基础信息事件 ITEM_INFO
    /// </summary>
    public class PushMessage_ItemInfo
    {
        ///<sumary>
        ///商品ID
        ///E20171234567890123456789
        ///</sumary>
        public long item_id { get; set; }
        ///<sumary>
        ///商品别名
        ///123455532
        ///</sumary>
        public String alias { get; set; }
        ///<sumary>
        ///店铺ID
        ///4
        ///</sumary>
        public long kdt_id { get; set; }
        ///<sumary>
        ///标题
        ///</sumary>
        public String title { get; set; }
        ///<sumary>
        ///商品简介
        ///</sumary>
        public String sub_title { get; set; }
        ///<sumary>
        ///价格(分)
        ///
        ///</sumary>
        public long price { get; set; }
        ///<sumary>
        ///显示在原价那里的信息
        ///
        ///</sumary>
        public String origin { get; set; }
        ///<sumary>
        ///统一运费
        ///
        ///</sumary>
        public long postage { get; set; }
        ///<sumary>
        ///序号
        ///
        ///</sumary>
        public int num { get; set; }
        ///<sumary>
        ///商品类型，0 默认类型，1 拍卖 10 分销
        ///
        ///</sumary>
        public int goods_type { get; set; }
        ///<sumary>
        ///货号
        ///
        ///</sumary>
        public String goods_no { get; set; }
        ///<sumary>
        ///是否虚拟商品，1是，0否
        ///
        ///</sumary>
        public int is_virtual { get; set; }
        ///<sumary>
        ///用户购买限额
        ///
        ///</sumary>
        public int quota { get; set; }
        ///<sumary>
        ///留言信息，json
        ///
        ///</sumary>
        public String messages { get; set; }
        ///<sumary>
        ///是否参加会员折扣，默认：0 不参加
        ///
        ///</sumary>
        public int join_level_discount { get; set; }
        ///<sumary>
        ///运费模板ID
        ///
        ///</sumary>
        public long delivery_template_id { get; set; }
        ///<sumary>
        ///商品分组
        ///
        ///</sumary>
        public String tag { get; set; }
        ///<sumary>
        ///隐藏库存
        ///
        ///</sumary>
        public int hide_stock { get; set; }
        ///<sumary>
        ///总库存
        ///
        ///</sumary>
        public int total_stock { get; set; }
        ///<sumary>
        ///商品主图
        ///
        ///</sumary>
        public String picture { get; set; }
        ///<sumary>
        ///图片高度
        ///
        ///</sumary>
        public int picture_height { get; set; }
        ///<sumary>
        ///定时开售时间
        ///
        ///</sumary>
        public int start_sold_time { get; set; }
        ///<sumary>
        ///商品详情
        ///
        ///</sumary>
        public String content { get; set; }
        ///<sumary>
        ///组件
        ///
        ///</sumary>
        public String components { get; set; }
    }
    
}
