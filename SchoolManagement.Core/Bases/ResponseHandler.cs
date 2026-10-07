using System.Net;

namespace SchoolManagement.Core.Bases;

public class ResponseHandler
{
    public ResponseHandler()
    {
    }

    public Response<T> Deleted<T>(string? message = null)
    {
        return new Response<T>()
        {
            StatusCode = HttpStatusCode.OK,
            Succeeded = true,
            Message = message ?? "Deleted Successfully"
        };
    }

    public Response<T> Success<T>(T entity, object? Meta = null)
    {
        return new Response<T>()
        {
            Data = entity,
            StatusCode = HttpStatusCode.OK,
            Succeeded = true,
            Message = "Added Successfully",
            Meta = Meta
        };
    }

    public Response<T> Unauthorized<T>()
    {
        return new Response<T>()
        {
            StatusCode = HttpStatusCode.Unauthorized,
            Succeeded = true,
            Message = "UnAuthorized"
        };
    }

    public Response<T> BadRequest<T>(string? Message = null)
    {
        return new Response<T>()
        {
            StatusCode = HttpStatusCode.BadRequest,
            Succeeded = false,
            Message = Message ?? "Bad Request"
        };
    }

    public Response<T> NotFound<T>(string? message = null)
    {
        return new Response<T>()
        {
            StatusCode = HttpStatusCode.NotFound,
            Succeeded = false,
            Message = message ?? "Not Found"
        };
    }

    public Response<T> Created<T>(T entity, object? Meta = null)
    {
        return new Response<T>()
        {
            Data = entity,
            StatusCode = HttpStatusCode.Created,
            Succeeded = true,
            Message = "Created Successfully",
            Meta = Meta
        };
    }
}
