# BaiduMapWebservice &amp; AMapWebservice
�ٶȺ͸ߵµĵ�ͼ���ýӿ�;

�ٶȵ�ͼWEBSERVICE �� C# ���ýӿ�( �����ϴ��븴���� ��https://github.com/Seamas/BaiduMapWebApi ��)��
Ϊ�ܿ��ٶȵ�ͼWEBSERVICE ���ô������ƣ�֧�ֶ�� �ٶȵ�ͼ WEBSERVICE �� appid 

//ȫ�����ðٶȵ� AppId �� SecretKey,  
BaiduMapConfig.AddBaiduMapConfig("Ar0P3ZtGzAbdDRvacMWUVvvHtjtftoWI", "iLY3xsGGI1SQ7kHjH9TbGAclgv9TI3FF");
 
 // �������������ַ����ȡ��Χ200��֮�ڵ�POI��Ϣ;  
 var client = BaiduMapConfig.GetClient();  
 IPPoint baiduGps = new IPPoint { X = lng, Y = lat };  
 var model = new ReGeoCoderModel   
 {
                location = string.Format("{0},{1}", baiduGps.Y, baiduGps.X),  
                pois = 1,  
                radius = 200  
 };  
 var request = new ReGeoCoderRequest(model);  
 ReGeoCoderResponse result = client.Execute(request);  


 
 �ߵµ�ͼWebservice �� c# ���ýӿ�; 
 ��ʱֻʵ�ֵ�ַ���� �͵�ַ����� 2��,��Ϊ���ǹ�˾ֻ�õ���2��,   
 //ȫ�����øߵµ� AppId �� SecretKey,    
 AMapConfig.AddAmapConfig("511b21a2f1c05c2f03b2ea6157b95a3b4d");  //amap key is error, please assign your app key  
 var firstGeo = AMapClientUtil.GetGeoResult("�����������A��", "����");  