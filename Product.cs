using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    public class Product
    {
         int id;
         public string name;
         public int price;
         public int qty;
         public string img;
         public string desc;
         List<string> gallery = new List<string>();

//         public Product(int id, string name, int price, int qty, string img, string desc)
//         {
//             this.id = id;
//             this.name = name;
//             this.price = price;
//             this.qty = qty;
//             this.img = img;
//             this.desc = desc;
//         }

         public void Input()
         {
             Console.WriteLine("Input id:");
             id = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Input price:");
             price = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Input qty:");
             qty = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Input img:");
             img = Console.ReadLine();
             Console.WriteLine("Input desc:");
             desc = Console.ReadLine();
         }
         public void GetInfo()
         {
             Console.WriteLine("Id:" + id);
             Console.WriteLine("Name: " + name);
             Console.WriteLine("Price:" + price);
             Console.WriteLine("Qty:" + qty);
             Console.WriteLine("Img:" + img);
             Console.WriteLine("Desc:" + desc);
         }

         public void In_OutOfStock()
         {
             if (qty == 0)
             {
                 Console.WriteLine("In stock");
             }
             else
             {
                 Console.WriteLine("Out of stock");
             }
         }

         public void AddImgToGallery()
         {
             Console.WriteLine("Add img:");
             gallery.Add(Console.ReadLine());
             if (gallery.Count>10)
             {
                 Console.WriteLine("Delete another img to add the anothers in");
                 DeleteFromGallery();
             }
             else
             {
                 AddImgToGallery();
             }
         }

         public void DeleteFromGallery()
         {
             for (int i = 0; i < gallery.Count; i++)
             {
                 Console.WriteLine("Img: " + gallery[i]);
             }
             Console.WriteLine("Choose the img you want to delete:");
             int x = Convert.ToInt32(Console.ReadLine());
             gallery.Remove(gallery[x]);
         }
    }
}