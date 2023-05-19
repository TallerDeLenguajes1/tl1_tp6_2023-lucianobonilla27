
int menu;
float a,b;
do
{
Console.WriteLine("ingrese la operacion que desea realizar"); 
Console.WriteLine("1_Valor absoluto:"); 
Console.WriteLine("2_Cuadrado:"); 
Console.WriteLine("3_Raiz cuadrada:"); 
Console.WriteLine("4_Seno:"); 
Console.WriteLine("5_Coseno:"); 
Console.WriteLine("6_Parte entera:"); 
Console.WriteLine("7_Maximo:"); 
Console.WriteLine("8_Minimo:"); 
Console.WriteLine("9_Salir:"); 
bool control=int.TryParse(Console.ReadLine(),out menu);  
switch (menu)
{
    case 1:
    Console.WriteLine("ingrese el numero"); 
    bool control1=float.TryParse(Console.ReadLine(),out a);  
    Console.WriteLine("|{0}| = {1}",a,Math.Abs(a));


       
    break;
     case 2:
    Console.WriteLine("ingrese el numero"); 
    bool control3=float.TryParse(Console.ReadLine(),out a);  
   
    Console.WriteLine("{0}^2 = {1}",a,a*a);
    
    break;
     case 3:
    Console.WriteLine("ingrese el numero");
    bool control5=float.TryParse(Console.ReadLine(),out a);   
    Console.WriteLine("raiz({0}) = {1}",a,Math.Sqrt(a));
    
    
    break;
     case 4:
    Console.WriteLine("ingrese el numero");
    bool control7=float.TryParse(Console.ReadLine(),out a);  
    Console.WriteLine("sin({0}) = {1}",a,Math.Sin(a));

    
    break;
    case 5:
    Console.WriteLine("ingrese el numero");
    bool control8=float.TryParse(Console.ReadLine(),out a);  
    Console.WriteLine("cos({0}) = {1}",a,Math.Cos(a));

    
    break;
    case 6:
    Console.WriteLine("ingrese el numero");
    bool control9=float.TryParse(Console.ReadLine(),out a);  
    Console.WriteLine("int({0}) = {1}",a,Math.Truncate(a));

    
    break;
    case 7:
    Console.WriteLine("ingrese el numero 1");
    bool control10=float.TryParse(Console.ReadLine(),out a); 
    Console.WriteLine("ingrese el numero 2");
    bool control11=float.TryParse(Console.ReadLine(),out b);  
    if (a > b)
    {
        Console.WriteLine("{0} es mayor",a);
    }else
    {
        Console.WriteLine("{0} es mayor",b);
        
    }

    
    break;
    case 8:
    Console.WriteLine("ingrese el numero 1");
    bool control12=float.TryParse(Console.ReadLine(),out a); 
    Console.WriteLine("ingrese el numero 2");
    bool control13=float.TryParse(Console.ReadLine(),out b);  
    if (a < b)
    {
        Console.WriteLine("{0} es menor",a);
    }else
    {
        Console.WriteLine("{0} es menor",b);
        
    }

    
    break;
    case 9:
    Console.WriteLine("Adios!"); 
    
    break;
    default:
    Console.WriteLine("Ingrese un numero valido"); 
    break;
}
} while (menu != 9);





