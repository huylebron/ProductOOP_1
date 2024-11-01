namespace BaiTapT3h ;

public delegate void EventConfig ( Product product ) ;
public class ProductService
{
    private List < Product > sp ; 
    
    
    public event EventConfig ProductOrder ;


    public ProductService ( ) {
        sp = new List < Product > ( ) ;
        
    }

    public void AddProduct ( Product product ) {
        sp.Add ( product ) ;
     
    }

    public void UpdateProduct ( Product product ) {

        var exist = sp . FirstOrDefault ( x => x . Id == product . Id ) ;
        if ( exist != null )
        {
            exist . Name = product . Name ;
            exist . Price = product . Price ;
            exist . Qnantity = product . Qnantity ;
        }
    }

    public Product Find ( int id ) {

        return sp . FirstOrDefault ( x => x . Id == id ) ;
        
    }

    public List < Product > Search ( string key ) {
        return sp .Where( x => x.Name.Contains(key)).ToList();
    }

    public void  delete ( int id ) {

        var product = Find ( id ) ;
        if ( product != null )
        {
            sp . Remove ( product ) ;
            
        }
    }

    public bool Order ( int id , int quantity ) {

        var product = Find ( id ) ;
        if ( product != null && product . Qnantity >= quantity )
        {
            product . Qnantity -= quantity ;
            ProductOrder(product);
            return true ;

        }

        return false ;

    }

    public List < Product > GetAll ( ) {

        return sp . ToList ( ) ;
        
    }
    
    
    
    
    

}