using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Aplicacion_Escritorio_Veterinaria.BBDD;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using DAL_Aplicacion_Escritorio_Veterinaria.Catalogos;
using BLL_Aplicacion_Escritorio_Veterinaria.BBDD;
using BLL_Aplicacion_Escritorio_Veterinaria.Catalogos;


namespace BLL_Aplicacion_Escritorio_Veterinaria.Catalogos
{
    public class cls_EntradaArticulos_BLL
    {

        public void Listar_Filtrar_Articulo(ref cls_EntradaArticulos_DAL Obj_EntArt_DAL)
        {

            cls_EntradaArticulos_DAL Obj_Articulo = new cls_EntradaArticulos_DAL();
            cls_BBDD_DAL Obj_BD_DAL = new cls_BBDD_DAL();
            cls_BBDD_BLL Obj_BD_BLL = new cls_BBDD_BLL();
            if (Obj_EntArt_DAL.sNombre == string.Empty)
            {
                Obj_BD_DAL.sNombreSp = ConfigurationManager.AppSettings["Listar_Articulo"].ToString();
            }
            else
            {
                Obj_BD_DAL.sNombreSp = ConfigurationManager.AppSettings["Filtrar_Articulo"].ToString();
                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);                                   // CREAR DATATABLE
                Obj_BD_DAL.obj_DtParametros.Rows.Add("@filtro", "6", Obj_EntArt_DAL.sNombre);  // AGREGAMOS LOS PARAMETROS QUE TIENEN EL STORE PROCEDURE
            }
            Obj_BD_DAL.sNombreTabla = "Artículo";
            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMensajeError == string.Empty)
            {
                Obj_EntArt_DAL.sMsjError = string.Empty;
                Obj_EntArt_DAL.dtDatos = Obj_BD_DAL.obj_DsConjunto.Tables[0];
            }
            else
            {
                Obj_EntArt_DAL.sMsjError = Obj_BD_DAL.sMensajeError;
                Obj_EntArt_DAL.dtDatos = null;
            }

        }

        public void Insertar_Articulo(ref cls_EntradaArticulos_DAL Obj_EntArt_DAL)
        {

            cls_BBDD_DAL Obj_BD_DAL = new cls_BBDD_DAL();
            cls_BBDD_BLL Obj_BD_BLL = new cls_BBDD_BLL();
            Obj_BD_DAL.sNombreSp = ConfigurationManager.AppSettings["Insertar_Articulo"].ToString();
            Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Id_Categoria", "1", Obj_EntArt_DAL.iCategoriaId);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Codigo", "6", Obj_EntArt_DAL.sCodigo);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Nombre", "6", Obj_EntArt_DAL.sNombre);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Precio_Venta", "2", Obj_EntArt_DAL.fPrecioVenta);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Stock", "1", Obj_EntArt_DAL.iStock);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Descripcion", "6", Obj_EntArt_DAL.sDescripcion);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Estado", "9", Obj_EntArt_DAL.bEstado);
            //Obj_BD_DAL.cAuxiliar = 'N';
            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);
            Obj_EntArt_DAL.sMsjError = Obj_BD_DAL.sMensajeError;
            if (Obj_EntArt_DAL.sMsjError == string.Empty)
            {
                Obj_EntArt_DAL.iArticuloId = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            }
            else
            {
                Obj_EntArt_DAL.iArticuloId = 0;
            }

        }

        public void Modificar_Articulo(ref cls_EntradaArticulos_DAL Obj_EntArt_DAL)
        {

            cls_BBDD_DAL Obj_BD_DAL = new cls_BBDD_DAL();
            cls_BBDD_BLL Obj_BD_BLL = new cls_BBDD_BLL();

            Obj_BD_DAL.sNombreSp = ConfigurationManager.AppSettings["Modificar_Articulo"].ToString();
            Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Id_Articulo", "1", Obj_EntArt_DAL.iArticuloId);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Id_Categoria", "1", Obj_EntArt_DAL.iCategoriaId);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Codigo", "6", Obj_EntArt_DAL.sCodigo);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Nombre", "6", Obj_EntArt_DAL.sNombre);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Precio_Venta", "2", Obj_EntArt_DAL.fPrecioVenta);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Stock", "1", Obj_EntArt_DAL.iStock);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Descripcion", "6", Obj_EntArt_DAL.sDescripcion);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Estado", "9", Obj_EntArt_DAL.bEstado);
            //Obj_BD_DAL.cAuxiliar = 'N';
            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);
            Obj_EntArt_DAL.sMsjError = Obj_BD_DAL.sMensajeError;

        }

        public void Eliminar_Articulo(ref cls_EntradaArticulos_DAL Obj_EntArt_DAL)
        {

            cls_BBDD_DAL Obj_BD_DAL = new cls_BBDD_DAL();
            cls_BBDD_BLL Obj_BD_BLL = new cls_BBDD_BLL();
            Obj_BD_DAL.sNombreSp = ConfigurationManager.AppSettings["Eliminar_Articulo"].ToString();
            Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_DtParametros.Rows.Add("@Id_Articulo", "6", Obj_EntArt_DAL.iArticuloId);
            //Obj_BD_DAL.cAuxiliar = 'N';
            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);
            Obj_EntArt_DAL.sMsjError = Obj_BD_DAL.sMensajeError;

        }
    }
}
