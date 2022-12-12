namespace Stefanini_CRUD.Domain.Aggregate
{
    public class InvalidAgeExceptions : ArgumentException
    {
        public InvalidAgeExceptions(): base("Person can not be so old.")
        {
        }
    }
}
