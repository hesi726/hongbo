using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Net
{
    /// <summary>
    /// Net的工具类：
    /// </summary>
    public static class NetUtil
    {
        /// <summary>
        /// 返回主机名称
        /// </summary>
        /// <returns></returns>
        public static string GetHostname()
        {
            return Dns.GetHostName();
        }
        private static string ipv4 = null;
        /// <summary>
        /// 获取本机的Ip地址(IPV4)
        /// </summary>
        /// <returns></returns>
        public static string GetLocalIp()
        {
            if (ipv4 != null) return ipv4;
           var ipaddress = Dns.GetHostAddresses(Dns.GetHostName()).
Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).
First();
            ipv4 = ipaddress.ToString();
            return ipv4;
        }

        private static string ipv6 = null;
        /// <summary>
        /// 获取本机的Ip地址(IPV6)
        /// </summary>
        /// <returns></returns>
        public static string GetLocalIpV6()
        {
            if (ipv4 != null) return ipv4;
            var ipaddress = Dns.GetHostAddresses(Dns.GetHostName()).
 Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6).
 First();
            ipv6 = ipaddress.ToString();
            return ipv6;
        }
    }
}
