using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContact
{
    public class Db
    {
        private string _conStr;
        public SqlConnection SqlConnection;

        public Food Food;

        public TypeProducts Types;

        public ColorProducts Colors;


        public Db(string connectionString)
        {
            _conStr = connectionString;
            Food = new Food(this);
            Types = new TypeProducts(this);
            Colors = new ColorProducts(this);
        }

        public void ConnectionToDb()
        {
            SqlConnection = new SqlConnection(_conStr);
            SqlConnection.Open();
        }

        public void DisconnectionToDb()
        {
            SqlConnection.Close();
        }
    }
}
