using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330067
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;
        public SayaTubeUser(string username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
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
            this.uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
                int a = 0;
                Console.WriteLine("User : " + this.Username);
                for (int i = 0; i < this.uploadedVideos.Count; i++)
                {
                    a++;
                    Console.WriteLine("Video " + a + " Judul : " + this.uploadedVideos[i].GetTitle());
                }

        }
    }
}
