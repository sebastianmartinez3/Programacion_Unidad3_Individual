namespace Unidad3_Individual;

class Program
{
    // Pista
    // static [Clase] _usuario
    // static [Clase] _libro
    
    static void Main(string[] args)
    {
        string? entrada;
        Console.WriteLine("Actividad Unidad 3 (Individual)");
        Console.WriteLine("Creada por: ");
        Menu();
        do
        {
            entrada = Console.ReadLine();
            switch (entrada)
            {
                case "0":
                    Menu();
                    break;
                case "1":
                    RegistrarUsuario();
                    break;
                case "2":
                    ConsultarUsuario();
                    break;
                case "3":
                    RegistrarLibro();
                    break;
                case "4":
                    ConsultarLibro();
                    break;
                case "9":
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }

        } while (entrada!= "9");
        Console.WriteLine("Fin de apicación");
    }

    static void Menu()
    {
        Console.WriteLine("=== Menu principal ===");
        Console.WriteLine("0. Menu principal");
        Console.WriteLine("1. Registrar usuario");
        Console.WriteLine("2. Consultar usuario");
        Console.WriteLine("3. Registrar libro");
        Console.WriteLine("4. Consultar libro");
        Console.WriteLine("----------------------");
        Console.WriteLine("9. Salir");
    }

    static void RegistrarUsuario()
    {
        
    }

    static void ConsultarUsuario()
    {
        
    }

    static void RegistrarLibro()
    {
        
    }

    static void ConsultarLibro()
    {
        
    }
}