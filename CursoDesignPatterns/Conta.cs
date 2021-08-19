using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public EstadoDeUmaConta EstadoAtual { get; set; }
        public String Titular { get; private set; }
        public double Saldo { get; set; }
        public int Numero { get; private set; }
        public int Agencia { get; private set; }
        public DateTime DataAbertura { get; private set; }

        public void Deposita(String titular, double valor)
        {
            this.Titular = titular;
            this.Saldo += valor;
        }

        public void DepositoCod(double valor)
        {
            EstadoAtual.DepositoCond(this, valor);
        }
        public void SaqueCod(double valor)
        {
            EstadoAtual.SaqueCond(this, valor);
        }

    }

    public enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }
}
