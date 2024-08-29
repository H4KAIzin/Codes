namespace Codes;

public class Entrega{
    Int64 Id;
    String Produto;
    String Frete;
     String Entreg;
    public Entrega()
    {
        
    }

    public void SetId1(Int64 i)
    {
        Id = i;
    }

    public Int64 GetId1()
    {
        return Id;
    }

    public void SetProduto(String p)
    {
        Produto = p;
    }

    public string GetProduto()
    {
        return Produto;
    }

    public void SetFrete(String f)
    {
        Frete = f;
    }

    public string GetFrete()
    {
        return Frete;
    }


    public void SetEntreg(String e)
    {
        Entreg = e;
    }

    public string GetEntreg()
    {
        return Entreg;
    }
}