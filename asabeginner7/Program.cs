using System;
class Program
{
    static void Main()
    {
        float f = 100000.25F;
        //cannot implicitly convert float to int
        //coz fractional part will be lost.Hence loss of data 
        //as float is bigger data type there is the possibility of
        //overflow exception int i = f;
        //use explicit conversion using cast () operator
        int i = (int)f;
        //or use convert class 
        //int i = convert.Toint32(f);
        Console.WriteLine(i);   
    }
}
