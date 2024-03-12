using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTi20N
{
     class Control
    {
        Model modelo;
        public Control() 
        { 
        
            modelo = new Model();
        
        }//fim do construtor

        public void Menu()

        {

            Console.WriteLine("\n\nEScolha uma das opçoes abaixo: \n" +
                "0. Sair \n" +
                "1. Exercicio 01\n" +
                "2. Exercicio 02\n" +
                "3. Exercicio 03\n" +
                "4. Exercicio 04\n" +
                "5. Exercicio 05\n" +
                "6. Exercicio 06\n" +
                "7. Exercicio 07\n" +
                "8. Exercicio 08\n" +
                "9. Exercicio 09\n" +
                "10.Exercicio 10\n" +
                "11.Exercicio 11\n" +
                "12.Exercicio 12\n" +
                "13.Exercicio 13\n" +
                "14.Exercicio 14\n" +
                "15.Exercicio 15\n" +
                "16.Exercicio 16\n" +
                "17.Exercicio 17\n" +
                "18.Exercicio 18\n" +
                "19.Exercicio 19\n" +
                "20.Exercicio 20\n" +
                "21.Exercicio 21\n" +
                "22.Exercicio 22\n" +
                "23.Exercicio 23\n" +
                "24.Exercicio 24\n" +
                "25.Exercicio 25\n");
        
        }//fim do menu


        public void Operacao() 
        {
            int opcao = 0;
            do
            {

                Menu();//Mostrando opcoes
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {

                    case 0:
                        Console.WriteLine("Obrigado!!");
                        break;
                    case 1:
                        Console.WriteLine(modelo.ExercicioUm());
                        break;
                    case 2:
                        Console.WriteLine(modelo.ExercicioDois());  
                        break;
                    case 3:
                        Console.WriteLine("A soma dos Números entre 1 e 100 é: " + modelo.ExercicioTres());
                        break;
                    case 4:
                        Console.WriteLine("Os multiplos de 5 entre 1 e 50 sao:" + modelo.ExercicioQuatro());
                        break;
                    case 5:
                        Console.WriteLine("Informe um número");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioCinco(num));
                        break;
                    case 6:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioSeis(num));
                        break;
                    case 7:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioSete(num));
                        break;
                    case 8:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioOito(num));
                        break;
                    case 9:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioNove(num));
                        break;
                    case 10:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioDez());
                        break;
                    case 11:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioOnze(num));
                        break;
                    case 12:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioDoze(num));
                        break;
                    case 13:
                        Console.WriteLine("Informe um número");
                        
                        Console.WriteLine(modelo.Exerciciotreze());
                        break;
                    case 14:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioQuatorze(num));
                        break;
                    case 15:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioQuinze(num));
                        break;
                    case 16:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioDezesseis(num));
                        break;
                    case 17:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioDezessete(num));
                        break;
                    case 18:
                        Console.WriteLine("Informe o primeiro número");
                        double num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o segundo número");
                        double num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioDezoito(num1,num2));
                        break;
                     case 19:
                        Console.WriteLine("Informe um número");
                        double farenait = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioDezenove(farenait));
                        break;
                     case 20:
                        Console.WriteLine("Informe um número");
                        double area = Convert.ToInt32(Console.ReadLine());
                        break;
                     case 21:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioVinteUm(num));
                        break;
                    case 22:
                        Console.WriteLine("Informe o Primeiro número");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo número");
                        int num4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioVinteDois(num3,num4));
                        break;
                    case 23:
                        Console.WriteLine("Informe o Primeiro número");
                        num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo número");
                        num4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioVinteTres(num3, num4));
                        break;
                    case 24:
                        Console.WriteLine("Informe o Primeiro número");
                        num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioVinteQuatro(num3));
                        break;
                    case 25:
                        Console.WriteLine("Informe o Primeiro número");
                        num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo número");
                        num4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.ExercicioVinteCinco(num3, num4));
                        break;

                    default: 
                        Console.WriteLine("Código digitado não é válido!");
                        break;
                    
                        

                }//fim do metodo
            } while (opcao != 0);

        }//fim operacao

    }//fim da classe
}//fim do projeto
