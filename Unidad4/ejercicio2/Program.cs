﻿using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos 
            //según la siguiente escala:

             //Si vende menos de 100 litros, no hay descuento.
             //Si vende entre 101 y 300 litros, el descuento es del 10%.
             //Si vende entre 301 y 500 litros, el descuento es del 15%.
             //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos 
            //y calcule y emita el importe con el descuento  aplicado..
            
            float litros, importe, total;

            Console.WriteLine("Ingrese la cantidad de litros vendidos:");
            litros=float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el importe de la venta:");
            importe=float.Parse(Console.ReadLine());

            if(litros>500){
                total=importe*0.75f;
            }else if (litros>300){
                total=importe*0.85f;
            }else if (litros>100){
                total=importe*0.9f;
            }else{
                total=importe;
            }

            Console.WriteLine("El total es de: " + total + " según el descuento correspondiente.");
            
        }
    }
}
