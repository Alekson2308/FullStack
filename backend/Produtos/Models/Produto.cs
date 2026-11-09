using Produtos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Produtos.Models;

internal class Produto : IProduto
{
    public string AvaliarProduto()
    {
        return "Produto avaliado com sucesso!";
    }

    public double CalcularEstoque()
    {
        int quantidade = 50;
        double valorUnitario = 25.90;

        return quantidade * valorUnitario;
    }

    public double CalcularTotalDaCompra()
    {
        double preco = 100.00;
        int quantidade = 3;

        return preco * quantidade;
    }

    public string EscolherOpcoes()
    {
        return "Opção selecionada: Produto padrão.";
    }

    public double ExibirValor()
    {
        double preco = 99.90;

        return preco;
    }

    public string RealizarCompra()
    {
        return "Compra realizada com sucesso!";
    }

    public string VerificarEstoque()
    {
        int quantidade = 50;

        if (quantidade > 0)
        {
            return "Produto disponível em estoque!";
        }
        else
        {
            return "Produto indisponível em estoque!";
        }
    }
}