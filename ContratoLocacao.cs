public ContratoLocacao{
    public int idCliente, qt;
    public TipoProduto tipo;
    public DateTime retorno, saida;
    public Queue<Produto> produtos;

    public ContratoLocacao(TipoProduto tipo, int idCliente, int qt){
        this.tipo = tipo;
        this.idCliente = idCliente;
        this.qt = qt;
        this.saida = DateTime.Now;
        this.retorno = new DateTime(DateTime.Now.Day+7, DateTime.Month, DateTime.Year);
    }
}
