using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsFormsApp2
{
    public class MySqlSdk
    {
        private readonly MySqlConnection _objcon;
        public MySqlSdk()
        {
            _objcon = new MySqlConnection("server=localhost;port=3306;User Id=root; database=aircooled; password=master");
        }

        public bool IsOpen()
        {
            if (_objcon.State == ConnectionState.Closed)
            {
                return false;
            }
            return true;
        }


        public bool Open()
        {
            try
            {
                if(_objcon.State == ConnectionState.Closed)
                {
                    _objcon.Open();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                if (_objcon.State == ConnectionState.Open)
                {
                    _objcon.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public DataTable Command(String sql)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, _objcon);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataRow CommandRow(String sql)
        {
            try
            {
                return Command(sql).Rows[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
