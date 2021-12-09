using System;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemasInterno = new(); 

            Diretor roberta = new("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new("326958628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiroComercial = new();
            parceiroComercial.Senha = "159";

            Console.WriteLine  ("---------------------------------------------------------");

            sistemasInterno.Logar(roberta, "123");
            sistemasInterno.Logar(roberta, "abc");

            Console.WriteLine  ("---------------------------------------------------------");

            sistemasInterno.Logar(camila, "123");
            sistemasInterno.Logar(camila, "abc");

            Console.WriteLine  ("---------------------------------------------------------");

            sistemasInterno.Logar(parceiroComercial, "159");
            sistemasInterno.Logar(parceiroComercial, "asd");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new();

            Designer pedro = new("833.222.084-39");
            pedro.Nome = "Pedro";
            Diretor roberta = new("159.753.398-04");
            roberta.Nome = "Roberta";
            Auxiliar igor = new("981.198.778-53");
            igor.Nome = "Igor";
            GerenteDeConta camila = new("326958628-89");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificação do mês: "+gerenciadorBonificacao.GetTotalBonificacao());
        }


    }
}
