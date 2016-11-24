using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int numero = Convert.ToInt32(Console.ReadLine());
        int restante = 0;
        int contador = 0; //para contar la cantidad de 1's
        int total = 0; //acumulador total de 1's contiguos

        //Using divide by 2 algorithm

        while (numero>0) //mientra se pueda divir n/2 y sea mayor a 0 
        {
            restante = numero % 2; // Registra si el digito es 0/1 binario, par = 0 , non = 1
            numero = numero/2; //Preparamos a 'n' para el siguiente bucle

            if (restante == 1) // Es un 1
            {
                contador++; //aumentamos el contador de 1's
                if (contador >= total) // si el contador es igual o mayor al total
                {
                    total = contador; //actualizamos el total 
                }
            } //Si no, entonces es un 0 
            else
            {
                contador = 0; //reset el contador de 1's
            }
        }
        Console.WriteLine(total);
    }
}

