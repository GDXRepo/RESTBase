using System.Web.Http;
using RESTBase.Data.Models;
using RESTBase.Domain;

namespace RESTBase.Web
{
	[RoutePrefix("utils")]
	public class UtilsController : ApiController
	{
		IUtilsService _service;

		public UtilsController(IUtilsService service)
		{
			_service = service;
		}

		[HttpGet]
		[Route("translate")]
		public IResponse Translate([FromUri()] TranslateRequest req)
		{
			if (req == null)
			{
				return new ErrorResponse();
			}
			Translate res = _service.Translate(req.Tag);

			if (res == null)
			{
				return new ErrorResponse();
			}
			return new TranslateResponse
			{
				Tag = req.Tag,
				Translation = res.value
			};
		}
	}
}
