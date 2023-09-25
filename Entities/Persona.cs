using System;
using System.Collections.Generic;

namespace LamasKpita.DataContext;

public partial class Persona
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? Edad { get; set; }

    public string? Email { get; set; }

    public DateTime? FechaNacimiento { get; set; }
}
