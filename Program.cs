﻿// See https://aka.ms/new-console-template for more information
using System;


public class Program{
    public static void Main (string [ ] args){
        Console.WriteLine("Enter a number: ");
        var a=Convert.ToInt32(Console.ReadLine());
        table_multiply(a);
        
    }
    static void table_multiply(int a){
        Console.WriteLine($"Multiplication Table for {a}\n");
        for (int i=1;i<=10;i++){
            Console.WriteLine(a*i);
        }
        
    }
}