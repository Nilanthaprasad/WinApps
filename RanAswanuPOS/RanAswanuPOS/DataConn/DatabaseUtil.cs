using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanAswanuPOS.DataConn
{
    class DatabaseUtil
    {
        public static String getSelectAllwithANDStatement(String tableName, String [] arguments)
        {
            String sql = "SELECT * FROM " + tableName + " WHERE ";
            int i = 0;
            while(i< arguments.Length)
            {
                if(i != arguments.Length-1)
                {
                    sql += arguments[i] + "=" + DataDictionary.getParameterOf(arguments[i]) + " AND ";
                   
                }
                else
                {
                    sql += arguments[i] + "=" + DataDictionary.getParameterOf(arguments[i]);
                }
                
                i++;
            }
            return sql;
        }

        public static String getSelectStatementWithColumns(String tableName, String [] columns)
        {
            String sql = "SELECT ";
            int i = 0;
            while (i < columns.Length)
            {
                if (i != columns.Length - 1)
                {
                    sql += columns[i] + ", ";

                }
                else
                {
                    sql += columns[i] + " FROM " + tableName ;
                }

                i++;
            }
            return sql;
        }

        public String getSelectORStatement()
        {
            return "";
        }

    }
}
