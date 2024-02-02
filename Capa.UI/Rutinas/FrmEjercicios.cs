using System;
using log4net; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa.BLL;
using Capa.Entidades.Entidades;
using Capa.Entidades;
using System.IO;

namespace Capa.UI.Rutinas
{
    public partial class FrmEjercicios : Form
    {
        private static readonly ILog GYMEventos = log4net.LogManager.GetLogger("NoahGYMEventos");

        public FrmEjercicios()
        {
            InitializeComponent();
        }
        #region Metodos Variados 

        private void Refrescar()
        {
            dgvEjercicios.DataSource = EjercicioBLL.ObtenerTodos();
            dgvEjercicios.ClearSelection(); 
        }
        private void CargarCombo()
        {
            //TipoEjercicio
            cmbTipoEjercicio.DataSource = TipoEjercicioBLL.ObtenerTodos(); 
            cmbTipoEjercicio.DisplayMember = "Nombre";
            cmbTipoEjercicio.ValueMember = "ID";
        }
        private void Validaciones()
        {
            erp.Clear();

            try
            {
                //Nombre
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    erp.SetError(txtNombre, "Digite el nombre del ejercicio"); return;
                }

                //Descripcion 
                if (string.IsNullOrEmpty(rtxtDescripcion.Text))
                {
                    erp.SetError(rtxtDescripcion, "Digite la descripción del ejercicios"); return;
                }

                //TipoEjercicio 
                if (cmbTipoEjercicio.SelectedIndex == -1)
                {
                    erp.SetError(cmbTipoEjercicio, "Seleccione el tipo de ejercicio correspondiente"); return;
                }

                //Foto
                if (pcbImagenE.Tag == Capa.UI.Properties.Resources.EjerciciosICON)
                {
                    erp.SetError(pcbImagenE, "Seleccione una foto de perfil"); return;
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
        private void IniciarFotografia()
        {
            pcbImagenE.Image = Capa.UI.Properties.Resources.EjerciciosICON;
            ImageConverter converter = new ImageConverter();
            byte[] cadenaByte = (byte[])converter.ConvertTo(pcbImagenE.Image, typeof(byte[]));
            pcbImagenE.Tag = cadenaByte;
        }
        #endregion

        private void FrmEjercicios_Load(object sender, EventArgs e)
        {
            CargarCombo();
            Refrescar();
            IniciarFotografia(); 
            //Limpiar 
            dgvEjercicios.ClearSelection();
            txtNombre.Text = "";
            rtxtDescripcion.Text = "";
            cmbTipoEjercicio.SelectedIndex = -1;
            pcbImagenE.Image = Capa.UI.Properties.Resources.EjerciciosICON; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    Validaciones();

                    Ejercicio oEjer = new Ejercicio();

                    oEjer.Nombre = txtNombre.Text;
                    oEjer.Descripcion = rtxtDescripcion.Text;

                    if(pcbImagenE.Tag != Capa.UI.Properties.Resources.EjerciciosICON)
                    oEjer.Foto = (byte[])pcbImagenE.Tag;

                    oEjer.IDTipoEjer = (int)cmbTipoEjercicio.SelectedValue;
                    oEjer.TipoEjercicio = cmbTipoEjercicio.SelectedItem as TipoEjercicio;

                    EjercicioBLL oBLL = new EjercicioBLL();
                    oBLL.Guardar(oEjer);
                    Refrescar();

                    //Limpiar
                    txtNombre.Text = "";
                    rtxtDescripcion.Text = "";
                    cmbTipoEjercicio.SelectedIndex = -1;
                    pcbImagenE.Image = Capa.UI.Properties.Resources.EjerciciosICON;


                    MessageBox.Show("Ejercicio registrado exitosamente! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                if (dgvEjercicios.SelectedRows.Count > 0)
                {
                    var Pregunta = MessageBox.Show("¿Esta seguro que desea eliminar el ejercicio seleccionado?", "Eliminación permanente",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Pregunta == DialogResult.Yes)
                    {
                        EjercicioBLL oBLL = new EjercicioBLL();
                        oBLL.Eliminar(txtNombre.Text); 
                        Refrescar();

                        //Limpiar
                        txtNombre.Text = "";
                        rtxtDescripcion.Text = "";
                        cmbTipoEjercicio.SelectedIndex = -1;
                        pcbImagenE.Image = Capa.UI.Properties.Resources.EjerciciosICON;


                        MessageBox.Show("El ejercicio se ha eliminado de manera exitosa! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Para poder eliminar el ejercicio, primero debe seleccionarlo", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Seleccione la foto de perfil";
                openFile.SupportMultiDottedExtensions = true; 
                openFile.DefaultExt = "*.png";
                openFile.Filter = "Archivos de Imagenes (*.png;*.jpeg)|*.png;*.jpeg| All files (*.*)|*.*";
                openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
                openFile.FileName = "";
                if (openFile.ShowDialog(this) == DialogResult.OK)
                {

                    try
                    {
                        pcbImagenE.ImageLocation = openFile.FileName;
                        pcbImagenE.SizeMode = PictureBoxSizeMode.StretchImage;
                        byte[] cadenaByte = File.ReadAllBytes(openFile.FileName);
                        pcbImagenE.Tag = (byte[])cadenaByte;
                    }

                    catch (Exception er) { MessageBox.Show("Error: " + er.Message); }
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

        private void dgvEjercicios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvEjercicios.SelectedRows.Count > 0)
                {
                    var oEjer = (Ejercicio)dgvEjercicios.SelectedRows[0].DataBoundItem;

                    txtNombre.Text = oEjer.Nombre;
                    rtxtDescripcion.Text = oEjer.Descripcion;
                    cmbTipoEjercicio.SelectedValue = oEjer.IDTipoEjer;
                    cmbTipoEjercicio.SelectedItem = oEjer.TipoEjercicio;

                    //Conver Imagen
                    ImageConverter img = new ImageConverter();
                    pcbImagenE.Image = (Bitmap)img.ConvertFrom(oEjer.Foto);

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
