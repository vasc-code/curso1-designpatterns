using System;

namespace CursoDesignPatterns
{
    public class ItemDaNota
    {
        public ItemDaNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public String Nome { get; private set; }
        public double Valor { get; private set; }

    }
}