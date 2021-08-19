using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class ContaPositiva : EstadoDeUmaConta
    {
        public void SaqueCond(Conta conta, double valor)
        {
            conta.Saldo -= valor;
            if (conta.Saldo < 0) conta.EstadoAtual = new ContaNegativa();
        }

        public void DepositoCond(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }
    }
}
