using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Data;
namespace AspNetProject1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        [WebMethod]
        public static string GetAllAccounts()
        {
            var accounts = new Opperations();
            var data = accounts.GetAccounts();
            return accounts.JsonConverter(data) ;
            

        }
        [WebMethod]
        public static string GetAllCustomers()
        {
            var customers = new Opperations();
            var data = customers.GetCustomers();
            return customers.JsonConverter(data);


        }
        [WebMethod]
        public static string GetAllProducts()
        {
            var products = new Opperations();
            var data = products.GetProducts();
            return products.JsonConverter(data);

        } 
        [WebMethod]
        public static string AddCustomerWeb(string fname,string lname, string email)
        {
            var customer = new Opperations();
            customer.AddCustomer(fname,lname,email);
            var data = customer.GetCustomers();
            return customer.JsonConverter(data);

        }
   
        

    }
}