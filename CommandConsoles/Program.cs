using ConnectionLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;

namespace CommandConsole
{
    class ConnectionToDB : Connection
    {

    }
    public class Article
    {
        public String planetaDestino;
        public String codigo;
        public String codificacion;
        public bool esDevolucion;
        public int cantidad;
        public String fechaEntrega;
        public Article(String planetaDestinoInput, String codigoInput, String codificacionInput, bool esDevolucionInput, int cantidadInput, String fechaEntregaInput)
        {
            planetaDestino = planetaDestinoInput;
            codigo = codigoInput;
            codificacion = codificacionInput;
            esDevolucion = esDevolucionInput;
            cantidad = cantidadInput;
            fechaEntrega = fechaEntregaInput;
        }
    }
    class Program
    {
        static DataSet dts;
        const string path = "../execute/FitxerDescarregat.edi";
        private static List<string> ProcessLine(string linia)
        {
            List<string> camps = new List<string>();
            if (linia != null)
            {
                if (linia.Substring(linia.Length - 1) == "|")
                {
                    linia = linia.Substring(0, linia.Length - 1);
                }
                string[] campsArray = linia.Split('|');

                camps = campsArray.ToList();
            }
            else
            {
                camps.Clear();
                camps.Add("ERROR");
            }

            return camps;
        }
        private static string FormatDateOrder(string fecha)
        {
        
            fecha = fecha.Substring(0, 4) + "-" + fecha.Substring(4, 2) + "-" + fecha.Substring(6, 2) + " 00:00:00";
            return fecha;
        }
        private static dynamic InsertaraBBDD(Dictionary<string, dynamic> mapaPedido)
        {
            ConnectionToDB conn = new ConnectionToDB();
            DataSet dts;
            string idReferencia, idPlanet, idFactory, idPriority;
            string queryArticle, queryOrder;
            string esUrgente, idOrder, idOperationalArea, idAgency;

            if (mapaPedido["esUrgente"])
            {
                esUrgente = "22E";
            }
            else
            {
                esUrgente = "220";
            }
            conn.Conectar();
            queryOrder = "SELECT Factories.idFactory, Priority.idPriority , OperationalAreas.idOperationalArea, Agencies.idAgency "+
                         "FROM Factories, Priority, OperationalAreas, Agencies " +
                         "WHERE Factories.codeFactory = '" + mapaPedido["codigoFabrica"] + "' " +
                         "AND Priority.CodePriority = '" + esUrgente + "' " +
                         "AND UPPER(DescOperationalArea) = '" + mapaPedido["zonaOperativa"].ToUpper()+"' "+
                         "AND Agencies.CodeAgency = '" + mapaPedido["emisor"].ToString()+ "'";
            dts = conn.PortarPerConsulta(queryOrder);

            idFactory = dts.Tables[0].Rows[0]["idFactory"].ToString();
            idPriority = dts.Tables[0].Rows[0]["idPriority"].ToString();
            idOperationalArea = dts.Tables[0].Rows[0]["idOperationalArea"].ToString();
            idAgency = dts.Tables[0].Rows[0]["idAgency"].ToString();

            mapaPedido["fechaDocumento"] = FormatDateOrder(mapaPedido["fechaDocumento"]);
            queryOrder = "INSERT INTO Orders (codeOrder, dateOrder, IdPriority, IdFactory" + ")"+
                          " VALUES (" + mapaPedido["codigoPedido"] + " , CONVERT(smalldatetime, '" + mapaPedido["fechaDocumento"] + 
                          "',101) , " + idPriority+ " , " + idFactory + ")";
            conn.Executa(queryOrder);

            idOrder = "SELECT MAX(idOrder) idOrder FROM Orders";
            dts = conn.PortarPerConsulta(idOrder);

            idOrder = dts.Tables[0].Rows[0]["idOrder"].ToString();

            queryOrder = "INSERT INTO OrderInfo (idOrder, idAgency, idOperationalArea)" +
                          "VALUES ("+ idOrder + ", " + idAgency + "," + idOperationalArea + ")";

            conn.Executa(queryOrder);
            foreach (Article article in mapaPedido["listaArticulos"])
            {
                conn.Conectar();
                queryArticle = "Select[SecureCore].[dbo].[References].idReference, Planets.idPlanet "+
                                "FROM[SecureCore].[dbo].[References], Planets "+ 
                                "WHERE[SecureCore].[dbo].[References].codeReference = " + article.codigo +
                                " AND UPPER(Planets.CodePlanet) = '" + article.planetaDestino + "'";


                dts = conn.PortarPerConsulta(queryArticle);
                idReferencia = dts.Tables[0].Rows[0]["idReference"].ToString();
                idPlanet = dts.Tables[0].Rows[0]["idPlanet"].ToString();
                article.fechaEntrega = FormatDateOrder(article.fechaEntrega);

                queryArticle = "INSERT INTO OrdersDetail (idOrder,idPlanet,idReference,Quantity,DeliveryDate)" +
                                "VALUES( " + idOrder + " , " + idPlanet + ", " + idReferencia + " , " + article.cantidad +
                                ", CONVERT(smalldatetime, '2020-01-19 00:00:00', 101))";
                conn.Executa(queryArticle);
            }

            return true;
        }
        private static bool Process()
        {
            // QUERY
            string query;
            dts = new DataSet();
            Connection connexio = new ConnectionToDB();

            string linia, numOrd = "", fechaOrd = "", areaOperativa = "", emisor="", receptor="";
            string planetaDestino, tipoCodigo, fechaEntrega = "";
            int cantidad = 7777;
            bool esDevolucion = false, esUrgente = false;

            //INT32 demasiado pequeño para el numero de Order
            string codigo, titulo = "";
            //*******************
            bool correctOrder;
            StreamReader sr = new StreamReader(path);
            
            List<string> campsLinia;
            
            correctOrder = true;

            List<Article> listaArticulos = new List<Article>();

            Dictionary<string, dynamic> mapaPedido = new Dictionary<string, dynamic>();

            linia = sr.ReadLine();
            while (linia != null)
            {
                campsLinia = ProcessLine(linia);

                switch (campsLinia.First())
                {
                    case "ORD":
                        numOrd = campsLinia[1];
                        if (int.Parse(campsLinia[2]) == 220)
                        {
                            esUrgente = false;
                        }
                        else
                        {
                            esUrgente = true;
                        }
                        query = "SELECT idPriority FROM Priority Where CodePriority = '" + campsLinia[2] + "'";
                        connexio.Conectar();
                        dts = connexio.PortarPerConsulta(query);
                        foreach (DataRow item in dts.Tables[0].Rows)
                        {
                            linia = item[0].ToString();
                        }
                        Console.WriteLine("-------------------------------" + linia);
                        break;

                    case "DTM":
                        fechaOrd = campsLinia[1];

                        break;
                    case "NADMS":
                        if (campsLinia[1].ToUpper().Equals("OUTER"))
                        {
                            areaOperativa = "Outer Ring";
                        }else if (campsLinia[1].ToUpper().Equals("INNER"))
                        {
                            areaOperativa = "Inner Ring";
                        }
                        else
                        {
                            areaOperativa = "Uknown";
                        }
                        emisor = campsLinia[2];
                        
                        break;
                    case "NADMR":
                        receptor = campsLinia[1];
                        break;
                    case "LIN":
                        planetaDestino = campsLinia[1];
                        codigo = campsLinia[2];
                        tipoCodigo = campsLinia[3];

                        //if(tipoCodigo.ToUpper().Equals())


                        linia = sr.ReadLine();
                        campsLinia = ProcessLine(linia);

                        while (linia != null && !campsLinia.First().Equals("LIN"))
                        {
                            Console.WriteLine(linia);
                            switch (campsLinia.First())
                            {
                                case "QTYLIN":
                                    if (campsLinia[1].Equals("21"))
                                    {
                                        esDevolucion = false;
                                    }
                                    else
                                    {
                                        esDevolucion = true;
                                    }
                                    cantidad = Int32.Parse(campsLinia[2]);
                                    break;

                                case "DTMLIN":
                                    fechaEntrega = campsLinia[1];
                                    break;
                                default:

                                    break;
                            }
                            if (!campsLinia.First().Equals("DTMLIN"))
                            {
                                linia = sr.ReadLine();
                                campsLinia = ProcessLine(linia);
                            }
                            else
                            {
                                break;
                            }
    
                        }
                        Article producto = new Article(planetaDestinoInput: planetaDestino,
                                                        codigoInput: codigo, codificacionInput: tipoCodigo,
                                                        esDevolucionInput:esDevolucion,cantidadInput:cantidad,
                                                        fechaEntregaInput:fechaEntrega) ;
                        listaArticulos.Add(producto);

                        
                        break;
                    default:
                        correctOrder = false;
                        Console.WriteLine(linia);
                        titulo = linia;
                        break;
                }
                linia = sr.ReadLine();
            }
            sr.Close();

            mapaPedido["titulo"] = titulo;
            mapaPedido["codigoPedido"] = numOrd;
            mapaPedido["esUrgente"] = esUrgente;
            mapaPedido["fechaDocumento"] = fechaOrd;
            mapaPedido["zonaOperativa"] = areaOperativa;
            mapaPedido["emisor"] = emisor;
            mapaPedido["codigoFabrica"] = receptor;

            mapaPedido["listaArticulos"] = listaArticulos;

            correctOrder = InsertaraBBDD(mapaPedido);
            return correctOrder;
        }
        private static void ViewOrder()
        {
            StreamReader sr = new StreamReader(path);
            string linia;

            linia = sr.ReadLine();
            Console.WriteLine("\n               VIEW ORDER             ");
            Console.WriteLine("========================================");
            while (linia != null)
            {
                Console.WriteLine(linia);
                linia = sr.ReadLine();
            }
            Console.WriteLine("========================================\n");
        }
        private static void UploadFile()
        {

        }
        static void Main(string[] args)
        {

            string menuOption, msgProcess;
            bool correctInput, correctOrder;
            Console.ForegroundColor = ConsoleColor.Green;
            MostrarLogo();

            do
            {
                menuOption = MostrarMenu();
                correctInput = true;
                switch (menuOption.ToUpper())
                {

                    case "DOWNLOAD":
                        Download();
                        break;
                    case "PROCESS":
                        correctOrder = Process();
                        if (!correctOrder)
                        {
                            msgProcess = "Error processant el fitxer. Siusplau torna a intentar-ho més tard...\n";
                        }
                        else
                        {
                            msgProcess = "Fitxer processat amb èxit!";
                        }

                        Console.WriteLine(msgProcess); 

                        break;
                    case "VIEW":
                        ViewOrder();
                        break;
                    case "EXIT":
                        Console.WriteLine("Sortint del programa...");
                        correctInput = false;
                        break;
                    default:
                        Console.WriteLine("\nERROR: Opció incorrecte...");
                        break;
                }
            } while (correctInput);
        }

        private static FtpWebRequest Connect()
        {
            FtpWebRequest ftpRequest;
            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://10.0.1.220//home//g7//RAREDI_1.edi");

            string strUser = "g7";
            string strPassword = "12345aA";
            ftpRequest.Credentials = new NetworkCredential(strUser, strPassword);
            return ftpRequest;
        }

        private static void Download()
        {
            FtpWebRequest ftpRequest;
            ftpRequest = Connect();
            ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
            try
            {
                FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string contingut = reader.ReadToEnd();
                File.WriteAllText(path, contingut);

                if ((int)response.StatusCode == 226)
                {
                    Console.WriteLine($"Download Complete, status {response.StatusDescription}");
                }
                else
                {
                    Console.WriteLine($"ERROR: Download Incomplete, status {response.StatusDescription}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: Unable to connect to the server, {e}");


            }

        }

        private static void MostrarLogo()
        {
            Console.WriteLine("\n");
            Console.WriteLine(" ███████╗████████╗ █████╗ ██████╗     ██████╗ ██████╗  ██████╗ ");
            Console.WriteLine(" ██╔════╝╚══██╔══╝██╔══██╗██╔══██╗    ██╔══██╗██╔══██╗██╔═══██╗");
            Console.WriteLine(" ███████╗   ██║   ███████║██████╔╝    ██████╔╝██║  ██║██║   ██║");
            Console.WriteLine(" ╚════██║   ██║   ██╔══██║██╔══██╗    ██╔═══╝ ██║  ██║██║   ██║");
            Console.WriteLine(" ███████║   ██║   ██║  ██║██║  ██║    ██║     ██████╔╝╚██████╔╝");
            Console.WriteLine(" ╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝    ╚═╝     ╚═════╝  ╚═════╝ ");
            Console.WriteLine("");
        }
        private static string MostrarMenu()
        {
            Console.WriteLine("══════════════════════════════════════════════════════════════");
            Console.WriteLine("║    [DOWNLOAD] Descarrega fitxer del servidor               ║");
            Console.WriteLine("║    [PROCESS] Processar el fitxer EDI                       ║");
            Console.WriteLine("║    [VIEW] Veure el formulari de visualització del llistat  ║");
            Console.WriteLine("║    [EXIT] Sortir del programa                              ║");
            Console.WriteLine("══════════════════════════════════════════════════════════════\n");
            Console.Write("Input: ");
            return Console.ReadLine();
        }
    }
}