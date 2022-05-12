﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        BinarySearchTree<T> LeftTree { get; set; }
        BinarySearchTree<T> RighttTree { get; set; }
        public BinarySearchTree(T nodeData)
        {

            this.NodeData = nodeData;
            this.LeftTree = LeftTree;
            this.RighttTree = RighttTree;
        }
        int leftcount = 0;
        int rightcount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValues = this.NodeData;
            if ((currentNodeValues.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.LeftTree.Insert(item);
                }
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftcount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (RighttTree != null)
            {
                this.rightcount++;
                this.RighttTree.Display();
            }
        }
    }
}