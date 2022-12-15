public static Estoque{
    public Queue<TipoProduto> tiposProduto;

    public void enfileiraTipoProduto(TipoProduto tipo){
        this.tiposProduto.Enqueue(tipo);
    }

    public static void mostraFilaProduto(){
        int i = 0;
        foreach(TipoProduto tipo in tiposProduto)
            {
                i++;
                Console.WriteLine(i, + "º: ", + tipo.ToString());
            }
        Console.WriteLine("---------------");
    }

    public TipoProduto procuraTipoProduto(int idtp){
    for (int i=0; i< tiposProduto.Count; i++) {
    if (tiposProduto[i].id == idp) {
        return qtProdutosTipoProduto[i];
    break;
    }
}
