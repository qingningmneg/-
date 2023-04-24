using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using static DevExpress.XtraPrinting.Export.Pdf.PdfImageCache;

namespace QA
{
    internal static class ClassMethod
    {
        public static string ServerUrl = "http://127.0.0.1:18800/api/webapi";

        //客户端其他写法 $@"select * from 表名 where guid = @guid".EQ(("@guid", this.guid));//查询
        //客户端其他写法 $@"delete 表名 where guid = @guid".ENQ(("@guid", this.guid));

        //具体可传类型看SqlHelper,能传的东西很多

        /// <summary>
        /// post 测试方法
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, object> postningmengText()
        {
            Dictionary<string, object> Result = new Dictionary<string, object>();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/postningmengText", JsonConvert.SerializeObject(new { user_no = "这是一个测试POST方法" }));

            Result = JsonConvert.DeserializeObject<Dictionary<string, object>>(ResultsJson);

            return Result;
        }

        /// <summary>
        /// get 测试方法
        /// </summary>
        /// <returns></returns>
        public static void getningmengText()
        {
            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.DownloadString($@"{ServerUrl}/getningmengText");
        }
    }
}
