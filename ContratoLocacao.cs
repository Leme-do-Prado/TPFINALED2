public ContratoLocacao{
    private DateTime retorno, saida;

    public ContratoLocacao(){
        this.saida = DateTime.Now;
        this.retorno = new DateTime(DateTime.Now.Day+7, DateTime.Month, DateTime.Year);
    }
}
