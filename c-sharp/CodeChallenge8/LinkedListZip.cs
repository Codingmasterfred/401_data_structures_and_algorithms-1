using System;
using System.Collections.Generic;

namespace CodeChallenges
{
  public class Node<T>
  {
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    public Node(T value)
    {
      Value = value;
      Next = null;
    }
  }

  public class LinkedList<T>
  {
    public Node<T> Head { get; set; }

    public LinkedList()
    {
      Head = null;
    }

    // Other methods for adding nodes to the linked list can be implemented here
  }

  public class CodeChallenge8
  {
    public LinkedList<T> ZipLists<T>(LinkedList<T> list1, LinkedList<T> list2)
    {
      LinkedList<T> resultList = new LinkedList<T>();
      Node<T> current1 = list1.Head;
      Node<T> current2 = list2.Head;
      Node<T> currentResult = null;

      while (current1 != null || current2 != null)
      {
        if (current1 != null)
        {
          if (currentResult == null)
          {
            resultList.Head = new Node<T>(current1.Value);
            currentResult = resultList.Head;
          }
          else
          {
            currentResult.Next = new Node<T>(current1.Value);
            currentResult = currentResult.Next;
          }
          current1 = current1.Next;
        }

        if (current2 != null)
        {
          if (currentResult == null)
          {
            resultList.Head = new Node<T>(current2.Value);
            currentResult = resultList.Head;
          }
          else
          {
            currentResult.Next = new Node<T>(current2.Value);
            currentResult = currentResult.Next;
          }
          current2 = current2.Next;
        }
      }

      return resultList;
    }
  }
}
