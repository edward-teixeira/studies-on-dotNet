using System;

namespace Studies_On_CSharp
{
    public class Variables
    {
        public static void Main(string[] args)
        {
            //32 bits Integer
            int x = 10;
            //Double
            double y = 3.12278786535563526;
            //Float
            float z = 3.18f; 
            //String
            String name = "Edward";
            //String concatenation
            string fullName = name + "Teixeira";
            //16 bits Char
            char character = 'a';
            //Boolean
            bool isName = true;
            //Byte
            byte myByte = 1;
            //64 bits Long
            long universeYears = 130000000000000;
            //16 bits Short
            short shortNumber = 150;
            //Operations
            double res = Math.Pow((x * y) + z, 2.00);
            String result = res > 1 ? "It's greater than 1" : "It's smaller than 1";
            // Casting
            double precision = 4.99;
            int precisionCasted = (int) precision;
            String castNumberToString =  precision.ToString();

        }

    }
}