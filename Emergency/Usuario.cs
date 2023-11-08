using System;
using System.Collections.Generic;

namespace Emergency;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Paterno { get; set; } = null!;

    public string? Materno { get; set; }

    public string? Correo { get; set; }

    public string Clave { get; set; } = null!;

    public int Edad { get; set; }

    public double? Altura { get; set; }

    public double? Peso { get; set; }

    public string? Enfermedad { get; set; }

    public string? Alergias { get; set; }

    public string? Telefono { get; set; }

    public string? TelefonoEmergencias { get; set; }

    public string? Tutor { get; set; }

    public string? Otro { get; set; }
}
