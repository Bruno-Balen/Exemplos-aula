using Exemplo1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    public class Importacao
    {
        private readonly string[] _arquivo;

        public Importacao()
        {
            _arquivo = File.ReadAllLines("C:\\Repositorios\\Paradigmas\\Exemplos-aula\\Exemplos\\Exemplos\\produtos.txt");
        }

        public List<produto> CoverterParaLista()
        {
            List<produto> produtos = new();

            for (int i = 1; i < _arquivo.Length; i++) {

               string[] coluna = _arquivo[i].Split(';');
                
               produto produto = new();
               produto.id = Convert.ToInt32(coluna[0]);
               produto.name = coluna[1];
               produto.descricao = coluna[2];
               produto.preco = Convert.ToDouble(coluna[3]);
               produto.quantidade = Convert.ToInt32(coluna[4]);
               produto.codbarras = coluna[5];

               produtos.Add(produto);
            }

            return produtos;
        }
    }
}
