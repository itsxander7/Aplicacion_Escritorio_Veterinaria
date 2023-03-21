using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Aplicacion_Escritorio_Veterinaria.BBDD;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BLL_Aplicacion_Escritorio_Veterinaria.BBDD
{
    public class cls_BBDD_BLL
    {

        public void CrearDTParametros(ref cls_BBDD_DAL Obj_DAL)
        {
            Obj_DAL.obj_DtParametros = new DataTable("Parametros");
            Obj_DAL.obj_DtParametros.Columns.Add("Nom_Param");
            Obj_DAL.obj_DtParametros.Columns.Add("Tipo_Dato");
            Obj_DAL.obj_DtParametros.Columns.Add("Valor");
        }

        public void ExecDataAdapter(ref cls_BBDD_DAL Obj_BD_DAL)
        {
            try
            {
                Obj_BD_DAL.obj_Sqlcnx = new SqlConnection(ConfigurationManager.ConnectionStrings["sql_auth"].ToString());

                if (Obj_BD_DAL.obj_Sqlcnx.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.obj_Sqlcnx.Open();
                }

                Obj_BD_DAL.obj_Sqldap = new SqlDataAdapter(Obj_BD_DAL.sNombreSp,    // nombre del store procedure que debe ejecutar en la BD
                                                        Obj_BD_DAL.obj_Sqlcnx); // conexion a la BD previamente costruida y abierta.

                Obj_BD_DAL.obj_Sqldap.SelectCommand.CommandType = CommandType.StoredProcedure;


        #region AGREGAR PARÁMETROS


                if (Obj_BD_DAL.obj_DtParametros != null)
                {
                    SqlDbType TipoDatoSQL = SqlDbType.VarChar;

                    foreach (DataRow dr in Obj_BD_DAL.obj_DtParametros.Rows)
                    {

            #region Definición de tipos de Datos del SQL

                        switch (dr[1])
                        {
                            case "1":
                                {
                                    TipoDatoSQL = SqlDbType.Int;
                                    break;
                                }
                            case "2":
                                {
                                    TipoDatoSQL = SqlDbType.Decimal;
                                    break;
                                }
                            case "3":
                                {
                                    TipoDatoSQL = SqlDbType.Float;
                                    break;
                                }
                            case "4":
                                {
                                    TipoDatoSQL = SqlDbType.Char;
                                    break;
                                }
                            case "5":
                                {
                                    TipoDatoSQL = SqlDbType.NChar;
                                    break;
                                }
                            case "6":
                                {
                                    TipoDatoSQL = SqlDbType.VarChar;
                                    break;
                                }
                            case "7":
                                {
                                    TipoDatoSQL = SqlDbType.NVarChar;
                                    break;
                                }
                            case "8":
                                {
                                    TipoDatoSQL = SqlDbType.DateTime;
                                    break;
                                }
                            case "9":
                                {
                                    TipoDatoSQL = SqlDbType.Bit;
                                    break;
                                }
                            case "10":
                                {
                                    TipoDatoSQL = SqlDbType.VarBinary;
                                    break;
                                }
                            case "11":
                                {
                                    TipoDatoSQL = SqlDbType.TinyInt;
                                    break;
                                }

                            default:
                                break;
                        }

            #endregion

                        Obj_BD_DAL.obj_Sqldap.SelectCommand.Parameters.Add(dr[0].ToString(),             // nombre del parametro
                                                                TipoDatoSQL                  // el tipo de datos que entiende el sql - resultado del switch
                                                                ).Value = dr[2].ToString(); // el valor del parametro

                    }
                }

        #endregion

                Obj_BD_DAL.obj_DsConjunto = new DataSet();
                Obj_BD_DAL.obj_Sqldap.Fill(Obj_BD_DAL.obj_DsConjunto,          // objeto donde el sql va a devolver los datos resultado de la ejecución del SP
                                        Obj_BD_DAL.sNombreTabla); // nombre técnico del data tables en programació o código

                Obj_BD_DAL.sMensajeError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMensajeError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_BD_DAL.obj_Sqlcnx.State == ConnectionState.Open)
                {
                    Obj_BD_DAL.obj_Sqlcnx.Close();
                }
                Obj_BD_DAL.obj_Sqlcnx.Dispose();
            }
        }

        public void ExecCommand(ref cls_BBDD_DAL Obj_BD_DAL)
        {
            try
            {
                Obj_BD_DAL.obj_Sqlcnx = new SqlConnection(ConfigurationManager.ConnectionStrings["sql_auth"].ToString());

                if (Obj_BD_DAL.obj_Sqlcnx.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.obj_Sqlcnx.Open();
                }

                Obj_BD_DAL.obj_Sqlcmd = new SqlCommand(Obj_BD_DAL.sNombreSp,    // nombre del store procedure que debe ejecutar en la BD
                                                        Obj_BD_DAL.obj_Sqlcnx); // conexion a la BD previamente costruida y abierta.

                Obj_BD_DAL.obj_Sqlcmd.CommandType = CommandType.StoredProcedure;

            #region AGREGAR PARÁMETROS

                if (Obj_BD_DAL.obj_DtParametros != null)
                {
                    SqlDbType TipoDatoSQL = SqlDbType.VarChar;

                    foreach (DataRow dr in Obj_BD_DAL.obj_DtParametros.Rows)
                    {

                #region Definición de tipos de Datos del SQL

                        switch (dr[1])
                        {
                            case "1":
                                {
                                    TipoDatoSQL = SqlDbType.Int;
                                    break;
                                }
                            case "2":
                                {
                                    TipoDatoSQL = SqlDbType.Decimal;
                                    break;
                                }
                            case "3":
                                {
                                    TipoDatoSQL = SqlDbType.Float;
                                    break;
                                }
                            case "4":
                                {
                                    TipoDatoSQL = SqlDbType.Char;
                                    break;
                                }
                            case "5":
                                {
                                    TipoDatoSQL = SqlDbType.NChar;
                                    break;
                                }
                            case "6":
                                {
                                    TipoDatoSQL = SqlDbType.VarChar;
                                    break;
                                }
                            case "7":
                                {
                                    TipoDatoSQL = SqlDbType.NVarChar;
                                    break;
                                }
                            case "8":
                                {
                                    TipoDatoSQL = SqlDbType.DateTime;
                                    break;
                                }
                            case "9":
                                {
                                    TipoDatoSQL = SqlDbType.Bit;
                                    break;
                                }
                            case "10":
                                {
                                    TipoDatoSQL = SqlDbType.VarBinary;
                                    break;
                                }
                            case "11":
                                {
                                    TipoDatoSQL = SqlDbType.TinyInt;
                                    break;
                                }

                            default:
                                break;
                        }

                #endregion

                        Obj_BD_DAL.obj_Sqlcmd.Parameters.Add(dr[0].ToString(),             // nombre del parametro
                                                                TipoDatoSQL                  // el tipo de datos que entiende el sql - resultado del switch
                                                                ).Value = dr[2].ToString(); // el valor del parametro

                    }
                }

            #endregion

                //Nuevo
                if (Obj_BD_DAL.cAuxiliar == 'N')
                {

                    Obj_BD_DAL.obj_Sqlcmd.ExecuteNonQuery();
                }
                else
                {
                    Obj_BD_DAL.sValorScalar = Obj_BD_DAL.obj_Sqlcmd.ExecuteScalar().ToString().Trim();
                }
                Obj_BD_DAL.sMensajeError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMensajeError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_BD_DAL.obj_Sqlcnx.State == ConnectionState.Open)
                {
                    Obj_BD_DAL.obj_Sqlcnx.Close();
                }
                Obj_BD_DAL.obj_Sqlcnx.Dispose();
            }
        }
    }
}