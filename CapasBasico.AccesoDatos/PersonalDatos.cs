using CapasBasico.AccesoDatos.Interface;
using CapasBasico.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CapasBasico.AccesoDatos
{
    public class PersonalDatos : IPersonalDatos
    {
        private readonly CapasNetContext _context;

        public PersonalDatos(CapasNetContext context) { 
            _context = context;
        }

        public IEnumerable<Personal> GetAll() {
            return _context.Personals.Include(c => c.IdCargoNavigation).ToList();
        }
    }
}
