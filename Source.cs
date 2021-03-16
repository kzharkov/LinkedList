﻿using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node
    {
        public int value;
        public Node next;
        public Node(int _value) { value = _value; }
    }

    public class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddInTail(Node _item)
        {
            if (head == null) head = _item;
            else tail.next = _item;
            tail = _item;
        }

        public Node Find(int _value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.value == _value) return node;
                node = node.next;
            }
            return null;
        }

        public List<Node> FindAll(int _value)
        {
            List<Node> nodes = new List<Node>();
            Node node = head;
            while (node != null)
            {
                if (node.value == _value)
                {
                    nodes.Add(node);
                }
                node = node.next;
            }
            return nodes;
        }

        public bool Remove(int _value)
        {
            Node node = head;
            Node prevNode = null;
            while (node != null)
            {
                if (node.value == _value)
                {
                    if (node == tail)
                    {
                        tail = prevNode;
                    }
                    if (node == head)
                    {
                        head = node.next;
                        return true;
                    }

                    prevNode.next = node.next;
                    return true;
                }
                prevNode = node;
                node = node.next;
            }

            return false;
        }

        public void RemoveAll(int _value)
        {
            Node node = head;
            Node prevNode = null;
            while (node != null)
            {
                if (node.value == _value)
                {
                    if (node == head)
                    {
                        head = node.next;
                        node = node.next;
                        continue;
                    }

                    prevNode.next = node.next;
                    if (node == tail)
                    {
                        tail = prevNode;
                    }
                    node = node.next;
                    continue;
                }
                prevNode = node;
                node = node.next;
            }
        }

        public void Clear()
        {
            Node node = head;
            while (node != null)
            {
                Node current = node;
                node = node.next;
                current.next = null;
            }
            head = null;
            tail = null;
        }

        public int Count()
        {
            int count = 0;
            Node node = head;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            return count;
        }

        public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
        {
            if (_nodeAfter == null)
            {
                _nodeToInsert.next = head;
                head = _nodeToInsert;
                return;
            }

            Node node = head;
            while (node != null)
            {
                if (node == _nodeAfter)
                {
                    _nodeToInsert.next = node.next;
                    node.next = _nodeToInsert;
                    return;
                }
                node = node.next;
            }
        }

    }
}
