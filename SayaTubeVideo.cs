using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace modul6_103022330067
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        public SayaTubeVideo(string title)
        {
            Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 200, "Judul tidak boleh nul dan kurang dari 200 karakter");
            try
            {
                checked
                {
                    Random random = new Random();
                    this.id = random.Next(10000, 99999);
                    this.title = title;
                    this.playCount = 0;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Play count melebihi batas maksimal");
            }  
        }
        public void IncreasePlayCount(int a)
        {
            Debug.Assert(a > 0 && a <= 25000000, "Play count harus lebih dari 0 dan maks 25000000");
            try
            {
                checked
                {
                    this.playCount += a;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Play count melebihi batas maksimal");
            }
        }

        public int GetPlayCount()
        {
            return this.playCount;
        }

        public string GetTitle()
        {
            return title;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }
}
