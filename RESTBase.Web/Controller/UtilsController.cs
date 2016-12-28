using System.Web.Http;
using RESTBase.Data.Models;
using RESTBase.Domain;

namespace RESTBase.Web
{
	[RoutePrefix("utils")]
	public class UtilsController : ApiController
	{
		readonly IUtilsService _service;

		public UtilsController(IUtilsService service)
		{
			_service = service;
		}

		[HttpGet]
		[Route("translate")]
		public IResponse Translate([FromUri()] TranslateRequest req)
		{
			if (!BaseRequest.Validate(req))
			{
				return BaseRequest.CreateErrorResponse(ErrorCode.BadRequest);
			}
			Translate t = _service.Translate(req.Tag);
			var data = new TranslateResponseData(t);

			return BaseRequest.CreateSuccessResponse(data);
		}
	}
}
