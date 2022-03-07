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

using System.Collections.Specialized;



namespace ws_Agroinge
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
        public string WebServiceAgroInge()
        {
           // return "Prueba";
           return Archivojson;
        }
       

    }


}
