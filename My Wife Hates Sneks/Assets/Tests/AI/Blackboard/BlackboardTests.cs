using Assets.AI.Blackboard;
using NUnit.Framework;


namespace Tests
{
    public class BlackboardTests
    {
        [SetUp]
        public void SetUp()
        {
            BlackBoard.Instance.ClearBlackBoard();
        }

        [Test]
        public void AccessBlackBoardTest()
        {
            var instance = BlackBoard.Instance;
            Assert.NotNull(instance);
        }

        [Test]
        public void BlackBoardSingleItemObjectTests()
        {
            var instance = BlackBoard.Instance;

            var obj1 = new object();
            var obj2 = new object();
            var obj3 = new object();

            instance.Objects.Add("obj1", obj1);
            instance.Objects.Add("obj2", obj2);
            instance.Objects.Add("obj3", obj3);

            Assert.IsTrue(instance.Objects.ContainsKey("obj1"));
            Assert.IsTrue(instance.Objects.ContainsKey("obj2"));
            Assert.IsTrue(instance.Objects.ContainsKey("obj3"));
            Assert.IsFalse(instance.Objects.ContainsKey("asdf"));

            Assert.AreSame(instance.Objects["obj1"], obj1);
            Assert.AreSame(instance.Objects["obj2"], obj2);
            Assert.AreSame(instance.Objects["obj3"], obj3);
        }
    }
}
