using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuaessWordGame
{
    public class GameServiceMpl : GameService
    {
        TaskProvider taskProvider;
        GameView gameview;
        Task task;
        string currentGuess;


        public GameServiceMpl(TaskProvider taskProvider, GameView gameview)
        {
            this.taskProvider = taskProvider;
            this.gameview = gameview;
        }

        public void GuaessLetter(string letter)
        {
            throw new NotImplementedException();
        }

        public void GuaessWord(string word)
        {
            
        }

        public void start()
        {
            task = taskProvider.get();
            gameview.showTask(task);
            currentGuess = new String('*', task.answer.Length);
            gameview.showCurrentGuess(currentGuess);
        }

       
    }
}
