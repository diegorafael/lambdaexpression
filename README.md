# Praticando com delegates

Considere os tipos abaixo:

```csharp
delegate bool Filter<T>(T element);
```

```csharp
class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
    public decimal Preco { get; set; }
}
```

```csharp
class LivroRepository
{
    private List<Livro> livros;

    public LivroRepository(List<Livro> livros)
    {
        this.livros = livros;
    }

    public List<Livro> Filtrar(Filter<Livro> filtro)
    {
        return livros.Where(x => filtro(x)).ToList();
    }
}
```

Para exercitar, crie uma classe `LivroFilter` que implementa as seguintes versões de `Filter<Livro>`:

- Filtro por ano de publicação: Mostrar livros publicados a partir de um determinado ano
- Filtro por preço máximo: Mostrar livros até um determinado preço
- Filtro por título: Mostrar livros que contenham uma palavra no título

Em seguida, crie uma aplicação que demonstre o uso das expressões/métodos definidas na classe `LivroFilter` como parâmetro para o método `LivroRepository.Filtrar(Filter<Livro> filtro)`
