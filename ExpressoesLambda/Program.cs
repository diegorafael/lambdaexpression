namespace ExpressoesLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Livro> livros = new List<Livro>
            {
                new Livro { Titulo = "A Jornada do Conhecimento", Autor = "Luciana Silva", AnoPublicacao = 2020, Preco = 30.0m },
                new Livro { Titulo = "Desvendando Mistérios Literários", Autor = "Carlos Oliveira", AnoPublicacao = 2022, Preco = 25.0m },
                new Livro { Titulo = "Caminhos da Imaginação", Autor = "Isabela Santos", AnoPublicacao = 2019, Preco = 40.0m },
            };

            var livroRepository = new LivroRepository(livros);

            const int ano = 2020;
            const decimal preco = 30.0m;
            const string palavra = "desvendando";

            Filter<Livro> filtroPorAno = livro => LivroFilter.FiltroPorAno(livro, ano);
            List<Livro> livrosFiltradorPorAno = livroRepository.Filtrar(filtroPorAno);
            ProgramHelpers.DisplayLivros(livrosFiltradorPorAno, $"Livros Filtrados Por Ano - {ano}");

            Filter<Livro> filtroPorPrecoMaximo = livro => LivroFilter.FiltroPorPrecoMaximo(livro, preco);
            List<Livro> livrosFiltradorPorPreco = livroRepository.Filtrar(filtroPorPrecoMaximo);
            ProgramHelpers.DisplayLivros(livrosFiltradorPorPreco, $"Livros Filtrados Por Preço Máximo - {preco}");

            Filter<Livro> filtroPorTitulo = livro => LivroFilter.FiltroPorTitulo(livro, palavra);
            List<Livro> livrosFiltradorPorTitulo = livroRepository.Filtrar(filtroPorTitulo);
            ProgramHelpers.DisplayLivros(livrosFiltradorPorTitulo, $"Livros Filtrados Por Título - {palavra}");
        }
    }
}
