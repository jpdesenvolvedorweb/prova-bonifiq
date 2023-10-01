﻿using Microsoft.AspNetCore.Mvc;
using ProvaPub.Services.Abstract;

namespace ProvaPub.Controllers
{
	/// <summary>
	/// Ao rodar o código abaixo o serviço deveria sempre retornar um número diferente, mas ele fica retornando sempre o mesmo número.
	/// Faça as alterações para que o retorno seja sempre diferente
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	public class Parte1Controller :  ControllerBase
	{
		private readonly IRandomService _randomService;

        #region CTOR
        public Parte1Controller(IRandomService randomService)
		{
			_randomService = randomService;
		}
        #endregion

        #region [Get]
        [HttpGet]
		public int Index()
		{
			return _randomService.GetRandom();
		}
        #endregion
    }
}
