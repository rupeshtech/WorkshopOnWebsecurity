using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WorkShopOnWebSecurity.Models;

namespace WorkShopOnWebSecurity.Helper
{
    public class SqlHelper
    {
        public static bool Login(SignIn credential)
        {
            using (var conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["hackworkshopsqldb"].ConnectionString))
            {
                var sqlText = "SELECT TOP (1) [Id] ,[UserName] ,[Password] FROM [dbo].[User]  where UserName='"+credential.UserName+"' and [Password]= '"+credential.Password+"'";
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                cmd.CommandText = sqlText;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                conn.Open();

                reader = cmd.ExecuteReader();
                if (reader.HasRows) return true;
            }
            return false;
        }

        internal static void CreateBook(Book book)
        {
            using (var conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["hackworkshopsqldb"].ConnectionString))
            {
                var sqlText = "INSERT INTO [dbo].[Book] ([Name],[Title],[Author],[Comment]) VALUES('"+ book.Name+ "','" + book.Name + "','" + book.Author + "','" + book.Comment + "')";
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                conn.Query<Book>(sqlText);

            }
        }

        public static List<Book> GetBooks()
        {
            using (var conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["hackworkshopsqldb"].ConnectionString))
            {
                var sqlText = "SELECT *  FROM [dbo].[Book]";
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                var result = conn.Query<Book>(sqlText);
                return result.ToList();
            }
            return null;
        }

        internal static Book GetBook(int id)
        {
            using (var conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["hackworkshopsqldb"].ConnectionString))
            {
                var sqlText = "SELECT *  FROM [dbo].[Book]";
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                var result = conn.Query<Book>(sqlText);
                return result.FirstOrDefault(b=>b.Id==id);
            }
        }

        public static void UpdateComment(Book book)
        {
            using (var conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["hackworkshopsqldb"].ConnectionString))
            {
                var sqlText = "UPDATE [dbo].[Book]   SET [Comment] = ' "+book.Comment+ "' WHERE [Id]='" + book.Id+"'";
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                conn.Query<Book>(sqlText);
                
            }
        }
    }
}