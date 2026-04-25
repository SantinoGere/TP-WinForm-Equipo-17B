using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winforms_app
{
    public partial class frmListadoArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmListadoArticulos()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmListadoArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            cargar();

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                lblNombre.Text = seleccionado.Nombre;
                lblDescripcion.Text = seleccionado.Descripcion;

                if (seleccionado.Imagenes != null && seleccionado.Imagenes.Count > 0)
                {
                    try
                    {
                        pbArticulo.Load(seleccionado.Imagenes[0].UrlImagen);
                    }
                    catch
                    {
                        pbArticulo.Load("https://via.placeholder.com/150");
                    }
                }
                else
                {
                    pbArticulo.Load("https://via.placeholder.com/150");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();

        }

        private void txtFiltradoRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltradoRapido.Text;

            if(filtro.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Codigo.ToLower().Contains(filtro.ToLower()));
                
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            try
            {
                dgvArticulos.DataSource = listaFiltrada;
                dgvArticulos.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
    }
}
