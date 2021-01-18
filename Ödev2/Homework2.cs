using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pro1 = new Product();
            pro1.ProductName = "Headphone    : Huawei FreeBuds Pro";
            pro1.Cost = 1.347;

            Product pro2 = new Product();
            pro2.ProductName = "MobilePhones : Huawei P30 Lite";
            pro2.Cost = 2.752;

            Product pro3 = new Product();
            pro3.ProductName = "Laptop       : Huawei Matebook D14";
            pro3.Cost = 6.292;

            Product pro4 = new Product();
            pro4.ProductName = "Television   : Samsung Ultra HD Smart QLED TV";
            pro4.Cost = 7.187;

            Product pro5 = new Product();
            pro5.ProductName = "WaterBottle  : Zojirushi SM-TA48-DM WaterBottle";
            pro5.Cost = 281;

            Product pro6 = new Product();
            pro6.ProductName = "Mouse        : Xiaomi Lite Mouse";
            pro6.Cost =74.90;

            Product[] product = new Product[] { pro1, pro2, pro3, pro4, pro5, pro6 };

            Console.WriteLine("**************************************************************************************");
            foreach (Product pro in product)
            {
                Console.WriteLine(pro.ProductName + " ---- " + "Cost : "+pro.Cost+" TL");
            }
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("**************************************************************************************");
            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(product[i].ProductName + " ---- " + "Cost : " + product[i].Cost + " TL");
            }
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("**************************************************************************************");
            int j = 0;
            while (j < product.Length){
                Console.WriteLine(product[j].ProductName + " ---- " + "Cost : " + product[j].Cost + " TL");
                j++;
            }
            Console.WriteLine("**************************************************************************************");
        }
    }
    class Product
    {
        public string ProductName { get; set; }

        public double Cost { get; set; }
    }
}
