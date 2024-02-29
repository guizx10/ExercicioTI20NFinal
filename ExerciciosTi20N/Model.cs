using System;
using System.Collections.Generic;
using System.Linq;
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

                resultado += "\n" + i+1;
            
            }

            return resultado;   
        
        }//fim do metodo


    }//fim da classe
}//fim do projeto
