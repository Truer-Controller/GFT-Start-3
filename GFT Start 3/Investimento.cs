using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Start_3
{
     class Investimento
    {
        public double ValorInicial { get; set; }
        public double JurosMensais { get; set; }

        public Investimento()
        {

        }
        public Investimento(double valorInicial, double jurosMensais)
        {
            ValorInicial = valorInicial;
            JurosMensais = jurosMensais / 100;
        }

        public double calcularLucro(int meses)
        {
            return ((ValorInicial * Math.Pow((1 + JurosMensais), meses)) - ValorInicial);
        }
      
    }
}
