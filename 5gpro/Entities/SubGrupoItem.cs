﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public class SubGrupoItem
    {
        public int SubGrupoItemID { get; set; }
        public string Nome { get; set; }
        public GrupoItem GrupoItem { get; set; }
    }
}
