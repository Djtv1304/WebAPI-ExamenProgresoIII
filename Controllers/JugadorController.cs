using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_Productos_ProgramacionIV.Data;
using WebAPI_Productos_ProgramacionIV.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_Productos_ProgramacionIV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadorController : ControllerBase
    {

        // Todo atributo private debe ir con guion bajo
        private readonly ApplicationDBContext _db;

        public JugadorController(ApplicationDBContext db)
        {
            // Inyección de dependencias, inyecto la dependencia de la DB
            _db = db;

        }

        // GET: api/<JugadorController>
        [HttpGet("/PartidasJugador/{idJugador}")]
        public async Task<IActionResult> GetPartidasByJugador(int idJugador)
        {
            try
            {
                // Utilizo Entity Framework para consultar las visitas asociadas a un miembro mediante su ID
                var partidasJugador = await _db.Partida
                    .Where(data => data.JugadorUnoID == idJugador || data.JugadorDosID == idJugador)
                    .ToListAsync();

                return Ok(partidasJugador);
            }
            catch (Exception ex)
            {
                // Manejo de errores
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }

        // GET api/<JugadorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JugadorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JugadorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JugadorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
