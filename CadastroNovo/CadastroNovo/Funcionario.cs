using System;

namespace CadastroNovo
{
    public class Funcionario
    {
        public string Nome { get; set; } = "";
        public string Cargo { get; set; } = "";
        public DateTime Nascimento { get; set; } = DateTime.Today;
        public DateTime Admissao { get; set; } = DateTime.Now;
        public double tempodeCasa { get; set; } = new();
        public double idade { get; set; } = new();




        public double TempodeCasa()
        {
            TimeSpan r = DateTime.Now - Admissao;
            int dias = r.Days;
            double anos = dias / 365;
            return anos;
        }
        public double CalculaIdade()
        {
            TimeSpan r = DateTime.Now - Nascimento;
            int dias = r.Days;
            double anos = dias / 365;
            return anos;



        }
    }


    

}