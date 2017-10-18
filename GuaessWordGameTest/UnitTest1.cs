using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuaessWordGame;

namespace GuaessWordGameTest
{
    [TestClass]
    public class TaskProviderTest
    {
        TaskProvider taskProvider = new TaskProviderImpl();
        [TestMethod]
        public void TestGet()
        {
            var task = taskProvider.get();
            Assert.IsNotNull(task);
            Assert.IsNotNull(task.answer);
            Assert.IsNotNull(task.question);

        }

        [TestMethod]
        public void testGetReturnsDiffernt()
        {
            var task1 = taskProvider.get();
            var task2 = taskProvider.get();
            Assert.AreNotEqual(task1, task2);
        }
    }
}
