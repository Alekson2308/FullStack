using System;
using System.Collections.Generic;
using System.Text;

namespace Produtos.Interface;

internal interface IProduto
{
    string RealizarCompra();
    string VerificarEstoque();
    string EscolherOpcoes();
    string AvaliarProduto();
    double ExibirValor();
    double CalcularEstoque();
    double CalcularTotalDaCompra();

}
