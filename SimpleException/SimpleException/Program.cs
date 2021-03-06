﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Program
    {
        using System.Collections;
        static void Main(string[] args)
        {
            Console.WriteLine("***** simple Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Member name: {0}", e.TargetSite);
                Console.WriteLine("class defining mebmer: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stack: {0}", e.StackTrace);
            Console.WriteLine("\n-> Custom Data:");
            if(e.Data != null)
            {
                foreach (Dictionary de in e.Data) ;
                Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
                    
            }

            }
            Console.WriteLine("\n***** Out of exception logic *****");
            
            Console.ReadLine();
        }
    }
}
