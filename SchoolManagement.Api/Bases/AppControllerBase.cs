using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Core.Bases;

namespace SchoolManagement.Api.Bases;

[ApiController]
public class AppControllerBase : ControllerBase
{
    public ObjectResult NewResult<T>(Response<T> response)
    {
        return new ObjectResult(response)
        {
            StatusCode = (int)response.StatusCode
        };
    }
}
