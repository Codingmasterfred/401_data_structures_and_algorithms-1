using Xunit;

    [Fact]
    public void LinkedList_Head_Property_Is_Node()
    {
      PropertyInfo head = typeof(LinkedList).GetProperty("Head");
      Type headType = head.PropertyType;
      Assert.Equal(typeof(Node), headType);
    }

    [Fact]
    public void LinkedList_Can_Add_Single_Value()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      LinkedList list = new LinkedList();

      int value = 5;
      insertMethod.Invoke(list, new object[]{value});
      PropertyInfo head = typeof(LinkedList).GetProperty("Head");

      Node headValue = (Node)head.GetValue(list);

      PropertyInfo ValueProperty = typeof(Node).GetProperty("Value");
      
      
      int result = (int)ValueProperty.GetValue(headValue);

      Assert.Equal(value, result);
    }

    [Fact]
    public void TestLinkedListCreation()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      LinkedList list = new LinkedList();
      int value = 5;
      int value2 = 6;
      insertMethod.Invoke(list, new object[]{value});
      insertMethod.Invoke(list, new object[]{value2});

      PropertyInfo head = typeof(LinkedList).GetProperty("Head");

      Type headType = head.PropertyType;
      Node headValue = (Node)head.GetValue(list);

      PropertyInfo ValueProperty = typeof(Node).GetProperty("Value");
      
      int result1 = (int)ValueProperty.GetValue(headValue);
      
      PropertyInfo NextProperty = typeof(Node).GetProperty("Next");
      Node headValue2 = (Node)NextProperty.GetValue(headValue);

      int result2 = (int)ValueProperty.GetValue(headValue2);
      Node headValue3 = (Node)NextProperty.GetValue(headValue);


      Assert.Equal(value2, result1);
      Assert.Equal(value, result2);
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
