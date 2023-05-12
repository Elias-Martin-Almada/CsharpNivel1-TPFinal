using System;

namespace TPFinal_Almada
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
            // A partir de dichos datos informar:
                // a. El mayor de los números pares.
                // b. La cantidad de números impares.
                // c. El menor de los números primos.
            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que 
            // devuelva true o false según corresponda.
            int n, BP, BanMaxPar, maxPar = 0;
            int minPrimo = 0, Bmin;
            int contarImpar;
            bool Pri;

            BanMaxPar = 0;
            contarImpar = 0;
            Bmin = 0;
            Console.WriteLine("Ingrese los numeros: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {   
                // Llamo a la funcion Par Y busco el Mayor de los Pares:
                BP = par(n);
                
                if(BP == 1){
                    if(BanMaxPar == 0){
                        maxPar = n;
                        BanMaxPar = 1;
                    }else{
                        if(n > maxPar){
                        maxPar = n;
                        }
                    }
                }else{
                    contarImpar ++;     // Si no es Par cuento los Impares.
                }

                // Llamo a la funcion Primo Y busco el menor de los Primos: Retorna TRUE O FALSE.
                Pri = primo(n);

                if(Pri == true){
                    if(Bmin == 0){
                        minPrimo = n;
                        Bmin = 1;
                    }else{
                        if(n < minPrimo){
                            minPrimo = n;
                        }
                    }            
                }

                n = int.Parse(Console.ReadLine()); // Pido otro numero.
            }
            Console.WriteLine("El mayor de los números pares: " + maxPar);
            Console.WriteLine("La cantidad de números impares: " + contarImpar);
            Console.WriteLine("El menor de los números primos: " + minPrimo); 
        }

        //Funciones: Par
        static int par(int a){
             
            if(a % 2 == 0){ // Si el resultado de dividir (n) entre 2 da cero es Par.
                return 1;   // Si es par retorna "par" con 1.
            }else{
                return 0;
            }        
        }
        //Funciones: Primo que retorna TRUE O FALSE.
        static bool primo(int a){
            int contador;
            
            contador = 0; // Cuento los numeros primos
            for (int x = 1; x <= a; x++) // Busco el numero Primo. Desde 1 hasta x <= a.
            {
                if(a % x == 0){  // Divido desde (x) hasta ..... (a)
                    contador ++;    
                }   
            }
            if(contador == 2){ // Si tuve 2 divisiones con resto cero, es primo.
                return true;
            }else{
                return false;
            }
        }   

            
    }
}
