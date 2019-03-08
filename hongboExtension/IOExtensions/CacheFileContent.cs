using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using hongbao.IOExtension;

namespace hongbao.IOExtension
{
    /// <summary>
    /// 缓存的文件内容定义;
    /// </summary>
    public class CacheFileContent
    {
        /// <summary>
        /// 文件保存的位置;
        /// </summary>
        protected string filePath = null;

        /// <summary>
        /// 
        /// </summary>
        public CacheFileContent()
        {

        }
        
        /// <summary>
        /// 设置文件路径
        /// </summary>
        /// <param name="filePath"></param>
        public void  SetFilePath(string filePath)
        {
            this.filePath = filePath;
            ReadFileContent();
        }

        /// <summary>
        /// 检查是否被其他进程更新了文件内容
        /// </summary>
        public bool CheckRefresh()
        {
            FileInfo fi = new FileInfo(filePath);
            return (fi.Exists && fi.LastWriteTime > this.UpdateDatetime);
        }
        /// <summary>
        /// 读取文件内容
        /// </summary>
        public virtual void ReadFileContent()
        {
            FileInfo fi = new FileInfo(filePath);
            if (fi.Exists)
            {
                Content = FileUtil.ReadUTFFileContent(filePath);
                ValidateContent(Content);
                UpdateDatetime = fi.LastWriteTime;
                FormatedContent = FormatContent(Content);
            }
        }

        /// <summary>
        /// 计算有效播放的JAVASCRIPT脚本的内容;
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 内容可能需要进行格式化;此字段存放格式化的文件内容;
        /// </summary>
        public string FormatedContent { get; set; }

        /// <summary>
        /// 最后更新时间;
        /// </summary>
        public DateTime? UpdateDatetime { get; set; }

        /// <summary>
        /// 错误信息;如果文件内容错误时,请设置此字段表示错误信息;
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 设置内容;
        /// </summary>
        /// <param name="content"></param>
        public virtual void SetContent(string content)
        {
            try
            {
                FormatedContent = FormatContent(content);
                ValidateContent(FormatedContent);
                if (new FileInfo(filePath).Exists)
                {
                    File.Move(filePath, filePath + DateTime.Now.ToString("yyyyMMddHHmmss"));
                }                
                FileUtil.WriteUTF8File(filePath, content);
                string formatFilePath = filePath + ".format";
                if (new FileInfo(formatFilePath).Exists)
                {
                    File.Move(formatFilePath, formatFilePath + DateTime.Now.ToString("yyyyMMddHHmmss"));
                }
                FileUtil.WriteUTF8File(formatFilePath, FormatedContent);
                Content = content;
                UpdateDatetime = DateTime.Now;
                ErrorMessage = null;
            }
            catch (Exception exp)
            {
                ErrorMessage = exp.Message;
            }
        }

        /// <summary>
        /// 验证内容是否有效;可能抛出异常;
        /// </summary>
        protected virtual void ValidateContent(string content)
        {

        }

        /// <summary>
        /// 格式化内容;默认下返回原始内容;
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public virtual string FormatContent(string content)
        {
            return content;
        }
    }
}