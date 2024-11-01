namespace BaiTapT3h ;

public class Product
{

    public int Id { get ; set ;  }
    public decimal Price { get ; set ;  }
    public string Name { get ; set ;  }
    public int Qnantity { get ; set ;  }

    public override string ToString ( ) {
       return $"id : {Id} , NAME : {Name} , PRICE : {Price} , QNANTITY : {Qnantity}";
    }
    
}