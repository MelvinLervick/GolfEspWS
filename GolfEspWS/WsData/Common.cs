using System.Configuration;
using System.Data;

namespace GolfEspWS.WsData
{
    public static class Common
    {
        public static DataTable GetAllTableData( string tableName )
        {
            var database = new AccessDatabase(ConfigurationManager.AppSettings["PROVIDER"],
                ConfigurationManager.AppSettings["DSN"]);
            database.LoadAllTableData(tableName);
            
            return database.DbDataSet.Tables[tableName];
        }
    }
}