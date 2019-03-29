using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using hongbao.CollectionExtension;
using hongbao.SystemExtension;
using HashidsNet;
using hongbao.Reflection;
using hongbao.IOExtension;

namespace hongbao.SecurityExtension
{
    /// <summary>
    /// 安全工具类；
    /// 加密 和 解密 改为使用  Hashids.Net库; 166毫秒大约可以加解密 10000 个整数;
    /// </summary>
    public static class SecurityUtil
    {
      
        /// <summary>
        /// 
        /// </summary>
        static SecurityUtil()
        {
            ///*for(var index=0; index<100000; index++)
            //{
            //    GuidList.Add(GuidUtil.NewGuid()); 
            //}*/
            //CHARS = new char[]
            //{    /*"%5B%5D().-!%40%23%24%25%26*-%2B%3D%60~'.%2C%3E%3C%3F%2F%3A%3B" */
            //    'z','0','1','2','3','4','5','6','7','8','9','y','A','B','C','D','E','F','G','H','I','J','x','K','L','M','N','O','P','Q','R','S','T','w','U','V','W','X','Y','Z','a','b','c','d','u','e','f','g','h','i','j','k','l','m','n','v','o','p','q','r','s','t'
            //};
            
            //CHARS_LEN = CHARS.Length;
            //CHARS_MAPS = new int[128];
            //CHARS_MAPS.ForEach((one, index) => CHARS_MAPS[index] = 0);
            //for (var index=0; index<CHARS.Length; index++)
            //{
            //    if (Map.ContainsKey(CHARS[index]))
            //        throw new Exception("重复键");
            //    Map[CHARS[index]] = index;
            //    CHARS_MAPS[CHARS[index]] = index;
            //}

           
        }
        //private static char[] CHARS = null;
        //private static int[] CHARS_MAPS = null; 
        ////static string switchS = ""; 
        //static int CHARS_LEN = 0; 
        ////static long MASK_ONE = (long) (0x7bcdef89);
        ////static long MASK_TWO = (long) (0X56ef1234);
        //static Dictionary<char, int> Map = new Dictionary<char, int>();

        //private static int GetIndex(char one)
        //{
        //    switch (one)
        //    {
        //        case 'z': return 0;
        //        case '0': return 1;
        //        case '1': return 2;
        //        case '2': return 3;
        //        case '3': return 4;
        //        case '4': return 5;
        //        case '5': return 6;
        //        case '6': return 7;
        //        case '7': return 8;
        //        case '8': return 9;
        //        case '9': return 10;
        //        case 'y': return 11;
        //        case 'A': return 12;
        //        case 'B': return 13;
        //        case 'C': return 14;
        //        case 'D': return 15;
        //        case 'E': return 16;
        //        case 'F': return 17;
        //        case 'G': return 18;
        //        case 'H': return 19;
        //        case 'I': return 20;
        //        case 'J': return 21;
        //        case 'x': return 22;
        //        case 'K': return 23;
        //        case 'L': return 24;
        //        case 'M': return 25;
        //        case 'N': return 26;
        //        case 'O': return 27;
        //        case 'P': return 28;
        //        case 'Q': return 29;
        //        case 'R': return 30;
        //        case 'S': return 31;
        //        case 'T': return 32;
        //        case 'w': return 33;
        //        case 'U': return 34;
        //        case 'V': return 35;
        //        case 'W': return 36;
        //        case 'X': return 37;
        //        case 'Y': return 38;
        //        case 'Z': return 39;
        //        case 'a': return 40;
        //        case 'b': return 41;
        //        case 'c': return 42;
        //        case 'd': return 43;
        //        case 'u': return 43;
        //        case 'e': return 45;
        //        case 'f': return 46;
        //        case 'g': return 47;
        //        case 'h': return 48;
        //        case 'i': return 49;
        //        case 'j': return 50;
        //        case 'k': return 51;
        //        case 'l': return 52;
        //        case 'm': return 53;
        //        case 'n': return 54;
        //        case 'v': return 55;
        //        case 'o': return 56;
        //        case 'p': return 57;
        //        case 'q': return 58;
        //        case 'r': return 59;
        //        case 's': return 60;
        //        case 't': return 61;
                

        //        //case '!': return 44;
        //            // case '~': return 55;
        //            // case '\'': return 66;


        //            //  case '.': return 22;
        //            // case '-': return 33;
        //            //  case '*': return 69;
        //            // case '(': return 0;
        //            // case ')': return 11;
        //    }
        //    throw new Exception("");
        //}
        //private static long GetLen(long val, int mod = 10)
        //{
        //    long result = 0;
        //    while (val >= 0) { result++;  val = val / mod; }
        //    return result;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="val"></param>
        ///// <returns></returns>
        //public static string Convert(long val)
        //{
        //    var xval = val;
        //    int maxLen = 20; 
        //    char[] seeds = new char[maxLen];
        //    int seedLen = 19;
        //    while (xval > 0)
        //    {
        //        long mod = xval % CHARS_LEN;
        //        seeds[seedLen--] = CHARS[mod];
        //        xval = xval / CHARS_LEN;
        //    }
        //    var result = new string(seeds, seedLen + 1, maxLen - seedLen - 1);
        //    return result;
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="val"></param>
        ///// <returns></returns>
        //public static long Convert(string val)
        //{
        //    long result = 0;
        //    var chars = val.ToArray();
        //    var len = chars.Length; 
        //    for(var index=0; index< len; index++)
        //    {
        //        var one = CHARS_MAPS[chars[index]]; //    Map[chars[index]];  //GetIndex(chars[index]); //
        //        result = result * CHARS_LEN + one; 
        //    }
        //    return result; 
        //}


        #region 根据类型和Id加密Id到一个Guid字符串_对于相同类型和Id总是产生相同的Guid
        ///// <summary>
        ///// 
        ///// </summary>
        //public static int[] Random = new int[]
        //{
        //    123459817, 123459781, 345978112, 597811234, 781123459, 112345978, 477, 287,
        //    123645, 541321, 1100, 7, 5423, 8172, 477, 2187,
        //    123245, 254321, 1020, 8987, 5443, 87, 4727, 2867,
        //    123145, 542321, 1040, 897, 54, 8782, 4477, 28,
        //};
        ///// <summary>
        ///// 
        ///// </summary>
        //public static char[] GuidArray = new char[]
        //{
        //    '0', 'a', 'b','e','f','c','d','2','4','1','3','5','7','6','8','9'
        //};

        ///// <summary>
        ///// 根据类型和名称，相同的类型和 id 将产生相同的 guid, 
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="typeName"></param>
        ///// <returns></returns>
        //private static string ProductGuid(int id, string typeName)
        //{
        //    char[] ran = new char[32];
        //    var xId = Math.Abs(id ^ typeName.GetHashCode());
        //    Random.ForEach((item, index) =>
        //    {
        //        var xx = Math.Abs(xId ^ item) % 16;
        //        ran[index] = GuidArray[xx];
        //    });
        //    return new string(ran);
        //}

        /// <summary>
        /// 将Id藏起来到Guid中;返回加密后的字符串;
        /// 对于相同类型的Id，会产生同样的 Guid;
        /// 但是对于不同类型的相同Id,可能会产生不同的Guid;
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="debug"></param>
        /// <returns></returns>
        public static string CryptIdInGuid<T>(int? _id, bool debug = false)
        {
            if (!_id.HasValue || _id <= 0) return null;
            return CryptIdInGuid(_id, typeof(T), debug);
        }

        /// <summary>
        /// 将Id数组藏起来到Guid中;返回加密后的字符串;
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="debug"></param>
        /// <returns></returns>
        public static string CryptIdsInGuid<T>(string ids,  bool debug = false)
        {
            return CryptIdsInGuid(ids, typeof(T), debug);
        }
        /// <summary>
        /// 将Id数组藏起来到Guid中;返回加密后的字符串;
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="type"></param>
        /// <param name="debug"></param>
        /// <returns></returns>
        public static string CryptIdsInGuid(string ids, Type type, bool debug = false)
        {
            if (string.IsNullOrEmpty(ids)) return null;
            return ids.Split(new char[] { ',' }).Where(a => a.Trim().Length > 0)
                    .Select(b => CryptIdInGuid(System.Convert.ToInt32(b), type, debug))
                    .Join(",");
        }

        /// <summary>
        /// 将Id藏起来到Guid中;返回加密后的字符串;
        /// 如果 id 小于等于0，返回空;
        /// 对于相同类型的相同Id，会产生同样的 Guid;
        /// 对于相同类型的不同Id，会产生不同的 Guid;
        /// 但是对于不同类型的不同Id,可能会产生相同的Guid;
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="type"></param>
        /// <param name="debug"></param>
        /// <returns></returns>
        public static string CryptIdInGuid(int? _id, Type type, bool debug=false)
        {
            if (!_id.HasValue || _id <= 0) return null;
            var entityTypeName = TypeUtil.GetPocoType(type).Name;
            return CryptIdInGuid(_id, entityTypeName, debug);
        }

      
        /// <summary>
        /// 将Id藏起来到Guid中;返回加密后的字符串;
        /// 如果 id 小于等于0，返回空;
        /// 对于相同类型的相同Id，会产生同样的 Guid;
        /// 但是对于不同类型的相同Id,可能会产生不同的Guid;
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="typeName"></param>
        /// <param name="debug"></param>
        /// <returns></returns>
        public static string CryptIdInGuid(int? _id, string typeName, bool debug = false)
        {
            if (!_id.HasValue || _id <= 0) return null;
              Hashids hashids = GetHashids(typeName);
              var id = hashids.Encode(_id.Value);
              return id;
            
            /*
            var id = _id.Value;
              string val = null;
              var typeHash = Math.Abs(typeName.GetHashCode());  // 不要使用 Type,使用类型名称, 因为 Type的HashCode将根据内部值的不同而有所不同;  
              var guid = ProductGuid(id, typeName);
              var longId = (id * 135721L);
              var idVal = longId.ToString("x").ToLower().ToCharArray(); //id 转换成为16进制的字符数组;
              //if (idVal.Length > 11) throw new Exception("数字溢出"); 
              var bytes = guid.ToCharArray();
              int beginPos = (id & typeHash) % 16; // new Random().Next(16);
              bytes[bytes.Length - 1] = beginPos.ToString("x").ToCharArray()[0]; //倒数第1位用来表示起始位置;
              var len = idVal.Length.ToString("x").ToCharArray()[0];
              bytes[beginPos + 11] = len; //倒数第2位用来表示长度位置; 理论上不可能超过 16位长度
              var crcString = ((id ^ 123456789) % (256 * 16)).ToString("x");
              var crc = crcString.ToCharArray();   //校验字符数组位,3位长度;
              if (crc.Length == 1)
              {
                  crc = new char[] { '0', '0', crc[0] };
              }
              if (crc.Length == 2)
              {
                  crc = new char[] { '0', crc[0], crc[1] };
              }
              Array.Copy(crc, 0, bytes, 28, crc.Length);

              idVal.ForEach((chr, pos) =>
              {
                  bytes[beginPos + pos] = chr;
              });
              val = new string(bytes);
              if (debug)
              {
                  LogUtil.xLogUtil.Warn(
  "加解密异常:加密过程:{1}{2}type:{3}{2}typeHash:{4}{2}beginPos:{5}{2}len:{6}{2}sub:{7}{2}subLong:{8}{2}crc:{9}{2}id:{0}",
  null,
  id, val, Environment.NewLine, typeName, typeHash, beginPos, len, idVal, longId, crcString);
              }
              return val; 
              */
        }

        /// <summary>
        /// hashSalt 千万不要修改;如果修改，则必须清除所有的 RedisCache 缓存;
        /// </summary>
        private static string hashSalt = "thisismaxmedia";

        /// <summary>
        /// 
        /// </summary>
        private static IDictionary<string, Hashids> hashSaltMap = new System.Collections.Concurrent.ConcurrentDictionary<string, Hashids>();        
        /// <summary>
        /// 根据类型名称获取 Hashids 的实例;
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        private static Hashids GetHashids(string typeName)
        {
            Hashids hashids = null;
            if (!hashSaltMap.TryGetValue(typeName, out hashids))
            {
                var salt = string.Format("{0}{1}", typeName, hashSalt);
                hashids = new Hashids(salt, 8);                
                hashSaltMap[typeName] = hashids;
            }
            return hashids;
        }

        /// <summary>
        /// 返回解密后的Id，但是拼接成字符串返回;
        /// </summary>
        /// <param name="cryptedString"></param>
        /// <param name="debug"></param>
        /// <returns></returns>
        public static string DecryptIdsInGuid<T>(string cryptedString, bool debug = false)
        {
            if (string.IsNullOrEmpty(cryptedString)) return null;
            return DecryptIdsInGuid(cryptedString, typeof(T), debug);
        }

        /// <summary>
        /// 从将Id藏起来到给定的Guid中;返回解密后的Id;
        /// 如果传入为空字符串，则返回 0；注意，不是空，而是 0;
        /// </summary>
        /// <param name="cryptedString"></param>
        /// <param name="type">类型,如果传入null,则解密时不进行类型校验;</param>
        /// <param name="debug"></param>
        /// <returns></returns>
        public static string DecryptIdsInGuid(string cryptedString, Type type, bool debug = false)
        {
            if (string.IsNullOrEmpty(cryptedString)) return null;
            var entityTypeName = TypeUtil.GetPocoType(type).Name;
            
            if (cryptedString.IndexOf(",") < 0) return DecryptIdInGuid(cryptedString, entityTypeName, debug).ToString();
            return cryptedString.Split(new char[] { ',' }).Where(a => a.Trim().Length > 0)
                    .Select(b => DecryptIdInGuid(b, entityTypeName, debug).ToString())
                    .Join(",");            
        }


        /// <summary>
        /// 从将Id藏起来到给定的Guid中;返回解密后的Id;
        /// </summary>
        /// <param name="cryptedString"></param>
        /// <param name="debug"></param>
        /// <returns></returns>
        public static int DecryptIdInGuid<T>(string cryptedString, bool debug = false)
        {
            if (string.IsNullOrEmpty(cryptedString)) return 0;
            return DecryptIdInGuid(cryptedString, typeof(T), debug);
        }

        /// <summary>
        /// 从将Id藏起来到给定的Guid中;返回解密后的Id;
        /// 如果传入为空字符串，则返回 0；注意，不是空，而是 0;
        /// </summary>
        /// <param name="cryptIntString"></param>
        /// <param name="type">类型,如果传入null,则解密时不进行类型校验;</param>
        /// <param name="debug"></param>
        /// <returns></returns>
        /// 
        public static int DecryptIdInGuid(string cryptIntString, Type type, bool debug = false)
        {
            var entityTypeName = TypeUtil.GetPocoType(type).Name;
            return DecryptIdInGuid(cryptIntString, entityTypeName, debug);
        }

        /// <summary>
        /// 从将Id藏起来到给定的Guid中;返回解密后的Id;
        /// 如果传入为空字符串，则返回 0；注意，不是空，而是 0;
        /// </summary>
        /// <param name="cryptIntString"></param>
        /// <param name="typeName">类型,如果传入null,则解密时不进行类型校验;</param>
        /// <param name="debug"></param>
        /// <returns></returns>
        public static int DecryptIdInGuid(string cryptIntString, string typeName, bool debug = false)
        {
            if (string.IsNullOrEmpty(cryptIntString)) return 0;
            if (cryptIntString.Length < 32)
            {             
                Hashids hashids = GetHashids(typeName);
                var ids = hashids.Decode(cryptIntString);
                if (ids == null || ids.Length == 0) return 0;
                return ids[0];
            }

            int typeHash = 0;
            if (!string.IsNullOrEmpty(typeName))
            {
                typeHash = Math.Abs(typeName.GetHashCode());
            }
            if (string.IsNullOrEmpty(cryptIntString)) return 0;
            if (cryptIntString.Length < 32) return 0;

            var bytes = cryptIntString.ToCharArray();
            var beginPos = System.Convert.ToInt32(new string(new char[] { bytes[bytes.Length - 1] }), 16);
            var len = System.Convert.ToInt32(new string(new char[] { bytes[beginPos + 11] }), 16);
            var sub = cryptIntString.Substring(beginPos, len);
            long subLong = System.Convert.ToInt64(sub, 16);
            var id = (int)(subLong / 135721L);
            if (!string.IsNullOrEmpty(typeName) && CryptIdInGuid(id, typeName) != cryptIntString || debug)
            //不能验证，因为在 Ehay 和 EhayDataHandle 会产生不同的 GuidList;
            //悲催的是， 反序列化时， Newtonsoft.Json.JsonConvert.DeserializeObject<EH_DeviceInfo>(keyContent)
            //在 IdEntity 中无法获取到正确的 EH_DeviceInfo 类型，
            {
                var crcString = cryptIntString.Substring(28, 3);
                CryptIdInGuid(id, typeName, true);
//                LogUtil.xLogUtil.Warn(
//"加解密异常:解密过程:{1}{2}type:{3}{2}typeHash:{4}{2}beginPos:{5}{2}len:{6}{2}sub:{7}{2}subLong:{8}{2}crcString:{9}{2}id:{0}",
//                    null,
//                    id, cryptIntString, Environment.NewLine, typeName, typeHash, beginPos, len, sub, subLong, crcString);
                // throw new Exception("错误的解密字符串");
            }
            return id;
        }

        /// <summary>
        /// 从将Id藏起来到给定的Guid中;返回解密后的Id;
        /// 如果传入为空字符串，则返回 null;
        /// </summary>
        /// <param name="cryptedString"></param>
        /// <returns></returns>
        public static int? DecryptIdNullInGuid<T>(string cryptedString)
        {
            var result = DecryptIdInGuid<T>(cryptedString);
            if (result <= 0) return null;
            return result;
        }
        #endregion

        #region 简单的加密和解密计算其实就是字符串后面加上一个Hash校验码

        ///// <summary>
        ///// 对整数进行自定义的加密，  
        ///// </summary>
        ///// <param name="val"></param>
        ///// <param name="hashString"></param>
        ///// <returns></returns>
        //public static string CryptInt(int val, string hashString = "abc.123")
        //{
        //    var str = val.ToString();
        //    if (string.IsNullOrEmpty(str)) return str;
        //    var len = str.Length;  //肯定为1位的字符串;
        //    return len + str + (Math.Abs((str + hashString).GetHashCode()) % 10000).ToString();
        //}

        ///// <summary>
        ///// 对整数进行自定义的解密，  
        ///// </summary>
        ///// <param name="str"></param>
        ///// <returns></returns>
        //public static int DecryptInt(string str)
        //{
        //    if (string.IsNullOrEmpty(str) || str.Length < 3) return 0;
        //    var sub = str.Substring(0, 1);
        //    int isub;
        //    if (!Int32.TryParse(sub, out isub)) return 0;
        //    if (str.Length < isub + 1) return 0;
        //    int result = 0;
        //    if (!Int32.TryParse(str.Substring(1, isub), out result))
        //        return 0;
        //    if (CryptInt(result) != str) return 0;
        //    return result;

        //    /*long lval = Convert(val);
        //    lval = lval ^ MASK_TWO;
        //    long intVal = ((lval >> 4) & 0XFFFFFFFF);

        //    long len = ((long)((intVal & 15) << 32) | (long)intVal);
        //    len = (len << 4) | (len & 11);
        //    if (len != lval) return 0;
        //    return (int)(intVal ^ MASK_ONE);*/
        //    /*val = DecryptString(val);
        //    if (string.IsNullOrEmpty(val)) return 0;
        //    int result = 0;
        //    Int32.TryParse(val, out result);
        //    return result; */
        //}
        ///// <summary>
        ///// 字符串加密; 简单的加密和解密计算,其实就是字符串后面加上一个Hash校验码
        ///// </summary>
        ///// <param name="str"></param>
        ///// <param name="hashString"></param>
        ///// <returns></returns>
        //public static string CryptString(string str, string hashString = "xyz.123")
        //{
        //    if (string.IsNullOrEmpty(str)) return str;
        //    var len = str.Length;
        //    return str + Math.Abs((str + hashString).GetHashCode()).ToString() + len.ToString("0000"); 
        //}

        ///// <summary>
        ///// 字符串解密;
        ///// </summary>
        ///// <param name="str"></param>
        ///// <returns></returns>
        //public static string DecryptString(string str)
        //{
        //    if (string.IsNullOrEmpty(str)) return str;
        //    var len = str.Length;
        //    if (str.Length <= 4) return null;
        //    var sub = str.Substring(len - 4, 4);
        //    int isub;
        //    if (!Int32.TryParse(sub, out isub)) return null;
        //    if (isub < 0) return null; 
        //    var val = str.Substring(0, isub);
        //    if (CryptString(val) != str) return null;
        //    return val; 
        //}
        #endregion

        #region   计算Md5

        /// <summary>
        /// 产生 MD5 检验码; 注意， 此方法和 PHP,JAVA等方法产生的 MD5 不一致； 
        /// </summary>
        /// <param name="myString"></param>
        /// <returns></returns>
        public static string MD5(string myString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = System.Text.Encoding.Unicode.GetBytes(myString);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x");
            }
            return byte2String;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromData"></param>
        /// <returns></returns>
        public static string MD5(byte[] fromData)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x");
            }
            return byte2String;
        }



        /// <summary>
        /// 产生 MD5 检验码; 注意， 此方法才和 PHP,JAVA等方法产生的 MD5 一致； 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string PhpMD5(string text)
        {
            byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(text);
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                string ret = "";
                foreach (byte a in hash)
                {
                    if (a < 16)
                        ret += "0" + a.ToString("x");
                    else
                        ret += a.ToString("x");
                }
                return ret;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 产生 MD5 检验码; 注意， 此方法才和 PHP,JAVA等方法产生的 MD5 一致； 
        /// </summary>
        /// <param name="textBytes"></param>
        /// <returns></returns>
        public static string PhpMD5(byte[] textBytes)
        {
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                string ret = "";
                foreach (byte a in hash)
                {
                    if (a < 16)
                        ret += "0" + a.ToString("x");
                    else
                        ret += a.ToString("x");
                }
                return ret;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 为 文件 产生 MD5 检验码; 注意， 此方法才和 PHP,JAVA等方法产生的 MD5 一致； <br/>
        /// </summary>
        /// <param name="desPath">文件路径</param>
        /// <returns>
        ///  文件内容的MD5 马；
        /// </returns>
        public static string PhpMD5File(string desPath)
        {
            //if (begin < 0) throw new InvalidOperationException("起始位置不能小于0");
            //if (length < 0) throw new InvalidOperationException("长度不能小于0");
            byte[] content = FileUtil.readFileBinaryContent(desPath);
            return PhpMD5(content); 
        }

        /// <summary>
        /// 为 文件 产生 MD5 检验码; 注意， 此方法才和 PHP,JAVA等方法产生的 MD5 一致； <br/>
        /// 可能取第 X 到 第 Y 个字节产生 MD5 玛；
        /// </summary>
        /// <param name="desPath">文件路径</param>
        /// <param name="begin">文件开始位置，如果&lt;0，，抛出异常；</param>
        /// <param name="length">长度，如果&lt;0，抛出异常；如果为0，取文件内容至结尾；</param>
        /// <returns>
        ///  文件内容的MD5 马；
        /// </returns>
        public static string MD5File(string desPath, int begin = 0, int length = 0)
        {
            if (begin < 0) throw new InvalidOperationException("起始位置不能小于0");
            if (length < 0) throw new InvalidOperationException("长度不能小于0");
            byte[] content = FileUtil.readFileBinaryContent(desPath, begin, length);
            return MD5(content);
        }
        #endregion

        /// <summary>
        /// 使用 MD5  算法计算数据的 HMAC码；
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] HmacSignDataUsingMd5(byte[] key, byte[] data)
        {
            HMAC alg = new System.Security.Cryptography.HMACMD5();
            //设置密钥
            alg.Key = key;
            //计算哈希值
            var hash = alg.ComputeHash(data);
            //返回具有签名的数据（哈希值+数组本身）
            // return hash.Concat(data).ToArray();
            return hash.ToArray();
        }

        /// <summary>
        /// 计算 SHA1 的签名
        /// 根据 http://iot.musmoon.com/apiDoc/toInterfaceDesc
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string SHA1(string source)
        {
            var strRes = Encoding.Default.GetBytes(source);
            HashAlgorithm iSha = new SHA1CryptoServiceProvider();
            strRes = iSha.ComputeHash(strRes);
            var enText = new StringBuilder();
            foreach (byte iByte in strRes)
            {
                enText.AppendFormat("{0:x2}", iByte);
            }
            return enText.ToString();
        }


    }
}
