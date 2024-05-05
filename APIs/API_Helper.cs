using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UGG_Overlay.APIs
{
	class API_Helper
	{
        private static HttpClient apiClient = null;
        public static HttpClient ApiClient
        {
            get
            {
                if (apiClient == null) InitializeClient();
                return apiClient;
            }
            set
            {
                apiClient = value;
            }
        }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
        }
    }
}
