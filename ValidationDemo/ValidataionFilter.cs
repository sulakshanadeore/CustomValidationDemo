using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ValidationDemo
{
    public class ValidataionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
          //  throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // throw new NotImplementedException();
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(
                    new { 
                    Message="Validation failed",
                    Errors=context.ModelState.Where(x=>x.Value.Errors.Count>0).
                    ToDictionary(kvp=>kvp.Key,kvp=>kvp.Value.Errors.Select(e=>e.ErrorMessage).ToArray()) }
                    );
            }
        }
    }
}