using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class RespostaEmCsv : Resposta
    {
        public Resposta OutraResposta { get; set; }

        public RespostaEmCsv(Resposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if(req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }
}
