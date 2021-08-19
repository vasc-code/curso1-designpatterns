using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ImpressaoMultiplicado : AcaoAposGerarNota
    {
        public ImpressaoMultiplicado(double fator)
        {
            Fator = fator;
        }

        public double Fator { get; private set; }
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine(nf.ValorBruto * Fator);
        }
    }
}
