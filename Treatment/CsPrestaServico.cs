using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DataBase;
using Objects;

namespace Treatment
{
    public class CsPrestaServico
    {
        private CsPrestaServico csPrestaServico;
        private CsCollectionPrestaServico csPrestaServicos;
        private CsCommand csCommand;
        private CsConnection csConnection;

        public void CsPrestaServicoParameterColletion_Create(CommandType commandType, string oleDbCommand, CsPrestaServico csPrestaServico)
        {
            csConnection = CsConnection.GetCsConnection();
            
            csCommand.Para
        }
    }

}
