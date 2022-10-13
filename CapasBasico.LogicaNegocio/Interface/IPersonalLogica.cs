using CapasBasico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapasBasico.LogicaNegocio.Interface
{
    public interface IPersonalLogica
    {
        IEnumerable<Personal> GetAllPersonal();
    }
}
