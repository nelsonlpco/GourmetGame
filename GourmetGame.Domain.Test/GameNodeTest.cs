using NUnit.Framework;

namespace GourmetGame.Domain.Test
{
    [TestFixture]
    public class GameNodeTest
    {
        [Test]
        public void creating_a_valid_game_node()
        {
            var gameNode = new GameNode("test", new GameNode("left"), new GameNode("right"));

            Assert.AreEqual("test", gameNode.Description);
            Assert.AreEqual("left", gameNode.LeftNode.Description);
            Assert.AreEqual("right", gameNode.RightNode.Description);
        }

        [Test]
        public void updating_the_description_of_game_node()
        {
            var gameNode = new GameNode("test");
            gameNode.UpdateNodeDescription("updating test");

            Assert.AreEqual("updating test", gameNode.Description);
        }

        [Test]
        public void setting_the_left_game_node()
        {
            var gameNode = new GameNode("test");
            var leftGameNode = new GameNode("left");
            gameNode.SetLeftNode(leftGameNode);

            Assert.AreEqual(gameNode.LeftNode.Description, leftGameNode.Description);
        }

        [Test]
        public void setting_the_right_game_node()
        {
            var gameNode = new GameNode("test");
            var rightGameNode = new GameNode("right");
            gameNode.SetRightNode(rightGameNode);

            Assert.AreEqual(gameNode.RightNode.Description, rightGameNode.Description);
        }
    }
}