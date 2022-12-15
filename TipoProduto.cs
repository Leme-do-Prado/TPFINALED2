using System.Collections.Generic;  

public TipoProduto{
    public int idTipo;
    public int vlDiarioTipo;
    public Queue<Produto> produtos;

    public TipoProduto(int idTipo, int vlDiarioTipo){
        this.idTipo = idTipo;
        this.vlDiarioTipo = vlDiarioTipo;
    }

    public void enfileiraProduto(Produto produto, Queue<Produto> qtProdutosTipoProduto){
        qtProdutosTipoProduto.enqueue(produto);
    }

    public Produto procuraProduto(int idp){
    for (int i=0; i< this.ProdutosTipoProduto.Count; i++) {
    if (ProdutosTipoProduto[i].id == idp) {
        return produto[i];
    break;
    }
}
