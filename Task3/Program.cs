using System;

namespace Task3
{
    class Program
    {
        public static void PlaySongs(IPlayable pla)
        {
            pla.Play();
            pla.Pause();
            pla.Stop();
        }

        public static void RecordSongs(IRecodable rec)
        {
            rec.Record();
            rec.Pause();
            rec.Stop();
        }
        static void Main(string[] args)
        {
            Player pla = new Player();
            PlaySongs(pla);
            Console.WriteLine(new string('-',50));
            RecordSongs(pla);
        }

      
    }
}
