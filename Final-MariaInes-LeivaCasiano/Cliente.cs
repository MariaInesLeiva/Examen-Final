using System.Runtime.InteropServices;

namespace Final_MariaInes_LeivaCasiano;

public class Cliente
{
    public string Nombre; // Se definieron las variables que se utilizaron en el código
    public string Apellido;
    public string Carnet;
    public string Telefono;
    public int opcioninfo;
    public string librodevuelto;
    public string nombrelibro;
    public int prestolibro;
    Biblioteca objbiblioteca = new Biblioteca(); // se creó el objeto de biblioteca para poder obtener algunos datos que se guardan en esa clase
Cliente [] clientes = new Cliente [5]; // se creo el arreglo de clientes para que la cantidad de libros coincidiera con los clientes
    public Cliente()
    {
        Nombre = ""; // se inicializaron las variables
        Apellido = "";
        Carnet = "";
        Telefono = "";
        opcioninfo = 0;
        librodevuelto = "";
    }

    public void MenuInfoCliente() //Se creo la función donde se encuentra el menu de la información del cliente
    {
        do //se creo un ciclo do while para que el menú se repita hasta que se indique la opción de salir
        {
            Console.WriteLine("");
            Console.WriteLine("Escoja la opción que desea realizar");
            Console.WriteLine("1) Ingresar datos del cliente");
            Console.WriteLine("2) Prestar libros");
            Console.WriteLine("3) Devolver libros");
            Console.WriteLine("4) Salir");
            opcioninfo = int.Parse(Console.ReadLine()); // se convitió el dato de tipo string en un dato de tipo int

            switch (opcioninfo)  // se creó el menú de opciones
            {
                case 1:
                    Cliente objetoclientes = new Cliente();  // se creo el objeto de la clase clientes
                    Console.WriteLine("Ingrese el nombre del cliente"); //se solicitaron los datos personales del cliente
                    objetoclientes.Nombre = Console.ReadLine(); //los datos se guardan en las variables indicadas
                    Console.WriteLine("Ingrese los apellidos del cliente");
                    objetoclientes.Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese el carné del cliente");
                    objetoclientes.Carnet = Console.ReadLine();
                    Console.WriteLine("Ingrese el número de teléfono del cliente");
                    objetoclientes.Telefono = Console.ReadLine();
                    int Repetir = 0;
                    do // se creo un ciclo do while para que aparezca el siguiente menú
                    {
                        Console.WriteLine("El usuario presto libro"); // se creo el menú para conocer si el usuario prestó libro
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                        objetoclientes.prestolibro = int.Parse(Console.ReadLine()); // el dato de tipo string se convitió a tipo entero
                        switch (objetoclientes.prestolibro) 
                        {
                            case 1: //Se crearon los casos que pueden solicitar
                            case 2:
                            Repetir = 1;
                                break;
                            default:
                                Repetir = 5;
                                break;
                        }
                    } while (Repetir == 5); // indica que se repetirá si se ingresa el número 5

                    for (int i = 0; i < clientes.Length; i++) // se recorre el arreglo de clientes para encontrar alguna posición vacía
                    {
                        if (clientes[i] == null) // se creo una condición que indica que si el espacio es nulo, entonces se ocupará por el nuevo cliente
                        {
                            clientes[i] = objetoclientes; // asigna al cliente en la posición vacía que se encontró
                            break;
                        }
                    }
                    break;
                case 2:
                    objbiblioteca.PrestarLibro(); // se llama a la función de prestar libro que se encuentra en la clase biblioteca
                    break;
                case 3:
                    objbiblioteca.DevolverLibro(); // se llama a la función de devolver libro que se encuentra en la clase biblioteca
                    break;
                case 4:
                    break;
            }
        }
        while (opcioninfo != 4);



    }
    public void MostrarLibrosP() // se creó la función para mostrar los libros prestados
    {
        objbiblioteca.LibroPrestado(); // se mandó a llamar la función de libros prestados en la clase biblioteca
    }

    public void MostrarCatalogo() // se creó la función para mostrar el catálogo
    {
        objbiblioteca.Catalogo(); // se mandó a llamar la función catálogo en la clase biblioteca
    }

    public void ClientesActivos() // se creó la función para determinar a los clientes que son activos
    {
        for(int i = 0;i<clientes.Length;i++) // se recorre el arreglo de clientes
        {
            if(clientes[i] != null) // se creo la condición para verificar que exista un cliente 
            {
                if(clientes[i].prestolibro == 1) // se valida si el cliente ha prestado un libro para considerase activo
                {
                    Console.WriteLine(clientes[i].Nombre+" es un cliente activo"); // se imprime el mensaje 
                }
            }
        } 
    }
}
