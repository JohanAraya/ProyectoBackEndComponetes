using Pojos;
using Pojos.Interfaces.Repositorios;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Servicios.Servicios
{
    public class MatchServicio : IServicioBase<Match, Guid>
    {

        private readonly IRepositorioBase<Match, Guid> repoMatch;

        public MatchServicio(IRepositorioBase<Match, Guid> _repoMatch)
        {
            repoMatch = _repoMatch;
        }
        public Match Agregar(Match entidad)
        {
            if (entidad == null)
            {
                throw new ArgumentNullException("Error");
            }

            var resultMatch = repoMatch.Agregar(entidad);
            repoMatch.guardarTodosLosCambios();
            return resultMatch;
        }

        public void Editar(Match tentidad)
        {
            if (tentidad == null)
            {
                throw new ArgumentNullException("El match es requerido para editar");
            }

            repoMatch.Editar(tentidad);
            repoMatch.guardarTodosLosCambios();
        }

        public void Eliminar(Guid entidadId)
        {
            repoMatch.Eliminar(entidadId);
            repoMatch.guardarTodosLosCambios();
        }

        public List<Match> Listar()
        {
            return repoMatch.Listar();
        }

        public Match seleccionarPorId(Guid entidadId)
        {
            return repoMatch.seleccionarPorId(entidadId);
        }

        public Match seleccionarPorIdUsuario(string idUsuario)
        {
            return repoMatch.seleccionarPorIdUsuario(idUsuario);
        }
    }
}

