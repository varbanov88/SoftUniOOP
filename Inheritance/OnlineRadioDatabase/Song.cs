﻿using OnlineRadioDatabase.ExceptionClasses;

public class Song
{
    private string artistName;
    private string songName;
    private int minutes;
    private int seconds;
    private int totalLength;

    public Song(string artistName, string songName, int minutes, int seconds)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
    }

    public int Seconds
    {
        get { return this.seconds; }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new InvalidSongSecondsException();
            }

            this.seconds = value;
        }
    }

    public int Minutes
    {
        get { return this.minutes; }
        set
        {
            if (value < 0 || value > 14)
            {
                throw new InvalidSongMinutesException();
            }

            this.minutes = value;
        }
    }

    public string SongName
    {
        get { return this.songName; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new InvalidSongNameException();
            }
        }
    }

    public string ArtistName
    {
        get { return this.artistName; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new InvalidArtistNameException();
            }
        }
    }
}

