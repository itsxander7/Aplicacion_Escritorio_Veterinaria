using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_Aplicacion_Escritorio_Veterinaria.Pantallas
{
    public partial class frm_Principal : Form
    {

        #region Variables Globales



        #endregion


        #region Eventos

        public frm_Principal()
        {
            InitializeComponent();
        }

        private void mniLogin_Click(object sender, EventArgs e)
        {

            Pantallas.Listar.frm_Login FormularioLogin = new Pantallas.Listar.frm_Login();
            FormularioLogin.ShowDialog();

        }

        private void tsm_ComprasProductos_Click(object sender, EventArgs e)
        {

            Pantallas.Listar.frm_Entrada_Articulos FormularioEntradaArticulos = new Pantallas.Listar.frm_Entrada_Articulos();
            FormularioEntradaArticulos.ShowDialog();

        }

        private void tsm_FacturacionServicios_Click(object sender, EventArgs e)
        {

            Pantallas.Listar.frm_Ingreso_Servicios FormularioFacturacionServicios = new Pantallas.Listar.frm_Ingreso_Servicios();
            FormularioFacturacionServicios.ShowDialog();

        }

        private void tsm_FacturacionProductos_Click(object sender, EventArgs e)
        {

            Pantallas.Listar.frm_Venta_Productos FormularioVentaProductos = new Pantallas.Listar.frm_Venta_Productos();
            FormularioVentaProductos.ShowDialog();

        }

        private void tsm_IngresoExpediente_Click(object sender, EventArgs e)
        {

            Pantallas.Listar.frm_Entrada_Expediente FormularioExpedientes = new Pantallas.Listar.frm_Entrada_Expediente();
            FormularioExpedientes.ShowDialog();

        }

        private void tsm_RegistroArticulos_Click(object sender, EventArgs e)
        {

            Pantallas.Listar.frm_Maestro_Articulos FormularioMaestroArticulos = new Pantallas.Listar.frm_Maestro_Articulos();
            FormularioMaestroArticulos.ShowDialog();

        }

        private void tsm_RegistroUsuarios_Click(object sender, EventArgs e)
        {
            
            Pantallas.Listar.frm_Registro_Usuarios FormularioRegistroUsuarios = new Pantallas.Listar.frm_Registro_Usuarios();
            FormularioRegistroUsuarios.ShowDialog();

        }

        private void tsm_RegistroSocios_Click(object sender, EventArgs e)
        {

            Pantallas.Listar.frm_Registro_Socios FormularioRegistroSocios = new Pantallas.Listar.frm_Registro_Socios();
            FormularioRegistroSocios.ShowDialog();

        }

        private void tsm_Reportes_Click(object sender, EventArgs e)
        {

            Pantallas.Listar.frm_Modulo_Reportes FormularioReportes = new Pantallas.Listar.frm_Modulo_Reportes();
            FormularioReportes.ShowDialog();

        }

        private void tsm_Mantenimiento_Click(object sender, EventArgs e)
        {

            Pantallas.Listar.frm_Modulo_Mantenimiento FormularioMantenimiento = new Pantallas.Listar.frm_Modulo_Mantenimiento();
            FormularioMantenimiento.ShowDialog();

        }

        private void mniSalir_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Desea realmente salir de la aplicación", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        #endregion

        #region Métodos



        #endregion

    }
}
