using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NathannJShop.Contracts.V1
{
    public class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;


        public static class Productos
        {
            public const string GetAll = Base + "/productos";
            public const string Create = Base + "/productos";
            public const string Get = Base + "/productos/{productoId}";
            public const string Update = Base + "/productos/{productoId}";
            public const string Delete = Base + "/productos/{productoId}";
        }

        public class Identity
        {
            public const string Register = Base + "/identity/register";
            public const string Login = Base + "/identity/login";
        }




    }
}
