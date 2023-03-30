namespace SinglyLinkedListLab
{
    public class Tests
    {
        private LinkedList sll;
        //private LinkedList<string> sllList;
        [SetUp]
        public void Setup()
        {
            sll= new LinkedList();
            //sllList = new LinkedList<string>();
        }

        [Test]
        public void TestPrependingToEmpty()
        {
            string name = "Joe Blow";
            sll.AddFirst(name);
            // assert new name added or the SLL is bigger
            Node first = sll.Head;
            Assert.IsNotNull(first);
            string value = first.Value;
            Assert.AreEqual("Joe Blow", value);
            Assert.AreEqual(1, sll.Count);
        }
        [Test]
        public void TestAppendingToLast() 
        {
            string name1 = "Joe Blow";
            string name2 = "Joe Schmoe";
            sll.AddLast(name1);
            sll.AddLast(name2);
            Assert.AreEqual(2, sll.Count);
        }
        [Test]
        public void TestRemoveFirst()
        {
            string name1 = "Joe Blow";
            string name2 = "Joe Schmoe";
            string name3 = "John Smith";
            sll.AddLast(name1);
            sll.AddLast(name2);
            sll.AddLast(name3);
            sll.RemoveFirst();
            Assert.AreEqual(2, sll.Count);
            sll.RemoveFirst();
            Assert.AreEqual(1, sll.Count);
            Node first = sll.Head;
            string value = first.Value;
            Assert.AreEqual("John Smith", value);
        }
        [Test]
        public void TestRemoveLast()
        {
            string name1 = "Joe Blow";
            string name2 = "Joe Schmoe";
            string name3 = "John Smith";
            string name4 = "Jane Doe";
            string name5 = "Bob Bobberson";
            sll.AddFirst(name1);
            sll.AddFirst(name2);
            sll.AddFirst(name3);
            sll.AddFirst(name4);
            sll.AddFirst(name5);
            Node first = sll.Head;
            string value = first.Value;
            sll.RemoveLast();
            Assert.AreEqual(4, sll.Count);
            sll.RemoveLast();
            Assert.AreEqual(3, sll.Count);            
            Assert.AreEqual("Bob Bobberson", value);
        }
        [Test]
        public void TestGetValue()
        {
            string name1 = "Joe Blow";
            string name2 = "Joe Schmoe";
            string name3 = "John Smith";
            string name4 = "Jane Doe";
            string name5 = "Bob Bobberson";
            string name6 = "Sam Sammerson";
            string name7 = "Dave Daverson";
            sll.AddFirst(name1);
            sll.AddFirst(name2);
            sll.AddFirst(name3);
            sll.AddFirst(name4);
            sll.AddFirst(name5);
            sll.AddFirst(name6);
            sll.AddFirst(name7);
            string value1 = sll.GetValue(0);
            string value2 = sll.GetValue(6);
            Assert.AreEqual("Dave Daverson", value1);
            Assert.AreEqual("Joe Blow", value2);
            Assert.AreEqual(7,sll.Count);
        }
    }
}