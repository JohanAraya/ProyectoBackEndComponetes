using Datos.Contextos;
using Pojos;
using Pojos.Interfaces;
using Pojos.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class MatchRepositorio : IRepositorioBase<Match, Guid>
    {
        private Conexion db;

        public MatchRepositorio(Conexion _db)
        {
            db = _db;
        }
        public Match Agregar(Match entidad)
        {
            entidad._id = Guid.NewGuid();
            db.Matches.Add(entidad);
            return entidad;
        }

        public void Editar(Match tentidad)
        {
           throw new NotImplementedException(); 
        }

        public void Eliminar(Guid entidadId)
        {
            throw new NotImplementedException();
        }

        public void guardarTodosLosCambios()
        {
            db.SaveChanges();
        }

        public List<Match> Listar()
        {
            return db.Matches.ToList();
        }

        public List<Mascota> listarPretendientes(Mascota mascota)
        {
            throw new NotImplementedException();
        }

        public Match seleccionarPorId(Guid entidadId)
        {
            var mascotaSeleccionada = db.Matches.Where(c => c._id == entidadId).FirstOrDefault();
            return mascotaSeleccionada;
        }

        public Match seleccionarPorIdUsuario(string idUsuario)
        {
            var mascotaSeleccionada = db.Matches.Where(c => c.id_usuario == idUsuario).FirstOrDefault();
            return mascotaSeleccionada;
        }
    }
}