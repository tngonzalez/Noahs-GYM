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
using Capa.UI.Reportes;

namespace Capa.UI.Rutinas
{
    public partial class FrmRutinas : Form
    {
        private static readonly ILog GYMEventos = log4net.LogManager.GetLogger("NoahGYMEventos");

        public FrmRutinas()
        {
            InitializeComponent();
        }

        #region Metodos Variados 

        private void Refrescar()
        {
            dgvRutinas.DataSource = RutinaBLL.ObtenerTodos(); 
        }
        private void CargarCombos()
        {
            //Ejercicio
            cmbEjercicio.DataSource = EjercicioBLL.ObtenerTodos();
            cmbEjercicio.DisplayMember = "Nombre";
            cmbEjercicio.ValueMember = "ID";

            //Instructor
            cmbInstructor.DataSource = InstructorBLL.ObtenerTodos();
            cmbInstructor.DisplayMember = "ID";
            cmbInstructor.ValueMember = "ID";

        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescanso.Clear();           
            txtSerieXRepeticion.Clear(); 
            cmbInstructor.SelectedIndex = -1;
            cmbEjercicio.SelectedIndex = -1;
            dgvRutinas.ClearSelection();

        }
        private void Validaciones()
        {
            erp.Clear();

            try
            {
                //Nombre
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    erp.SetError(txtNombre, "Digite el nombre de la rutina"); return;
                }

                //Instructor 
                if (cmbInstructor.SelectedIndex == -1)
                {
                    erp.SetError(cmbInstructor, "Seleccione la identificación del instructor correspondiente"); return;
                }

                //Ejercicio 
                if (cmbEjercicio.SelectedIndex == -1)
                {
                    erp.SetError(cmbEjercicio, "Seleccione el nombre del ejercicio correspondiente"); return;
                }

                //SerieXRepticion 
                if (string.IsNullOrEmpty(txtSerieXRepeticion.Text))
                {
                    erp.SetError(txtSerieXRepeticion, "Digite la cantidad de series y repeticiones por ejercicio"); return;
                }

                //Descanso
                if (string.IsNullOrEmpty(txtDescanso.Text))
                {
                    erp.SetError(txtDescanso, "Digite la cantidad de descanso"); return;
                }

            }
            catch (Exception)
            {
                throw;
            }



        }
        #endregion

        private void FrmRutinas_Load(object sender, EventArgs e)
        {
            Refrescar();
            CargarCombos();
            LimpiarCampos();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(txtNombre.Text))
                {
                    Validaciones();

                    Rutina oRutina = new Rutina();
                    oRutina.Nombre = txtNombre.Text;
                    oRutina.IDInstructor = (int)cmbInstructor.SelectedValue;
                    oRutina.IDEjercicio = (int)cmbEjercicio.SelectedValue;
                    oRutina.Ejercicio = cmbEjercicio.SelectedItem as Ejercicio;
                    oRutina.SerieRepeticion = txtSerieXRepeticion.Text;
                    oRutina.Descanso = txtDescanso.Text; 

                    RutinaBLL oBLL = new RutinaBLL();
                    oBLL.Guardar(oRutina);
                    Refrescar();

                    MessageBox.Show("La rutina se registro exitosamente! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarCampos();
                    CargarCombos(); 
                }
                else
                {
                    MessageBox.Show("Ingrese los datos solicitados", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus(); 
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
                if (dgvRutinas.SelectedRows.Count > 0)
                {
                    var Pregunta = MessageBox.Show("¿Esta seguro que desea eliminar la rutina seleccionada?", "Eliminación permanente",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Pregunta == DialogResult.Yes)
                    {
                        RutinaBLL oBLL = new RutinaBLL();
                        oBLL.Eliminar(Convert.ToInt32(txtCodigo.Text));
                        Refrescar();

                        MessageBox.Show("La rutina se elimino de manera exitosa! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarCampos();

                    }
                }
                else
                {
                    MessageBox.Show("Para poder eliminar una rutina, primero debe seleccionarla", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnMostrarEjercicios_Click(object sender, EventArgs e)
        {
            FrmEjercicios oEjercicios = new FrmEjercicios();
            oEjercicios.ShowDialog(); 
        }

        private void dgvRutinas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvRutinas.SelectedRows.Count > 0)
                {
                    var oRut = (Rutina)dgvRutinas.SelectedRows[0].DataBoundItem;

                    txtCodigo.Text = oRut.ID.ToString();
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

        private void btnAsignarRutinas_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRutinas.SelectedRows.Count > 0)
                {
                    var oRu =
                        dgvRutinas.SelectedRows[0].DataBoundItem;

                    var frm = new FrmAsignarRutina();

                    frm.Rutina = (Rutina)oRu;
                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Primero debe seleccionar la rutina", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmRepCorreo();
            frm.ShowDialog();

        }
    }
}
