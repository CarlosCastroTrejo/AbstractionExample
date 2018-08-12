// Estructura de Datos 
// Jorge Romero Romanis A01423263
// Carlos Castro Trejo A01422062
using System;

namespace BoletoDeAvion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Boletos uno = new Boletos();
            Console.WriteLine(uno.llenarDatos("Carlos", 123, "AEORMEXICO", "MEX", "MIA", "B303", "Desayuno","EliteBlack"));
            Console.WriteLine(uno.codigoBarras());
            Console.WriteLine(uno.baseDeDatos(123));
            Console.WriteLine(uno.Imprimir(uno.codigoBarras()));

            Console.WriteLine("--------------------");

            Boletos dos = new Boletos();
            Console.WriteLine(dos.llenarDatos("Jorge#", 563, "INTERJET", "MEX", "LAX", "C506", "Cena", "Turista"));
            Console.WriteLine(dos.codigoBarras());
            Console.WriteLine(dos.baseDeDatos(563));
            Console.WriteLine(dos.Imprimir(dos.codigoBarras()));
            Console.ReadKey();
        }
    }
    public class Boletos
    {

        //Atributos
        /*
            Fecha/Hora Partida: Fecha y hora de salida del origen
            Fecha/Hora Llegada: Fecha y hora de llegada al destino
         */

        string sNOmbre;
        // Nombre del Cliente: Nombre de la persona que va a viajar con ese boleto

        int iVuelo;
        //Número de Vuelo: Número del vuelo que tiene el boleto

        string sAerolinea;
        //Aerolínea: Aerolínea a la que el boleto pertenece

        string sOrigen;
        //Origen: Nombre del aeropuerto de donde parte

        string sDestino;
        //Destino: Nombre del aeropuerto de donde va a llegar

        string sAvion;
        //Tipo de Avión: Avión que se va a abordar

        string sServicios;
        //Servicios Extras: Servicios que se van a ofrecer en el vuelo (desayuno, comida, cena)

        string sClase;
        //Clase: Clase de servicio del vuelo

        int aleatorio = 0;

        //Constructor
        public Boletos()
        {

        }
        //Metodos
        /*
            Llenar Datos: Cargar los datos a la base de datos de la aerolínea
            Input: Persona escriba los datos en la correspondiente casilla
            Output: Mensaje de carga exitosa y de envío de datos a la base de datos
         */
        public string llenarDatos(string sNOmbre, int iVuelo, string sAerolinea, string sOrigen, string sDestino, string sAvion, string sServicios, string sClase)
        {
            if(comprobacion(sNOmbre))
            {
                this.sNOmbre = sNOmbre;
            }else
            {
                return "Error en el Nombre";
            }
            this.iVuelo = iVuelo;
            if (comprobacion(sAerolinea)) 
            {
                this.sAerolinea = sAerolinea;            
            }
            else
            {
                return "Error en la Aerolinea";
            }

            if (comprobacion(sOrigen))
            {
                this.sOrigen = sOrigen;
            }
            else
            {
                return "Error en el Origen";
            }

            if (comprobacion(sDestino))
            {
                this.sDestino = sDestino;
            }
            else
            {
                return "Error en el Destino";
            }

            if (comprobacion(sAvion))
            {
                this.sAvion = sAvion;
            }
            else
            {
                return "Error en el Avion";
            }
            if (comprobacion(sServicios))
            {
                this.sServicios = sServicios;
            }
            else
            {
                return "Error en los Servicios";
            }

            if (comprobacion(sClase))
            {
                this.sClase = sClase;
            }
            else
            {
                return "Error en la Clase";
            }


            Random random = new Random();
            this.aleatorio = random.Next(100000, 90000000);

            return "Llenados de datos con exito";
        }

        /*
            Generar Código de Barras: 
            Input: numero de vuelo, nombre de cliente y aerolínea
            Output: Código unico para abordar
        */
        public string codigoBarras()
        {
           
            return this.aleatorio + this.iVuelo + this.sNOmbre + this.sAerolinea;
        }

        /*
            Conectarse a Base de Datos de Aerolínea:  Checar y verificar datos del vuelo
            Input: Número de vuelo
            Output: Horarios del vuelo
         */
        public string baseDeDatos(int iVuelo)
        {
            string[] horarios = new string[4] { "10:00PM", "2:50PM", "11:30AM", "6:59AM" };
            int[] vuelos = new int[4] { 123,563,189,4563 };

            for (int x = 0; x < vuelos.Length;x++)
            {
                if(iVuelo==vuelos[x])
                {
                    return "Tu vuelo sale a la hora: " + horarios[x];
                    break;
                }
            }
            return "Tu vuelo todavia no ha sido asignado";
        }

        /*
            Imprimirse:  Imprimir el check-in
            Input: Código unico para abordar
            Output: Mandar formulario a la impresora y aviso de exito
         */
        public string Imprimir(string codigoDeAbordar)
        {

            return "Se ha impreso el formulario del codigo: "+codigoDeAbordar;
        }

        /*
            Comprobación de datos: Comprobar que el dato vaya acorde al tipo de dato del formulario
            Input: Dato del formulario
            Output: Mensaje de datos validos
        */
        public bool comprobacion(string dato)
        {
            char[] arreglo = new char[14] { '@', '#', '$', '%', '^', '&', '*', '(', ')', '=', '+', '-', '_', '~' };
            for (int x = 0; x < arreglo.Length; x++)
            {
                if (dato.Contains(arreglo[x].ToString()))
                {
                    return false;
                    break;
                }
            }

            return true;
        }

    }

}