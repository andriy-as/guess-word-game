using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuaessWordGame
{
    public class TaskProviderImpl : TaskProvider
    {
        Random random = new Random();

        Task[] tasks =
        {
            new Task() { answer ="Capital of the Ukraine ?", question="Kyiv" },
            new Task() { answer ="Capital of the Russia ?", question="Moskov" },
        };

        public Task get()
       {

           return tasks[random.Next(tasks.Length)] ;
            
        }
    }
}
