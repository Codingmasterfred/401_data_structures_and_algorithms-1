using Xunit;

namespace CodeChallenges.Tests
{
  public class LinkedListTests
  {
    [Fact]
    public void LinkedList_Can_Add_Single_Node()
    {
      // Arrange
      LinkedList list = new LinkedList();
      Node node = new Node(5);

      // Act
      list.AddNewNode(node);

      // Assert
      Assert.Equal(list.Head, node);
    }

    [Fact]
    public void LinkedList_Can_Add_Two_Nodes()
    {
      // Arrange
      LinkedList list = new LinkedList();
      Node node1 = new Node(5);
      Node node2 = new Node(6);

      LinkedList expectedList = new LinkedList();
      node2.Next = node1;
      expectedList.Head = node2;

      // Act
      list.AddNewNode(node1);
      list.AddNewNode(node2);

      // Assert
      Assert.Equal(expectedList.Head, list.Head);
      Assert.Equal(expectedList.Head.Next, list.Head.Next);
    }
  }
}
