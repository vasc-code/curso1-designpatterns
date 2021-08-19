using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();

            ItemDaNotaBuilder criadorItem1 = new ItemDaNotaBuilder();
            ItemDaNotaBuilder criadorItem2 = new ItemDaNotaBuilder();

            criadorItem1
                .ComNome("Item 1")
                .ComValor(150.0);
            criadorItem2
                .ComNome("Item 2")
                .ComValor(50);

            criador
                .ParaEmpresa("Caelum Ensino e Inovação")
                .ComCnpj("12.123.456/0001-12")
                .NaDataATual(new DateTime(2000,06,18))
                .ComItem(criadorItem1.Constroi())
                .ComItem(criadorItem2.Constroi())
                .ComObs("Uma obs qualquer");

            criador.AdicionarAcao(new EnviadorDeEmail());
            criador.AdicionarAcao(new EnviadorDeSms());
            criador.AdicionarAcao(new NotaFiscalDao());
            criador.AdicionarAcao(new ImpressoraNf());
            criador.AdicionarAcao(new ImpressaoMultiplicado(2.0));

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.WriteLine(nf.DataDeEmissao);

            Console.ReadKey();
        }
    }
}
