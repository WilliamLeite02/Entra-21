using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Teste_01
{
    class Program
    {
        static void Main(String[] args)
        {
            //ImparEpar();
            //Nome();
            //exer3();
            // Exer4();
            //exer5();
            //exer6();
            //exer7();
            //exer8();
            exer9();
        }
        public static void ImparEpar() {
            int NumeroDigitado;
            Console.WriteLine("insira um numero:");
            NumeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (NumeroDigitado % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }
            Console.ReadKey();
        }
        public static void Nome()
        {
            string Nome;

            Console.WriteLine("informe o nome:");
            Nome = Console.ReadLine();

            //Console.WriteLine(string.Format("meu nome é: {0}",Nome));
            //Console.WriteLine("Meu nome é: "+Nome);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Meu nome é:");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Nome);
            Console.ReadKey();

        }
        public static void exer3()
        {
            double Num1, Num2, Resultado = 0;
            char Operacao;

            Console.WriteLine("Entre com a operação -->");
            Console.WriteLine("+ Adição-->");
            Console.WriteLine("- Subtração-->");
            Console.WriteLine("* Multiplicação-->");
            Console.WriteLine("/ Divisão-->");

            Console.WriteLine();

            char.TryParse(Console.ReadLine(), out Operacao);

            Console.WriteLine();
            Console.WriteLine("Informe o primeiro valor: ");
            double.TryParse(Console.ReadLine(), out Num1);

            Console.WriteLine();
            Console.Write("informe o segundo valor: ");
            double.TryParse(Console.ReadLine(), out Num2);

            Console.WriteLine();
            Console.WriteLine();

            switch (Operacao)
            {
                case '+':
                    Resultado = Adicao(Num1, Num2);
                    break;

                case '-':
                    Resultado = Subtracao(Num1, Num2);
                    break;

                case '*':
                    Resultado = Multiplicacao(Num1, Num2);
                    break;

                case '/':
                    Resultado = Divisao(Num1, Num2);
                    break;
                
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Resultado: {0}", Resultado));

            Console.ReadKey();

        }
        private static Double Adicao(double Num1, double Num2)
        {
            return (Num1 + Num2);
        }
        private static Double Subtracao(double Num1, double Num2)
        {
            return (Num1 - Num2);
        }
        private static Double Multiplicacao(double Num1, double Num2) 
        {
            return (Num1 * Num2);
        }
        private static Double Divisao(double Num1, double Num2)
        {
            return (Num1 / Num2);
        }
        public static void Exer4()
        {
            int Idade;
            Console.Write("Informe a sua idade:");
            int.TryParse(Console.ReadLine(), out Idade);

            if (Idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Acesso Permitido");
            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Acesso Negado");
            }

        }
        public static void exer5()
        {
            string Nome;
            Console.WriteLine("Informe o seu nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(string.Format("ola, meu nome é:{0} ", Nome));
            Console.ReadKey();  
        }
        public static void exer6()
        {
            Program p = new Program();
            string Frase = "Agora eu sou um bom desenvolvedor.";
            Console.WriteLine(p.Alterar(Frase));
            Console.ReadKey();
        }
        private string Alterar (string Frase)
        {
            if (Frase.Trim().Length > 0)
            {
                int Total = Frase.Length;
                int Count = 0;

                var StringBuilder = new StringBuilder(Frase);

                while (Count < Total)
                {
                    if (StringBuilder[Count] == 'o')
                    {
                        StringBuilder[Count] = '&';
                    }
                    Count++;
                }
                Frase = StringBuilder.ToString();
                return Frase;

            }
            else { return null; }
        }
        public static void exer7()
        {
            Program p = new Program();
            Double Salario;
            Console.WriteLine("informe o seu salario, use ponto");
            Console.WriteLine();
            Console.Write("Salario");
            double.TryParse(Console.ReadLine(), out Salario);
            Console.WriteLine();
            Console.Write("salario atual");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Salario.ToString());
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("\a");
            Console.Write("novo Salario:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(p.CalcularSalario(Salario));
            Console.ReadKey();

        }
        private double CalcularSalario(double Salario)
        {
            double NovoSalario = 0;

            if (Salario >= 1700)
            {
                NovoSalario = (Salario + 200);
            }
            else { NovoSalario = (Salario + 300); }
            return NovoSalario;
        }
        public static void exer8()
        {
            string acao = "";
            string caminho = "usuario.txt";
            string nome = "", email = "", telefone = "", rg = "";

            Console.WriteLine("===============");
            Console.WriteLine("G - Gravar");
            Console.WriteLine("L - Ler");
            Console.WriteLine("S - Sair");
            Console.WriteLine("Digite uma operação:");

            acao = Console.ReadLine().ToUpper();
            Console.WriteLine();

            while (acao != "S")
            {
                if (acao == "G")
                {
                    Console.Write("Informe seu Nome:");
                    nome = Console.ReadLine();

                    Console.Write("informe email");
                    email = Console.ReadLine();

                    Console.Write("informe Telefone:");
                    telefone = Console.ReadLine();

                    Console.Write("informe RG:");
                    rg = Console.ReadLine();

                    StreamWriter sw = new StreamWriter(caminho, true);

                    sw.WriteLine("nome " + nome);
                    sw.WriteLine("email "+email);
                    sw.WriteLine("telefone "+telefone);
                    sw.WriteLine("rg "+rg);

                    sw.Close();

                }else if (acao == "L")
                {
                    StreamReader sr = new StreamReader(caminho);
                    while (sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
                Console.WriteLine();
                Console.WriteLine("pressione uma tecla para continuar");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("G - Gravar");
                Console.WriteLine("L - Ler");
                Console.WriteLine("S - Sair");
                Console.WriteLine("Digite uma operação:");

                acao = Console.ReadLine().ToUpper();
                Console.WriteLine();
            }
        }
        public static void exer9()
        {
            string acao = "";
            string caminho = "imc.txt";
            double peso, altura, imc;
            string nome, resultado = "";
            int idade;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("N - Novo");
            Console.WriteLine("C - Consultar");
            Console.WriteLine("S - Sair");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("informe uma operação");
            Console.ResetColor();

            while(acao != "S")
            {
                if (acao == "N")
                {
                    Console.Write("informe o nome");
                    nome = Console.ReadLine();

                    Console.Write("informe peso");
                    double.TryParse(Console.ReadLine(), out peso);

                    Console.Write("informe idade");
                    int.TryParse(Console.ReadLine(), out idade);

                    Console.Write("inforem altura");
                    double.TryParse(Console.ReadLine(), out altura);

                    imc = Math.Round((peso / (altura * altura)));

                    if(imc < 18.5)
                    {
                        resultado = "peso abaixo do normal";
                    }else if (imc >18.6 && imc < 25)
                    {
                        resultado = "peso normal";
                    }else if (imc > 25.1 && imc < 30)
                    {
                        resultado = "peso "
                    }

                }
            }
        }
    }

}