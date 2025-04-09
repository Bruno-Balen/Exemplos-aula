using System;
using Exemplo1;

Importacao importacao = new();

var produtos = importacao.CoverterParaLista();

foreach (var produto in produtos)
{
    Console.WriteLine(produto.id + " " + produto.name);
}

//Console.WriteLine("Hello, World!");
