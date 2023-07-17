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
    public void TestLinkedListIncludes()
    {
      LinkedList linkedList = new LinkedList();
      linkedList.AddNewNode(new Node(5));
      linkedList.AddNewNode(new Node(10));

      Assert.True(linkedList.Includes(5));
      Assert.True(linkedList.Includes(10));
      Assert.False(linkedList.Includes(7));
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
