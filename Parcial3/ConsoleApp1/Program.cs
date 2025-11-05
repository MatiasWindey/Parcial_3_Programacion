

using Parcial3.Modelo;
using Parcial3.Repositories;
using Parcial3.Data;

bool consolaActiva = true;

while (consolaActiva)
{
    Console.WriteLine("ingrese una de las siguientes opciones\n\r 1.Registrar Nuevo Producto\n\r 2.Registrar nuevo cliente\n\r 3.Registrar nueva venta\n\r 4.Mostrar reporte de ventas de un cliente\n\r 5.Salir\n\r");
    int OpcionSeleccionada = int.Parse(Console.ReadLine());

    switch (OpcionSeleccionada)
    {
        case 1:

            if(OpcionSeleccionada == 1)
            {
                Console.WriteLine("Ingrese el nombre del producto");
                string NombreProd = Console.ReadLine();
                Console.WriteLine("ingrese el Precio del producto por unidad");
                float Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad de producto a agregar");
                int Cant = int.Parse(Console.ReadLine());

                Producto ProductoNuevo = new Producto(NombreProd, Precio, Cant);

                RepoProducto.AgregarProducto(ProductoNuevo);

            }
        break;

        case 2:
            if(OpcionSeleccionada == 2)
            {

                Console.WriteLine("ingrese el Dni del cliente");
                string Dni = Console.ReadLine();
                using(var context = new ApplicationDbContext())
                {
                    
                    var ClienteBuscado = context.clientes.FirstOrDefault(c => c.DNI == Dni);
                    if(ClienteBuscado != null)
                    {

                        Console.WriteLine("Cliente ya existente, intente otra vez");


                    }
                    else
                    {
                        Console.WriteLine("Dni verificado");

                        Console.WriteLine("ingrese el Nombre del cliente");
                        string Nombre = Console.ReadLine();
                        Console.WriteLine("ingrese el apellido del cliente");
                        string Apellido = Console.ReadLine();

                        Cliente ClienteNuevo = new Cliente(Dni, Nombre, Apellido);

                        RepoCliente.AgregarCliente(ClienteNuevo);


                    }

                }
                
            }
        break;

        case 3:

            if(OpcionSeleccionada == 3)
            {
                Console.WriteLine("Ingrese la fehca de la nueva venta");
                string FechaVenta = Console.ReadLine();
                Console.WriteLine("Ingrese el dni del comprador");
                string Dni = Console.ReadLine();

                using (var context = new ApplicationDbContext())
                {
                    var ClienteBuscado = context.clientes.FirstOrDefault(c => c.DNI == Dni);
                    if (ClienteBuscado != null)
                    {

                        Console.WriteLine("Dni verificado y encontrado");

                        foreach (Producto producto in context.productos)
                        {

                            Console.WriteLine($"Nombre : {producto.NombreProducto} Precio: ${producto.Precio}\n\r");
                        }

                        Console.WriteLine("ingrese el producto a comprar de los que se muestran arriba");
                        string NombreProd = Console.ReadLine();
                        var ProductoBuscado = context.productos.FirstOrDefault(p => p.NombreProducto == NombreProd);
                        if(ProductoBuscado != null)
                        {
                            Console.WriteLine("Nombre verificado y encontrado");

                            Console.WriteLine("ingrese la cantidad a comprar del producto seleccionado");
                            int CantProd = int.Parse(Console.ReadLine());

                            Venta VentaNueva = new Venta(FechaVenta, Dni, NombreProd, CantProd);

                            RepoVenta.AgregarVenta(VentaNueva);




                        }
                        else
                        {
                            Console.WriteLine("Nombre de producto no existente, intente nuevamente");
                        }



                    }
                    else
                    {
                        Console.WriteLine("Dni no existente, intente de nuevo");
                    }
                }
            }
        break;

        case 4:
            if(OpcionSeleccionada == 4)
            {

                Console.WriteLine("Seleccione el dni del cliente del cual quiere revisar las compras");
                string Dni = Console.ReadLine();

                using (var context = new ApplicationDbContext())
                {
                    var ClienteBuscado = context.ventas.FirstOrDefault(c => c.DniCliente == Dni);
                    if(ClienteBuscado != null)
                    {

                        Console.WriteLine($"El cliente con el DNI: {ClienteBuscado.DniCliente} Compro el producto {ClienteBuscado.ProductoComprado} y compro {ClienteBuscado.CantidadComprada} unidades");

                    }
                    else
                    {
                        Console.WriteLine("el Cliente Con dicho Dni no existe o aun no ha realizado compras, intente otra vez");
                    }
                }
            }
        break;

        case 5:
            if(OpcionSeleccionada== 6)
            {
                consolaActiva = false;
            }
        break;
    }
    


}