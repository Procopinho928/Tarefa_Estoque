namespace Estoque
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();

            p.codigo = txt_codigo.Text;
            p.descricao = txt_descricao.Text;
            p.precoCompra = Convert.ToDouble(txt_preco.Text);
            p.lucro = Convert.ToDouble(txt_lucro.Text);

           
            p.ValorTotal();
            txt_venda.Text = p.valorVenda.ToString();

            produtos.Add(p);


            table_produtos.Rows.Add(p.codigo, p.descricao, p.precoCompra, p.lucro, p.valorVenda);
            
            
        }
    }
}