using System;
using System.Collections.Generic;
using System.Text;

namespace NathannJShop.Core.Entities
{
    public class AuthenticationResult
    {
        public string Token { get; set; }
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
