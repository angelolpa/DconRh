using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataBase;
using System.Data.OleDb;

namespace DconRh
{
    public partial class Form1 : Form
    {
        CsConnection csConnection = new CsConnection();

        public Form1()
        {
            InitializeComponent();
        }
        private void Connect()
        {

            csConnection.OpenConnection();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            string select = "INSERT INTO funcao(nome, descricao) VALUES(@nome, @desc)";

            OleDbCommand oleDbCommand = new OleDbCommand(select, csConnection.GetOleDbConnection());
            oleDbCommand.Parameters.AddWithValue("@nome",TxtNomeFuncao.Text);
            oleDbCommand.Parameters.AddWithValue("@desc", TxtDesc.Text);

            try
            {
                csConnection.GetOleDbConnection().Open();
                oleDbCommand.ExecuteNonQuery();

                TxtNomeFuncao.Clear();
                TxtDesc.Clear();


            }
            catch(Exception Er404)
            {
                MessageBox.Show(Er404.Message);
            }


        }
    }
}
