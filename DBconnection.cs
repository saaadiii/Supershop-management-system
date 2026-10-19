using System;
using System.Collections.Generic;
using System.Text;
namespace Supershop
{
    internal class DBconnection
    {
        private string connStr;

        public string myconnection()
        {
            connStr = @"Data Source=Sadia\SQLEXPRESS;Initial Catalog=Supershop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            return connStr;
        }
    }
}

