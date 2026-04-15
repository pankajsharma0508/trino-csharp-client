using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Trino.Client.Auth
{
    using System.Net.Http;

    public class TrinoKerberosAuth : ITrinoAuth
    {
        public void AuthorizeAndValidate()
        {
            // No-op for Kerberos (Windows handles ticket acquisition)
        }

        public void ConfigureHandler(HttpClientHandler handler)
        {
            handler.UseDefaultCredentials = true;
            handler.PreAuthenticate = false;
            handler.AllowAutoRedirect = false;
        }

        public void AddCredentialToRequest(HttpRequestMessage httpRequestMessage)
        {
        }
    }
}
