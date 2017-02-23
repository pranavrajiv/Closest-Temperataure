using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526
        int closest=0; //stores the number closest to 0;
        int flag=0;  //flag variable to store the first number as closest in the beginning
        int parseVal=0; //stores the number that has been parsed from the line

       if((n<0)||(n>=10000))
        {//fuction checks if the value of N is in between 0 and 10,000 
            Console.WriteLine("Value of N is out of Range"); 
            System.Environment.Exit(1);
        }       
        MatchCollection matching = Regex.Matches(temps,@"\b\d+|-\d+\b");            
        foreach (Match m in matching)
         {    
            parseVal = Int32.Parse(m.Value);//convert string to integer
            
            /*
            if((parseVal<= -273)||(parseVal >= 5526))
             {  //fuction checks if the value of teh Temperature is in between -273 and 5526
                Console.WriteLine("Value of Temperature is out of Range"); 
                System.Environment.Exit(1);  
             }
            */

            if(flag==0)
                closest=parseVal;//store the first number as closest in the beginning
                flag++;
            
            if((closest == -1*parseVal)&&(closest<parseVal))
                closest=parseVal;//stores the postive nmber is that number's negative value is currently the closest number
            
            if(Math.Abs(parseVal)< Math.Abs(closest))
                closest =parseVal;//check for the closest number to 0 and stores it
            
          } 
          
       if((flag!=0)&&(flag==n))
            Console.WriteLine(closest); 
       else
            Console.WriteLine("0");         
    }
}