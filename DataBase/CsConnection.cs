using System;
using System.Data.OleDb;
using System.Data;

namespace DataBase
{
    public class CsConnection
    {
        private static string connectionString;
        private OleDbConnection OleDbConnect = Connection();
        
        #region Singleton
        public static CsConnection csConnection;
        public CsConnection()
        {

        }
        public static CsConnection GetCsConnection()
        {
            if(csConnection == null)
            {
                csConnection = new CsConnection();
            }
            return csConnection;
        }
        #endregion

        #region Private Method's
        private static OleDbConnection Connection()
        {
            connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\angel\source\repos\DconRh\Database.mdb";
            return new OleDbConnection(connectionString);
        }
        #endregion

        #region Public Method's
        public OleDbConnection GetOleDbConnection()
        {
            return OleDbConnect;
        }
        public bool OpenConnection()
        {
            if (!(OleDbConnect.State == ConnectionState.Open))
            {
                try
                {
                    OleDbConnect.Open();
                    throw new Exception("Executado");
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool CloseConnection()
        {
            if (!(OleDbConnect.State == ConnectionState.Closed))
            {
                try
                {
                    OleDbConnect.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

    }
}
