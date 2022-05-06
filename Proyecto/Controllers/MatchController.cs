using Datos.Contextos;
using Datos.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Pojos;
using Servicios.Servicios;

namespace Proyecto.Controllers
{

    namespace TestCosmo.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class MatchController : ControllerBase
        {
            MatchServicio CrearServicio()
            {
                Conexion db = new Conexion();
                MatchRepositorio repo = new MatchRepositorio(db);
                MatchServicio servicio = new MatchServicio(repo);
                return servicio;
            }

            [HttpGet]
            public ActionResult<List<Match>> Get()
            {
                var servicio = CrearServicio();
                return Ok(servicio.Listar());
            }

            [HttpGet("{idUsuario}")]
            public ActionResult<Match> Get(string idUsuario)
            {
                var servicio = CrearServicio();
                return Ok(servicio.seleccionarPorIdUsuario(idUsuario));
            }

            [HttpPost]
            public ActionResult Post([FromBody] Match match)
            {
                var servicio = CrearServicio();
                servicio.Agregar(match);
                return Ok("Agregada Satisfactoriamente");
            }

            [HttpPut("{id}")]
            public ActionResult Put(Guid id, [FromBody] Match match)
            {
                var servicio = CrearServicio();
                match._id = id;
                servicio.Editar(match);
                return Ok("Editado correctamennte");

            }

            [HttpDelete("{id}")]
            public ActionResult Delete(Guid id)
            {
                var servicio = CrearServicio();
                servicio.Eliminar(id);
                return Ok("Eliminado correctamente");

            }
        }
    }

}
