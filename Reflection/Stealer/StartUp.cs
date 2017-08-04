using System;

public class StartUp
{
    public static void Main()
    {
        Collector();
    }

    private static void Collector()
    {
        Spy spy = new Spy();
        var result = spy.CollectGettersAndSetters("Hacker");
        Console.WriteLine(result);
    }

    private static void MissionPrivateImpossible()
    {
        Spy spy = new Spy();
        var result = spy.RevealPrivateMethods("Hacker");
        Console.WriteLine(result);
    }

    private static void HighQualityMistakes()
    {
        Spy spy = new Spy();
        var result = spy.AnalyzeAcessModifiers("Hacker");
        Console.WriteLine(result);
    }

    private static void Stealer()
    {
        Spy spy = new Spy();
        var result = spy.StealFieldInfo("Hacker", "username", "password");
        Console.WriteLine(result);
    }
}