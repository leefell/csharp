using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET: api/<UsuarioController>
        //Este verbo é utilizado para solicitar dados de um recurso específico ou de uma coleção de recursos
        [HttpGet]
        public IEnumerable<UsuarioModel> Get()
        {
            List<UsuarioModel> usuarioModels = new List<UsuarioModel>();

            usuarioModels.Add(new UsuarioModel() { Id = 1, Nome = "Alexandre Augusto", Email = "alexandre@gmail.com" });

            return usuarioModels;
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public UsuarioModel Get(int id)
        {
            UsuarioModel usuario = new UsuarioModel() { Id = 1, Nome = "Alexandre Augusto", Email = "alexandre@gmail.com" };

            return usuario;
        }

        // POST api/<UsuarioController>
        // O método POST é utilizado para enviar dados para o servidor para criar um novo recurso
        [HttpPost]
        public void Post([FromBody] UsuarioModel usuario)
        {   // fromBody significa que os dados vão vir do corpo da API
        }

        // PUT api/<UsuarioController>/5
        //O método PUT é utilizado para atualizar um recurso existente ou criar um novo recurso se ele não existir.
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UsuarioModel usuario)
        {
        }

        // DELETE api/<UsuarioController>/5
        //o método DELETE é utilizado para excluir um recurso específico. 
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
