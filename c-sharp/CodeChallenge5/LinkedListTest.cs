using Xunit;

namespace LinkedListTest
{
  public class LinkedListTests
  {
    [Fact]
    public void TestLinkedListCreation()
    {
      LinkedList linkedList = new LinkedList();
      Assert.Null(linkedList.Head);
    }

    [Fact]
    public void TestLinkedListInsertion()
    {
      LinkedList linkedList = new LinkedList();
      linkedList.AddNewNode(new Node(3));
      linkedList.AddNewNode(new Node(7));

      Assert.Equal(7, linkedList.Head.Value);
      Assert.Equal(3, linkedList.Head.Next.Value);
    }

    [Fact]
    public void TestLinkedListHeadPointsToFirstNode()
    {
      LinkedList linkedList = new LinkedList();
      linkedList.AddNewNode(new Node(2));

      Assert.NotNull(linkedList.Head);
      Assert.Equal(2, linkedList.Head.Value);
      Assert.Null(linkedList.Head.Next);
    }

    [Fact]
    public void TestLinkedListInsertMultipleNodes()
    {
      LinkedList linkedList = new LinkedList();
      linkedList.AddNewNode(new Node(5));
      linkedList.AddNewNode(new Node(10));
      linkedList.AddNewNode(new Node(15));

      Assert.Equal(15, linkedList.Head.Value);
      Assert.Equal(10, linkedList.Head.Next.Value);
      Assert.Equal(5, linkedList.Head.Next.Next.Value);
    }

    [Fact]
    public void TestLinkedListIncludesExistingValue()
    {
      LinkedList linkedList = new LinkedList();
      linkedList.AddNewNode(new Node(5));
      linkedList.AddNewNode(new Node(10));

      Assert.True(linkedList.Includes(5));
      Assert.True(linkedList.Includes(10));
    }

    [Fact]
    public void TestLinkedListIncludesNonExistingValue()
    {
      LinkedList linkedList = new LinkedList();
      linkedList.AddNewNode(new Node(5));
      linkedList.AddNewNode(new Node(10));

      Assert.False(linkedList.Includes(7));
      Assert.False(linkedList.Includes(15));
    }

    [Fact]
    public void TestLinkedListToString()
    {
      LinkedList linkedList = new LinkedList();
      linkedList.AddNewNode(new Node(2));
      linkedList.AddNewNode(new Node(4));
      linkedList.AddNewNode(new Node(6));

      Assert.Equal("{ 6 } -> { 4 } -> { 2 } -> NULL", linkedList.ToString());
    }
  }
}
