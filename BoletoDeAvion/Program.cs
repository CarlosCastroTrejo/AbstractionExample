using System;

namespace BoletoDeAvion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Boletos uno = new Boletos();
            Console.WriteLine(uno.codigoBarras(123, "Carlos", "AEROMEXICO"));
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

        int iCodigo;
        //Código de Barras: Código único a escanear que representa los datos del boleto

        string sAvion;
        //Tipo de Avión: Avión que se va a abordar

        string sServicios;
        //Servicios Extras: Servicios que se van a ofrecer en el vuelo (desayuno, comida, cena)

        string sClase;
        //Clase: Clase de servicio del vuelo


        //Constructor
        public Boletos()
        {
            
        }

        public bool llenarDatos(string sNOmbre,int iVuelo,string sAerolinea, string sOrigen,string sDestino,int iCodigo, string sAvion, string sServicios,string sClase)
        {
            this.sNOmbre = sNOmbre;
            this.iVuelo = iVuelo;
            this.sAerolinea = sAerolinea;
            this.sOrigen = sOrigen;
            this.sDestino = sDestino;
            this.iCodigo = iCodigo;
            this.sAvion = sAvion;
            this.sServicios = sServicios;
            this.sClase = sClase;
            return true;
        }
        /*
        Llenar Datos: Cargar los datos a la base de datos de la aerolínea
        Input: Persona escriba los datos en la correspondiente casilla
        Output: Mensaje de carga exitosa y de envío de datos a la base de datos
        */

        public string codigoBarras(int iVuelo,string sNombre,string sAerolinea)
        {
            Random random = new Random();
            int aleatorio=random.Next(100000, 90000000);
            return aleatorio+iVuelo+sNombre;
        }

    }
}
/*

Generar Código de Barras: 
        Input: numero de vuelo, nombre de cliente y aerolínea
        Output: Código unico para abordar
Conectarse a Base de Datos de Aerolínea:  Checar y verificar datos del vuelo

        Input: Número de vuelo
        Output: Horarios del vuelo
Imprimirse:  Imprimir el check-in
        Input: Código unico para abordar

        Output: Mandar formulario a la impresora
Comprobación de datos: Comprobar que el dato vaya acorde al tipo de dato del formulario

        Input: Dato del formulario
        Output: Mensaje de datos validos
*/