using System;
using System.Collections.Generic;

namespace CapasBasico.Entidades
{
    public partial class Personal
    {
        public string NumeroDocumento { get; set; } = null!;
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? Edad { get; set; }
        public int IdCargo { get; set; }

        public virtual Cargo IdCargoNavigation { get; set; } = null!;
    }
}
