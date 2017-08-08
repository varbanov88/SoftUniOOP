namespace _03BarracksFactory.Core.Commands
{
    using _03BarracksFactory.Attributes;
    using _03BarracksFactory.Contracts;

    class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data)
            : base(data)
        {
        }

        public override string Execute()
        {
            this.repository.RemoveUnit(Data[1]);
            return $"{this.Data[1]} retired!";
        }
    }
}
