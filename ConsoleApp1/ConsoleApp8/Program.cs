using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"Data Source = (DESCRIPTION =
                (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
                (CONNECT_DATA =
                (SERVER = DEDICATED)
                (SERVICE_NAME = topcredu)
                )
                ); User Id = scott;Password = tiger; Provider = OraOleDB.Oracle";//오라클클라이언트를 안깔았을때
            //string str = "data source=topcredu; user id=scott; password=tiger";
            OleDbConnection Conn = new OleDbConnection(str);
            OleDbCommand Comm;
            Comm = new OleDbCommand();
            Comm.Connection = Conn;
            try
            {
                Conn.Open();
                Comm.CommandText = "SELECT ENAME FROM EMP";
                OleDbDataReader reader = Comm.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(reader.GetOrdinal("ENAME")));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
   
