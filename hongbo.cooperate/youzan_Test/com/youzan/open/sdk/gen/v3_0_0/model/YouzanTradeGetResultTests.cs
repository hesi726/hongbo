using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.youzan.open.sdk.gen.v3_0_0.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using youzanTests;

namespace com.youzan.open.sdk.gen.v3_0_0.model.Tests
{
    [TestClass()]
    public class YouzanTradeGetResultTests : BaseTest
    {
        [TestMethod()]
        public void DeserializeTest()
        {
            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.NullValueHandling = NullValueHandling.Ignore;
            var msg = @"{""trade"":{""consign_time"":"""",""buyer_area"":""广东省广州市"",""original_post_fee"":""0.00"",""num"":1,""adjust_fee"":{""pay_change"":""0.00"",""change"":""0.00"",""post_change"":""0.00""},""relation_type"":"""",""type"":""FIXED"",""order_mark"":"""",""tid"":""E20180711133932074300002"",""send_num"":0,""feedback"":0,""delivery_start_time"":0,""outer_user_id"":0,""qr_id"":0,""price"":""80000.00"",""button_list"":[{""tool_parameter"":""{}"",""tool_type"":""goto_native:trade_change_price"",""create_time"":"""",""tool_value"":"""",""tool_title"":""改价"",""new_sign"":""0"",""tool_icon"":""https://img.yzcdn.cn/upload_files/2015/08/28/Ftodf5cdSlo-vaH1Jty4GylCJLr5.png""},{""tool_parameter"":"""",""tool_type"":""goto_native:trade_close"",""create_time"":"""",""tool_value"":"""",""tool_title"":""关闭"",""new_sign"":"""",""tool_icon"":""https://img.yzcdn.cn/upload_files/2015/08/28/Flv3HyyRB2DGyXsPwRqnZvA4pHla.png""},{""tool_parameter"":""{}"",""tool_type"":""goto_native:trade_memo"",""create_time"":"""",""tool_value"":"""",""tool_title"":""备注"",""new_sign"":""0"",""tool_icon"":""https://img.yzcdn.cn/upload_files/2015/08/28/FpO1UIXyOEZO026tWIgUOm9uZnT2.png""}],""total_fee"":""80000.00"",""payment"":""80000.00"",""order_type"":""0"",""is_tuan_head"":0,""lat"":23.140641677174,""sub_trades"":[],""delivery_time_display"":"""",""buyer_message"":"""",""delivery_end_time"":0,""lng"":113.31697387642,""created"":""2018-07-11 13:39:32"",""kind"":1,""delivery_list"":[],""is_retail_offline"":false,""offline_id"":""0"",""goods_kind"":1,""status_str"":""待付款"",""close_time"":"""",""pay_time"":"""",""group_no"":"""",""shop_id"":""0"",""out_trade_no"":[],""points_price"":0,""tuan_no"":"""",""orders"":[{""is_virtual"":0,""outer_item_id"":""10001"",""pic_thumb_path"":""https://img.yzcdn.cn/upload_files/2017/06/19/Fna08FxNZDN37i6oxWOCK9KnQ8IQ.png?imageView2/2/w/200/h/0/q/75/format/png"",""item_type"":0,""num"":""1"",""refunded_fee"":""0.00"",""oid"":18637515,""title"":""触发广告"",""fenxiao_payment"":""0.00"",""discount_fee"":""0.00"",""new_oid_str"":""1459543455095587819"",""buyer_messages"":[],""is_present"":0,""price"":""80000.00"",""fenxiao_price"":""0.00"",""total_fee"":""80000.00"",""alias"":""3npbbgvkv7dye"",""payment"":""80000.00"",""outer_sku_id"":""10005"",""sku_unique_code"":""42401902336217793"",""is_send"":0,""item_id"":""424019023"",""sku_id"":""36217793"",""sku_properties_name"":""套餐:1000台"",""pic_path"":""https://img.yzcdn.cn/upload_files/2017/06/19/Fna08FxNZDN37i6oxWOCK9KnQ8IQ.png"",""new_oid"":1459543455095587819,""item_refund_state"":""NO_REFUND"",""refund_id"":"""",""state_str"":""待付款"",""unit"":""件"",""order_promotion_details"":[],""allow_send"":0,""seller_nick"":""全视传媒""}],""promotion_details"":[],""id_card_number"":"""",""refund_state"":""NO_REFUND"",""status"":""WAIT_BUYER_PAY"",""post_fee"":""0.00"",""pic_thumb_path"":""https://img.yzcdn.cn/upload_files/2017/06/19/Fna08FxNZDN37i6oxWOCK9KnQ8IQ.png?imageView2/2/w/200/h/0/q/75/format/png"",""invoice_title"":"""",""receiver_city"":""广州市"",""shipping_type"":""express"",""refunded_fee"":""0.00"",""title"":""触发广告"",""discount_fee"":""0.00"",""buy_way_str"":"""",""hotel_info"":"""",""pf_buy_way_str"":"""",""receiver_state"":""广东省"",""update_time"":""2018-07-11 13:39:32"",""coupon_details"":[],""receiver_zip"":""511105"",""receiver_name"":""戴伟"",""pay_type"":"""",""fans_info"":{""fans_type"":9,""fans_weixin_openid"":""oHIuujuVgjqigDSQ_mpFm2oBok4E"",""buyer_id"":170428135,""fans_nickname"":""daiwei"",""fans_id"":1306391026},""delivery_third_party_supported"":false,""transaction_tid"":"""",""item_id"":""424019023"",""phase_payments"":{""is_presale"":false,""state"":"""",""phases"":[]},""receiver_district"":""越秀区"",""box_price"":""0.00"",""pic_path"":""https://img.yzcdn.cn/upload_files/2017/06/19/Fna08FxNZDN37i6oxWOCK9KnQ8IQ.png"",""feedback_num"":0,""receiver_mobile"":""18122449326"",""confirm_time"":"""",""sign_time"":"""",""seller_flag"":0,""service_phone"":"""",""is_retail_free_buy"":false,""shop_type"":""1"",""order_source"":{""platform"":""WECHAT""},""receiver_address"":""天河路1号锦绣联合商务大厦7楼710-A02室"",""trade_memo"":"""",""relations"":[],""outer_tid"":""""}}";
            var result = JsonConvert.DeserializeObject<YouzanTradeGetResult>(msg, setting);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Trade);
            Assert.IsTrue(result.Trade.ItemId == 424019023);
            Assert.IsTrue(result.Trade.BuyerArea == "广东省广州市");
            //Assert.IsTrue(result.Trade.ConsignTime == 424019023);

        }
    }
}