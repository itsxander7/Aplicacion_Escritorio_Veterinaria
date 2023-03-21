using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Aplicacion_Escritorio_Veterinaria.BBDD
{
    public class cls_BBDD_DAL
    {

        #region Variables Privadas

        private SqlConnection _obj_Sqlcnx;
        private SqlDataAdapter _obj_Sqldap;
        private SqlCommand _obj_Sqlcmd;
        private DataSet _obj_DsConjunto;
        private DataTable _obj_DtParametros;
        private char _cAuxiliar;
        private string _sNombreTabla, _sNombreSp, _sValorScalar,
                       _sMensajeError;

        #endregion

        #region Variables Públicas

        public SqlConnection obj_Sqlcnx { get => _obj_Sqlcnx; set => _obj_Sqlcnx = value; }
        public SqlDataAdapter obj_Sqldap { get => _obj_Sqldap; set => _obj_Sqldap = value; }
        public SqlCommand obj_Sqlcmd { get => _obj_Sqlcmd; set => _obj_Sqlcmd = value; }
        public DataSet obj_DsConjunto { get => _obj_DsConjunto; set => _obj_DsConjunto = value; }
        public DataTable obj_DtParametros { get => _obj_DtParametros; set => _obj_DtParametros = value; }
        public char cAuxiliar { get => _cAuxiliar; set => _cAuxiliar = value; }
        public string sNombreTabla { get => _sNombreTabla; set => _sNombreTabla = value; }
        public string sNombreSp { get => _sNombreSp; set => _sNombreSp = value; }
        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sMensajeError { get => _sMensajeError; set => _sMensajeError = value; }

        #endregion

    }
}
