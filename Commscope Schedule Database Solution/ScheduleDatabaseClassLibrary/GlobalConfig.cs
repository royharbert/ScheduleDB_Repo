
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ScheduleDatabaseClassLibrary;
using System.Data.SqlClient;
using ScheduleDatabaseClassLibrary.DataAccess;

namespace ScheduleDatabaseClassLibrary
{
    public static class GlobalConfig
    {
        public static DatabaseType DatabaseMode = DatabaseType.Sandbox;
        public static string AttachmentPath = "";
        public static IDataConnection Connection { get; private set; }
        
        public static void InitializeConnection(DatabaseType db)
        { 
            if (db == DatabaseType.Live)
            {
                SqlConnector.db = "Live";
                SqlConnector LiveConnection = new SqlConnector();
                Connection = LiveConnection;
                AttachmentPath = "\\" + "\\USCA5PDBATDGS01\\Databases\\AttcacmentsSchedule";
            }
            else if (db == DatabaseType.Sandbox)
            {
                SqlConnector.db = "Sandbox";
                SqlConnector SandboxConnection = new SqlConnector();
                Connection = SandboxConnection;
                AttachmentPath = "\\" + "\\USCA5PDBATDGS01\\Databases\\Sandbox\\AttachmentsSchedule";
            }
        }

        public static void SetDatabaseMode(DatabaseType mode)
        {
            if (mode == DatabaseType.Live)
            {
                GlobalConfig.InitializeConnection(DatabaseType.Live);
                GlobalConfig.AttachmentPath = "\\" + "\\USCA5PDBATDGS01\\Databases\\AttachmentsSchedule";
                DatabaseMode = DatabaseType.Live;
            }
            else
            {
                GlobalConfig.InitializeConnection(DatabaseType.Sandbox);
                GlobalConfig.AttachmentPath = "\\" + "\\USCA5PDBATDGS01\\Databases\\Sandbox\\AttachmentsSchedule";
                DatabaseMode = DatabaseType.Sandbox;
            }
        }

        public static String ConnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppKeyLookup(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

       
    }
}
