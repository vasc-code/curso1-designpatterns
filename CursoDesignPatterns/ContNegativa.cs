using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class ContaNegativa : EstadoDeUmaConta
    {
        public void DepositoCond(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0) conta.EstadoAtual = new ContaPositiva();
        }

        public void SaqueCond(Conta conta, double valor)
        {
            throw new Exception("Sua conta está no vermleho, não é possível sacar");
        }
    }
}
