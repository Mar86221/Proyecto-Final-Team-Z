using System;

namespace proyectoVdufferx;

public class prestamo
{
    public int id_usuario { get; set; }
    public int id_ejemplar { get; set; }
    public DateTime fecha_prestamo { get; set; }
    public DateTime fecha_devolucion { get; set;}
}