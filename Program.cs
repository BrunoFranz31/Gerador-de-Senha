using System;

namespace _2_Atividade__UC2___SENAC
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeUsuario;
            DateTime dataUsuario;
            int idade;
            string sim;

            Console.WriteLine("Seja bem vindo ao gerador de senha! \nDiga seu nome: ");
            nomeUsuario = Console.ReadLine();
            Console.WriteLine("Olá " + nomeUsuario);
            Console.WriteLine("Qual sua data de nascimento?\nUtilize o formato dd/mm/yyyy");
            dataUsuario = DateTime.Parse(Console.ReadLine());
            int day = dataUsuario.Day;
            int month = dataUsuario.Month;
            int year = dataUsuario.Year;
            Console.WriteLine("Sua data de aniversário é {0}/{1}/{2}.", day, month, year);
            idade = DateTime.Now.Subtract(dataUsuario).Days / 365;
            Console.WriteLine("Conforme suas informações inseridas você tem " + idade + " anos.\nSuas informações estão corretas?");
            sim = Console.ReadLine();
            if(sim=="não"){

                Console.WriteLine("Informações incorretas, por gentileza, reinicie o programa.");

            }

            else if(idade>=18){

                Console.WriteLine("Sua senha é: " + nomeUsuario + idade);

            }


            else{

                Console.WriteLine("Sua senha é: "  + idade + nomeUsuario);

            }
            
        Console.WriteLine("Obrigado por utilizar nosso programa, volte sempre.");

        }
    }
}
