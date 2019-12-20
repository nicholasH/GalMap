using SQLite4Unity3d;

public class chain
{
    [PrimaryKey, AutoIncrement]
    public int id { get; set; }
    public int Oid { get; set; }

    public override string ToString()
    {
        return string.Format("[chain: id={0}, Oid={1}", id, Oid);
    }
}
