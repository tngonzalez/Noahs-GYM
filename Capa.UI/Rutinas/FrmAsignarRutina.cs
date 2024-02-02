using Capa.BLL;
using log4net; 
using Capa.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Rutinas
{
    public partial class FrmAsignarRutina : Form
    {
        private static readonly ILog GYMEventos = log4net.LogManager.GetLogger("NoahGYMEventos");

        public FrmAsignarRutina()
        {
            InitializeComponent();
        }
        public Rutina Rutina { get; set; }

        #region Metodos Variados 
        private void CargarCombos()
        {
            //Cliente
            cmbUsuario.DataSource = ClienteBLL.ObtenerTodos(); 
            cmbUsuario.DisplayMember = "ID";
            cmbUsuario.ValueMember = "ID";
        }
        private void AsignarValores()
        {

            txtNombre.Text = Rutina.Nombre;
            txtEjercicio.Text = Rutina.Ejercicio.Nombre;
            txtSerieRepeticion.Text = Rutina.SerieRepeticion;
            txtDescanso.Text = Rutina.Descanso;

        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescanso.Clear();
            txtEjercicio.Clear();
            txtSerieRepeticion.Clear();
            cmbUsuario.SelectedIndex = -1;
            txtDia.Clear(); 

        }
        private void Validaciones()
        {
            erp.Clear();

            try
            {
                //  Usuario 
                if (cmbUsuario.SelectedIndex == -1)
                {
                    erp.SetError(cmbUsuario, "Seleccione la identificación del usuario correspondiente"); return;
                }

                //DiaRutina 
                if (string.IsNullOrEmpty(txtDia.Text))
                {
                    erp.SetError(txtDia, "Digite el día de la rutina"); return;
                }

            }
            catch (Exception error)
            {

                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);
                msg.AppendFormat("Data           {0}\n", error.Data);

                GYMEventos.Error(msg.ToString());

                MessageBox.Show("Se ha producido un error :" + error.Message, "Error");
            }



        }
       
        #endregion

        private void FrmAsignarRutina_Load(object sender, EventArgs e)
        {
            CargarCombos();
            LimpiarCampos();
            AsignarValores(); 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUsuario.SelectedIndex != -1)
                {
                    Validaciones();
                    int cliente = Convert.ToInt32(cmbUsuario.SelectedValue); 

                   ClienteBLL oBLL = new ClienteBLL();
                    oBLL.GuardarClienteRutina(cliente, Rutina.ID, txtDia.Text); 

                    MessageBox.Show("Asignación se realizó exitosamente! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ingrese los datos solicitados", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbUsuario.Focus();
                }
            }
            catch (Exception error)
            {

                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);
                msg.AppendFormat("Data           {0}\n", error.Data);

                GYMEventos.Error(msg.ToString());

                MessageBox.Show("Se ha producido un error :" + error.Message, "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                    var Pregunta = MessageBox.Show("¿Esta seguro que desea eliminar la rutina asignada?", "Eliminación permanente",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Pregunta == DialogResult.Yes)
                {
                    ClienteBLL oBLL = new ClienteBLL();
                    oBLL.EliminarClienteRutina(Convert.ToInt32(cmbUsuario.SelectedValue), Rutina.ID);

                    MessageBox.Show("La asignación se elimino de manera exitosa! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarCampos();
                }

            }

            catch (Exception error)
            {

                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);
                msg.AppendFormat("Data           {0}\n", error.Data);

                GYMEventos.Error(msg.ToString());

                MessageBox.Show("Se ha producido un error :" + error.Message, "Error");
            }
        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
