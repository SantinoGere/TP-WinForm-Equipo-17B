using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winforms_app
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo = null;
        private ImagenNegocio imagenNegocio = new ImagenNegocio();
        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            try
            {
                this.articulo.Imagenes = new List<Imagen>();
                this.articulo.Imagenes = imagenNegocio.GetImagenes(this.articulo.Id);
            }
            catch
            {
                this.articulo.Imagenes = null;
            }
        }


        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {

            nPrecio.Controls[0].Visible = false;
            try
            {
                lblNombre.Text = articulo.Nombre;
                lblTextoCodigo.Text = articulo.Codigo;
                lblTextoMarca.Text = articulo.Marca.Descripcion;
                lblTextoCategoria.Text = articulo.Categoria.Descripcion;
                nPrecio.Value = articulo.Precio;
                rtxtDescripcion.Text = articulo.Descripcion;

                if(articulo.Imagenes != null)
                {
                    try
                    {
                        pboxImagenArticulo.Load(articulo.Imagenes[0].UrlImagen);

                    }
                    catch
                    {
                        pboxImagenArticulo.Load("https://capacitacion.fundacionbancopampa.com.ar/wp-content/uploads/2024/09/placeholder-4.png");

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
