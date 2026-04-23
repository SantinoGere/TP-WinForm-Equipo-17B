using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ImagenNegocio
    {


        public void agregar(int id, string url)
        {
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("insert into IMAGENES (IdArticulo,ImagenUrl)values(@id,@url)");
				datos.setearParametros("@id", id);
				datos.setearParametros("@url", url);

				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{

				throw;
			}
			finally
			{
				datos.cerrarConexion();
			}
        }
    }
}
