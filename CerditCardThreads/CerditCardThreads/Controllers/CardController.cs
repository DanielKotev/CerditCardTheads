using CerditCardThreads.Models;
using CerditCardThreads.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CerditCardThreads.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CardController : ControllerBase
	{
		private readonly CardService cardService;
		public CardController(CardService cardService)
		{
			this.cardService = cardService;
		}

		[HttpPost("payment")]
		public ActionResult<CardResponse> MakePayment([FromBody] CardRequest request)
		{
			return Ok(cardService.MakePayment(request.Amount));
		}

		[HttpPost("reset")]
		public ActionResult<double> Reset()
		{
			return Ok(cardService.Reset());
		}
	}
}
