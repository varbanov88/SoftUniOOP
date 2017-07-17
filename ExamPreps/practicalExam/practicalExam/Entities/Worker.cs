public abstract class Worker
{
    private string id;

    protected Worker(string id)
    {
        this.id = id;
    }

    public string Id
    {
        get => id;
        protected set
        {
            this.id = value;
        }
    }
}

