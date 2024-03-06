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
                "12.Exercicio 12");
        
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



                    default: 
                        Console.WriteLine("Código digitado não é válido!");
                        break;
                    
                        

                }//fim do metodo
            } while (opcao != 0);

        }//fim operacao

    }//fim da classe
}//fim do projeto
