namespace escolaAPI.src.Factories;
public abstract class EntityFactoryCreator
{
    public abstract IEntityFactory CreateFactory();
}

public class JsonEntityFactoryCreator : EntityFactoryCreator
{
    public override IEntityFactory CreateFactory()
    {
        return new JsonEntityFactory();
    }
}