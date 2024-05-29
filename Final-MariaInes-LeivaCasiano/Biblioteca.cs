namespace Final_MariaInes_LeivaCasiano;

public class Biblioteca
{
    public string libroagregado; // se declaran las variables que se utilizaron 
    public string librodevuelto;
    public string libropres;
    public string libroa;
    public int opciondato;
    public string[] libros; // se declaró el arreglo de libros que se utilizó en el programa
    public string[] libros2; // se declaró un segundo arreglo de libros para utilizarlo en el programa

    public string[] libros3; // se declaró un tercer arreglo de libros para utilizarlo en el programa

    public Biblioteca()
    {
        opciondato = 0; // se inicializaron algunas variables 
        libroagregado = "";
        libros = new string[5] { "El principito", "Maria", "Orgullo y prejuicio", "Los juegos del hambre", "Harry potter" }; // se creo el arreglo de libros
        libros2 = new string[5] { "El principito", "Maria", "Orgullo y prejuicio", "Los juegos del hambre", "Harry potter" }; // se creo un segundo arreglo de libros con los mismos datos
        libros3 = new string[5]; // se creo el tercer arreglo de libros, pero con valores nulos
    }

    public void PrestarLibro() // se creo la función de prestar libros
    {
        for (int i = 0; i < libros.Length; i++) // se recorre el arreglo de libros
        {
            Console.WriteLine(libros[i]); // imprime el nombre de los libros que se encuentran en el arreglo
        }
        int Regreso = 0;
        do // se creo un bucle do while que se repite hasta marcar la opción indicada
        {
            Console.WriteLine("¿Qué libro desea prestar? (Escriba el nombre del libro tal como aparece en la pantalla)"); // se imrpime el mensaje
            libroagregado = Console.ReadLine(); // se guarda el dato en la variable
            switch (libroagregado) // se creo el switch para comprobar que el libro ingresado si exista en el programa
            {
                case "El principito":
                case "Maria":
                case "Orgullo y prejuicio":
                case "Los juegos del hambre":
                case "Harry potter":
                    Regreso = 0;
                    break;
                default: // muestra el siguiente error si el libro ingresado no aparece en la lista

                    Console.WriteLine("Opción inválida");
                    Regreso = 5;
                    break;
            }
        } while (Regreso == 5);
        for (int i = 0; i < libros2.Length; i++) // se recorre el arreglo y se busca algún lugar vacío en el arreglo de libros2
        {
            if (libros2[i] == libroagregado) // se crea una condición para poder comprobar que el libre ingresado se encuentra en el arreglo de,libros2
            {
                libros2[i] = null; //convierte la posición donde se encuentra el libro en nula al ya no poseer al libro
                libros3[i] = libroagregado; //el libro seleccionado de guarda en el arreglo de libros3
                Console.WriteLine($"El libro '{libros3[i]}' ha sido prestado"); // se imprime el mensaje
                break;
            }
            else // se agrega otra condición
            {
                if (i == 10) //verifica que el arreglo2 llegue hasta el final
                {
                    Console.WriteLine("El libro se encuentra disponible en este momento"); // se imprime el mensaje
                }
            }
        }
    }
    public void DevolverLibro() // se crea la función de devolver el libro
    {
        int Regreso = 0;
        do // se crea un bucle do while para que se repita hasta marcar la opción indicada
        {
            Console.WriteLine("¿Qué libro desea devolver?"); // se imprime el mensaje
            librodevuelto = Console.ReadLine(); // se guarda la información en la variable
            switch (librodevuelto) // se creo el switch para verificar que el libro ingresado si exista
            {
                case "El principito":
                case "Maria":
                case "Orgullo y prejuicio":
                case "Los juegos del hambre":
                case "Harry potter":
                    Regreso = 0; // se creo regreso con el fin de terminar el bucle si el libro se encuentra en el arreglo
                    break;
                default:

                    Console.WriteLine("Opción inválida");
                    Regreso = 5; // se creo regreso con el fin de continuar el bucle si el libro no se encuentra en el arreglo
                    break;
            }
        } while (Regreso == 5);

        for (int i = 0; i < libros.Length; i++) // se recorre el arreglo para encontrar algún espacio vacío en el arreglo 
        {
            if (libros2[i] == null) //verifica que el espacio en el arreglo2 sea nulo
            {
                libros2[i] = librodevuelto; //se coloca el libro en el espacio vacío que se encuentre en el arreglo
                break;
            }
        }

        for (int i = 0; i < libros.Length; i++) // se recorre el arreglo para encontrar el libro ingresado en el arreglo3
        {
            if (libros3[i] == librodevuelto) // se creo la condición para comprobar que el libro que se encuentra en el arreglo3 es igual al libro que ha devuelto
            {
                libros3[i] = null; // la posición donde se encotraba el libro queda vacía
                break;
            }
        }
        Console.WriteLine("El libro ha sido devuelto"); // se imprime el mensaje
    }

    public void LibroPrestado() // se creo la función para prestar el libro
    {

        for (int i = 0; i < libros3.Length; i++) // se recorre el arreglo3 para poder mostrar los libros prestadps
        {
            if (libros3[i] != null) // se creo una condición para verificar si se encuentran libros en las posiciones del arreglo
            {
                Console.WriteLine($"El libro prestado es: {libros3[i]}"); // se imprime el mensaje
            }
        }
    }

    public void Catalogo() // se creo la función para ver el catálogo
    {
        Console.WriteLine("Libros que no han sido prestados"); // se imprime el mensaje
        for (int i = 0; i < libros2.Length; i++) //se recorre el arreglo2 para observar los libros que quedan en este arreglo
        {
            if (libros2[i] != null) // se creo la condición para verificar si las posciones del arreglo poseen libros o no
            {
                Console.WriteLine(libros2[i]); // se imprime el nombre del libro
            }
        }
    }


}
