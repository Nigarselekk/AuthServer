using System;
namespace AuthServer.Core.DTOs
{
	public class ClientTokenDto
	{

        public string AccessToken { get; set; }

        public DateTime AccessTokenExpression { get; set; }

    }
}

