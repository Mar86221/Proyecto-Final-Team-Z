using System;

namespace proyectoVdufferx
{
    public class ejemplar
    {
        public int id { get; set; }
        public string etiqueta { get; set; }     
        public string nombre { get; set; }
        public string Palabras_claves { get; set; }
        public DateTime fecha_publicacion { get; set; }
        public int id_coleccion { get; set; }
        public int id_editorial { get; set; }
        public int id_idioma { get; set; }
        public int id_formato { get; set; }
    }
}