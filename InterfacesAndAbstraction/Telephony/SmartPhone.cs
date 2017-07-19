using System.Collections.Generic;
using System.Text;

public class SmartPhone : ICalling, IBrowsing
{
    private const string model = "Smartphone";
    private List<string> numbers;
    private List<string> sites;

    public SmartPhone(List<string> numbers, List<string> sites)
    {
        this.numbers = numbers;
        this.sites = sites;
    }

    public string Model => model;

    public string Call()
    {
        var sb = new StringBuilder();

        foreach (var num in this.numbers)
        {
            bool isValidNumber = true;
            foreach (var ch in num)
            {
                if (!char.IsDigit(ch))
                {
                    isValidNumber = false;
                    break;
                }
            }

            if (isValidNumber)
            {
                sb.AppendLine($"Calling... {num}");
            }

            else
            {
                sb.AppendLine("Invalid number!");
            }
        }

        return sb.ToString().Trim();
    }

    public string Browse()
    {
        var sb = new StringBuilder();

        foreach (var url in this.sites)
        {
            bool isValidUrl = true;
            foreach (var ch in url)
            {
                if (char.IsDigit(ch))
                {
                    isValidUrl = false;
                    break;
                }
            }

            if (isValidUrl)
            {
                sb.AppendLine($"Browsing: {url}!");
            }

            else
            {
                sb.AppendLine("Invalid URL!");
            }

        }

        return sb.ToString().Trim();
    }
}

