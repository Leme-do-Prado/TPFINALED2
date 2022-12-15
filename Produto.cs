using System.Collections.Generic;  

public Produto{
    public int idProduto;
    public bool itemState = false;

    Produto(int id){
        this.idProduto = id;
    }

    public void mudaEstadoProduto(){
        if(this.itemState == false){
            this.itemState == true;
        } else{
            this.itemState=false;
        }
    }
}
