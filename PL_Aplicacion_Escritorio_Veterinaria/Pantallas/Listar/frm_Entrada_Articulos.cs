using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Globalization;
using DAL_Aplicacion_Escritorio_Veterinaria.BBDD;
using DAL_Aplicacion_Escritorio_Veterinaria.Catalogos;
using BLL_Aplicacion_Escritorio_Veterinaria.BBDD;
using BLL_Aplicacion_Escritorio_Veterinaria.Catalogos;


namespace PL_Aplicacion_Escritorio_Veterinaria.Pantallas.Listar
{
    public partial class frm_Entrada_Articulos : Form
    {

        #region Variables Globales

        cls_EntradaArticulos_BLL Obj_EntArt_BLL = new cls_EntradaArticulos_BLL();
        cls_EntradaArticulos_DAL Obj_EntArt_DAL = new cls_EntradaArticulos_DAL();

        #endregion


        #region Eventos

        public frm_Entrada_Articulos()
        {

            InitializeComponent();

        }

        private void frm_Entrada_Articulos_Load(object sender, EventArgs e)
        {

            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = 1650;
                time.Tick += MarcaTiempo;  
                time.Start();
                MessageBox.Show("Bienvenido(a) al módulo de Compras, en el cual podrás registrar tus facturas de compra de mercadería.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            tls_txt_Filtrar.Text = string.Empty;
            GestionarMusica('p');

        }


        private void tls_btn_Salir_Click(object sender, EventArgs e)
        {

            this.Close();
            GestionarMusica('s');

        }

        private void tls_lbl_Limpiar_Click(object sender, EventArgs e)
        {



        }

        private void tls_btn_Filtrar_Click(object sender, EventArgs e)
        {



        }

        private void tls_btn_eliminar_Click(object sender, EventArgs e)
        {



        }

        private void tls_btn_modificar_Click(object sender, EventArgs e)
        {



        }

        private void tls_btn_nuevo_Click(object sender, EventArgs e)
        {



        }

        private void tls_btn_refrescar_Click(object sender, EventArgs e)
        {



        }

        private void frm_Entrada_Articulos_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Desea realmente salir de la aplicación", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            GestionarMusica('s');

        }

        private void lsb_IdProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            lsb_Moneda.Enabled = true;

        }

        private void lsb_Moneda_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_IdTransaccion.Enabled = true;

        }

        private void txt_IdTransaccion_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsNumber(e.KeyChar) || (e.KeyChar == 8))
            {
                e.Handled = false;
                lsb_Estado.Enabled = true;
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txt_IdTransaccion, "No digitaste un número entero o el mismo es mayor a 20 carácteres");
                txt_IdTransaccion.Focus();
            }

        }

        private void txt_IdTransaccion_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_IdTransaccion.Text))
            {
                errorProvider1.SetError(txt_IdTransaccion, "No tiene digitado algún número (entero) de factura comercial");
                txt_IdTransaccion.Focus();
            }
            errorProvider1.Clear();

        }

        private void lsb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {

            mtb_FechaTransaccion.Enabled = true;

        }

        private void mtb_FechaTransaccion_Validating(object sender, CancelEventArgs e)
        {

            ValidarFechas(mtb_FechaTransaccion, 'T');

        }

        private void mtb_FechaVencimiento_Validating(object sender, CancelEventArgs e)
        {

            ValidarFechas(mtb_FechaVencimiento, 'V');

        }

        private void dgv_Entrada_Articulos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if(e.ColumnIndex == 2)
            {
                bool IsFecha = DateTime.TryParse(e.FormattedValue.ToString(), out DateTime fecha);
                if (!IsFecha)
                {
                    e.Cancel = true;
                    MessageBox.Show("No tiene el formato MM/DD/AAAA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    e.Cancel = false;
                }
            }
            else if (e.ColumnIndex == 4 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8)
            {
                bool IsDouble = double.TryParse(e.FormattedValue.ToString(), out double resultado);
                if(!IsDouble)
                {
                    e.Cancel = true;
                    MessageBox.Show("No tiene el formato 00,00 o 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    float conversion = float.Parse(e.FormattedValue.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                    if (conversion>0.00)
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                        MessageBox.Show("El número es negativo o no tiene el indicador del decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void txt_Comentarios_Leave(object sender, EventArgs e)
        {

            if (txt_Comentarios.TextLength > 50)
            {
                errorProvider1.SetError(txt_Comentarios, "La extensión del comentario es mayor a 50 caracteres");
            }
            else
            {
            errorProvider1.Clear();
            }

        }

        #endregion

        #region Métodos

        private void ValidarFechas(MaskedTextBox Obj_CajaTexto, char flag)
        {

            DateTime fechas;
            if (!DateTime.TryParse(Obj_CajaTexto.Text, out fechas))
            {
                errorProvider1.SetError(Obj_CajaTexto, "No tiene el formato MM/DD/AAAA");
                Obj_CajaTexto.Focus();
            }
            else
            {
                errorProvider1.Clear();
                if(flag== 'V')
                {
                    dgv_Entrada_Articulos.Enabled = true;
                    txt_Comentarios.Enabled = true;
                }
                else
                {
                    mtb_FechaVencimiento.Enabled = true;
                }
            }

        }

        private void MarcaTiempo(object sender, EventArgs e)
        {

            (sender as Timer).Stop();  /* Detiene el Timer */
            SendKeys.Send("{ESC}"); /* Hace la simulación de la tecla Escape, también puedes usar {ENTER} */
        
        }

        private void GestionarMusica (char flag)
        {

            if(flag== 'p')
            {
                SoundPlayer Sonido = new SoundPlayer();
                Sonido.SoundLocation = "C:/Users/Anita/Documents/Proyectos Visual/Aplicacion_Escritorio_Veterinaria/Yellow.wav";
                Sonido.Play();
            }
            else
            {
                SoundPlayer Sonido = new SoundPlayer();
                Sonido.SoundLocation = "C:/Users/Anita/Documents/Proyectos Visual/Aplicacion_Escritorio_Veterinaria/Yellow.wav";
                Sonido.Stop();
            }

        }

        #endregion

    }
}