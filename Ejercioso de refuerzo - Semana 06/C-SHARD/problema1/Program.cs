
class Program
{
    static  void  MostrarLinea ( string  caracter ,  int  n ) 
    {
        for ( int  i = 0 ; i < n ; i ++ ) 
        {
            Console.Write ( caracter ) ;
        }
        
        Console.WriteLine ( "" ) ;
    }

    static  void  Main ( ) 
    {
        Console.WriteLine ( "ingresa el caracter" ) ;
        string  carac = Console.ReadLine ( ) ;
        
        Console.WriteLine ( "ingresa N numero" ) ;
        int  Num = int.Parse ( Console.ReadLine ( ) ) ;
        
        MostrarLinea ( carac ,  Num ) ;
        
        Console.WriteLine ( "fin de la impresion" ) ;
    }
}