using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace DataBase
{
    public class CsCommand
    {
        CsConnection csConnection = CsConnection.GetCsConnection();

        private OleDbParameterCollection oleDbParameterCollection = new OleDbCommand().Parameters;
        private OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
        private OleDbDataReader oleDbDataReader;
        private DataTable dataTable = new DataTable();

        #region Operations CsDataBase
        public object ExecuteCommandNonQuery(CommandType commandType, string command)
        {
            try
            {
                csConnection.OpenConnection();

                // Cria o objeto
                OleDbCommand oleDbCommand = csConnection.GetOleDbConnection().CreateCommand();
                oleDbCommand.CommandType = commandType;
                oleDbCommand.CommandText = command;
                // Adiciona parametros
                foreach (OleDbParameter OleDbParameter in oleDbParameterCollection)
                {
                    oleDbCommand.Parameters.Add(new OleDbParameter(OleDbParameter.ParameterName, OleDbParameter.Value));
                }

                return oleDbCommand.ExecuteNonQuery();
            }
            catch (Exception Er404)
            {
                throw new Exception(Er404.Message);
            }
            finally
            {
                csConnection.CloseConnection();
            }
        }

        public DataTable ExecuteCommandConsult(CommandType commandType, string command)
        {
            try
            {
                csConnection.OpenConnection();
                // Cria o objeto 
                OleDbCommand oleDbCommand = csConnection.GetOleDbConnection().CreateCommand();
                oleDbCommand.CommandType = commandType;
                oleDbCommand.CommandText = command;
                // Adiciona parametros
                foreach (OleDbParameter oleDbParameter in oleDbParameterCollection)
                {
                    oleDbCommand.Parameters.Add(new OleDbParameter(oleDbParameter.ParameterName, oleDbParameter.Value));
                }

                oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
                dataTable = new DataTable();
                // Preenche a Tabela de dados
                oleDbDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception Er404)
            {
                throw new Exception(Er404.Message);
            }
            finally
            {
                csConnection.CloseConnection();
            }
        }
        //
        //
        //
        public OleDbDataReader ExecuteReader(CommandType commandType, string command)
        {
            try
            {
                csConnection.OpenConnection();
                // Cria o objeto 
                OleDbCommand oleDbCommand = csConnection.GetOleDbConnection().CreateCommand();
                oleDbCommand.CommandType = commandType;
                oleDbCommand.CommandText = command;
                // Adiciona parametros
                foreach (OleDbParameter oleDbParameter in oleDbParameterCollection)
                {
                    oleDbCommand.Parameters.Add(new OleDbParameter(oleDbParameter.ParameterName, oleDbParameter.Value));
                }
                oleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.CloseConnection);

                return oleDbDataReader;
            }
            catch (Exception Er404)
            {
                throw new Exception(Er404.Message);
            }
            finally
            {
                csConnection.CloseConnection();
            }
        }
        #endregion
    }
}
