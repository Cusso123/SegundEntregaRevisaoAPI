using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class JogoMegaSena
    {
        #region Construtores
        public JogoMegaSena(string nome, string cpf, int primeiroNro, int segundoNro, int terceiroNro, int quartoNro, int quintoNro, int sextoNro, DateTime datajogo) 
        { 
            Nome = nome;
            CPF = cpf;
            PrimeiroNumero = primeiroNro;
            SegundoNumero = segundoNro;
            TerceiroNumero = terceiroNro;
            QuartoNumero = quartoNro;
            QuintoNumero = quintoNro;
            SextoNumero = sextoNro;
        }

        #endregion 

        #region Propriedades
        public string Nome { get; private set; }

        public string CPF { get; private set; }

        public int PrimeiroNumero { get; private set; }

        public int SegundoNumero { get; private set; }

        public int TerceiroNumero { get; private set; }

        public int QuartoNumero { get; private set; }

        public int QuintoNumero { get; private set; }

        public int SextoNumero { get; private set; }

        public DateTime Datajogo { get; private set; }
        #endregion

    }
}
