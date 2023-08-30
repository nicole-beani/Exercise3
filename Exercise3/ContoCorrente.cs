using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class ContoCorrente
    {
        private string Nome { get; set; }
        private string Cognome { get; set; }
        public double Saldo { get; set; }

        public bool ContoAperto = false;

        public void AprireConto(double tot)
        {
            if (ContoAperto) { Console.WriteLine("Conto già aperto!"); }
            else
            {
                Saldo = 0;
                ContoAperto = true;
                if (tot >= 1000) Versamento(tot);
                else Console.WriteLine("Aggiungi soldi");
            }
        }
        public double Versamento(double tot)
        {
            return Saldo += tot;
        }
        public double Prelievo(double tot)
        {
            return Saldo -= tot;
        }
        public string StatoDelConto()
        {
            return $"Il conto è intestato a {Nome} {Cognome}. Il Saldo totale è {Saldo}";
        }
        public ContoCorrente() { }
        public ContoCorrente(string Nome, string Cognome)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
        }
    }
}
