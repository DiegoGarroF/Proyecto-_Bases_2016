using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Controlador;
using Modelo;


namespace Vista
{
    public partial class frmListaGeneral : Form
    {
        private SqlDataReader dataReader;
        private clsUsuario usuario;
        private clsConexion conexion;
        private clsLibro libro;
        private clsPrestamo prestamo;
        private int idUsuario;
        public frmListaGeneral(clsConexion cone)
        {
            InitializeComponent();
            usuario = new clsUsuario();
            this.conexion = cone;
            this.libro = new clsLibro();
            this.prestamo = new clsPrestamo();
            this.conexion.codigo = "123";
            this.conexion.clave = "123";
        }

        private void frmListaGeneral_Load(object senqder, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvGeneral_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvGeneral.Items.Count; i++)
            {
                if (lvGeneral.Items[i].Selected)
                {
                    idUsuario = Convert.ToInt32(lvGeneral.Items[i].Text);
                }
            }
        }
        public int mIdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        //libros
        public void cargarListViewLibros()
        {

            dataReader = libro.mSeleccionarTodos(conexion);
            lvGeneral.Items.Clear();
            if (dataReader != null)
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(dataReader.GetInt32(0)));
                    item.SubItems.Add(dataReader.GetString(1));
                    lvGeneral.Items.Add(item);
                }
        }
        // Usuario
        public void cargarListViewUsuarios()
        {

            dataReader = usuario.mConsultaGeneral(conexion);

            if (dataReader != null)
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(dataReader.GetInt32(0)));
                    item.SubItems.Add(dataReader.GetString(1) +" "+ dataReader.GetString(3));
                    lvGeneral.Items.Add(item);
                }
        } 

        //Metodo que se utiliza para cargar los usuariosClientes
        public void cargarListViewUsuariosCliente()
        {
            dataReader = prestamo.mConsultaGeneralCliente(conexion);

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(dataReader.GetInt32(0)));
                    item.SubItems.Add(dataReader.GetString(1));
                    lvGeneral.Items.Add(item);
                }
            }
        }
    }
}
