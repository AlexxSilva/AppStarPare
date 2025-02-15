﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStarPare.Models
{
    public abstract class VeiculoFactory
    {
        public abstract IVeiculo CriarVeiculo(string placa);
    }
}
