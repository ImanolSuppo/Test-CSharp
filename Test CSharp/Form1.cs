using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_CSharp
{
    public partial class Videojuegos : Form
    {
        private ConexionDB helper = new ConexionDB();
        public Videojuegos()
        {
            InitializeComponent();
        }

        private void Videojuegos_Load(object sender, EventArgs e)
        {
            cbnCategoria.DropDownStyle=ComboBoxStyle.DropDownList;
            cbnPEGI.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarCombo("select * from categoria", cbnCategoria, "categoria", "cod_categoria");
            CargarCombo("select * from PEGI", cbnPEGI, "PEGI", "cod_PEGI");
            CargarLista();
            Limpiar();
            Habilitar(false);
        }

        private void Habilitar(bool x)
        {
            txtNombre.Enabled = x;
            txtEmpresa.Enabled = x;
            txtPrecio.Enabled = x;
            txtStock.Enabled = x;
            cbnCategoria.Enabled = x;
            cbnPEGI.Enabled = x;
            dtpFechaLanzamiento.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnCancelar.Enabled = x;
            lstVideojuegos.Enabled = !x;
        }

        private void Limpiar()
        {
            txtEmpresa.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cbnCategoria.SelectedIndex = 0;
            cbnPEGI.SelectedIndex = 0;
            dtpFechaLanzamiento.Value = DateTime.Today;
        }

        private void CargarLista()
        {
            DataTable table = helper.ConsultarDatos("select * from VideoJuego");
            lstVideojuegos.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                VideoJuego vj = new VideoJuego();
                vj.Nombre = row["nombre"].ToString();
                vj.Empresa = row["empresa"].ToString();
                vj.FechaLanzamiento = Convert.ToDateTime(row["fecha_Lanzamiento"].ToString());
                vj.Categoria = Convert.ToInt32(row["cod_categoria"].ToString());
                vj.EdadPermitida = Convert.ToInt32(row["cod_PEGI"].ToString());
                vj.Stock = Convert.ToInt32(row["stock"].ToString());
                vj.Precio = Convert.ToInt32(row["precio"].ToString());
                lstVideojuegos.Items.Add(vj);
            }
        }

        private void CargarCombo(string cadena, ComboBox cbn, string display, string value)
        {
            DataTable table = helper.ConsultarDatos(cadena);
            cbn.DataSource = table;
            cbn.DisplayMember = display;
            cbn.ValueMember = value;
            cbn.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            txtNombre.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string query = "";
            if (!Existe() && Validar())
            {
                query = "insert into videojuego(nombre,precio,cod_PEGI,stock,cod_categoria,fecha_lanzamiento,empresa) values(@nombre,@precio,@PEGI,@stock,@categoria,@fechaLanzamiento,@empresa)";
            }
            else if(Existe()&&Validar())
            {
                query = "update videojuego set nombre=@nombre,precio=@precio,cod_PEGI=@PEGI,stock=@stock,cod_categoria=@categoria,fecha_lanzamiento=@fechaLanzamiento,empresa=@empresa where nombre=@nombre";
            }
            else
            {
                MessageBox.Show("Error. No se pudo guardar los datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            VideoJuego vj = new VideoJuego();
            vj.Nombre = txtNombre.Text;
            vj.Empresa = txtEmpresa.Text;
            vj.Precio = Convert.ToInt32(txtPrecio.Text);
            vj.Stock = Convert.ToInt32(txtStock.Text);
            vj.Categoria = Convert.ToInt32(cbnCategoria.SelectedValue);
            vj.EdadPermitida = Convert.ToInt32(cbnPEGI.SelectedValue);
            vj.FechaLanzamiento = dtpFechaLanzamiento.Value;
            helper.EjecutarDatos(query, vj);
            MessageBox.Show("Se guardó con exito!", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            Habilitar(false);
            CargarLista();
        }

        private bool Validar()
        {

            if (txtNombre.Text == "" || txtEmpresa.Text == "" || txtPrecio.Text == "" || txtStock.Text == "")
            {
                return false;
            }
            if(cbnCategoria.SelectedIndex<0|| cbnPEGI.SelectedIndex<0)
            {
                return false;
            }
            if(!int.TryParse(txtPrecio.Text,out int precio) || !int.TryParse(txtStock.Text,out int stock))
            {
                return false;
            }
            return true;
        }

        private bool Existe()
        {
            string query = "select * from videojuego where nombre = '" + txtNombre.Text + "' and empresa = '" + txtEmpresa.Text + "'";
            DataTable filas = helper.ConsultarDatos(query);
            if (filas.Rows.Count >= 1)
            {
                return true;
            }
            return false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void lstVideojuegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVideojuegos.SelectedIndex != -1)
            {
                VideoJuego vj = (VideoJuego)lstVideojuegos.SelectedItem;
                txtNombre.Text=vj.Nombre;
                txtEmpresa.Text = vj.Empresa;
                txtPrecio.Text = vj.Precio.ToString();
                txtStock.Text = vj.Stock.ToString();
                cbnCategoria.SelectedValue=vj.Categoria.ToString();
                cbnPEGI.SelectedValue = vj.EdadPermitida.ToString();
                dtpFechaLanzamiento.Value = vj.FechaLanzamiento;
            }
        }
    }
}
