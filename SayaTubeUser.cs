using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq.Expressions;

namespace modul6_103022330067
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;
        public SayaTubeUser(string username)
        {
            Debug.Assert(!string.IsNullOrEmpty(username) && username.Length <= 100, "Username tidak boleh nul dan maksimal 100 karakter");
            try
            {
                checked
                {
                    Random random = new Random();
                    this.id = random.Next(10000, 99999);
                    this.Username = username;
                    this.uploadedVideos = new List<SayaTubeVideo>();
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Play count melebihi batas maksimal");
            }
        }

        public int GetTotalPlayCount()
        {
            int totalPlayCount = 0;
            foreach (SayaTubeVideo video in this.uploadedVideos)
            {
                totalPlayCount += video.GetPlayCount();
            }
            return totalPlayCount;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null && video.GetPlayCount() < int.MaxValue, "Video tidak boleh null");
            this.uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
                int a = 0;
                Console.WriteLine("User : " + this.Username);
                for (int i = 0; i < this.uploadedVideos.Count; i++)
                {
                    a++;
                if (a > 8)
                {
                    break;
                }
                    Console.WriteLine("Video " + a + " Judul : " + this.uploadedVideos[i].GetTitle());
                }

        }
    }
}
