using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            Salesman s1 = new Salesman();
            s1.Name = "Julio";
            s1.Age = 45;
            s1.Gender = 1;

            Salesman s2 = new Salesman();
            s2.Name = "Maria";
            s2.Age = 35;
            s2.Gender = 0;

            Salesman s3 = new Salesman();
            s3.Name = "Natalia";
            s3.Age = 22;
            s3.Gender = 0;

            Product p1 = new Product();
            p1.Name = "shoes";
            p1.Price = 70000;

            Product p2 = new Product();
            p2.Name = "shirts";
            p2.Price = 40000;

            Product p3 = new Product();
            p3.Name = "lotions";
            p3.Price = 50000;

            venta v1 = new venta();
            v1.Salesman = s1;
            v1.Product = p1;
            v1.Comments = "Venta #1";

            venta v2 = new venta();
            v2.Salesman = s2;
            v2.Product = p2;
            v2.Comments = "Venta #2";

            venta v3 = new venta();
            v3.Salesman = s3;
            v3.Product = p3;
            v3.Comments = "Venta #3";

            venta v4 = new venta();
            v4.Salesman = s3;
            v4.Product = p2;
            v4.Comments = "Venta #4";

            // Sumar el total de las ventas

            int suma = v1.Product.Price + v2.Product.Price + v3.Product.Price + v4.Product.Price;
            System.Console.WriteLine("Sales total amount: " + suma);







        }
    }
}
