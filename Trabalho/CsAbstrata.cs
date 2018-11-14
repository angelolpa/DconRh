using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public abstract class CsAbstrata
    {
        private string _sqlCommand;

        public string SqlCommand { get => _sqlCommand; set => _sqlCommand = value; }

        public abstract void InsertObjTrans(object objTrans);
        public abstract void UpdateObjTrans(object objTrans);
        public abstract void DeleteObjTrans(object objTrans);
        public abstract void SeacherObjTrans(string where);
    }
}
