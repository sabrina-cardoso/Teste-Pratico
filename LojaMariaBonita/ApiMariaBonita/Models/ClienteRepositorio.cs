using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaMariaBonita.Models
{
    public class ClienteRepositorio
    {
        private List<Cliente> _cliente;

        public ClienteRepositorio()
        {
            InicializaDados();
        }

        private void InicializaDados()
        {
            _cliente = DalCliente.GetClientes();
        }

        public IEnumerable<Cliente> All
        {
            get
            {
                return _cliente;
            }
        }
        public Cliente Find(int id)
        {
            return DalCliente.GetCliente(id);
        }

        public void Create(Cliente cliente)
        {
            DalCliente.CreateCliente(cliente);
        }

        public void Update(int id, Cliente cliente)
        {
            DalCliente.UpdateCliente(id, cliente);
        }

        public void Delete(int id)
        {
            DalCliente.DeleteCliente(id);
        }

    }
}