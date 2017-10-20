using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuaessWordGame
{
    public interface GameView
    {
        void showSorry(string message);
        void showCongratulations(string message);
        void showCurrentGuess(string message);
        void showTask(Task task);
        
    }
}
