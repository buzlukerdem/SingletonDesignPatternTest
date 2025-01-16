namespace SingletonAspNetCoreExample.Services
{
    public class DatabaseServices
    {
        private DatabaseServices()
        {
            Console.WriteLine($"{nameof(DatabaseServices)} nesnesi üretildi.");
        }

        static DatabaseServices _databaseServices;

        public static DatabaseServices GetDatabase
        {
            get
            {
                if( _databaseServices == null )
                    _databaseServices = new DatabaseServices();
                return _databaseServices;
            }
        }
        public int Count { get; set; }

        // Connection Operations
        public bool Connection()
        {
            Console.WriteLine("Connected.");
            Count++;
            return true;
        }
        public bool DisConnection()
        {
            Console.WriteLine("Disconnected.");
            Count++;
            return true;
        }
    }
}
