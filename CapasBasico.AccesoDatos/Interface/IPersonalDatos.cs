using CapasBasico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapasBasico.AccesoDatos.Interface
{
    public interface IPersonalDatos
    {
        IEnumerable<Personal> GetAll();
    }
}
