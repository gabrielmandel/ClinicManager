namespace Stefanini_CRUD.Application.Common
{
    public abstract class BaseResponse
    {
        public bool Success { get; set; } = true;

        public object? Error { get; set; } = null;
    }
}
