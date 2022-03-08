using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading.Tasks; // Librería para trabajar de forma asincrona
using System.Configuration;
using System.Text;
using System.IO;

using System.Collections.Specialized;

namespace ws_Agroinge
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //button clickedButton = (Button)sender;
                TextBoxError.Text = "En funcionamiento. ";
                btnGuardarCambios.Click += new EventHandler(this.btnGuardarCambios_Click);
                TextBoxError.Text = "Evento botón creado. ";
            }
            catch (Exception ex)
            {
                TextBoxError.Text = "Ha habido un error: " + ex.Message;   
            }
                        
        }

        void btnGuardarCambios_Click(Object sender, EventArgs e)
        {
            TextBoxError.Text = "Botón pulsado.";
            string Archivojson = File.ReadAllText(@"D:\00 Elena Piles\30 Digitalización\30 Visual Studio\30 WS AgroInge\ws-Agroinge\json.json");


            TextBoxError.Text = Archivojson;


        }

    }
}