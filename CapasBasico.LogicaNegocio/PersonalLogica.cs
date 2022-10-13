using CapasBasico.AccesoDatos.Interface;
using CapasBasico.Entidades;
using CapasBasico.LogicaNegocio.Interface;

namespace CapasBasico.LogicaNegocio
{
    public class PersonalLogica : IPersonalLogica
    {
        private readonly IPersonalDatos _personalDatos;

        public PersonalLogica(IPersonalDatos personalDatos) 
        { 
            _personalDatos = personalDatos;
        }

        public IEnumerable<Personal> GetAllPersonal()
        {
            return _personalDatos.GetAll();
        }
    }
}
