﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv8
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public List<Dependente> Dependentes { get; set; }
    }
}
