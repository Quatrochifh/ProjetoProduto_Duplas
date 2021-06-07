using System;
using System.Collections.Generic;
using ProjetoProdutos.classes;

namespace ProjetoProdutos.Interfaces
{
    public interface Inmarca
    {
        string Cadastrar(Marca marca);
        List<Marca> Listar();
        string Deletar(Marca marca);

    }
}