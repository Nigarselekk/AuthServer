using System;
namespace AuthServer.Core.DTOs
{
	public class TokenDto
	{

		public string AccessToken { get; set; }

		public DateTime AccessTokenExpression { get; set; }

		public string RefreshToken { get; set; }

		public DateTime RefreshTokenExpression { get; set; }







	}
}

