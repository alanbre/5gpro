using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public class Usuario
    {
        public string Codigo { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.|tbNomeUsuario", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O Login é obrigatório.|tbLoginUsuario", AllowEmptyStrings = false)]
        public string Login { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória.|tbSenhaUsuario", AllowEmptyStrings = false)]
        public string Senha { get; set; }

        public string Email { get; set; }
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe o grupo de acesso do usuário.|tbCodGrupoUsuario", AllowEmptyStrings = false)]
        public GrupoUsuario Grupousuario { get; set; }



        public Usuario()
        {

        }

        public Usuario(string codigo, string nome, string sobrenome, string login, string senha, string email, string telefone, GrupoUsuario grupousuario)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Login = login;
            this.Senha = senha;
            this.Email = email;
            this.Telefone = telefone;
            this.Grupousuario = grupousuario;
        }

    }
}
