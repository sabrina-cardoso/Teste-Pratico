using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LojaMariaBonita.Models
{
    public class DalCliente
    {

        //Puxa todos os Clientes da tabela
        public static List<Cliente> GetClientes()
        {
            try
            {
                List<Cliente> _clientes = new List<Cliente>();

                SqlConnection con = new SqlConnection(@"Server=DESKTOP-4HDF6K5;Database=DBMariaBonita;User Id=sa;Password=01061999;");
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM tblClientes", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.Id = Convert.ToInt32(dr["Id"]);
                    cliente.Nome = dr["Nome"].ToString();
                    cliente.Telefone = dr["Telefone"].ToString();
                    cliente.DataNasc = dr["DataNasc"].ToString();
                    cliente.Email = dr["Email"].ToString();
                    cliente.CEP = dr["CEP"].ToString();
                    cliente.Estado = dr["Estado"].ToString();
                    cliente.Cidade = dr["Cidade"].ToString();
                    cliente.Bairro = dr["Bairro"].ToString();
                    cliente.Rua = dr["Rua"].ToString();
                    cliente.Numero = dr["Numero"].ToString();
                    cliente.PontoRef = dr["PontoRef"].ToString();

                    _clientes.Add(cliente);
                }

                return _clientes;

            }
            catch (Exception)
            {

                throw;
            }

        }

        //Puxa apenas um Cliente da tabela pelo ID
        public static Cliente GetCliente(int id)
        {
            try
            {
                Cliente cliente = new Cliente();

                SqlConnection con = new SqlConnection(@"Server=DESKTOP-4HDF6K5;Database=DBMariaBonita;User Id=sa;Password = 01061999;");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblClientes Where Id=" + id, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    cliente.Id = Convert.ToInt32(dr["Id"]);
                    cliente.Nome = dr["Nome"].ToString();
                    cliente.Telefone = dr["Telefone"].ToString();
                    cliente.DataNasc = dr["DataNasc"].ToString();
                    cliente.Email = dr["Email"].ToString();
                    cliente.CEP = dr["CEP"].ToString();
                    cliente.Estado = dr["Estado"].ToString();
                    cliente.Cidade = dr["Cidade"].ToString();
                    cliente.Bairro = dr["Bairro"].ToString();
                    cliente.Rua = dr["Rua"].ToString();
                    cliente.Numero = dr["Numero"].ToString();                 
                    cliente.PontoRef = dr["PontoRef"].ToString();
                    
                }

                return cliente;

            }
            catch (Exception)
            {

                throw;
            }

        }


        //Cria um cliente na tabela
        public static void CreateCliente([FromBody]Cliente cliente)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=DESKTOP-4HDF6K5;Database=DBMariaBonita;User Id=sa;Password = 01061999;");

                string sql = "Insert into tblClientes(Nome,Telefone,Datanasc,Email,CEP,Estado,Cidade,Bairro,Rua,Numero,PontoRef)"+
                    "values (@Nome,@Telefone,@DataNasc,@Email,@CEP,@Estado,@Cidade,@Bairro,@Rua,@Numero,@PontoRef)";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@DataNasc", cliente.DataNasc);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@Rua", cliente.Rua);
                cmd.Parameters.AddWithValue("@Numero", cliente.Numero);
                cmd.Parameters.AddWithValue("@PontoRef", cliente.PontoRef);
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception)
            {
                throw;
            }

        }

        //Atualiza um cliente da tabela
        public static void UpdateCliente(int id, [FromBody]Cliente cliente)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=DESKTOP-4HDF6K5;Database=DBMariaBonita;User Id=sa;Password = 01061999;");

                string sql = "Update tblClientes set Nome = @Nome,@Telefone,@DataNasc,@Email,@CEP," +
                    "@Estado,@Cidade,@Bairro,@Rua,@Numero,@PontoRef where Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@DataNasc", cliente.DataNasc);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@Rua", cliente.Rua);
                cmd.Parameters.AddWithValue("@Numero", cliente.Numero);
                cmd.Parameters.AddWithValue("@PontoRef", cliente.PontoRef);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Deleta um cliente da tabela
        public static void DeleteCliente(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=DESKTOP-4HDF6K5;Database=DBMariaBonita;User Id=sa;Password = 01061999;");
                SqlCommand cmd = new SqlCommand("Delete from tblClientes where Id = @Id", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}