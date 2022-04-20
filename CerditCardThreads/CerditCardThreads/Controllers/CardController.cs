using CerditCardThreads.Services;
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

		[HttpPost("amount")]
		public ActionResult<List<string>> MakePayment([FromQuery] double amount)
		{
			return Ok(cardService.MakePayment(amount));
		}
	}
}
