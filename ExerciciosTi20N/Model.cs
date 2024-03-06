using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTi20N
{
     class Model
    {
        //Construtor

        public Model() 
        { 
        
        
        
        }//fim do metado construtor

        // Exercicio 01: Faça um programa que imprima os numeros de 1 a 10.

        public string ExercicioUm()
        {

            string resultado = "";
            for(int i=0; i < 10; i++) 
            {

                resultado += "\n" + (i+1);
            
            }

            return resultado;   
        
        }//fim do metodo


        //Faça um programa que imprima os numeros pares de 1 a 20.
        public string ExercicioDois()
        {

            string resultado = "";

            for (int i = 0; i < 20; i++)

            {
                if((i+1) % 2 == 0)
                { 
            
                    resultado += "\n" + (i+1);
                }//fim do if

            }//fim do for

            return resultado;       
                
        }//fim do exercicio dois


        //Exercicio 3: Faça um programa que calcule a soma dos numeros de 1 a 100.

        public int ExercicioTres()
        {

            int resultado = 0;
            
            for (int i = 1; i <= 100; i++)
            {    
               resultado += i;
            }//fim do for

            return resultado;

        }//fim do exercicio tres


        // Exercicio 4: Faça um programa que imprima os multiplos de 5 de 1 a 50.

        public string ExercicioQuatro()
        {

            string resultado = "";

            for (int i = 1; i <=50; i++)

            {
                if ((i + 1) % 5 == 0 )
                {

                    resultado += "\n" + (i + 1);
                }//fim do if

            }//fim do for

            return resultado;

        }//fim do exercicio quatro



        //Exercicio 6: Faça um programa que peça ao usuario um numero e imprima se é par ou ímpar.

        public string ExercicioSeis(int num)
        {

            if (num > 0)
            {

                return "Positivo";

            }

            else if ( num< 0 )
            {
                return "Negativo";
            }

            else 
            {
                return "zero";
            
            
            }

        }//fim do exercicio Seis


        //Exercicio 05: FaÇa um programa que peça ao usuario um número e imprimna se é positivo, negativo ou zero.


        public string ExercicioCinco(int num)
        {

            if (num % 2 == 0)
            {

                return "Par";

            }

            else
            {
                return "Ímpar";
            }

        }//fim do exercicio Cinco


        // Exercicio 7: Faça um programa que peça ao usuario um
        // número e imprima a tabuada desse número.

        public string ExercicioSete(int num)
        {
            string resultado = "";
            resultado += " Tabuada de " + num;
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n " + num + " * " + i + " = " + (num * i);

            }// fim do for

            return resultado;
           

        }//fim da tabuada

        //Exercicio 8: Faça um programa que peça ao usuário um número e
        //imprima os números de 1 até esse número.

        public string ExercicioOito(int num)
        {

            string resultado = "";
            for (int i = 0; i < num; i++)
            {

                resultado += "\n" + (i + 1);

            }

            return resultado;

        }//fim do metodo


        //Exercicio 9: Faça um programa que peça ao usuário um número e
        //imprima a soma dos números de 1 até esse número


        public int ExercicioNove(int num)
        {

            int resultado = 0;
            for (int i = 1; i <= num; i++)
            {

                resultado += i;
            }//fim do for

            return resultado;
        }
            // exercicio 10: Faça um programa que imprime os números primos de 1 a 20.

            public string ExercicioDez()
            {

                string primos = "";
                for (int i = 0; i <= 20; i++)
                { 
                
                    if( i % 2 !=0 && i % 3 !=0 && i % 5 !=0)

                    { 
                        primos += " " + i; 
                    }

                }//fim do for              

                return primos;          
                        
            }// fim do metodo


        // Faça um programa que peça ao usuario um número e verifique se é primo.


        public string ExercicioOnze(int num)
        {

            if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0)
            {
                return "Primos!!";

            }
            else if (num == 2 || num == 3 || num == 5)
            {
                return "Primo!!";

            }
            else
            {
                return " Não Primo!!";
            
            }   

                         
                            

        }// fim do metodo



        // Faça um programa que calcule o fatorial de um número.

        public int ExercicioDoze(int num)
        {

            int resultado = 1;
            while(num != 0) 
            { 
                resultado = (resultado * num);
                num = num -1;
            
            }// fim do while
            return resultado;
           

        }// fim do metodo

    }//fim da classe
}//fim do projeto
