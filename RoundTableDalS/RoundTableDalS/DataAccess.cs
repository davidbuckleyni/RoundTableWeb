using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
namespace RoundTableDal
{
   public  class SQLSetup
    {

        public SqlDbType ColumnType { get; set; }

        public enum DatabaseType
        {
            SqlServer =1,
            Oracle = 2,
         
        }

        public void AddCustomField(string tableName,string FieldName,SqlDbType ColumnType,int DataSize)
        {






        }




    }
}
