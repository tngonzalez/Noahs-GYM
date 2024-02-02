using Capa.BLL;
using Capa.Entidades;
using Capa.Entidades.Entidades;
using Capa.UI.Registros;
using log4net; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Clientes
{
    public partial class FrmCliente : Form
    {
    
    private static readonly ILog GYMEventos = log4net.LogManager.GetLogger("NoahGYMEventos");

    public FrmCliente()
        {
            InitializeComponent();
        }
        #region Metodos Variados 

        private void Refrescar()
        {
            dgvClientes.DataSource = ClienteBLL.ObtenerTodos();
            dgvClientes.ClearSelection();
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
                //Id
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    erp.SetError(txtID, "Digite la identificación del usuario"); return;
                }
                if (!int.TryParse(txtID.Text, out int cod))
                {
                    erp.SetError(txtID, "Este campo solo permite datos numéricos"); return;
                }
                //Nombre
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    erp.SetError(txtNombre, "Digite el nombre del usuario"); return;
                }

                //Apellidos 
                if (string.IsNullOrEmpty(txtApellidos.Text))
                {
                    erp.SetError(txtApellidos, "Digite los apellidos de usuario"); return;
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

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Refrescar();
            CargarCombo();
            IniciarFotografia();

            //Limpiar
            dgvClientes.ClearSelection(); 
            txtID.Clear(); 
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtContra.Clear();
            cmbGenero.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now; 
            mskTelefono.Clear();
            pcbFoto.Image = Capa.UI.Properties.Resources.UserIcon; 
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    var oCli = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;

                    txtID.Text = oCli.ID.ToString();
                    txtNombre.Text = oCli.Nombre;
                    txtApellidos.Text = oCli.Apellidos;
                    txtContra.Text = oCli.Clave;
                    txtCorreo.Text = oCli.Correo;
                    cmbGenero.SelectedValue = oCli.IdGenero;
                    cmbGenero.SelectedItem = oCli.Genero;
                    mskTelefono.Text = oCli.Telefono;
                    dtpFechaNacimiento.Value = (DateTime)oCli.FechaNacimiento;

                    //Conver Imagen
                    ImageConverter img = new ImageConverter();
                    pcbFoto.Image = (Bitmap)img.ConvertFrom(oCli.Foto);

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

                    Cliente oCli = new Cliente();

                    oCli.ID = Convert.ToInt32(txtID.Text);
                    oCli.Nombre = txtNombre.Text;

                    oCli.Telefono = mskTelefono.Text;
                    oCli.IdGenero = (int)cmbGenero.SelectedValue;
                    oCli.Genero = cmbGenero.SelectedItem as Genero;
                    oCli.Clave = txtContra.Text;
                    oCli.Apellidos = txtApellidos.Text;
                    oCli.Foto = (byte[])pcbFoto.Tag;
                    oCli.FechaNacimiento = dtpFechaNacimiento.Value;
                    oCli.Correo = txtCorreo.Text;

                    ClienteBLL oBLL = new ClienteBLL();
                    oBLL.Guardar(oCli);
                    Refrescar();

                    MessageBox.Show("Miembro registrado exitosamente! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Limpiar
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    cmbGenero.SelectedIndex = -1;
                    dtpFechaNacimiento.Value = DateTime.Now;
                    txtCorreo.Text = "";
                    txtContra.Text = "";
                    mskTelefono.Text = "";
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
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    var Pregunta = MessageBox.Show("¿Esta seguro que desea eliminar el usuario seleccionado?", "Eliminación permanente",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Pregunta == DialogResult.Yes)
                    {
                        ClienteBLL oBLL = new ClienteBLL();
                        oBLL.Eliminar(Convert.ToInt32(txtID.Text));
                        Refrescar();

                        MessageBox.Show("El miembro se ha eliminado de manera exitosa! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //Limpiar
                        txtID.Text = "";
                        txtNombre.Text = "";
                        txtApellidos.Text = "";
                        cmbGenero.SelectedIndex = -1;
                        dtpFechaNacimiento.Value = DateTime.Now;
                        txtCorreo.Text = "";
                        txtContra.Text = "";
                        mskTelefono.Text = "";
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

        private void btnMedidas_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    var oCli =
                        dgvClientes.SelectedRows[0].DataBoundItem;

                    var frm = new FrmMedidas();

                    frm.Cliente = (Cliente)oCli;
                    frm.ShowDialog();
                    dgvClientes.ClearSelection(); 

                }
                else
                {
                    MessageBox.Show("Primero debe seleccionar el usuario", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btnMembresias_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    var oCli =
                        dgvClientes.SelectedRows[0].DataBoundItem;

                    var frm = new FrmMembresias();

                    frm.oCliente = (Cliente)oCli;
                    frm.ShowDialog();
                    dgvClientes.ClearSelection(); 
                }
                else
                {
                    MessageBox.Show("Primero debe seleccionar el usuario", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
    }
}
