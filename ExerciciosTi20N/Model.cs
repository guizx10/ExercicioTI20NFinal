using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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




        // exercicio 13: Faça um programa que imprima a sequencia de fibonate ate o 10 termo.

        public string Exerciciotreze()

        {
            string resultado = "0 1";
            int fib1 = 0;
            int fib2 = 1; 
            int fib3 = 0;
            for (int i = 1; i <=8; i++) 
            {
               
                fib3 = fib1 + fib2;
                resultado += " " + fib3;
                fib1 = fib2; 
                fib2 = fib3;                    
            
            
            }//fim do for

            return resultado;      
                      
        
        }// fim do metodo

        // exercicio 14: Faça um programa que peça ao usuario um  numero e imprima se e um numero de fibonate  

        public string ExercicioQuatorze(int num)
        {


            {
                string resultado = "0 1";
                int fib1 = 0;
                int fib2 = 1;
                int fib3 = 0;
                for (int i = 1; i <= num - 2; i++)
                {

                    fib3 = fib1 + fib2;
                    resultado += " " + fib3;
                    fib1 = fib2;
                    fib2 = fib3;


                }//fim do for

                return resultado;


            }// fim do metodo
        }//fim do metodo   

        // Exercicio 15: faça um programa que peça ao usuario um 
        //numero e calcule a soma dos seus digitos.
        public int ExercicioQuinze(int num)
        {

            int soma = 0;

            
            while (num != 0)
            {
                
                soma += num % 10;
                
                num /= 10;
            }

            return soma;
        }
       
        // exercicio 16:faça um programa que peça ao usuario um numero
        // e imprima os numeros pares e impares de 1 ate esse numero

        public string ExercicioDezesseis(int num) 
        {

            
            string par = "";
            string impar = "";

            for (int i = 1; i <= num; i++)

            {
                

                if (i % 2 == 0)
                {
                    par += " " + i;
                }
                else
                {
                    impar += " " + i;
                }



            }//fim do for

            return "Pares: " + par + "\nimpar: " + impar;

        }


        // Exercicio 17: Faça um programa que peça ao usuario um numero e imprima o dobro deste numero.


        public int ExercicioDezessete(int num)
        {

            int resultado = 0;

            resultado = num * 2;

            return resultado;
               
        
        
        }


        // Exercicio 18: Faça um programa que peça ao usuario dois numeros
        //e imprima a média dele.

        public double ExercicioDezoito(double num1,double num2)
        { 
        
        
        double media = 0;
            
            
            media = (num1 + num2) / 2;

            return media;

            
        
        
        }

        // Exercicio 19: Faça um programa que converta a temperaturav de celsus 
        // para fahrenheit.A formula é f = c * 9/5 +32.


        public double ExercicioDezenove(double celsu)

        {

            double farenait = 0;

            farenait = celsu * 9 / 5 + 32;

            return farenait;      
                        
               
        }



        // Exercicio 20: Faça um programa que peça o raio de um circulo e imprima a area
        // a formula é A = pi * raio ^2.

        public double ExercicioVinte(double raio)
        {
            double area = 0;

            area = Math.PI * (raio * raio);

            return area;
        }

        // Exercicio 21: Faça um programa que peça  um número e imprima o seu quadrado
        public int ExercicioVinteUm(int num)

        {
            int resultado = 0;
            resultado = num * num;

            return resultado ;      
                
        }
        //Exercicio 22: Faça um programa que peça dois números e imprima o maiorm deles.

        public int ExercicioVinteDois(int num3, int num4)
        {

            

            if (num3 > num4)
            {

                return num3; 


            }

            else 
            {
                return num4;
            
            }
        
                    
        }
        //Exercicio 23:Faça um programa que peça dois números e imprima "São iguais" se os números forem iguais
        //ou imprima "são diferentes"  se forem diferentes.

        public string ExercicioVinteTres(int num3, int num4)
        {

            if (num3 == num4)
            {

                return "São iguais";

            }
            else

            {

                return " São Diferentes";
            }           
        
        
        }

        //Exercicio 24:Faça um programa que peça a idade do usuario e
        //imprima se ele e maior ou menor

        public string ExercicioVinteQuatro(int num3)

        { 
        
            if ( num3 < 18) 
            
            {

                return " É menor";
            }
            else 
            {

                return " É maior";
            }
            
        
        
        
        }

        // Exercicio 25:Faça um programa que peça dois numeros e impria o menor deles.

        public string ExercicioVinteCinco(int num3, int num4)

        {

            if (num3 < num4)
            {
                return "Este é o menor" + num3;


            }

            else
            {

                return "Este é o menor" + num4;
            
            }
        
        
        
        
        }



    }//fim do metodo
    }//fim da classe

