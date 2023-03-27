namespace Infrastructure
{
    public interface IConfiguration
    {
        object GetConnectionString(string v);
    }
}