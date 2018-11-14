using System.Data.OleDb;
using System.Data;

namespace DataBase
{
    public class CsConnection
    {

        #region Singleton
        public static CsConnection csConnection;

        private OleDbConnection oleDbConnection = Connection();

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
            return new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\LordYakefu\source\repos\angelolpa\DconRh\Database.mdb");
        }
        #endregion

        #region Public Method's
        public OleDbConnection GetOleDbConnection()
        {
            return oleDbConnection;
        }
        public bool OpenConnection()
        {
            if (!(GetOleDbConnection().State == ConnectionState.Open))
            {
                try
                {
                    oleDbConnection.Open();
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
        public bool CloseConnection()
        {
            if (!(oleDbConnection.State == ConnectionState.Closed))
            {
                try
                {
                    oleDbConnection.Close();
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
