using System;
using System.Collections.Generic;
using ProjetoProdutos.Interfaces;

namespace ProjetoProdutos.classes
{
    public class Marca : Inmarca
    {
         public int CodigoMarca { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
// ------------------------------------------------------
        List<Marca> ListaMarcas = new List<Marca>();

        public string Cadastrar(Marca marca)
        {
            ListaMarcas.Add(marca);
            return "";
        }

        public string Deletar(Marca marca)
        {
            ListaMarcas.Remove(marca);
            return "";
        }

        public List<Marca> Listar()
        {
            return ListaMarcas;
        }
    }
}