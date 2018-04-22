using GourmetGame.CrossCutting.Resources;
using GourmetGame.Domain.Test.Mock;
using NUnit.Framework;
using System;

namespace GourmetGame.Domain.Test
{
    [TestFixture]
    internal class GourmetGameManagerTest
    {
        [Test]
        public void creating_a_game_manager()
        {
            var gameManager = new GameManagerMock();

            Assert.AreEqual(GameMessages.Pasta, gameManager.Root.Description);
            Assert.AreEqual(GameMessages.ChocolateCake, gameManager.Root.RightNode.Description);
            Assert.AreEqual(GameMessages.Lasagna, gameManager.Root.LeftNode.Description);
        }

        [Test]
        public void plaing_a_valid_game()
        {
            var gameManager = new GameManagerMock();
            var exception = Assert.Throws<Exception>(() => gameManager.StartGame());

            Assert.AreEqual(GameMessages.IGotItRightAgain, exception.Message);
        }
    }
}