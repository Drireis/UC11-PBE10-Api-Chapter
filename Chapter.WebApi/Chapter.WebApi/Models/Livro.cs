namespace Chapter.WebApi.Models
{
    // models: armazena as propriedades da classe
    public class Livro
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? QuantidadePaginas { get; set; }
        public bool Disponivel { get; set; }

    }
}
