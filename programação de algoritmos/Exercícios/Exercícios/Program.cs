using System;
using System.Collections;
using System.Data;
using System.Linq.Expressions;

namespace Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Exercício (1 - 11): ");
            string Line = Console.ReadLine();
            int Option = int.Parse(Line);
            switch (Option)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                case 6:
                    Exercicio6();
                    break;
                case 7:
                    Exercicio7();
                    break;
                case 8:
                    Exercicio8();
                    break;
                case 9:
                    Exercicio9();
                    break;
                case 10:
                    Exercicio10();
                    break;
                case 11:
                    Exercicio11();
                    break;
            }
        }

        public static void Exercicio1()
        {
            Console.Write("Digite um número de 0 até 100: ");
            int Num = int.Parse(Console.ReadLine());
            string Resposta = Num >= 0 && Num <= 100 ? "Valor válido" : "Valor inválido";
            Console.WriteLine(Resposta);
            Console.ReadKey();
        }

        public static void Exercicio2()
        {
            Console.Write("Digite as 4 notas do aluno: ");
            string NotasLine = Console.ReadLine();
            string[] NotasSplitted = NotasLine.Split(' ');
            if (NotasSplitted.Length > 4 || NotasSplitted.Length < 4)
            {
                Console.WriteLine($"São 4 notas. Não {NotasSplitted.Length}.");
                Console.ReadKey();
                return;
            }
            double Nota1 = double.Parse(NotasSplitted[0]);
            double Nota2 = double.Parse(NotasSplitted[1]);
            double Nota3 = double.Parse(NotasSplitted[2]);
            double Nota4 = double.Parse(NotasSplitted[3]);
            double MA = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            string Result = MA >= 5 ? "Aprovado" : "Reprovado";
            Console.WriteLine(Result); 
            Console.ReadKey();
        }
        public static void Exercicio3()
        {
            Console.Write("Digite 2 números: ");
            string Line = Console.ReadLine();
            string[] SplittedLine = Line.Split(' ');
            int n1 = int.Parse(SplittedLine[0]);
            int n2 = int.Parse(SplittedLine[1]);
            double res = n1 > n2 ? n1 - n2 : n2 - n1;
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static void Exercicio4()
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            string res = n % 2 == 0 ? "Par" : "Impar";
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static void Exercicio5()
        {
            Console.Write("Digite 3 números: ");
            string[] Lines = Console.ReadLine().Split(' ');
            int NumA = int.Parse(Lines[0]);
            int NumB = int.Parse(Lines[1]);
            int NumC = int.Parse(Lines[2]);
            int[] arr = 
            {
                NumA,
                NumB,
                NumC
            };
            Array.Sort(arr);
            Console.WriteLine(string.Join(", ", arr));
            Console.ReadKey();
        }

        public static void Exercicio6()
        {
            bool meiaEntrada = false;
            float valor = 20.0f;
            Console.Write("Insira a idade do cliente: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("O cliente é um estudante? (S/N) ");
            char input = Console.ReadKey().KeyChar;
            bool estudante = false;
            if (input == 's')
            {
                estudante = true;
            } else if (input == 'n')
            {
                estudante = false;
            }
            if (idade < 12 || idade > 65) meiaEntrada = true;

            if (estudante) meiaEntrada = true;
            float resultado = meiaEntrada ? valor / 2 : valor;
            Console.WriteLine($"\nValor a ser pago: R${resultado}");
            Console.ReadKey();
        }

        public static void Exercicio7()
        {
            Console.Write("Digite 3 números: ");
            string[] Lines = Console.ReadLine().Split(' ');
            int NumA = int.Parse(Lines[0]);
            int NumB = int.Parse(Lines[1]);
            int NumC = int.Parse(Lines[2]);
            
            if(NumA > NumB)
            {
                NumB = NumA - NumB;
                NumA -= NumB;
                NumB += NumA;
            }
            if (NumA > NumC)
            {
                NumC = NumA - NumC;
                NumA -= NumC;
                NumC += NumA;
            }
            if (NumB > NumC)
            {
                NumC = NumB - NumC;
                NumB -= NumC;
                NumC += NumB;
            }
            Console.WriteLine($"{NumA} {NumB} {NumC}");
            Console.ReadKey();
        }

        public static void Exercicio8()
        {
            Console.Write("Insira o salário do funcionário: ");
            double sal = double.Parse(Console.ReadLine());
            double nov = sal;
            double dif;
            if (sal < 1000) nov += sal * 0.1;
            if (sal <= 2000) nov += sal * 0.08;
            if (sal <= 3500) nov += sal * 0.06;
            if (sal <= 5000) nov += sal * 0.04;
            nov += sal * 0.02;
            dif = nov - sal;
            Console.WriteLine($@"
Salário anterior = {sal}
Aumento = {dif}
Salário atual = {nov} 
");
            Console.ReadKey();
        }
        
        public static void Exercicio9()
        {
            Console.WriteLine("Por favor, responda algumas perguntas para determinar se você está apto para participar da pesquisa.");
            Console.Write("Qual é o seu sexo (M/F)? ");
            char sexo = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é a sua classe social (A/B)? ");
            char classe = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Você possui nível superior (S/N)? ");
            char nivel = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Há quanto tempo você adquiriu o produto (em meses)? ");
            int tempo = int.Parse(Console.ReadLine());
            bool apto = false;
            if (sexo == 'M' && idade >= 20 && idade <= 25 &&
            (classe == 'A' || classe == 'B') &&
            nivel == 'S' && tempo > 6 && tempo < 12) apto = true;
            string res = apto ? "Você está apto" : "Você não está apto";
            Console.WriteLine(res);
            Console.ReadKey();
        }

        public static void Exercicio10()
        {
            Console.WriteLine(@"
1 –adição
2 –subtração
3 –multiplicação
4 –divisão
5 –resto da divisão
");
            Console.Write("Selecione uma operação: ");
            int opt = int.Parse(Console.ReadLine());
            char[] operators = {
                '+',
                '-',
                '*',
                '/',
                '%'
            };
            char oper = operators[opt - 1];
            Console.Write("Digite 2 números: ");
            string[] Lines = Console.ReadLine().Split(' ');
            double num1 = double.Parse(Lines[0]);
            double num2 = double.Parse(Lines[1]);
            var eval = new DataTable().Compute($"{num1}{oper}{num2}", "");
            Console.WriteLine(eval);
            Console.ReadKey();
        }
        public static void Exercicio11()
        {
            string[] nomesm = { "João", "Pedro", "Lucas", "Marcos", "Mateus", "André", "Fernando", "Rafael", "Gustavo", "Leonardo" };
            string[] nomesf = { "Maria", "Ana", "Carla", "Camila", "Juliana", "Laura", "Mariana", "Renata", "Amanda", "Isabela" };

            int pontos = 0;
            int escolha;
            Console.WriteLine(@"
1- Primavera
2- Verão
3- Outono
4- Inverno
");
            Console.Write("Selecione uma das estações: ");
            escolha = int.Parse(Console.ReadLine());
            pontos += Math.Max(1, Math.Min(4, escolha));
            Console.WriteLine(@"
1- cidade
2- campo
3- praia
4- radical
5- cruzeiro
6- resort
");
            Console.Write("Selecione uma das viagens: ");
            escolha = int.Parse(Console.ReadLine());
            pontos += Math.Max(1, Math.Min(6, escolha));

            Console.WriteLine("Qual é o gênero do seu par ideal? (F/M)");
            string genero = Console.ReadLine().ToUpper();
            Random rnd = new Random();
            string nomep = string.Empty; 
            if (genero == "F")
            {
                nomep = nomesf[rnd.Next(nomesf.Length)];
            }
            else if (genero == "M")
            {
                nomep = nomesm[rnd.Next(nomesm.Length)];
            }
            Console.WriteLine($"Seu par ideal é: {nomep}! {pontos}");
            Console.ReadKey();
        }
    }
}
