﻿// See https://aka.ms/new-console-template for more information


namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("---------Welcome To Binary Search Tree--------");
            Console.WriteLine();
            BinarySearchTree<int> bST = new BinarySearchTree<int>(56);
            bST.Insert(30);
            bST.Insert(70);
            bST.Insert(22);
            bST.Insert(40);
            bST.Insert(60);
            bST.Insert(95);
            bST.Insert(11);
            bST.Insert(65);
            bST.Insert(3);
            bST.Insert(16);
            bST.Insert(63);
            bST.Insert(67);

            bST.GetSize();
            bST.Display();


            Console.Read();
        }
    }
}