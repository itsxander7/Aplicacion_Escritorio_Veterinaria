using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL_Aplicacion_Escritorio_Veterinaria.Catalogos
{
    public class cls_EntradaArticulos_DAL
    {

        #region Variables Globales

        private ulong _uIdTransaccion;
        private string _sNombreProveedor, _sMoneda, _sEstado,
                       _sComentarios, _sDescripcion, _sUbicacion, _sUnidadMedida;
        private ushort _uIdProveedor, _uCodigoArticulo;
        private uint _uConsecutivo;
        private float _fSubtotal, _fGastosAdicionales, _fIva, _fTotal, _fCantidad,
                     _fCostoUnidad, _fDescuento, _fIvaFila, _fTotalFila;
        private DateTime _dFechaTransaccion, _dFechaVencimiento, _dFechaCaducidad;
        private string _sMsjError;
        private char _cAxn;
        private DataTable _dtDatos;

        #endregion


        #region Constructores

        public ulong uIdTransaccion { get => _uIdTransaccion; set => _uIdTransaccion = value; }
        public string sNombreProveedor { get => _sNombreProveedor; set => _sNombreProveedor = value; }
        public string sMoneda { get => _sMoneda; set => _sMoneda = value; }
        public string sEstado { get => _sEstado; set => _sEstado = value; }
        public string sComentarios { get => _sComentarios; set => _sComentarios = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        public string sUbicacion { get => _sUbicacion; set => _sUbicacion = value; }
        public string sUnidadMedida { get => _sUnidadMedida; set => _sUnidadMedida = value; }
        public ushort uIdProveedor { get => _uIdProveedor; set => _uIdProveedor = value; }
        public ushort uCodigoArticulo { get => _uCodigoArticulo; set => _uCodigoArticulo = value; }
        public uint uConsecutivo { get => _uConsecutivo; set => _uConsecutivo = value; }
        public float fSubtotal { get => _fSubtotal; set => _fSubtotal = value; }
        public float fGastosAdicionales { get => _fGastosAdicionales; set => _fGastosAdicionales = value; }
        public float fIva { get => _fIva; set => _fIva = value; }
        public float fTotal { get => _fTotal; set => _fTotal = value; }
        public float fCantidad { get => _fCantidad; set => _fCantidad = value; }
        public float fCostoUnidad { get => _fCostoUnidad; set => _fCostoUnidad = value; }
        public float fDescuento { get => _fDescuento; set => _fDescuento = value; }
        public float fIvaFila { get => _fIvaFila; set => _fIvaFila = value; }
        public float fTotalFila { get => _fTotalFila; set => _fTotalFila = value; }
        public DateTime dFechaTransaccion { get => _dFechaTransaccion; set => _dFechaTransaccion = value; }
        public DateTime dFechaVencimiento { get => _dFechaVencimiento; set => _dFechaVencimiento = value; }
        public DateTime dFechaCaducidad { get => _dFechaCaducidad; set => _dFechaCaducidad = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public char sAxn { get => _cAxn; set => _cAxn = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }

        #endregion

    }
}
