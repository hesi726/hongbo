﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.DrawingExtension
{
    /// <summary>
    /// 视频的工具类； 
    /// </summary>
    public static class MovieUtil
    {
        /// <summary>
        /// 获取视频文件长度； 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static int GetMediaTimeLenSecond(string pathToVideoFile)
        {
            try
            {
                var ffProbe = new NReco.VideoInfo.FFProbe();
                var videoInfo = ffProbe.GetMediaInfo(pathToVideoFile);
                return (int) videoInfo.Duration.TotalSeconds;
            }
            catch (Exception ex)
            {
                string xx = ex.Message;
                return 0;
            }
        }
    }
}