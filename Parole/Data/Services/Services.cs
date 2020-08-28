namespace Parole.Data.Services
{
    public class Services
    {
        private readonly ApplicationDbContext _db;
        public Services(ApplicationDbContext db)
        {
            _db = db;
        }

    }
}