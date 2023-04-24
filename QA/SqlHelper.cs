using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Net.Http;

namespace QA
{
    public static class SqlHelper
    {
        public static string ServerUrl = "http://127.0.0.1:18800/api/webapi";
        public static string user_no = "";
        public static string user_name = "";


        /// <summary>
        /// RtxStr To Byte[] 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] RtxToBytes(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return default;
            else
            {
                try
                {
                    return Encoding.UTF8.GetBytes(str);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return default;
                }
            }
        }

        public static string ToJsonString(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static dynamic ToDynamic(this string str)
        {
            return JsonConvert.DeserializeObject<dynamic>(str);
        }


        /// <summary>
        /// OBJ To String
        /// </summary>
        /// <param name="byt"></param>
        /// <returns></returns>
        public static string RtxBytesToString(this object obj)
        {
            if (obj is byte[])
            {
                if (obj == default)
                    return default;
                else
                {
                    try
                    {
                        return Encoding.UTF8.GetString((byte[])obj);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        return null;
                    }
                }
            }
            return default;
        }

        public static DataTable EQ(this string strSql, object Params = null)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable EQ(this string strSql, Dictionary<string, object> Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable EQ(this string strSql, List<(string, object)> Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable EQ(this string strSql, List<(string, object, string)> Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable EQ(this string strSql, params (string, object)[] Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static DataTable EQ(this string strSql, params (string, object, string)[] Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<DataTable>(ResultsJson);

            return Result;
        }

        public static List<dynamic> EQListDynamic(this string strSql, object Params = null)
        {
            List<dynamic> Result = new List<dynamic>();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<List<dynamic>>(ResultsJson);

            return Result;
        }

        public static List<dynamic> EQListDynamic(this string strSql, Dictionary<string, object> Params)
        {
            List<dynamic> Result = new List<dynamic>();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<List<dynamic>>(ResultsJson);

            return Result;
        }

        public static List<dynamic> EQListDynamic(this string strSql, List<(string, object)> Params)
        {
            List<dynamic> Result = new List<dynamic>();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<List<dynamic>>(ResultsJson);

            return Result;
        }

        public static List<dynamic> EEQListDynamicQ(this string strSql, List<(string, object, string)> Params)
        {
            List<dynamic> Result = new List<dynamic>();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<List<dynamic>>(ResultsJson);

            return Result;
        }

        public static List<dynamic> EQListDynamic(this string strSql, params (string, object)[] Params)
        {
            List<dynamic> Result = new List<dynamic>();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<List<dynamic>>(ResultsJson);

            return Result;
        }

        public static List<dynamic> EQListDynamic(this string strSql, params (string, object, string)[] Params)
        {
            List<dynamic> Result = new List<dynamic>();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            var ResultsJson = webClient.UploadString($@"{ServerUrl}/EQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));

            Result = JsonConvert.DeserializeObject<List<dynamic>>(ResultsJson);

            return Result;
        }

        public static void ENQ(this string strSql, object Params = null)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString($@"{ServerUrl}/ENQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));
        }

        public static void ENQ(this string strSql, Dictionary<string, object> Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString($@"{ServerUrl}/ENQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));
        }

        public static void ENQ(this string strSql, List<(string, object)> Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString($@"{ServerUrl}/ENQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));
        }

        public static void ENQ(this string strSql, List<(string, object, string)> Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString($@"{ServerUrl}/ENQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));
        }

        public static void ENQ(this string strSql, params (string, object)[] Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString($@"{ServerUrl}/ENQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));
        }

        public static void ENQ(this string strSql, params (string, object, string)[] Params)
        {
            DataTable Result = new DataTable();

            WebClient webClient = new WebClient();
            webClient.Headers["Accept"] = "application/json";
            webClient.Headers["Content-Type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString($@"{ServerUrl}/ENQ", JsonConvert.SerializeObject(new { strSql = strSql, Params = Params }));
        }

        public static string UploadFile(this byte[] Bytes, string FileName)
        {
            var hc = new HttpClient(new HttpClientHandler { ServerCertificateCustomValidationCallback = delegate { return true; } });
            var fd = new MultipartFormDataContent();

            var Key = Guid.NewGuid().ToString();
            fd.Add(new ByteArrayContent(Bytes), Key, FileName);
            fd.Add(new StringContent(JsonConvert.SerializeObject(new
            {
                //AbsolutePath = "",
                //RelativePath = "",
                //FileName = "2.jpg"
            }), Encoding.UTF8), Key);

            var Results = JsonConvert.DeserializeObject<Dictionary<string, object>>(hc.PostAsync($@"{ServerUrl}/UploadFile", fd).Result.Content.ReadAsStringAsync().Result);
            var SavePath = Convert.ToString(Results[Key]);

            return SavePath;
        }
    }
}
