using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace B9
{
    // #Proszę stworzyć klasę lub klasy przechowujące informacje o zwierzętach w ogrodzie zoologicznym 
    //w formie binarnego drzewa poszukiwań zawierającego obiekty typu string.

    //BFS


    public class ZooTreeNode
    {
        public ZooTreeNode LeftNode { get; set; }
        public ZooTreeNode RightNode { get; set; }
        public ZooTreeNode UpNode { get; set; }
        public string Val { get; set; }
    }

    class ZooTree
    {
        public ZooTreeNode Root { get; set; }

        // #dodawanie nowego zwierzęcia do drzewa
        public bool Add(string value)
        {
            ZooTreeNode before = null, after = this.Root;
            
            while (after != null)
            {
                before = after;
                if (value.CompareTo(after.Val) < 0) //Is new node in left tree?  //value < after.Val
                    after = after.LeftNode;
                else if (value.CompareTo(after.Val) > 0) //Is new node in right tree? value > after.Val
                    after = after.RightNode;
                else
                {
                    return false;
                }
            }

            ZooTreeNode newNode = new ZooTreeNode();
            newNode.Val = value;

            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (value.CompareTo(before.Val) < 0)      //value < before.Val)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;
        }

        public ZooTreeNode Find(string value)
        {
            return this.Find(value, this.Root);
        }

        public void Remove(string value)
        {
            Remove(this.Root, value);
        }
        // #usuwanie istniejącego zwierzęcia z drzewa (3 pkt),
        private ZooTreeNode Remove(ZooTreeNode parent, string key)
        {
            if (parent == null) return parent;

            if (key.CompareTo(parent.Val) < 0) parent.LeftNode = Remove(parent.LeftNode, key); //key < parent.Val
            else if (key.CompareTo(parent.Val) > 0)  // key > parent.Val)
                parent.RightNode = Remove(parent.RightNode, key);

            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                parent.Val = MinValue(parent.RightNode);

                // Delete the inorder successor  
                parent.RightNode = Remove(parent.RightNode, parent.Val);
            }

            return parent;
        }
        //!!!
        private string MinValue(ZooTreeNode node)
        {
            string minv = node.Val;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Val;
                node = node.LeftNode;
            }

            return minv;
        }

        private ZooTreeNode Find(string value, ZooTreeNode parent)
        {
            if (parent != null)
            {
                if (value.CompareTo(parent.Val) == 0) return parent;    //value == parent.Val
                if (value.CompareTo(parent.Val) < 0)    //value < parent.Val)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }

            return null;
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }

        private int GetTreeDepth(ZooTreeNode parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
        }

        public void TraversePreOrder(ZooTreeNode parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Val + ", ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraverseInOrder(ZooTreeNode parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Val + ", ");
                TraverseInOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(ZooTreeNode parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Val + ", ");
            }
        }
        // #zapisywanie bieżącego stanu drzewa do pliku tekstowego
        public void DumpTreeToFile(ZooTreeNode parent, string FileNamePath)
        {

            TraversePreOrderToFile(parent, FileNamePath);
        }
        public void TraversePreOrderToFile(ZooTreeNode parent, string FileNamePath)
        {
            if (parent != null)
            {
                string stringToWrite = parent.Val + ", ";
                File.AppendAllText(FileNamePath, stringToWrite);
                TraversePreOrderToFile(parent.LeftNode, FileNamePath);
                TraversePreOrderToFile(parent.RightNode, FileNamePath);
            }
        }
    
        public void Print()
        {
             Root.PrintZoo();
        }
    }
}