namespace WaniKaniApi.Exceptions
{
    public enum WaniKaniErrorType
    {
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        UnprocessableEntity = 422,
        TooManyRequests = 429,
        InternalServerError = 500,
        ServiceUnavailable = 503,
        HttpRequest = 1,
        Unknown = 0
    }
}
