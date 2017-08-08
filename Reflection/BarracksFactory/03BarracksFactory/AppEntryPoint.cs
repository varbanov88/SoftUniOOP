namespace _03BarracksFactory
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Data;

    public class AppEntryPoint
    {
        public static void Main()
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            ICommandInterpreter commentInterpreter = new CommandInterpreter(repository, unitFactory);
            IRunnable engine = new Engine(commentInterpreter);
            engine.Run();
        }
    }
}
