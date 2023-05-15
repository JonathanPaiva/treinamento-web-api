namespace TreinamentoWebAPI.Domain
{
    public class Poder
    {
        public int Id { get; set; }
        public string Habilidade { get; set; }
        public ICollection<SuperHeroi> SuperHerois { get; set; }

    }
}
