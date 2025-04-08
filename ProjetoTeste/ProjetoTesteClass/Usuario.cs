using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoTesteClass
{
    public class Usuario
    {
        // Propriedades da classe:
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set;}
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        // Métodos construtores da classe:
        public Usuario() { }
        public Usuario(int id, string nome, string email, string telefone,string senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            Ativo = ativo;
        }
        public Usuario(string nome, string email, string telefone,string senha)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;
        }

        // Métodos da classe
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario = new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetBoolean(5)
                    );
            }

            return usuario;
        }

        public static List<Usuario> ObterLista()
        {
            List<Usuario> lista = new();

            var cmd = Banco.Abrir();

            // espera um comando text
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios";
            //Executa o comando
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add
                    (new
                        (
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetString(4),
                            dr.GetBoolean(5)
                        )
                    );
            }


            return lista;
        }

        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into usuarios (nome, email, telefone, senha, default)" +
                $"values ('{Nome}','{Email}','{Telefone}', md5('{Senha}'), default)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select last_insert_id()";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static void Arquivar(int id)
        {
            var usuario = ObterPorId(id);
            if (usuario.Ativo)
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update usuarios set ativo = 0 " +
                                  $"where id = {id}";
                cmd.ExecuteNonQuery();
            }
        }

        public static void Restaurar(int id)
        {
            var usuario = ObterPorId(id);
            if (!usuario.Ativo)
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update usuarios set ativo = 1 " +
                                  $"where id = {id}";
                cmd.ExecuteNonQuery();
            }
        }
    }
}
