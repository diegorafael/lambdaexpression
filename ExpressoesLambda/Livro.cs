namespace ExpressoesLambda
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public decimal Preco { get; set; }

        public override string ToString()
        {
            return $"Título: {Titulo}, Autor: {Autor}, AnoPublicado: {AnoPublicacao}, Preco: R$ {Preco:F2}";
        }
    }
}
