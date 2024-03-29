﻿using System;
using System.Collections.Generic;
using System.Globalization;
using MetodoAbstrato.Entities;
using MetodoAbstrato.Entities.Enums;

namespace MetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Retangle or Circle? (r/c)");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("What is the color? (black/blue/red) ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    
                    list.Add(new Circle(radius, color));
                }

                Console.WriteLine();
                Console.WriteLine("SHAPE  AREAS");

            }
            foreach(Shape count in list)
            {
                Console.WriteLine(count.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
