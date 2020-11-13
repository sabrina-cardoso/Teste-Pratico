using LojaMariaBonita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LojaMariaBonita.Controllers
{

    public class ClientesController : ApiController
    {
        
        private readonly ClienteRepositorio _clienteRepositorio;

        public ClientesController()
        {
            _clienteRepositorio = new ClienteRepositorio();
        }

        [HttpGet]
        [Route("api/clientes")]
        public IEnumerable<Cliente> List()
        {
            return _clienteRepositorio.All;
        }

        [HttpGet()]
        [Route("api/clientes")]
        public Cliente GetCliente(int id)
        {
            return _clienteRepositorio.Find(id);       
        }

        [HttpPost()]
        [Route("api/clientes")]
        public void Post(Cliente cliente)
        {
            _clienteRepositorio.Create(cliente);
        }

        [HttpPut()]
        [Route("api/clientes")]
        public void Put(int id, Cliente cliente)
        {
            cliente.Id = id;
            _clienteRepositorio.Update(id, cliente);
        }

        [HttpDelete()]
        [Route("api/clientes")]
        public void Delete(int id)
        {
            _clienteRepositorio.Delete(id);
        }



    }

}
