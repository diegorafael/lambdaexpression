namespace ExpressoesLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var livros = new List<Livro> {
            new Livro { AnoPublicacao = 2010, Autor = "João", Preco = 50, Titulo = "Uma nova forma de ver" },
            new Livro { AnoPublicacao = 1970, Autor = "Maria", Preco = 10, Titulo = "A casa da colina" },
            new Livro { AnoPublicacao = 2024, Autor = "Ariel", Preco = 500, Titulo = "Arquitetura do metaverso" },
            new Livro { AnoPublicacao = 1995, Autor = "Cláudia", Preco = 45, Titulo = "Como organizar sua casa" },
            new Livro { AnoPublicacao = 2020, Autor = "Pedro", Preco = 22, Titulo = "Vinte e sete segredos" },
};
            var repository = new LivroRepository(livros);

            var preco = LivroFilter.CriterioPrecoMaximo(40);
            var titulo = LivroFilter.CriterioTituloContemPalavra("casa");
            var ano = LivroFilter.CriterioAnoMinimo(2000);

            Console.WriteLine("---- Preço ----");
            ImprimirLivros(repository.Filtrar(preco.Criteria));
            Console.WriteLine("---------------");

            Console.WriteLine("---- Título ----");
            ImprimirLivros(repository.Filtrar(titulo.Criteria));
            Console.WriteLine("---------------");

            Console.WriteLine("---- Ano ----");
            ImprimirLivros(repository.Filtrar(ano.Criteria));
            Console.WriteLine("---------------");

            Console.ReadLine();

            void ImprimirLivros(List<Livro> livros)
            {
                foreach (var livro in livros)
                    Console.WriteLine($"{livro.Titulo} ({livro.Autor}), {livro.AnoPublicacao} - R$ {livro.Preco}");
            }
        }
    }
}
