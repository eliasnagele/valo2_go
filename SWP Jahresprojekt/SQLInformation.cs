﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SWP_Jahresprojekt
{
    internal class SQLInformation
    {
        public static SqlConnection conn = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; Integrated Security = true;");
        public static SqlCommand cmd = new SqlCommand("", conn);
        public static List<string> tables = new List<string>();
        public static DataTable dt = new DataTable();
        public static string NTourName, PriceMoney;

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
                    conn.Close();
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
                cmd.CommandText = "create table skins (ID int not null primary key identity, Name nvarchar(100), Price int, Rarity nvarchar(100), BundleID int)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "create table competition (ID int not null primary key identity, Name nvarchar(100), PriceMoney int, FinalTeam1 nvarchar(100), FinalTeam2 nvarchar(100), Result nvarchar(100), Winner nvarchar(100), Date nvarchar(100), Lan int, Place nvarchar(100))";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "create table login (ID int not null primary key identity, Username nvarchar(100), Password nvarchar(100), Admin int);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into login (Username, Password, Admin) values ('admin', 'admin', 1);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into competition (Name, PriceMoney, FinalTeam1, FinalTeam2, Result, Winner, Date, Lan, Place) values ('Name', 100, 'FinalesTeam1', 'FinalesTeam2', 'Ergebnis', 'Gewinner', 'Datum', 1, 'Ort');";
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
            conn.Close();
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

        public static DataTable FillDTV(string table)
        {
            conn.Open();
            cmd.CommandText = "select * from " + table;
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            return dt;
        }

        public static void SaveTableChanges()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            sqlDataAdapter.Update(dt);
        }
        public static void SkinsshowAll(DataTable dt)
        {
            try
            {
                conn.Close();
                conn.Open();
                cmd.CommandText = "SELECT * FROM skins";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception ex) { ex.ToString(); }
        }

        public static void AddUser(string username, string password)
        {
            conn.Close();
            conn.Open();
            cmd.CommandText = "insert into login(Username, Password) values ('" + username + "', '" + password + "');";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void tournamentShowAll(DataTable dt)
        {
            try
            {
                conn.Close();
                conn.Open();
                cmd.CommandText = "SELECT * FROM competition";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception ex) { ex.ToString(); }
        }
        public static void newTourNfill()
        {
            try
            {
                conn.Open();
                cmd.CommandText = "Select Name from competition";
                NTourName = cmd.ExecuteNonQuery().ToString();
                
                PriceMoney = cmd.CommandText = "Select PriceMoney from competition";
                conn.Close();


            }catch(Exception ex) { ex.ToString(); }
        }
    }
}
