using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public class GrupoUsuario
    {
        public int GrupoUsuarioID { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.|tbNomeGrupoUsuario", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        public List<Permissao> Permissoes { get; set; }

    }
}
