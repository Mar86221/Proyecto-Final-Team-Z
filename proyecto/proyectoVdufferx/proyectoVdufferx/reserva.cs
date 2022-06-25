using System;

namespace proyectoVdufferx;

public class reserva
{
    public int id_usuario { get; set; }
    public int id_ejemplar { get; set; }
    public DateTime fecha_reserva { get; set; }
    public DateTime fecha_devolucion { get; set; }
}