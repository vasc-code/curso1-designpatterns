using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public interface EstadoDeUmaConta
    {
        void SaqueCond(Conta conta, double valor);
        void DepositoCond(Conta conta, double valor);
    }
}
