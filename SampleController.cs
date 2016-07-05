 public class SampleController : Controller
    {
        [MyCustomAuthorize]
        [HttpPost]
        public JsonResult Req1()
        {
            return Json(new { success = true });
        }
    }