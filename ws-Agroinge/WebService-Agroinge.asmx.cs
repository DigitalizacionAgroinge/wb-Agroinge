using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


using System.Threading.Tasks; // Librería para trabajar de forma asincrona
using System.Configuration;
using System.Net;
using System.IO;



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

        /* [WebMethod]
         public string WebServiceAgroInge()
         {
             return "Web Service de AgroInge";
         }*/

        [WebMethod]
        public int Suma(int Numero)
        {
            return Numero + 25;
        }
        
    }
}
