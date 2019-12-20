using SQLite4Unity3d;

public class Planet 
{
    [PrimaryKey, AutoIncrement]
    public int id { get; set; }
    public int x { get; set; }
    public int y { get; set; }

    public override string ToString()
    {
        return string.Format("[planet: Id={0}, x={1},  y={2}]", id, x, y);
    }
}
