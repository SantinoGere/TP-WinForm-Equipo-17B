Grupo 17B | Programación 3 - UTN FRGP

Consigna TP WinForm
Requisitos de finalización
Se necesita una aplicación para la gestión de artículos de un catálogo de un comercio. La aplicación debe ser genérica, es decir, aplicar para cualquier tipo de comercio; y la información que en ella se cargue será consumida luego desde distintos servicios para ser mostradas ya sea en webs, e-commerces, apps mobile, revistas, etc. Esto no es parte del desarrollo, pero sí del contexto en el cual se utilizará la aplicación a desarrollar.
Deberá ser un programa de escritorio que contemple la administración de artículos. Las funcionalidades que deberá tener la aplicación serán:
Listado de artículos.
Búsqueda de artículos por distintos criterios.
Agregar artículos.
Modificar artículos.
Eliminar artículos.
Ver detalle de un artículo.
Toda esta información deberá ser persistida en una base de datos ya existente (la cual se adjunta).
Los datos mínimos con los que deberá contar el artículo son los siguientes:
Código de artículo.
Nombre.
Descripción.
Marca (seleccionable de una lista desplegable).
Categoría (seleccionable de una lista desplegable).
Imagen.
Precio.
El programa debe permitir administrar las Marcas y Categorías disponibles en el programa. Además, un producto podría llegar a tener una o más imágenes, sin un límite establecido. Esto debe estar contemplado en la gestión del artículo.
Etapa 1: Construir las clases necesarias para el modelo de dicha aplicación junto a las ventanas con las que contará y su navegación.
Etapa 2: Construir la interacción con la base de datos y validaciones correspondiente para dar vida a la funcionalidad.

==============================================================================================================================================================================================================================================================================================================================================================================

MODELO DE DOMINIO
 
-          ARTÍCULO
o   Id | int
o   Código | string
o   Nombre | string
o   Descripción | string
o   Marca | Marca (clase) 
o   Categoría | Categoría
o   Precio | float
o   Imagen | Imagen (clase) (Lista)
-          CATEGORÍA
o   Id | int
o   Descripcion | string
-          MARCA
o   Id | int
o   Descripcion | string
-          IMAGEN
o   IdArticulo | int
o   Id | int
o   UrlImagen | string
-          ARTICULONEGOCIO (BBDD)
o   (Solo funciones)
o   Clase ACCESO DATOS
VISUAL – INTERFAZ
General: Tipo Pokémon, que por cada opción salte una pequeña interfaz confirmando la acción.
Filtros por: marca, artículo, desplegables, etc.
