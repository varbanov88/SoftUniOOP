namespace _02BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type blackBoxType = typeof(BlackBoxInt);
            BlackBoxInt blackBox = (BlackBoxInt)Activator.CreateInstance(blackBoxType, true);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split('_');
                string method = tokens[0];
                int value = int.Parse(tokens[1]);

                blackBoxType.GetMethod(method, BindingFlags.Instance | BindingFlags.NonPublic)
                        .Invoke(blackBox, new object[] { value });
                string innerState = blackBoxType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                        .First()
                        .GetValue(blackBox)
                        .ToString();

                Console.WriteLine(innerState);
            }
        }
    }
}
