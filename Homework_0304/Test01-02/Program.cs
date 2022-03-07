//编写面向对象程序实现长方形、正方形、三角形等形状的类。每个形状类都能计算面积、判断形状是否合法。 请尝试合理使用接口/抽象类、属性来实现。
//随机创建10个形状对象，计算这些对象的面积之和。 尝试使用简单工厂设计模式来创建对象。

using System;
namespace Homework_0304
{
    abstract class Sharp
    {
        public virtual double area { get; }
        public virtual string type { get; }
    }

    class Rectangle : Sharp
    {
        private double length;
        private double width;

        public override double area { get => length * width; }
        
        public override string type
        {
            get => "Rectangle";
        }

        public Rectangle(double length, double width)
        {
            if (length <= 0 || width <= 0)
                throw new ArgumentException("Invalid input");
            this.length = length;
            this.width = width;
        }

        public Rectangle() : this(1, 1) { }
    }

    class Circle : Sharp
    {
        private double radius;
        public override double area
        {
            get => Math.PI * radius * radius;
        }
        public override string type
        {
            get => "Circle";
        }

        public Circle(double radius)
        {
            if(radius <= 0)
                throw new ArgumentException("Invalid input");
            this.radius = radius;
        }

        public Circle() : this(1) { }
    }

    class Square : Rectangle
    {
      
        public Square(double length):base(length,length)
        {
        }
        public override string type
        {
            get => "Square";
        }

        public Square() : this(1) { }
    }

    class Triangle : Sharp
    {
        private double theBase;
        private double height;
        public override double area
        {
            get => height * theBase / 2;
        }
        public override string type
        {
            get => "Triangle";
        }

        public Triangle(double theBase, double height)
        {
            if(theBase <= 0 || height <= 0)
                throw new ArgumentException("Invalid input");
            this.theBase = theBase;
            this.height = height;
        }

        public Triangle() : this(1, 1) { }
    }

    class SharpFactory
    {
        public static Sharp GetSharp(int type, params double[] lengths)
        {
            switch (type)
            {
                case 0:
                    return new Rectangle(lengths[0],lengths[1]);
                case 1:
                    return new Square(lengths[0]);
                case 2:
                    return new Circle(lengths[0]);
                case 3:
                    return new Triangle(lengths[0],lengths[1]);
                default:
                    throw new ArgumentException("Invalid type");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sharp rectangle = new Rectangle(2, 3);
            Sharp square = new Square(3);
            Sharp triangle = new Triangle(2, 3);
            Sharp circle = new Circle(2);
            
            Console.WriteLine(rectangle.area);
            Console.WriteLine(square.area);
            Console.WriteLine(triangle.area);
            Console.WriteLine(circle.area);
            Console.WriteLine();
            
            
            //每种图形的边长数量
            int[] sides = {2, 1, 1, 2}; 
            
            Random random = new Random();
            double sum = 0;
            for (int i = 0; i < 10; ++i)
            {
                int type = random.Next(0,3);
                //给边长赋随机值
                double[] lengths = new double[sides[type]];
                for (int j = 0; j < sides[type]; ++j)
                    lengths[j] = random.Next(1,100);
                Sharp sharp = SharpFactory.GetSharp(type,lengths);
                Console.WriteLine("This is a " + sharp.type + "\tArea: " + sharp.area);
                sum += sharp.area;
            }

            Console.WriteLine($"Sum of all areas is {sum}.");
        }
    }
}