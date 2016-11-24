using System;
using System.Collections.Generic;
using System.IO;


class Solution {

    public static bool isPrime(int n) {
    if (n ==  1){
        return false;
    } else if(n < 4) {
        return true;
    } else if(n % 2 == 0) {
        return false;
    } else if (n < 9) {
        return true;
    } else if(n % 3 == 0 ){
        return false;
    } else {
        var r = Math.Round(Math.Sqrt(n));
        int    f = 5;
        while (f <= r){
            if(n % f == 0){
                return false;
            }
            if(n % (f + 2) == 0) {
                return false;
            }
            f += 6;
        }
        return true;
    }
}




    static void Main(String[] args) {

            int n = Convert.ToInt32(Console.ReadLine());
            List<int> inputList = new List<int>();
            
            for (int i = 0; i < n; i++)
            {   
                inputList.Add(Convert.ToInt32(Console.ReadLine()));                
            }

            for (int i = 0; i < inputList.Count; i++){
                if(isPrime(inputList[i])){
                    Console.WriteLine("Prime");
                }
                else {
                    Console.WriteLine("Not prime");
                }

            }

           
    }

    }

