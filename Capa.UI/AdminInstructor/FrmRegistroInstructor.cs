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

namespace Capa.UI.AdminInstructor
{
    public partial class FrmRegistroInstructor : Form
    {
        private static readonly ILog GYMEventos = log4net.LogManager.GetLogger("NoahGYMEventos");
        public FrmRegistroInstructor()
        {
            InitializeComponent();
        }

        #region Metodos Variados 

        private void Refrescar()
        {
            dgvInstructor.DataSource = InstructorBLL.ObtenerTodos();
            dgvInstructor.ClearSelection();
        }
        private void CargarCombo()
        {
            //Genero
            cmbGenero.DataSource = GeneroBLL.ObtenerTodos();
            cmbGenero.DisplayMember = "Nombre";
            cmbGenero.ValueMember = "ID";
        }
        private void Validaciones()
        {
            erp.Clear();

            try
            {
                //ID
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    erp.SetError(txtID, "Digite la identificación del usuario"); return;
                }

                if (!int.TryParse(txtID.Text, out int cod))
                {
                    erp.SetError(txtNombre, "Este campo solo permite datos numéricos"); return;

                }

                //Nombre
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    erp.SetError(txtNombre, "Digite el nombre del usuario"); return;
                }

                //Apellidos 
                if (string.IsNullOrEmpty(txtApellidos.Text))
                {
                    erp.SetError(txtApellidos, "Digite los apellidos del usuario"); return;
                }

                //Genero 
                if (cmbGenero.SelectedIndex == -1)
                {
                    erp.SetError(cmbGenero, "Seleccione el genero correspondiente"); return;
                }

                //Foto
                if (pcbFoto.Tag == Capa.UI.Properties.Resources.UserIcon)
                {
                    erp.SetError(pcbFoto, "Seleccione una foto de perfil"); return;
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
            pcbFoto.Image = Capa.UI.Properties.Resources.UserIcon;
            ImageConverter converter = new ImageConverter();
            byte[] cadenaByte = (byte[])converter.ConvertTo(pcbFoto.Image, typeof(byte[]));
            pcbFoto.Tag = cadenaByte;
        }

        #endregion

        private void FrmRegistroInstructor_Load(object sender, EventArgs e)
        {
            Refrescar();
            CargarCombo();
           IniciarFotografia();

            //Limpiar
            dgvInstructor.ClearSelection(); 
            txtID.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtContra.Clear();
            txtCorreo.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            cmbGenero.SelectedIndex = -1;

        }

        private void dgvInstructor_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvInstructor.SelectedRows.Count > 0)
                {
                    var oIns = (Instructor)dgvInstructor.SelectedRows[0].DataBoundItem;
                    txtID.Text = oIns.ID.ToString();
                    txtNombre.Text = oIns.Nombre;
                    txtApellidos.Text = oIns.Apellidos;
                    cmbGenero.SelectedValue = oIns.IDGenero;
                    cmbGenero.SelectedItem = oIns.Genero;
                    dtpFechaNacimiento.Value = (DateTime)oIns.FechaNacimiento;

                    //Conver Imagen
                    ImageConverter img = new ImageConverter();
                    pcbFoto.Image = (Bitmap)img.ConvertFrom(oIns.Foto);

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    Validaciones();

                    Instructor oIns = new Instructor();

                    oIns.ID = Convert.ToInt32(txtID.Text);
                    oIns.Nombre = txtNombre.Text;

                    oIns.IDGenero = (int)cmbGenero.SelectedValue;
                    oIns.Genero = cmbGenero.SelectedItem as Genero;
                    oIns.Clave = txtContra.Text;
                    oIns.Apellidos = txtApellidos.Text;
                    oIns.Foto = (byte[])pcbFoto.Tag;
                    oIns.FechaNacimiento = dtpFechaNacimiento.Value;
                    oIns.Correo = txtCorreo.Text;

                    InstructorBLL oBLL = new InstructorBLL();
                    oBLL.Guardar(oIns);
                    Refrescar();

                    MessageBox.Show("Instructor registrado exitosamente! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Limpiar
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    cmbGenero.SelectedIndex = -1;
                    dtpFechaNacimiento.Value = DateTime.Now;
                    txtCorreo.Text = "";
                    txtContra.Text = "";
                    pcbFoto.Image = Capa.UI.Properties.Resources.UserIcon;
                }
                else
                {
                    MessageBox.Show("Ingrese los datos solicitados", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
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
                if (dgvInstructor.SelectedRows.Count > 0)
                {
                    var Pregunta = MessageBox.Show("¿Esta seguro que desea eliminar el usuario seleccionado?", "Eliminación permanente",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Pregunta == DialogResult.Yes)
                    {
                        AdministradorBLL oBLL = new AdministradorBLL();
                        oBLL.Eliminar(Convert.ToInt32(txtID.Text));
                        Refrescar();

                        MessageBox.Show("El administrador se ha eliminado de manera exitosa! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //Limpiar
                        txtID.Text = "";
                        txtNombre.Text = "";
                        txtApellidos.Text = "";
                        cmbGenero.SelectedIndex = -1;
                        dtpFechaNacimiento.Value = DateTime.Now;
                        txtCorreo.Text = "";
                        txtContra.Text = "";
                        pcbFoto.Image = Capa.UI.Properties.Resources.UserIcon;

                    }
                }
                else
                {
                    MessageBox.Show("Para poder eliminar un usuario, primero debe ser seleccionado", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btnSeleccionFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Seleccione la foto de perfil";
                openFile.SupportMultiDottedExtensions = true; //soporte para varias extensiones
                openFile.DefaultExt = "*.png";
                openFile.Filter = "Archivos de Imagenes (*.png;*.jpeg)|*.png;*.jpeg| All files (*.*)|*.*";
                openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
                openFile.FileName = "";
                if (openFile.ShowDialog(this) == DialogResult.OK)
                {

                    try
                    {
                        pcbFoto.ImageLocation = openFile.FileName;
                        pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                        //convertir la imagen en bytes
                        byte[] cadenaByte = File.ReadAllBytes(openFile.FileName);
                        //almacenamos los bytes en el tag del picture
                        pcbFoto.Tag = (byte[])cadenaByte;
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

        #region Mostrar un ejemplo de correo
        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "someone@ejemplo.com")
            {
                txtCorreo.Text = "";

                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "someone@ejemplo.com";

                txtCorreo.ForeColor = Color.Silver;
            }
        }
        #endregion
    }
}
