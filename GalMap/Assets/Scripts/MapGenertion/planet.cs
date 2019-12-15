using SQLite4Unity3d;

public class Planet 
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public int x { get; set; }
    public int y { get; set; }

    public override string ToString()
    {
        return string.Format("[Person: Id={0}, x={1},  y={2}]", Id, x, y);
    }
}
