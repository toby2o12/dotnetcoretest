using System;
using Dapper;

namespace dotnetcoretest {
    class Program {
        static void Main (string[] args) {
            string connString = "";
            using (var conn = new MySql.Data.MySqlClient.MySqlConnection ("server=192.168.255.128;User Id=root;password=root;Database=testdb"))
            {
                conn.Open();
                string sql="select count(1) from tb_user";
                int count=conn.QueryFirst<int>(sql);
            }
            Console.WriteLine ("Hello World!");
        }
    }
}