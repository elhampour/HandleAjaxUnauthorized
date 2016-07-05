public class MyCustomAuthorize : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //if ajax request set status code and end Response
            if (filterContext.RequestContext.HttpContext.Request.IsAjaxRequest())
            {
                JsonResult unauthorizedResult = new JsonResult
                {
                    Data = new { unAuthorized = true },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
                filterContext.Result = unauthorizedResult;
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }