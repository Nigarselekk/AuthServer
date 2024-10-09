using System;
using AuthServer.Core.DTOs;
using SharedLibrary.Dtos;

namespace AuthServer.Core.Services
{
	public interface IAuthanticationService
	{

		Task<Response<TokenDto>> CreateTokenAsync(LoginDto LoginDto);

		Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken);

		Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken);

		Task<Response<ClientTokenDto>> CreateTokenByClient(ClientLoginDto clientLoginDto);


	}
}

