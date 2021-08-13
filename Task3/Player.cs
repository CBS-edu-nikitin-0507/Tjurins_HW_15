using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Player : IRecodable, IPlayable
    {
        void IPlayable.Play() 
        {
            Console.WriteLine("Playing song");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Playing paused");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Playing stoped");
        }

        void IRecodable.Record() 
        {
            Console.WriteLine("Recording song");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Recording paused");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Recording stopped");
        }
    }
}
