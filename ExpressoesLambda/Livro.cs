using System.Globalization;

namespace ExpressoesLambda
{
    internal class Livro
    {
        private readonly CultureInfo ptBr = CultureInfo.GetCultureInfo("pt-BR");
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public decimal Preco { get; set; }
        public override string ToString()
        {
            return $"{nameof(Titulo)}: {Titulo}, " +
                   $"{nameof(Autor)}: {Autor}, " +
                   $"{nameof(AnoPublicacao)}: {AnoPublicacao}, " +
                   $"{nameof(Preco)}: {Preco.ToString("C2", ptBr)}";
        }
    }
}
