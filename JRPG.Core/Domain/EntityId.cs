namespace JRPG.Core.Domain;

public readonly struct EntityId
{
    public int Id { get; }
    
    public EntityId(int id)
    {
        Id = id;
    }
    
    public override string ToString() => Id.ToString();
}