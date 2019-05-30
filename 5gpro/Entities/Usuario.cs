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
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.|tbNomeUsuario", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória.|tbSenhaUsuario", AllowEmptyStrings = false)]
        public string Senha { get; set; }

        public string Email { get; set; }
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe o grupo de acesso do usuário.|buscaGrupoUsuario", AllowEmptyStrings = false)]
        public GrupoUsuario Grupousuario { get; set; }


    }
}
