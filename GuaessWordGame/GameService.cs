using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuaessWordGame
{
    public interface GameService
    {
        
        void start();
        void GuaessWord(string word);
        void GuaessLetter(string letter); 
    }
}
