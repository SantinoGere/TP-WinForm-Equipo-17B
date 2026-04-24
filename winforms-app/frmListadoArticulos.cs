using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winforms_app
{
    public partial class frmListadoArticulos : Form
    {
        public frmListadoArticulos()
        {
            InitializeComponent();
        }

        private void frmListadoArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> articulos = negocio.listar();
            dgvArticulos.DataSource = articulos;
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
