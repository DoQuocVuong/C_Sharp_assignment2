using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleApplication2.Properties;

namespace ConsoleApplication2
{
    public class Cart
    {
//        id, customer (tên KH), grandTotal (tổng tiền), productList
// ( List - mỗi element là 1 product ở Lab assignment 2 ), 
////        city , country.
//        Phương thức thêm sản phẩm vào giỏ hàng
//        Phương thức xoá 1 sản phẩm khỏi giỏ hàng
//        Phương tính tinh tổng tiền ( grandTotal) theo công thức: Hà Nội hoặc HCM
// thì phí ship: 1%, Thành phố khác: 2%, quốc gia ngoài Việt Nam: 5%.
//        Viết chương trình thêm / xoá sản phẩm vào giỏ hàng và tính tổng tiền
        public int id;
        public int customer;
        public int grandtotal;
        public List<Products> ProductList;
        public string city;
        public string country;

        public delegate void AddMore();
        
        public bool AddToCart(Products p)
        {
            if (ProductList.Contains(p) && p.CheckQty())
            {
                ProductList.Add(p);
                p.qty--;
                grandtotal += p.price;
                return true;
            }
            Console.WriteLine("In cart.");
            return false;
        }
        public bool DeleteFromCart(Products p)
        {
            if (ProductList.Contains(p))
            {
                ProductList.Remove(p);
                p.qty++;
                grandtotal -= p.price;
                return true;
            }
            Console.WriteLine("Product has been removed");
            return false;
        }

        public decimal GetGrandTotal()
        {
            decimal finalTotal = 0;
            if (country == "VN")
            {
                if (city == "HN" || city == "HCM")
                {
                    finalTotal = grandtotal * (decimal) 1.01;
                }
                else
                {
                    finalTotal = grandtotal * (decimal) 1.02;
                }
            }
            else
            {
                finalTotal = grandtotal * (decimal) 1.05;
            }

            return finalTotal;
        }
    }
}