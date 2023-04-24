using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    public static class SqlHelper
    {
        /// <summary>
        /// 会运行的方法在WebApiController
        /// </summary>
        public static string strConn = "server=.;uid=sa;pwd=sa;database=LemonQA";

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public static DataTable ExecuteQuery(string strSql)
        {
            DataTable Result = new DataTable();

            var conn = new SqlConnection(strConn);
            var dba = new SqlDataAdapter(strSql, conn);

            conn.Open();

            dba.Fill(Result);

            conn.Close();

            return Result;
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="strSql"></param>
        public static void ExecuteNonQuery(string strSql)
        {
            var conn = new SqlConnection(strConn);
            var cmd = new SqlCommand(strSql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataTable ExecuteQuery(this string strSql, Dictionary<string, object> Params = null)
        {
            var Result = new DataTable();

            var dba = new SqlDataAdapter(strSql, strConn);
            var cmd = dba.SelectCommand;
            if (Params != null)
            {
                foreach (var item in Params)
                {
                    var Key = item.Key;
                    var Value = item.Value;
                    var ValueType = Value.GetType().FullName;

                    if (Value == null)
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else if (ValueType == typeof(byte[]).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, DBNull.Value);
                        }
                    }
                    else
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            var img = (Image)Value;
                            byte[] PhotoBytes = null;
                            if (img != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    img.Save(ms, ImageFormat.Bmp);
                                    PhotoBytes = ms.ToArray();
                                }
                            }

                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = PhotoBytes;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, Value);
                        }
                    }
                }
            }
            dba.Fill(Result);

            return Result;
        }

        public static DataTable ExecuteQuery(this string strSql, object Params = null)
        {
            var Result = new DataTable();

            var dba = new SqlDataAdapter(strSql, strConn);
            var cmd = dba.SelectCommand;
            if (Params != null)
            {
                foreach (var item in Params.GetType().GetProperties())
                {
                    var Key = item.Name;
                    var Value = item.GetValue(Params);
                    var ValueType = item.PropertyType.FullName;

                    if (Value == null)
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else if (ValueType == typeof(byte[]).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, DBNull.Value);
                        }
                    }
                    else
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            var img = (Image)Value;
                            byte[] PhotoBytes = null;
                            if (img != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    img.Save(ms, ImageFormat.Bmp);
                                    PhotoBytes = ms.ToArray();
                                }
                            }

                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = PhotoBytes;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, Value);
                        }
                    }
                }
            }
            dba.Fill(Result);

            return Result;
        }

        public static DataTable ExecuteQuery(this string strSql, List<(string, object)> Params = null)
        {
            var Result = new DataTable();

            var dba = new SqlDataAdapter(strSql, strConn);
            var cmd = dba.SelectCommand;
            if (Params != null)
            {
                foreach (var item in Params)
                {
                    var Key = item.Item1;
                    var Value = item.Item2;
                    var ValueType = Value.GetType().FullName;

                    if (Value == null)
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else if (ValueType == typeof(byte[]).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, DBNull.Value);
                        }
                    }
                    else
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            var img = (Image)Value;
                            byte[] PhotoBytes = null;
                            if (img != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    img.Save(ms, ImageFormat.Bmp);
                                    PhotoBytes = ms.ToArray();
                                }
                            }

                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = PhotoBytes;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, Value);
                        }
                    }
                }
            }
            dba.Fill(Result);

            return Result;
        }

        public static DataTable ExecuteQuery(this string strSql, List<(string, object, string)> Params = null)
        {
            var Result = new DataTable();

            var dba = new SqlDataAdapter(strSql, strConn);
            var cmd = dba.SelectCommand;
            if (Params != null)
            {
                foreach (var item in Params)
                {
                    var Key = item.Item1;
                    var Value = item.Item2;
                    var ValueType = item.Item3;

                    if (Value == null)
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else if (ValueType == typeof(byte[]).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, DBNull.Value);
                        }
                    }
                    else
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            var img = (Image)Value;
                            byte[] PhotoBytes = null;
                            if (img != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    img.Save(ms, ImageFormat.Bmp);
                                    PhotoBytes = ms.ToArray();
                                }
                            }

                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = PhotoBytes;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, Value);
                        }
                    }
                }
            }
            dba.Fill(Result);

            return Result;
        }

        public static DataTable ExecuteQuery(this string strSql, params (string, object)[] Params)
        {
            var Result = new DataTable();

            var dba = new SqlDataAdapter(strSql, strConn);
            var cmd = dba.SelectCommand;
            if (Params != null)
            {
                foreach (var item in Params)
                {
                    var Key = item.Item1;
                    var Value = item.Item2;
                    var ValueType = Value.GetType().FullName;

                    if (Value == null)
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else if (ValueType == typeof(byte[]).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, DBNull.Value);
                        }
                    }
                    else
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            var img = (Image)Value;
                            byte[] PhotoBytes = null;
                            if (img != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    img.Save(ms, ImageFormat.Bmp);
                                    PhotoBytes = ms.ToArray();
                                }
                            }

                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = PhotoBytes;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, Value);
                        }
                    }
                }
            }
            dba.Fill(Result);

            return Result;
        }

        public static DataTable ExecuteQuery(this string strSql, params (string, object, string)[] Params)
        {
            var Result = new DataTable();

            var dba = new SqlDataAdapter(strSql, strConn);
            var cmd = dba.SelectCommand;
            if (Params != null)
            {
                foreach (var item in Params)
                {
                    var Key = item.Item1;
                    var Value = item.Item2;
                    var ValueType = item.Item3;

                    if (Value == null)
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else if (ValueType == typeof(byte[]).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, DBNull.Value);
                        }
                    }
                    else
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            var img = (Image)Value;
                            byte[] PhotoBytes = null;
                            if (img != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    img.Save(ms, ImageFormat.Bmp);
                                    PhotoBytes = ms.ToArray();
                                }
                            }

                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = PhotoBytes;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, Value);
                        }
                    }
                }
            }
            dba.Fill(Result);

            return Result;
        }

        public static void ExecuteNonQuery(this string strSql, Dictionary<string, object> Params = null)
        {
            var conn = new SqlConnection(strConn);
            conn.Open();

            var cmd = new SqlCommand(strSql, conn);
            if (Params != null)
            {
                foreach (var item in Params)
                {
                    var Key = item.Key;
                    var Value = item.Value;
                    var ValueType = Value.GetType().FullName;

                    if (Value == null)
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else if (ValueType == typeof(byte[]).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, DBNull.Value);
                        }
                    }
                    else
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            var img = (Image)Value;
                            byte[] PhotoBytes = null;
                            if (img != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    img.Save(ms, ImageFormat.Bmp);
                                    PhotoBytes = ms.ToArray();
                                }
                            }

                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = PhotoBytes;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, Value);
                        }
                    }
                }
            }
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void ExecuteNonQuery(this string strSql, object Params = null)
        {
            var conn = new SqlConnection(strConn);
            conn.Open();

            var cmd = new SqlCommand(strSql, conn);
            if (Params != null)
            {
                foreach (var item in Params.GetType().GetProperties())
                {
                    var Key = item.Name;
                    var Value = item.GetValue(Params);
                    var ValueType = item.PropertyType.FullName;

                    if (Value == null)
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else if (ValueType == typeof(byte[]).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, DBNull.Value);
                        }
                    }
                    else
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            var img = (Image)Value;
                            byte[] PhotoBytes = null;
                            if (img != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    img.Save(ms, ImageFormat.Bmp);
                                    PhotoBytes = ms.ToArray();
                                }
                            }

                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = PhotoBytes;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, Value);
                        }
                    }
                }
            }
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void ExecuteNonQuery(this string strSql, List<(string, object)> Params = null)
        {
            var conn = new SqlConnection(strConn);
            conn.Open();

            var cmd = new SqlCommand(strSql, conn);
            if (Params != null)
            {
                foreach (var item in Params)
                {
                    var Key = item.Item1;
                    var Value = item.Item2;
                    var ValueType = Value.GetType().FullName;

                    if (Value == null)
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else if (ValueType == typeof(byte[]).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, DBNull.Value);
                        }
                    }
                    else
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            var img = (Image)Value;
                            byte[] PhotoBytes = null;
                            if (img != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    img.Save(ms, ImageFormat.Bmp);
                                    PhotoBytes = ms.ToArray();
                                }
                            }

                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = PhotoBytes;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, Value);
                        }
                    }
                }
            }
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void ExecuteNonQuery(this string strSql, List<(string, object, string)> Params = null)
        {
            var conn = new SqlConnection(strConn);
            conn.Open();

            var cmd = new SqlCommand(strSql, conn);
            if (Params != null)
            {
                foreach (var item in Params)
                {
                    var Key = item.Item1;
                    var Value = item.Item2;
                    var ValueType = item.Item3;

                    if (Value == null)
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else if (ValueType == typeof(byte[]).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, DBNull.Value);
                        }
                    }
                    else
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            var img = (Image)Value;
                            byte[] PhotoBytes = null;
                            if (img != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    img.Save(ms, ImageFormat.Bmp);
                                    PhotoBytes = ms.ToArray();
                                }
                            }
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = PhotoBytes;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, Value);
                        }
                    }
                }
            }
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void ExecuteNonQuery(this string strSql, params (string, object)[] Params)
        {
            var conn = new SqlConnection(strConn);
            conn.Open();

            var cmd = new SqlCommand(strSql, conn);
            if (Params != null)
            {
                foreach (var item in Params)
                {
                    var Key = item.Item1;
                    var Value = item.Item2;
                    var ValueType = Value.GetType().FullName;

                    if (Value == null)
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else if (ValueType == typeof(byte[]).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, DBNull.Value);
                        }
                    }
                    else
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            var img = (Image)Value;
                            byte[] PhotoBytes = null;
                            if (img != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    img.Save(ms, ImageFormat.Bmp);
                                    PhotoBytes = ms.ToArray();
                                }
                            }

                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = PhotoBytes;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, Value);
                        }
                    }
                }
            }
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void ExecuteNonQuery(this string strSql, params (string, object, string)[] Params)
        {
            var conn = new SqlConnection(strConn);
            conn.Open();

            var cmd = new SqlCommand(strSql, conn);
            if (Params != null)
            {
                foreach (var item in Params)
                {
                    var Key = item.Item1;
                    var Value = item.Item2;
                    var ValueType = item.Item3;

                    if (Value == null)
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else if (ValueType == typeof(byte[]).FullName)
                        {
                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, DBNull.Value);
                        }
                    }
                    else
                    {
                        if (ValueType == typeof(Image).FullName)
                        {
                            var img = (Image)Value;
                            byte[] PhotoBytes = null;
                            if (img != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    img.Save(ms, ImageFormat.Bmp);
                                    PhotoBytes = ms.ToArray();
                                }
                            }

                            cmd.Parameters.Add(Key, SqlDbType.Image).Value = PhotoBytes;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(Key, Value);
                        }
                    }
                }
            }
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
