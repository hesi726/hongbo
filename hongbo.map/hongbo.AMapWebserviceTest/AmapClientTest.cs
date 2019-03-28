using hongbo.AMapWebservice.Response;
using hongbo.AMapWebservice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Linq;

namespace hongbo.AMapWebServiceTest
{
    [TestClass]
    public class AmapClientTest
    {
        AMapClient client = null;

        [TestInitialize]
        public void TestIntialize()
        {
            client = AMapConfig.GetClient();
            if (client == null)
            {
                AMapConfig.AddAmapConfig("1b21a2f1c05c2f03b2ea6157b95a3b4d");
            }
            client = AMapConfig.GetClient();
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        /// <summary>
        /// ���Ե�ַ���������Json�����л�
        /// </summary>
        [TestMethod]
        public void DeserialzeGeoCoderResponse()
        {
            var json = @"{""status"":""1"",""info"":""OK"",""infocode"":""10000"",""count"":""1"",""geocodes"":[{""formatted_address"":""�����г����������������|A��"",""country"":""�й�"",""province"":""������"",""citycode"":""010"",""city"":""������"",""district"":""������"",""township"":[],""neighborhood"":{""name"":[],""type"":[]},""building"":{""name"":[],""type"":[]},""adcode"":""110105"",""street"":[],""number"":[],""location"":""116.480656,39.989677"",""level"":""���ƺ�""}]}";
            var firstGeo = client.DeserialzeObject<GeoCoderResponse>(json).geocodes.First();
            Assert.IsTrue(firstGeo.city == "������");
            Assert.IsTrue(firstGeo.formatted_address == "�����г����������������|A��");
            Assert.IsTrue(firstGeo.province == "������");
            Assert.IsTrue(firstGeo.citycode == "010");
            Assert.IsTrue(firstGeo.district == "������");
        }

        /// <summary>
        /// ������������������Json�����л�
        /// </summary>
        [TestMethod]
        public void DeserialzeReGeoCoderResponse()
        {
            var json = @"{""status"":""1"",""regeocode"":{""addressComponent"":{""city"":""������"",""province"":""�㶫ʡ"",""adcode"":""440103"",""district"":""������"",""towncode"":""440103016000"",""streetNumber"":{""number"":""39-41��"",""location"":""113.234829,23.0956758"",""direction"":""����"",""distance"":""5.13984"",""street"":""���ش����""},""country"":""�й�"",""township"":""���ؽֵ�"",""businessAreas"":[{""location"":""113.22920880838318,23.08934754391219"",""name"":""����"",""id"":""440103""},{""location"":""113.27621431593793,23.13001418476728"",""name"":""����·"",""id"":""440104""}],""building"":{""name"":[],""type"":[]},""neighborhood"":{""name"":[],""type"":[]},""citycode"":""020""},""formatted_address"":""�㶫ʡ���������������ؽֵ����ش����39-41�Ż�Է��ҵ�㳡""},""info"":""OK"",""infocode"":""10000""}";
            var firstGeo = client.DeserialzeObject<ReGeoCoderResponse>(json).regeocode;

            json = @"{""status"":""1"",""regeocode"":{""addressComponent"":{""city"":""������"",""province"":""�㶫ʡ"",""adcode"":""440103"",""district"":""������"",""towncode"":""440103008000"",""streetNumber"":{""number"":""23��"",""location"":""113.244856,23.127685"",""direction"":""��"",""distance"":""27.0603"",""street"":""��Դ��һ��""},""country"":""�й�"",""township"":""�𻨽ֵ�"",""businessAreas"":[{""location"":""113.24618428070171,23.12686938596491"",""name"":""�¼���"",""id"":""440103""},{""location"":""113.24390343265311,23.129331138775512"",""name"":""����·"",""id"":""440103""},{""location"":""113.26933427830193,23.12798241037737"",""name"":""����"",""id"":""440104""}],""building"":{""name"":[],""type"":[]},""neighborhood"":{""name"":""����Է��Ԣ"",""type"":""����סլ;סլ��;סլС��""},""citycode"":""020""},""formatted_address"":""�㶫ʡ�������������𻨽ֵ�����Է��Ԣ�¾�������""},""info"":""OK"",""infocode"":""10000""}";
            firstGeo = client.DeserialzeObject<ReGeoCoderResponse>(json).regeocode;

            json = @"{""status"":""1"",""regeocode"":{""addressComponent"":{""city"":""������"",""province"":""�㶫ʡ"",""adcode"":""440111"",""district"":""������"",""towncode"":""440111014000"",""streetNumber"":{""number"":""21��"",""location"":""113.252417,23.2461431"",""direction"":""����"",""distance"":""10.4054"",""street"":""�Ļ�һ·""},""country"":""�й�"",""township"":""ʯ���ֵ�"",""businessAreas"":[[]],""building"":{""name"":[],""type"":[]},""neighborhood"":{""name"":[],""type"":[]},""citycode"":""020""},""formatted_address"":""�㶫ʡ�����а�����ʯ���ֵ������������""},""info"":""OK"",""infocode"":""10000""}";
            firstGeo = client.DeserialzeObject<ReGeoCoderResponse>(json).regeocode;

        }

        
    }

    
}
