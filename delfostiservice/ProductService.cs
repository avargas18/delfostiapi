using delfostidata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delfostiservice
{
    public class ProductService
    {
        public string GetAllProduct(string param)
        {
            SqlServerConnection sql = new SqlServerConnection("connectiondelfosti");
            string result = sql.ExecuteCommandJson("sp_all_product", param);
            return result;
        }

        public string GetProduct(string param)
        {
            SqlServerConnection sql = new SqlServerConnection("connectiondelfosti");
            string result = sql.ExecuteCommandJson("sp_get_product", param);
            return result;
        }

        public string DeleteProduct(string param)
        {
            SqlServerConnection sql = new SqlServerConnection("connectiondelfosti");
            string result = sql.ExecuteCommandJson("sp_delete_product", param);
            return result;
        }

        public string ModifyProduct(string param)
        {
            SqlServerConnection sql = new SqlServerConnection("connectiondelfosti");
            string result = sql.ExecuteCommandJson("sp_modify_product", param);
            return result;
        }

        public string SearchProduct(string param)
        {
            SqlServerConnection sql = new SqlServerConnection("connectiondelfosti");
            string result = sql.ExecuteCommandJson("sp_search_product", param);
            return result;
        }
    }
}
