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

		public List<Imagen> GetImagenes(int id)
		{
			AccesoDatos datos = new AccesoDatos();
			List<Imagen> listaImagenes = new List<Imagen>();
			string consulta = "Select Id,ImagenUrl from IMAGENES where IdArticulo = ";
			try
			{
                consulta += id;
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];

					listaImagenes.Add(aux);

                }
				return listaImagenes;

			}
			catch (Exception)
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
