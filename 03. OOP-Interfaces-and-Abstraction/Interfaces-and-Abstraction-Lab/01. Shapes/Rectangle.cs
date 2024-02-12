﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Height 
        {
            get => height;
            set => height = value;
        }

        public int Width 
        { 
            get => width; 
            set => width = value; 
        }

        public void Draw()
        {
            Console.WriteLine(new string ('*', width));

            for (int i = 0; i < height - 1; i++)
            {
                Console.WriteLine('*' + new string(' ', width - 2) + '*');
            }

            Console.WriteLine(new string('*', width));
        }
    }
}
