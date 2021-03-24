using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;

namespace WebserviceTreino
{
    /// <summary>
    /// Descrição resumida de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        DataTable dataCountries = new DataTable();

        [WebMethod]
        public string HelloWorld()
        {
            return "Olá, Mundo";
        }

        [WebMethod]
        public int Sum(int a, int b)
        {
            return a+b;
        }

        [WebMethod]
        public string Countries()
        {
            //Minhas colunas
            dataCountries.Columns.Add("Country Name");
            dataCountries.Columns.Add("Continent");
            //Adicionando minhas linhas (Country name, Continent)
            dataCountries.Rows.Add("Brazil", "America");
            dataCountries.Rows.Add("India", "Asia");
            dataCountries.Rows.Add("USA", "America");
            dataCountries.Rows.Add("Pakistan", "Asia");
            dataCountries.Rows.Add("Germany", "Europe");

            return JsonConvert.SerializeObject(dataCountries);
        }
    }
}
