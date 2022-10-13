using System;
using System.Collections.Generic;

namespace CapasBasico.Entidades
{
    public partial class Cargo
    {
        public Cargo()
        {
            Personals = new HashSet<Personal>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Personal> Personals { get; set; }
    }
}
