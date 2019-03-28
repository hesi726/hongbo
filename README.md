#hongbo
hongbo 公司使用的代码，

#hongbo.core
hongbo 公司使用的核心库



#hongbo.map
	地图库(目前只有 高德 和 百度)

#hongbo.map.AmapWebservice 
	    高德地图Webservice 后台服务区接口
		 顺便说一下，高德的地址解析 和 地址逆解析 返回的结果很不规范，
		 例如:
			 AddressComponent 中的  businessAreas 字段，
			 有时候是 

			 "businessAreas":{"location":"113.22920880838318,23.08934754391219","name":"芳村","id":"440103"}  
			 或者这样，
			 "businessAreas":[{"location":"113.22920880838318,23.08934754391219","name":"芳村","id":"440103"},{"location":"113.27621431593793,23.13001418476728","name":"二三路","id":"440104"}]  
			 或者这样:
			 "businessAreas": [[]]  

#hongbo.map.BaiduMapWebservice
	百度地图Webservice 后台服务区接口

#hongbo.cooperate
	和一些合作平台的合作库

#hongbo.cooperate.youzan
	有赞商城的服务接口库（支持到 4.0, 后续未维持合作）


	#
			自己公司使用的基于数据库的异步消息处理类（慢，不要用于效率要求比较高的场合)

#hongboEntityframework
对 EntityFramework 或者 EFCore 的扩展


#hongboExtension
对标准类的扩展


# hongboPrivilege
自己公司使用的权限控制代码  
因为公司较小，权限变化不大（一般不会定义新的权限或者删除权限）  
所以权限存放在常量，而没有存放在数据库中；
这样，就可以在 Controller 上定义 Attribute 来进行授权控制      
也可以在 Action 上定义 Attribute 来控制控制  
还可以根据 Action 的某一个参数，根据参数类型和参数值：   
1. 参数类型为字符串时，解析参数值对应的类型，通过在此类型上的定义的 Attribute ， 从而对这个 Action 进行授权控制，    
2. 参数类型为枚举类型，解析参数值对应的枚举值，解析此枚举值上所定义的Attribute,从而控制对这个 Action 的授权控制，  

Accord the url, https://docs.microsoft.com/en-us/dotnet/core/tutorials/libraries#how-to-multitarget
but there is one question, for example, you set the targetframeworks to net46, but in your code, you use the net45, it will not defined net45;