
int menu,a,b;
do
{
Console.WriteLine("ingrese la operacion que desea realizar"); 
Console.WriteLine("1_Sumar:"); 
Console.WriteLine("2_Restar:"); 
Console.WriteLine("3_Multiplicar:"); 
Console.WriteLine("4_Dividir:"); 
Console.WriteLine("5_Salir:"); 
bool control=int.TryParse(Console.ReadLine(),out menu);  
switch (menu)
{
    case 1:
    Console.WriteLine("ingrese el primer numero a sumar"); 
    bool control1=int.TryParse(Console.ReadLine(),out a);  
    Console.WriteLine("ingrese el segundo numero a sumar"); 
    bool control2=int.TryParse(Console.ReadLine(),out b);  
        Console.WriteLine("{0} + {1} = {2}",a,b,a+b);


       
    break;
     case 2:
    Console.WriteLine("ingrese el primer numero a restar"); 
    bool control3=int.TryParse(Console.ReadLine(),out a);  
    Console.WriteLine("ingrese el segundo numero a restar"); 
    bool control4=int.TryParse(Console.ReadLine(),out b);  
    Console.WriteLine("{0} - {1} = {2}",a,b,a-b);
    
    break;
     case 3:
    Console.WriteLine("ingrese el primer numero a multiplicar");
    bool control5=int.TryParse(Console.ReadLine(),out a);  
    Console.WriteLine("ingrese el segundo numero a multiplicar"); 
    bool control6=int.TryParse(Console.ReadLine(),out b);  
    Console.WriteLine("{0} x {1} = {2}",a,b,a*b);
    
    
    break;
     case 4:
    Console.WriteLine("ingrese el primer numero a dividir");
    bool control7=int.TryParse(Console.ReadLine(),out a);  
    Console.WriteLine("ingrese el segundo numero a dividir"); 
    bool control8=int.TryParse(Console.ReadLine(),out b);  
    Console.WriteLine("{0} : {1} = {2}",a,b,a/b);

    
    break;

    case 5:
    Console.WriteLine("Adios!"); 
    
    break;
    default:
    Console.WriteLine("Ingrese un numero valido"); 
    break;
}
} while (menu != 5);





