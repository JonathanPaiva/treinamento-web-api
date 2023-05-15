namespace TreinamentoWebAPI.Domain
{
    public class SuperHeroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? IdentidadeSecreta { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataAparicao { get; set; }
        public int? PoderId { get; set; }
        public virtual Poder? Poder { get; set; }
    }
}
