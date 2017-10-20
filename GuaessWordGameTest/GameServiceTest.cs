using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using GuaessWordGame;

namespace GuaessWordGameTest
{
    [TestClass]
    public class GameServiceTest
    {
        [TestMethod]
        public void TestStart()
        {
            var taskProviderMoq = new Mock<TaskProvider>();

            var task = new Task() { question= "Capital of the Ukraine ?", answer = "Kyiv" };
          
            taskProviderMoq.Setup(x => x.get()).Returns(task);

            var gameViewMock = new Mock<GameView>();

            var gameservice = new GameServiceMpl(taskProviderMoq.Object, gameViewMock.Object);
            

            gameservice.start();

            gameViewMock.Verify(x => x.showTask(task));
            gameViewMock.Verify(x => x.showCurrentGuess("****"));

        }
        [TestMethod]
        public void TestGuaessWord()
        {
            

        }
    }
}
