﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication6
//{
//    class L3P2
//    {
//        static void Main(string[] args)
//        {
//            Staff[] st = new Staff[5];
//            for (int i = 0; i < 5; i++)
//            {
//                st[i] = new Staff();
//            }
//            for (int i = 0; i < 5; i++)
//            {
//                st[i].getDetail();
//            }
//            for (int i = 0; i < 5; i++)
//            {
//                st[i].display();
//            }
//        }
//    }

//    public class Staff
//    {
//        string name, post;

//        public void getDetail()
//        {
//            Console.WriteLine("enter name : ");
//            name = Console.ReadLine();
//            Console.WriteLine("enter post : ");
//            post = Console.ReadLine();
//        }

//        public void display()
//        {
//            if (post == "hod" || post == "HOD")
//            {
//                Console.WriteLine("Name: {0}, Post: {1}", name, post);
//            }
//        }
//    }
//}
