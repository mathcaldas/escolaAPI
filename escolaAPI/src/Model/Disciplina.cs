namespace escolaAPI.src.Model;

public class Disciplina
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public object Clone()
    {
        return MemberwiseClone();
    }
}