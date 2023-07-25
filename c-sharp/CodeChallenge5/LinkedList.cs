using System;

public class LinkedList
{
  public Node Head;

<<<<<<< HEAD
  public void AddNewNode(Node node)
  {
    node.Next = Head;
    Head = node;
  }

  public bool Includes(int value)
  {
    Node current = Head;
    while (current != null)
    {
      if (current.Value == value)
      {
        return true;
      }
      current = current.Next;
    }
    return false;
  }

  public override string ToString()
  {
    if (Head == null)
    {
      return "NULL";
=======


>>>>>>> 141754c9c629af4a4d1cdea725b8156896753c85
    }

    string result = "";
    Node current = Head;
    while (current != null)
    {
      result += $"{{ {current.Value} }} -> ";
      current = current.Next;
    }
    result += "NULL";
    return result;
  }
}

public class Node
{
  public Node Next;
  public int Value;

  public Node(int value)
  {
    Value = value;
    Next = null;
  }
}
