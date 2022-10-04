namespace ExoApi.Models
{
    public class Projetos
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Status { get; set; }
        public DateTimeOffset? DataInicio { get; set; }
        public string? Area { get; set; }
    }
}
