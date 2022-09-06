using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace teste
{
    class Program
    {

        static void Main(string[] args)
        {
            // primeiro();
            //segundo();
            //terceiro();
            //quarto();
            //quinto();
            //sexto();
            // setimo();
            oito();


        }
        public static void primeiro()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 =0;

            Console.Write("digite numero1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("digite numero2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("digite numero3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int soma = num1 + num2 + num3;

            Console.WriteLine("os numeros somados dão= " + soma);

        }
        public static void segundo()
        {
            Console.WriteLine("---------------");
            Console.Write("Mensagem");
            Console.WriteLine("---------------");
        }
        public static void terceiro()
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;

            Console.Write("digite nota: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite nota2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite nota3: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite nota4: ");
            num4 = Convert.ToDouble(Console.ReadLine());

            double media = (num1 + num2 + num3 + num4) / 4;

            if(media >= 7)
            {
            Console.WriteLine("sua média é :" + media+ " Aprovado");

            }
            else { Console.WriteLine("sua média é :" + media + " Reprovado"); }

        }
        public static void quarto()
        {
            double salario = 1800;


           double comissao= salario * 0.20;

            Console.Write("sua comissao: "+salario+comissao);
        }
        public static void quinto()
        {
            double moeda;

            Console.Write("informe o valor em dolares: ");
            moeda = Convert.ToDouble(Console.ReadLine());

            double convert = moeda * 5.24;

            Console.Write("o valor em Reais é " + convert);

        }
        public static void sexto()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.Write("digite numero1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("digite numero2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("digite numero3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if((num1 <= num2 && (num1 < num3)))
            {
                Console.Write("menor numero"+num1);

            }else if((num2 <= num1 && (num2 < num3)))
            {
                Console.Write("menor numero"+num2);
            }
            else { Console.Write(num3); }


        }
        public static void setimo()
        {
            Console.Write("digite nome: ");
            string nome = Console.ReadLine();

            Console.Write("digite idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("digite cargo: ");
            string cargo = Console.ReadLine();

            Console.Write("digite salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Write(nome + " " + idade + " anos cargo " + cargo + " salario " + salario);

        }
        public static void oito()
        {
            Console.Write("digite numero:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            double raiz= Math.Sqrt(num1);
            double cubo = Math.Pow(num1,1/3);

            Console.Write("raiz "+raiz+" cubica "+ cubo);


        }
    }
}
