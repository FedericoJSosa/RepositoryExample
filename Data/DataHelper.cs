using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample.Data
{
    public class DataHelper
    {
        private static DataHelper _instancia;
        private SqlConnection _connection;
        private DataHelper()
        {
            _connection = new SqlConnection(Properties.Resources.cnnString);
        }
        public static DataHelper GetInstance()
        {
            if (_instancia == null)
            {
                _instancia = new DataHelper();
            }
            return _instancia;
        }
        public DataTable ExecuteSPQuery(string sp)
        {
            DataTable dt = new DataTable();
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(sp, _connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dt.Load(cmd.ExecuteReader());
                _connection.Close();
            }
            catch (Exception)
            {
                dt = null;
            }

            return dt;
        }
    }
}
