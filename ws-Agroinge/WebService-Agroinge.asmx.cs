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
using Newtonsoft.Json;


using System.Reflection;


using System.Web.Script.Serialization;
using System.Web.Script.Services;


//namespace ws_Agroinge
//{
//    /// <summary>
//    /// Descripción breve de WebService_Agroinge
//    /// </summary>
//    [WebService(Namespace = "http://tempuri.org/")]
//    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
//    [System.ComponentModel.ToolboxItem(false)]


//    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
//    // [System.Web.Script.Services.ScriptService]
//    public class WebService_Agroinge : System.Web.Services.WebService
//    {

//        string Archivojson = File.ReadAllText(@"D:\00 Elena Piles\30 Digitalización\30 Visual Studio\30 WS AgroInge\ws-Agroinge\json.json");


//        [WebMethod]
//         public string ArchivoJSON()
//         {

//            return Archivojson;
//         }


//    }


//}

//namespace ws_Agroinge
//{
//    /// <summary>
//    /// Summary description for WsCaller
//    /// </summary>
//    [WebService(Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
//    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
//    [System.ComponentModel.ToolboxItem(false)]

//    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
//    // [System.Web.Script.Services.ScriptService]
//    public class WebService_Agroinge : System.Web.Services.WebService
//    {

//        [WebMethod]
//        public string EjemploWebService()
//        {
//            return "Hello World";
//        }

//        [WebMethod]
//        public void ArchivoJSON()
//        {

//            string Archivojson = File.ReadAllText(@"D:\00 Elena Piles\30 Digitalización\30 Visual Studio\30 WS AgroInge\ws-Agroinge\json.json");

//            var client = new RestClient("https://localhost:44386/WebService-Agroinge.asmx/ArchivoJSON");
//            var request = new RestRequest(Archivojson, Method.Post);
//            request.Method = Method.Post;

//            request.AddHeader("cache-control", "no-cache");
//            request.AddHeader("Content-Type", "application/json");
//            request.AddHeader("Authorization", "Basic");
//            request.AddHeader("Access-Control-Allow-Origin", "*");
//            request.AddHeader("Content-Type", "text/xml");
//            request.AddHeader("dataType", "json");

//            //request.AddFile("json.json", File.ReadAllBytes(@"D:\00 Elena Piles\30 Digitalización\30 Visual Studio\30 WS AgroInge\ws-Agroinge\json.json"), "application /json");

//            var ResultJson = JsonConvert.DeserializeObject(Archivojson);
//            request.AddJsonBody(ResultJson);

//            request.AddJsonBody<string>(Archivojson, "application/json");
//            client.UseJson();
//            request.AddParameter("application/json; charset=utf-8", ResultJson, ParameterType.RequestBody);
//            var responsePost = client.ExecutePostAsync(request);

//            var Ejecutar = client.ExecutePostAsync(request);



//            // IRestResponse response = client.Execute(request);
//            /*StreamReader ReaderJson = new StreamReader(@"D:\00 Elena Piles\30 Digitalización\30 Visual Studio\30 WS AgroInge\ws - Agroinge\json.json");
//            string JsonString = ReaderJson.ReadToEnd();
//            Datamodel m = JsonConvert.DeserializeObject<datamodel>(jsonString);*/

//            //     XmlDocument DocumentoXML = new XmlDocument();
//            //  DocumentoXML.LoadXml(response.Content);

//            //DocumentoXML = (XmlDocument)(Newtonsoft.Json.JsonConvert.DeserializeXmlNode(Archivojson));

//            //return request;
//        }

//    }
//}

//namespace ws_Agroinge
//{
//    /// <summary>
//    /// Summary description for WsCaller
//    /// </summary>
//    [WebService(Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
//    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
//    [System.ComponentModel.ToolboxItem(false)]

//    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
//    // [System.Web.Script.Services.ScriptService]
//    public class WebService_Agroinge : System.Web.Services.WebService
//    {
//        public WebService_Agroinge()
//        {
//            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
//        }

//        [WebMethod]
//        public string EjemploWebService()
//        {
//            return "Hello World";
//        }

//        [WebMethod]
//        public Object ArchivoJSON()
//        {

//            string Archivojson = File.ReadAllText(@"D:\00 Elena Piles\30 Digitalización\30 Visual Studio\30 WS AgroInge\ws-Agroinge\json.json");
//            // https://localhost:44386/WebService-Agroinge.asmx/ArchivoJSON

//            var client = new RestClient("https://localhost:44386/WebService-Agroinge.asmx/ArchivoJSON");
//            var request = new RestRequest("/WebService-Agroinge.asmx/ArchivoJSON", Method.POST);
//            request.Method = Method.POST;

//            request.AddHeader("cache-control", "no-cache");
//            request.AddHeader("Content-Type", "application/json"); //"application/json; charset=utf-8";
//            request.AddHeader("Authorization", "Basic");
//            request.AddHeader("Access-Control-Allow-Origin", "*");
//            request.AddHeader("Accept", "text/json");
//            //           request.AddHeader("Content-Type", "application/json; charset=utf-8");

//            request.RequestFormat = RestSharp.DataFormat.Json;

//            var ResultJson = JsonConvert.DeserializeObject(Archivojson);

//            request.AddParameter("application/json", Archivojson, ParameterType.RequestBody);

//            request.AddJsonBody(Archivojson);

//            IRestResponse response = client.Execute(request, Method.POST);


//            var datos = JsonConvert.DeserializeObject(Archivojson);


//            // XmlDocument DocumentoXML = new XmlDocument();
//            // DocumentoXML.LoadXml(response.Content);
//            // object RespuestaJson = request.BodyParameter.Value;
//            object RespuestaJson = response.Request.BodyParameter.Value;

//            //return response.Content;
//            return RespuestaJson;

//        }

//    }
//}

namespace ws_Agroinge
{
    ///<summary>  
    /// Summary description for TestService  
    ///</summary> 
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]


    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService_Agroinge : System.Web.Services.WebService
    {
        public WebService_Agroinge()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)] // Se define el formato del archivo que debe enviar como respuesta a la petición
        public void ArchivoJSON()
        {

            // Abrimos el archivo JSON que tiene los datos de los equipos
            string Archivojson = File.ReadAllText(@"D:\00 Elena Piles\30 Digitalización\30 Visual Studio\30 WS AgroInge\ws-Agroinge\json.json");
            // Deserializamos la cadena que contiene el JSON. Con este método se obtiene un objeto de tipo JSON a partir de una cadena string.
            object ResultJson = JsonConvert.DeserializeObject(Archivojson);

            // Añadimos cabeceras a la respuesta del webService para indicar:
            // "Content-Type", "application/json" -> la api que obtenga la respuesta espere que sea un JSON
            // "Access-Control-Allow-Origin", "*" -> Para las peticiones sin credenciales, el servidor puede especificar el caracter "*" como un comodín, permitiendo a cualquier origen acceder al recurso. 
            Context.Response.AddHeader("Content-Type", "application/json");
            Context.Response.AddHeader("Access-Control-Allow-Origin", "*");

            // Enviamos
            Context.Response.Write(ResultJson);
            
        }

    }
}





