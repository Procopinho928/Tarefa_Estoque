public class Produto
{
    public string codigo;
    public string descricao;
    public double precoCompra;
    public double lucro;
    public double valorVenda;  

    public void ValorTotal()
    {
        double porcentagem = (lucro * precoCompra) / 100;
        
        valorVenda = porcentagem + precoCompra;
    }
}