有赞开放平台SDK .net Standard 版本；
依赖自项目：
https://github.com/fy290800220/TakeawayCube.SDK.Youzan （这儿是 .Net Standard 版）
https://github.com/ph0ly/open-sdk-csharp （这儿是 .NetFramework 版）
上述2个版本存在的问题是，只能得到 json 内容，还需要自行去进行解析；
本项目增加了 json 内容的解析和封装; (不过，最高到 4.0， 4.0后我们公司不再在和有赞进行合作)


大家可以 clone 代码自行修改（请注意版权协议, http://www.gnu.org/licenses/licenses.zh-cn.html)
大家如果想要修改，可以留言, 告诉我你的 github 账号，来一起进行修改;

使用方法：

			YouzanConfig youzanConfig = new YouzanConfig { AppId = "Appid1", AppSecret = "AppSecret1", KdtId = "KdtId1"};
			YouzanShopGet shopGet = new YouzanShopGet();
            YouzanShopGetParams param = new YouzanShopGetParams();
            shopGet.APIParams = param;
            YouzanShopGetResult result = shopGet.Invoke(youzanConfig);  
			//或者 YouzanShopGetResult result = youzanConfig.Invoke(shopGet);   
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Name);