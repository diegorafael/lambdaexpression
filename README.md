# Lambda Expression - Atividade sobre Delegates - Programa DiverseDev 📘

## Descrição da Atividade 🚀

Esta atividade faz parte de um estudo em grupo sobre o uso de delegates no contexto de desenvolvimento de software. Ela foi proposta pela Ada, no âmbito do programa DiverseDev do Mercado Eletrônico. O objetivo é explorar e compreender como os delegates podem ser aplicados para implementar filtros em uma lista de livros.

## Componentes Principais 📚

### 1. Livro 📖

- **Propriedades:**
  - Titulo (string): Título do livro.
  - Autor (string): Autor do livro.
  - AnoPublicacao (int): Ano de publicação do livro.
  - Preco (decimal): Preço do livro.

### 2. LivroRepository 📚

- **Métodos:**
  - Construtor: Inicializa o repositório de livros com uma lista fornecida.
  - Filtrar: Aceita um delegate como critério de filtro e retorna a lista de livros filtrada.

### 3. LivroFilter 🔍

- **Métodos Estáticos:**
  - FiltroPorAno: Retorna true se o livro atender ao critério de ano fornecido.
  - FiltroPorPrecoMaximo: Retorna true se o livro atender ao critério de preço máximo fornecido.
  - FiltroPorTitulo: Retorna true se o livro atender ao critério de título fornecido.

### 4. ProgramHelpers 🛠️

- **Métodos Estáticos:**
  - DisplayLivros: Exibe uma lista de livros no console, juntamente com um título descritivo.

### 5. Delegates e Filtros ⚙️

- São utilizados três delegates diferentes para aplicar filtros aos livros: `filtroPorAno`, `filtroPorPrecoMaximo` e `filtroPorTitulo`.

## Execução do Programa ▶️

1. Criação de uma lista de livros.
2. Inicialização do repositório de livros com a lista criada.
3. Definição de critérios de filtro (ano, preço, título).
4. Utilização de delegates para aplicar os filtros.
5. Exibição dos resultados no console.

## Observações 📌

- O código utiliza expressões lambda para definir os delegates de filtro, demonstrando a flexibilidade e concisão desse recurso.

## Como Executar o Programa 🚀

1. Clone o repositório.
2. Abra o projeto em um ambiente de desenvolvimento compatível com C#.
3. Compile e execute o programa.

## Contribuidores 👥

Este projeto foi desenvolvido como parte do programa DiverseDev, iniciativa da Ada em parceria com o Mercado Eletrônico.

- [Camila Zambanini](https://github.com/czambanini)
- [Carolina Armentano](https://github.com/armentanoc)
- [Igor Nunes](https://github.com/ig-nunes)
- [Paula Marinho](https://github.com/paulaandrezza)

---

*Este projeto é parte de uma iniciativa educacional e não tem como objetivo ser utilizado em um ambiente de produção.* 🚧

=======

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
