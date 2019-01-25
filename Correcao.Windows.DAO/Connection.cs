using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;

namespace Correcao.Windows.DAO
{
    public static class Connection
    {
        public static SqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Cesgranrio"].ToString();

            return new SqlConnection(connStr);
        }

        public static SqlCommand GetCommand(CommandType cmdType, string cmdText, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.CommandType = cmdType;

            return cmd;
        }
    }
}
