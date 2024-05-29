using Final_MariaInes_LeivaCasiano;
Cliente objcliente = new Cliente();

int opcion = 0; // se declaran las variables y se inicializan
int opciondato = 0;
do // se creo un bucle do while para poder repetir el menú hasta dar en la opción que lo termina
{
    Console.WriteLine(""); // se imprimen las opciones del menú
    Console.WriteLine("Escoja la opción que desea realizar");
    Console.WriteLine("1) Ingresar datos");
    Console.WriteLine("2) Mostrar datos");
    Console.WriteLine("3) Salir");

    opcion = int.Parse(Console.ReadLine()); // se convirtió el dato de tipo string a tipo entero

    switch (opcion) // se creo el menú 
    {
        case 1:
            objcliente.MenuInfoCliente (); // se mandó a llamar a la función de información cliente para mostar las preguntas que posee esta función

            break;
        case 2:
            do // se creo otro ciclo while para poder repetir el segundo menú
            {
                Console.WriteLine(""); // se imprimen las opciones del menú
                Console.WriteLine("Escoja la opción que desea realizar");
                Console.WriteLine("1) Listado de libros prestados por el usuario");
                Console.WriteLine("2) Consultar catálogo de libros");
                Console.WriteLine("3) Listado de usuarios activos");
                Console.WriteLine("4) Volver al menú principal");
                opciondato = int.Parse(Console.ReadLine()); // se convirtió el dato de valor string a uno de valor entero

                switch (opciondato) // se creo un switch para mostar el menú
                {
                case 1: 
                    objcliente.MostrarLibrosP(); // se mandó a llamar a función de mostrar libros
                    break;
                case 2:
                     objcliente.MostrarCatalogo(); // se mandó a llamar a la función de mostrar catálogo
                    break;
                case 3:
                    objcliente.ClientesActivos(); // se mandó a llamar a la función de clientes activos
                    break;
                case 4:
                    break;
                   }       
            }
            while (opciondato !=4);
            break;
        case 3: // se dejó un case vacío para terminar con el bucle
            break;
    }
}
while (opcion != 3);