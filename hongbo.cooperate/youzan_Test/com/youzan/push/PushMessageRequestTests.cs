using Microsoft.VisualStudio.TestTools.UnitTesting;
using youzan.com.youzan.push;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace youzan.com.youzan.push.Tests
{
    [TestClass()]
    public class PushMessageRequestTests
    {
        [TestMethod]
        public void Convert_ItemInfo_ItemUpdate_Test()
        {
            var msg = @"{""client_id"":""528f1d2ed44c91f50e"",""id"":""425892132"",""kdt_id"":41177244,""mode"":1,""msg"":""%7B%22data%22%3A%22%7B%5C%22kdt_id%5C%22%3A41177244%2C%5C%22item_id%5C%22%3A425892132%2C%5C%22price%5C%22%3A1%2C%5C%22channel%5C%22%3A0%2C%5C%22alias%5C%22%3A%5C%222xad1lhg8z4gc%5C%22%2C%5C%22tax_class_code%5C%22%3A%5C%22%5C%22%2C%5C%22title%5C%22%3A%5C%22%E6%B5%8B%E8%AF%95%E5%95%86%E5%93%81%E5%9B%9B%5C%22%2C%5C%22picture%5C%22%3A%5C%22%5B%7B%5C%5C%5C%22height%5C%5C%5C%22%3A640%2C%5C%5C%5C%22url%5C%5C%5C%22%3A%5C%5C%5C%22https%3A%2F%2Fimg.yzcdn.cn%2Fupload_files%2F2018%2F01%2F22%2FFnlHRufXMtUI_AbAEP0tux_nDL1T.png%5C%5C%5C%22%2C%5C%5C%5C%22width%5C%5C%5C%22%3A640%7D%5D%5C%22%7D%22%2C%22change_fields%22%3A%22%5B%5C%22price%5C%22%2C%5C%22picture%5C%22%5D%22%7D"",""sendCount"":0,""sign"":""7c83ae6db2c6b2d1d485e67a24f18e54"",""status"":""ITEM_UPDATE"",""test"":false,""type"":""ITEM_INFO"",""version"":1532424907000}";
            var result = JsonConvert.DeserializeObject<PushMessageRequest>(msg);
            PushMessage_ItemInfo detail = result.ConvertToDetailMessage() as PushMessage_ItemInfo;
            Assert.IsTrue(detail.item_id == 425892132);
        }

        [TestMethod]
        public void Convert_TradeOrderState_WaitBuyerPay_Test()
        {
            var msg = @"{""client_id"":""528f1d2ed44c91f50e"",""id"":""E20180724174829074300001"",""kdt_id"":41177244,""kdt_name"":""全视精选"",""mode"":1,""msg"":""%7B%22update_time%22:%222018-07-24%2017:48:29%22,%22extra_info%22:%22%7B%5C%22is_retail_offline%5C%22:false%7D%22,%22payment%22:%220.01%22,%22pay_type%22:%22%22,%22book_id%22:%22201807241748025b56f5d26138542268%22,%22tid%22:%22E20180724174829074300001%22,%22status%22:%22WAIT_BUYER_PAY%22%7D"",""sendCount"":0,""sign"":""5e25816f0ac26ec20269163ab6984864"",""status"":""WAIT_BUYER_PAY"",""test"":false,""type"":""TRADE_ORDER_STATE"",""version"":1532425709}";
            var result = JsonConvert.DeserializeObject<PushMessageRequest>(msg);
            PushMessage_TradeOrderState detail = result.ConvertToDetailMessage() as PushMessage_TradeOrderState;
            Assert.IsTrue(detail.tid == "E20180724174829074300001");
            Assert.IsTrue(detail.payment == 0.01m);
        }
    }
}