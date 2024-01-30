namespace ExpressoesLambda
{
    internal class LivroFilter 
    {
        public Filter<Livro> Criteria { get; private set; }

        private LivroFilter(Filter<Livro> criteria)
        {
            Criteria = criteria;
        }

        public static LivroFilter CriterioAnoMinimo(int ano)
            => new(livro => livro.AnoPublicacao >= ano);

        public static LivroFilter CriterioPrecoMaximo(decimal precoMaximo)
            => new(livro => livro.Preco <= precoMaximo);

        public static LivroFilter CriterioTituloContemPalavra(string palavra)
            => new(livro => livro.Titulo.Contains(palavra, StringComparison.OrdinalIgnoreCase));
    }
}
