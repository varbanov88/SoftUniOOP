using OnlineRadioDatabase.ExceptionClasses;
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();

        for (int i = 0; i < count; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            try
            {
                var artistName = input[0];
                var songName = input[1];

                var time = input[2].Split(':').ToArray();
                int minutes;
                int seconds;
                if (int.TryParse(time[0], out minutes) && int.TryParse(time[1], out seconds))
                {
                    songs.Add(new Song(artistName, songName, minutes, seconds));
                    Console.WriteLine("Song added.");
                }
                else
                {
                    throw new InvalidSongLengthException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        int totalDuration = 0;
        foreach (var song in songs)
        { totalDuration += song.Minutes * 60 + song.Seconds; }
        int totalMinutes = totalDuration / 60;
        int totalSeconds = totalDuration % 60;
        int hours = totalMinutes / 60;
        totalMinutes %= 60;

        Console.WriteLine($"Songs added: {songs.Count}");
        Console.WriteLine($"Playlist length: {hours}h {totalMinutes}m {totalSeconds}s");
    }
}

