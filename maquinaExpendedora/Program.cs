using System;
using System.Collections;

namespace maquinaExpendedora
{
    class Program
    {
        static void Main(string[] args)
        {

            Producto[] producto = new Producto[5];
            Queue pasoMaquina = new Queue();
            string nombreProducto = "";
            int totalDinero = 0;
            int devuelta = 0;



            producto[0] = new Producto("cheestrese", 2000, 5);
            producto[1] = new Producto("tacos", 1000, 5);
            producto[2] = new Producto("bombom", 500, 5);
            producto[3] = new Producto("caramelos", 1000, 5);
            producto[4] = new Producto("yogurt", 3000, 5);


            while (true)
            {
                pasoMaquina.Enqueue(totalDinero = recibirDinero());
                pasoMaquina.Enqueue(nombreProducto = pedirProdcuto(producto, totalDinero));
                pasoMaquina.Enqueue(devuelta = darProducto(producto, nombreProducto, totalDinero));

                Console.WriteLine("su devuelta es " + devuelta);

            }




        }

        public static string pedirProdcuto(Producto[] producto, int totalDinero)

        {
            Console.WriteLine(" tu dinero es : " + totalDinero + "\n\n");

            Console.WriteLine("\t\t\t MAQUINA DIXPENSADORA \n");


            var sb = new System.Text.StringBuilder();



            string nombreProducto = "";

            Console.WriteLine("\tNOMBRE" + "\t\t\tPRECIO" + "\t\t\tCANTIDAD \n");

            foreach (var product in producto)
            {
                sb.Append(String.Format("{0,15}  {1,20}  {2,25}\n", product.getNombre(), product.getPrecio(), product.getCantidad()));

            }

            Console.WriteLine(sb);




            Console.Write("\n digite el nombre del prodcuto : ");
            nombreProducto = Console.ReadLine().ToLower();





            switch (nombreProducto)
            {
                case "cheestrese":




                    break;

                case "tacos":
                    break;

                case "bombom":
                    break;

                case "caramelos":
                    break;

                case "yogurt":
                    break;

                default:
                    Console.Clear();
                    pedirProdcuto(producto, totalDinero);
                    break;
            }

            foreach (var product in producto)
            {
                if (product.getNombre() == nombreProducto)
                {
                    if (product.getPrecio() > totalDinero)
                    {
                        Console.Clear();
                        Console.WriteLine("dinero insuficinete");

                        pedirProdcuto(producto, totalDinero);
                    }
                    break;
                }

            }


            return nombreProducto;
        }


        public static int recibirDinero()
        {
            char respuesta = 'N';



            int totalDinero = 0;
            try
            {
                do
                {
                    Console.WriteLine("ingrese el  dinero ");
                    totalDinero += int.Parse(Console.ReadLine());
                    Console.WriteLine("S para escoger producto  N para introducir mas dinero");
                    respuesta = Console.ReadLine()[0];


                } while (respuesta == 'n' || respuesta == 'N');
            }
            catch (FormatException e)
            {
                Console.Clear();
                Console.WriteLine("dato numerico no valido ");

                do
                {
                    Console.WriteLine("ingrese el  dinero ");
                    totalDinero += int.Parse(Console.ReadLine());
                    Console.WriteLine("S para escoger producto  N para introducir mas dinero");
                    respuesta = Console.ReadLine()[0];


                } while (respuesta == 'n' || respuesta == 'N');
            }


            Console.Clear();

            return totalDinero;
        }


        public static int darProducto(Producto[] producto, string nombreProducto, int totalDinero)
        {

            Console.Clear();


            int countMonedaQuinientos = 0;
            int countMonedaDocientos = 0;
            int countMonedaCien = 0;




            foreach (var product in producto)
            {
                if (product.getNombre() == nombreProducto)
                {
                    product.setCantidad(product.getCantidad() - 1);
                    totalDinero = totalDinero - product.getPrecio();

                    break;
                }
            }



            Console.WriteLine("ENTREGANDO PRODUCTO ...  \n");



            while (totalDinero > 0)
            {

                if (totalDinero >= 500)
                {
                    totalDinero = totalDinero - 500;
                    countMonedaQuinientos++;
                }
                else if (totalDinero >= 200)
                {
                    totalDinero = totalDinero - 200;
                    countMonedaDocientos++;
                }
                else if (totalDinero >= 100)
                {
                    totalDinero = totalDinero - 100;
                    countMonedaCien++;
                }

            }


            Console.WriteLine("total en moneda de 500 " + countMonedaQuinientos);
            Console.WriteLine("total en moneda de 200 " + countMonedaDocientos);
            Console.WriteLine("total en moneda de 100 " + countMonedaCien);







            return ((500 * countMonedaQuinientos) +(200 *countMonedaDocientos) + (100 * countMonedaCien) );
        }
    }
}
