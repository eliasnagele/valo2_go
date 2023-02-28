using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SWP_Jahresprojekt
{
    internal class SQLInformation
    {
        public static SqlConnection conn = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; Integrated Security = true;");
        public static SqlCommand cmd = new SqlCommand("", conn);
        public static List<string> tables = new List<string>();
        


        public static void CreateDB()
        {
            try
            {
                conn.Open();
                cmd.CommandText = "select count(*) from sys.databases where name = 'valo2_go'";
                bool exists = cmd.ExecuteScalar().ToString().Equals("0") ? false : true;
                conn.Close();

                if (!exists)
                {
                    conn.Open();
                    cmd.CommandText = "create database valo2_go";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    conn.ConnectionString += " database = valo2_go;";

                    CreateTables();
                }
                else
                {
                    conn.ConnectionString += " database = valo2_go;";
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public static void CreateTables()
        {
            try
            {
                conn.Open();
                cmd.CommandText = "create table bundles (ID int not null primary key identity, Name nvarchar(100), Price int, Rarity nvarchar(100), Date nvarchar(100), Variants nvarchar(100))";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "create table skins (ID int not null primary key identity, Name nvarchar(100), Price int, Rarity nvarchar(100), Bundle-ID int)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "create table competition (ID int not null primary key identity, Name nvarchar(100), PriceMoney int, FinalTeam1 nvarchar(100), FinalTeam2 nvarchar(100), Result nvarchar(100), Winner nvarchar(100), Date nvarchar(100))";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public static void ReadTables()
        {
            conn.Open();
            cmd.CommandText = "select * from sys.tables;";
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string item = reader[0].ToString();
                    tables.Add(item);
                }
            }
            conn.Close();
        }

        public static void FillDTV(string table)
        {
            conn.Open();

            conn.Close();
        }
    }
}
