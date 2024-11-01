using System . Runtime . InteropServices ;

namespace BaiTapT3h ;

public class ProductManager
{
    private ProductService ps;

    public ProductManager ( ) {
        ps = new ProductService ( ) ;
        ps . ProductOrder += HandleProductOrder ;
        
        
    }

    private void HandleProductOrder ( Product product ) {
       
        Console.WriteLine ( $"Product {product.Name} order ok " ) ;
    }

    public void imp ( ) {

        while ( true )
        {

            menu ( ) ;

            string chon = Console . ReadLine ( ) ;

            switch ( chon )
            {
                case "1":
                    Create ( ) ;
                    break;
                case "2" :
                    Update ( ) ;
                    break;
                case "3" :
                    Delete ( ) ;
                    break;
                case "4" :
                    Order ( ) ;
                    break;
                case "5" :
                    Search ( ) ;
                    break;
                case "6" :
                    ShowAll ( ) ;
                    break;
                case "7" :
                    return;
                    
                default:
                    Console . WriteLine ( "Chon sai" ) ;
                    break;
            }
        }
    }

    private void ShowAll ( ) {
        Console.WriteLine("\n Hien thi all \n");
        var product = ps . GetAll ( ) ;
        foreach ( var p in product )
        {
            Console . WriteLine ( p ) ;
        }
    }

    private void Search ( ) {
        Console.WriteLine("\n Tim kiem san pham \n");
        Console . Write ( "Nhap ten: " ) ;
        string key = Console . ReadLine ( ) ;
        var result = ps . Search ( key ) ;
        foreach ( var product in result )
        {
            Console . WriteLine ( product ) ;
        }
    }

    private void Create ( ) {
        Console.WriteLine("\n them san phan \n");
        
        Console . Write ( "Nhap id: " ) ;
        int id = int . Parse ( Console . ReadLine ( ) ) ;
        Console . Write ( "Nhap ten: " ) ;
        string name = Console . ReadLine ( ) ;
        Console . Write ( "Nhap gia: " ) ;
        decimal price = decimal . Parse ( Console . ReadLine ( ) ) ;
        Console . Write ( "Nhap so luong: " ) ;
        int quantity = int . Parse ( Console . ReadLine ( ) ) ;

        Product product = new Product ( ) ;
        product . Id = id ;
        product . Name = name ;
        product . Price = price ;
        product . Qnantity = quantity ;
       ps.AddProduct ( product ) ;

       
    }
    
    private void Update ( ) {
        Console.WriteLine("\n Sua san pham \n");
        Console . Write ( "Nhap id: " ) ;
        int id = int . Parse ( Console . ReadLine ( ) ) ;
        Console . Write ( "Nhap ten: " ) ;
        string name = Console . ReadLine ( ) ;
        Console . Write ( "Nhap gia: " ) ;
        decimal price = decimal . Parse ( Console . ReadLine ( ) ) ;
        Console . Write ( "Nhap so luong: " ) ;
        int quantity = int . Parse ( Console . ReadLine ( ) ) ;

        Product product = new Product ( ) ;
        product . Id = id ;
        product . Name = name ;
        product . Price = price ;
        product . Qnantity = quantity ;
        ps.UpdateProduct ( product ) ;
    }
    
    private void Delete ( ) {
        Console.WriteLine("\n Xoa san pham \n");
        Console . Write ( "Nhap id: " ) ;
        int id = int . Parse ( Console . ReadLine ( ) ) ;
        ps.delete ( id ) ;
    }
    
    private void Order ( ) {
        Console.WriteLine("\n Dat hang \n");
        Console . Write ( "Nhap id: " ) ;
        int id = int . Parse ( Console . ReadLine ( ) ) ;
        Console . Write ( "Nhap so luong: " ) ;
        int quantity = int . Parse ( Console . ReadLine ( ) ) ;
        if ( ps . Order ( id , quantity ) )
        {
            Console . WriteLine ( "Dat hang ok" ) ;
        }
        else
        {
            Console . WriteLine ( " failed" ) ;
        }
    }
    
    
    

    private void menu ( ) {
        Console.WriteLine("\n QUẢN LÝ SẢN PHẨM \n  ");
        Console . WriteLine ( "1. Them san pham" ) ;
        Console . WriteLine ( "2. Sua san pham" ) ;
        Console . WriteLine ( "3. Xoa san pham" ) ;
        Console . WriteLine ( "4. Dat hang" ) ;
        Console . WriteLine ( "5. Tim kiem" ) ;
        Console . WriteLine ( "6. Hien thi tat ca" ) ;
        Console . WriteLine ( "7. Thoat" ) ;
        Console . Write ( "Chon: " ) ;
    }
}