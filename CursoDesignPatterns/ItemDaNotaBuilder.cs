﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class ItemDaNotaBuilder
    {
        public String Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Nome, Valor);
        }
        public ItemDaNotaBuilder ComNome(String nome)
        {
            Nome = nome;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            Valor = valor;
            return this;
        }
    }
}
