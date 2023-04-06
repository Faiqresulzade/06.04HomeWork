using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Height = 4;
            rectangle.Width = 5;
            rectangle.FindArea();
        }
    }
    interface ICalculatteFigure
    {
        public int Width { get; set; }
        public int Height { get; set; }
        void FindArea();
        void FindPerimetr();
    }
    class Rectangle : ICalculatteFigure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void FindArea()
        {
            Console.WriteLine("Area is "+ Width*Height);
        }
        public void FindPerimetr()
        {
            Console.WriteLine("Perimetr is"+2*(Width+Height));
        }
    }
    class Triangle : ICalculatteFigure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void FindArea()
        {
            throw new NotImplementedException();
        }

        public void FindPerimetr()
        {
            throw new NotImplementedException();
        }
    }
}
