using System;

namespace proyectoVdufferx;

public class prestamo
{
    public int id_usuario { get; set; }
    public int id_ejemplar { get; set; }
    public string fecha_prestamo { get; set; }
    public string fecha_devolucion { get; set;}
}