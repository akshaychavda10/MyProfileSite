using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CSASPNETResumeDownload2012
{
    /// <summary>
    /// Summary description for DownloadHttpHandler
    /// </summary>
    public class DownloadHttpHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string filePath = ConfigurationManager.AppSettings["FilePath"];
            Downloader.DownloadFile(context, filePath);
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}