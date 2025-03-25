using modul6_103022330067;
using System;

class main
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Intan Nur Aini");
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Harry Potter 1 oleh Intan Nur Aini");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Harry Potter 2 oleh Intan Nur Aini");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Harry Potter 3 oleh Intan Nur Aini");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Harry Potter 4 oleh Intan Nur Aini");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Harry Potter 5 oleh Intan Nur Aini");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film How to train Your Dragon oleh Intan Nur Aini");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film How to train Your Dragon 2 oleh Intan Nur Aini");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film How to train Your Dragon 3 oleh Intan Nur Aini");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Frozen oleh Intan Nur Aini");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Frozen oleh Intan Nur Aini");
        SayaTubeVideo video11 = new SayaTubeVideo("Review Film Moana oleh Intan Nur Aini");
        video1.IncreasePlayCount(3);
        video2.IncreasePlayCount(5);
        video3.IncreasePlayCount(2);
        video4.IncreasePlayCount(3);
        video5.IncreasePlayCount(2);
        video6.IncreasePlayCount(2);
        video7.IncreasePlayCount(3);
        video8.IncreasePlayCount(4);
        video9.IncreasePlayCount(3);
        video10.IncreasePlayCount(2);
        video11.IncreasePlayCount(3);
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);
        user.AddVideo(video11);
        user.PrintAllVideoPlayCount();
        Console.WriteLine("Memanggil sisa method yang ada di dua class yang belum terpanngil(kecuali get dan set)");
        video1.PrintVideoDetails();
        Console.WriteLine("Total Play Count : " + user.GetTotalPlayCount());
    }
}
