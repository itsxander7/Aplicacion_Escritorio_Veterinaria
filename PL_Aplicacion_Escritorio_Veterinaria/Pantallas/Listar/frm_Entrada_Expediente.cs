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




namespace PL_Aplicacion_Escritorio_Veterinaria.Pantallas.Listar
{
    public partial class frm_Entrada_Expediente : Form
    {

        #region Variables Globales



        #endregion

        #region Eventos

        public frm_Entrada_Expediente()
        {
            InitializeComponent();
        }

        private void frm_Entrada_Expediente_Load(object sender, EventArgs e)
        {

            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = 1650;
                time.Tick += MarcaTiempo;
                time.Start();
                MessageBox.Show("Bienvenido(a) al módulo de Expediente Clínico, en el cual podrás ingresar los datos de la mascota de nuevo ingreso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frm_Entrada_Expediente_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Desea realmente salir de la aplicación", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            GestionarMusica('s');

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
                if (flag == 'V')
                {
                    //dgv_FacturacionServicios.Enabled = true;
                    txt_Comentarios.Enabled = true;
                }
                else
                {
                    //mtb_FechaVencimiento.Enabled = true;
                }
            }

        }

        private void MarcaTiempo(object sender, EventArgs e)
        {

            (sender as Timer).Stop();  /* Detiene el Timer */
            SendKeys.Send("{ESC}"); /* Hace la simulación de la tecla Escape, también puedes usar {ENTER} */

        }

        private void GestionarMusica(char flag)
        {

            if (flag == 'p')
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
