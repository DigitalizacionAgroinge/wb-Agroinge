using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


using System.Threading.Tasks; // Librería para trabajar de forma asincrona
using System.Configuration;
using System.Net;
using System.Text;
using System.IO;

using System.Xml;

using System.Collections.Specialized;

using RestSharp;

/*namespace ws_Agroinge
{
    /// <summary>
    /// Descripción breve de WebService_Agroinge
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]


    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService_Agroinge : System.Web.Services.WebService
    {

        string Archivojson = File.ReadAllText(@"D:\00 Elena Piles\30 Digitalización\30 Visual Studio\30 WS AgroInge\ws-Agroinge\json.json");

        [WebMethod]
         public string ArchivoJSON()
         {
            
            return Archivojson;
         }
       

    }


}*/

namespace ws_Agroinge
{
    /// <summary>
    /// Summary description for WsCaller
    /// </summary>
    [WebService(Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService_Agroinge : System.Web.Services.WebService
    {

        [WebMethod]
        public string EjemploWebService()
        {
            return "Hello World";
        }

        [WebMethod]
        public string ArchivoJSON()
        {

            string Archivojson = File.ReadAllText(@"D:\00 Elena Piles\30 Digitalización\30 Visual Studio\30 WS AgroInge\ws-Agroinge\json.json");
            var client = new RestClient("https://localhost:44386/WebService-Agroinge.asmx/ArchivoJSON");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Access-Control-Allow-Origin");
            request.AddHeader("Content-Type", "text/xml");
  
            IRestResponse response = client.Execute(request);

            return Archivojson;
        }

    }
}
