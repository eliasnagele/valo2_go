using System;
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
        public static string NTourName, PriceMoney, FinalTeam1, FinalTeam2, Result, Winner, Date, Lan, Place;
        public static string BundleName, BundlePrice, BundleRarity, BundleDate, BundleVariants;

        public static void CreateDB()           //checking if the database already exists; creating db if it doesn`t
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

        public static void CreateTables()       //creating all the tables
        {
            try
            {
                conn.Open();
                cmd.CommandText = "create table bundles (ID int not null primary key identity, BundleNumber int not null, Name nvarchar(100), Price int, Rarity nvarchar(100), Date nvarchar(100), Variants nvarchar(100))";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "create table skins (ID int not null primary key identity, Name nvarchar(100), Price int, Rarity nvarchar(100), BundleID int)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "create table competition (ID int not null primary key identity, CompetitionNumber int not null, Name nvarchar(100), PriceMoney int, FinalTeam1 nvarchar(100), FinalTeam2 nvarchar(100), Result nvarchar(100), Winner nvarchar(100), Date nvarchar(100), Lan int, Place nvarchar(100))";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "create table login (ID int not null primary key identity, Username nvarchar(100), Password nvarchar(100), Admin int);";
                cmd.ExecuteNonQuery();
                conn.Close();

                TestData();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public static void ReadTables()         //saving all tables to a list; list is used for the editing the tables
        {
            try
            {
                tables.Clear();

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static DataTable FillDTV(string table)       //fills the datatable which is then used to edit the tables
        {
            try
            {
                conn.Open();
                dt.Clear();
                dt.Columns.Clear();
                cmd.CommandText = "select * from " + table;
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dt;
            }
        }

        public static void SaveTableChanges()       //saving the changes made to a table
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlDataAdapter.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void SkinsshowAll(DataTable dt)       //show the data from the table 'skins'
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

        public static void BundlesShowAll(DataTable dt)     //show the data from the table 'bundles'
        {
            try
            {
                conn.Close();
                conn.Open();
                cmd.CommandText = "select * from bundles";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void AddUser(string username, string password)        //add a new user; hash the password
        {
            string salt = BCrypt.GenerateSalt();
            string hashedpassword = BCrypt.HashPassword(password, salt);

            try
            {
                conn.Close();
                conn.Open();
                cmd.CommandText = "insert into login(Username, Password) values ('" + username + "', '" + hashedpassword + "');";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void tournamentShowAll(DataTable dt)      //show the data from the table 'competition'
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

        public static void newTourNfill()           //get the data from the most recent competition
        {
            try
            {
                conn.Open();
                cmd.CommandText = "Select Name from competition";
                NTourName = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "Select PriceMoney from competition";
                PriceMoney = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "Select FinalTeam1 from competition";
                FinalTeam1 = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "Select FinalTeam2 from competition";
                FinalTeam2 = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "Select Result from competition";
                Result = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "Select Winner from competition";
                Winner = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "Select Date from competition";
                Date = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "Select Lan from competition";
                Lan = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "Select Place from competition";
                Place = cmd.ExecuteScalar().ToString();


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool CheckIfUsernameExists(string username)       //check if the username which the user entered already exists
        {
            bool usernameexist = false;

            try
            {
                conn.Close();
                conn.Open();
                cmd.CommandText = "select * from login where Username = '" + username + "';";
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();

                if (reader.Equals(null))
                    usernameexist = false;
                else
                    usernameexist = true;
                return usernameexist;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return usernameexist;
            } 
        }

        public static bool CheckIfUserIsAdmin(string username)          //check if the user which is logging in is an admin
        {
            bool userisadmin = false;

            try
            {
                conn.Close();
                conn.Open();
                cmd.CommandText = "select Admin from login where Username = '" + username + "';";

                if (cmd.ExecuteScalar().Equals(1))
                    userisadmin = true;

                MessageBox.Show(userisadmin.ToString());
                return userisadmin;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return userisadmin;
            }
        }

        public static bool GetPassword(string username, string password)        //check if the password which the user entered is matching the username
        {
            try
            {
                conn.Close();
                conn.Open();
                cmd.CommandText = "select Password from login where username = '" + username + "';";

                if (BCrypt.CheckPassword(password, cmd.ExecuteScalar().ToString()))
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public static void BundleDetails()          //get the data from the most recent and second most recent bundle
        {

            if (Bundles.BundleID.Equals(1))
            {
                try
                {
                    conn.Open();

                    cmd.CommandText = "select max(BundleNumber) from bundles";
                    int rows = (int)cmd.ExecuteScalar();

                    cmd.CommandText = "select Name from bundles where BundleNumber = " + rows;
                    BundleName = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "select Price from bundles where BundleNumber = " + rows;
                    BundlePrice = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "select Rarity from bundles where BundleNumber = " + rows;
                    BundleRarity = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "select Date from bundles where BundleNumber = " + rows;
                    BundleDate = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "select Variants from bundles where BundleNumber = " + rows;
                    BundleVariants = cmd.ExecuteScalar().ToString();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (Bundles.BundleID.Equals(2))
            {
                try
                {
                    conn.Open();

                    cmd.CommandText = "select max(BundleNumber) from bundles";
                    int rows = (int)cmd.ExecuteScalar();
                    rows--;

                    cmd.CommandText = "select Name from bundles where BundleNumber = " + rows;
                    BundleName = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "select Price from bundles where BundleNumber = " + rows;
                    BundlePrice = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "select Rarity from bundles where BundleNumber = " + rows;
                    BundleRarity = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "select Date from bundles where BundleNumber = " + rows;
                    BundleDate = cmd.ExecuteScalar().ToString();
                    cmd.CommandText = "select Variants from bundles where BundleNumber = " + rows;
                    BundleVariants = cmd.ExecuteScalar().ToString();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }




        public static void TestData()
        {
            string salt = BCrypt.GenerateSalt();
            string hashedpassword = BCrypt.HashPassword("admin", salt);

            try
            {
                conn.Open();
                cmd.CommandText = "insert into bundles values (1, 'Reaver', 7800, 'Epic', '05.11.2019', 'Blue, Red, White, Black')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into bundles values (2, 'Prime', 7800, 'Epic', '17.03.2020', 'Gold, Blue, Orange, Yellow')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into login values ('admin', '" + hashedpassword + "', 1)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into competition (CompetitionNumber, Name, PriceMoney, FinalTeam1, FinalTeam2, Result, Winner, Date, Lan, Place) values (1, 'Test1', 100, 'FinalesTeam1', 'FinalesTeam2', 'Ergebnis', 'Gewinner', 'Datum', 1, 'Ort');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into competition (CompetitionNumber, Name, PriceMoney, FinalTeam1, FinalTeam2, Result, Winner, Date, Lan, Place) values (2, 'Test2', 100, 'FinalesTeam1', 'FinalesTeam2', 'Ergebnis', 'Gewinner', 'Datum', 1, 'Ort');";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }       //data to showcase the program
    }
}
