using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Web;
using System.Configuration;
using System.Net;
using System.IO;

using System.Xml;

namespace WS_WindowsFormsAgroInge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMetodoGET_Click(object sender, EventArgs e)
        {

            Dim url as String = "https://localhost:44386/WebService-Agroinge.asmx/Suma?numero=";

            Dim HttpRequest as new MSXML2.XMLHTTP30;

            //HttpRequest.open("GET", url & CStr(Trim(txtNumero.Text)), False);
            //HttpRequest.open("GET", url & ToString(Trim(txtNumero.Text)), False);
            HttpRequest.open("GET", url + (txtNumero.Text.ToString));
            HttpRequest.send();

            dim xml as MSXML2.DOMDocument;
            xml = HttpRequest.ResponseXML;

            try
            {
                MessageBox.Show("Resultado: " + xml.DocumentELement.text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema: " + ex.Message);
            }


        }
    }
}
