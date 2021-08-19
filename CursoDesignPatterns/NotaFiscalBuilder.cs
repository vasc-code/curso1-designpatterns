using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscalBuilder
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public String Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        private IList<AcaoAposGerarNota> todaAcoesASeremExecutadas = new List<AcaoAposGerarNota>();

        public NotaFiscalBuilder()
        {
            Data = DateTime.Now;
        }

        public void AdicionarAcao(AcaoAposGerarNota acao)
        {
            todaAcoesASeremExecutadas.Add(acao);
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal nf =  new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);

            foreach (AcaoAposGerarNota acao in todaAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComObs(String obs)
        {
            Observacoes = obs;
            return this;
        }

        public NotaFiscalBuilder NaDataATual(DateTime data)
        {
            Data = data;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }

    }
}
