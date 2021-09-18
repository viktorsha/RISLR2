using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication2._1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        string path = @"D:\Viktoria\University\4 cource\1 semester\РИС\ЛР 2\WebApplication2.1\WebApplication2.1\";

        [WebMethod]
        public string ReturnXml(string filename)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path + filename + ".xml"))
                {
                    return sr.ReadToEnd();
                }
            }
            catch
            {
                throw new FileNotFoundException("No such file found!");
            }
            
        }
    }
}
