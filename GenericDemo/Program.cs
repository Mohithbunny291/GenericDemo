﻿using System.Collections.Generic;

namespace GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generics
            //Syntax <T> , T is the type parameter

            GenericClass<int> intGenericObject = new GenericClass<int>();
            intGenericObject.Print(10);

            GenericClass<string> strGenericObject = new GenericClass<string>();
            strGenericObject.Print("Test");

            // Important Generic Collection
            // List<T> -- > Preferred over Arrays(no length restriction)

            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);

            //intList[1] : For retrieving a value;

        }
    }
}
