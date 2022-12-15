
public Program{
    public static void Main[]{
        Random myObject = new Random();
        int s = Console.ReadInt();
        while (s<9 && s >0)
        {
            switch(s){
            case 1:
            int a = myObject.Next();
            Console.WriteLine("Lembre-se! ID: ", + a);
            Console.WriteLine("Valor diário: ")
            int vl = Console.ReadInt();
            tiposProduto.enqueue(new TipoProduto(a, vl));
            break;
            case 2:
            mostraFilaProduto();
            break;
            case 3:
            int idp = myObject.Next();
            int idtp = Console.ReadInt();
            procuraTipoProduto(idtp).enfileiraProduto(new Produto(idp));
            break;
            case 4:
            
            break;
            case 5:
            break;
            case 6:
            break;
            case 7:
            break;
            case 8:
            break;
            case 9:
            break;
        }
        }
    }
}
