using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using ConnectionLibrary;
using System.Data;

namespace CommandConsole
{
    class ConnectionToDB : Connection
    {

    }
    class Program
    {

        static DataSet dts;
        const string path = "../../FitxerDescarregat.edi";
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
        private static bool Process()
        {
            // QUERY
            int idUrgencia;
            string query;
            dts = new DataSet();
            Connection connexio = new ConnectionToDB();
            connexio.BeginRead();

            string linia, numOrd, fechaOrd, areaOperativa, emisor, receptor;
            string planetaDestino, tipoCodigo, fechaEntrega;
            int urgencia, calificador, cantidad;

            //INT32 demasiado pequeño para el numero de Order
            string codigo;
            //*******************
            bool correctOrder;
            StreamReader sr = new StreamReader(path);
            linia = sr.ReadLine();
            List<string> campsLinia;

            correctOrder = true;
            while (linia != null)
            {
                campsLinia = ProcessLine(linia);

                switch (campsLinia.First())
                {
                    case "ORD":

                        numOrd = campsLinia[1];

                        urgencia = int.Parse(campsLinia[2]);

                        query = "SELECT idPriority FROM Priority Where CodePriority = " + urgencia.ToString();
                        connexio.
                        dts = connexio.PortarPerConsulta(query);
                        foreach (DataRow item in dts.Tables[0].Rows)
                        {
                            idUrgencia = (int)item[0];
                        }
                        Console.WriteLine("-------------------------------" + urgencia);
                        break;
                    case "DTM":
                        fechaOrd = campsLinia[1];

                        break;
                    case "NADMS":
                        areaOperativa = campsLinia[1];
                        emisor = campsLinia[2];
                        break;
                    case "NADMR":
                        receptor = campsLinia[1];
                        break;
                    case "LIN":
                        planetaDestino = campsLinia[1];
                        codigo = campsLinia[2];
                        tipoCodigo = campsLinia[3];

                        linia = sr.ReadLine();
                        campsLinia = ProcessLine(linia);
                        while (linia != null && !campsLinia.First().Equals("LIN"))
                        {
                            Console.WriteLine(linia);
                            switch (campsLinia.First())
                            {
                                case "QTYLIN":
                                    calificador = Int32.Parse(campsLinia[1]);
                                    cantidad = Int32.Parse(campsLinia[2]);
                                    break;

                                case "DTMLIN":
                                    fechaEntrega = campsLinia[1];
                                    break;
                                default:

                                    break;
                            }
                            linia = sr.ReadLine();
                            campsLinia = ProcessLine(linia);
                        }
                        break;
                    default:
                        correctOrder = false;
                        Console.WriteLine(linia);
                        break;
                }
                linia = sr.ReadLine();
            }
            sr.Close();
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
            string menuOption;
            bool correctInput, correctOrder;
            Console.ForegroundColor = ConsoleColor.Green;
            MostrarLogo();

            do
            {
                menuOption = MostrarMenu();
                correctInput = true;
                switch (menuOption.ToUpper())
                {
                    case "UPLOAD":
                        UploadFile();
                        Console.WriteLine("Opcional, no esta fet");
                        break;
                    case "DOWNLOAD":
                        Download();
                        break;
                    case "PROCESS":
                        correctOrder = Process();
                        if (!correctOrder)
                        {
                            Console.WriteLine("Error processant el fitxer. Siusplau torna a intentar-ho més tard...\n");
                        }
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

            //   ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;

            //byte[] content = File.ReadAllBytes("hola.edi");
            //ftpRequest.ContentLength = content.Length;
            //Stream stream = ftpRequest.GetRequestStream();
            //stream.Write(content, 0, content.Length);
            //stream.Close();

            //reader.Close();
            //response.Close();
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
            Console.WriteLine("║    [UPLOAD] Puja fitxer al servidor                        ║");
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
