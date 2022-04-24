using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojos.Interfaces
{
    public interface IListar<TEntidad, TEntidadID>
    {
        List<TEntidad> Listar();

        TEntidad seleccionarPorIdUsuario(string idUsuario);

        TEntidad seleccionarPorId(TEntidadID entidadId);
    }


}
