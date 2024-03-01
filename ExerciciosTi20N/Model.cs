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



        //Exercicio 5: Faça um programa que peça ao usuario um numero e imprima se é par ou ímpar.

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

        }//fim do exercicio quatro






    }//fim da classe
}//fim do projeto
