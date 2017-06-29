
public class Car
{
    private string model;
    private string speed;

    public Car(string model, string speed)
    {
        Model = model;
        Speed = speed;
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }

    public string Speed
    {
        get
        {
            return this.speed;
        }
        set
        {
            this.speed = value;
        }
    }
}

