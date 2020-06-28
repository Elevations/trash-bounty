using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashBountyAPI
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
        public string UsersCollectionName { get; set; }
        public string OpenBountiesCollectionName { get; set; }
        public string ClosedBountiesCollectionName { get; set; }
    }

    public interface IDatabaseSettings
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
        string UsersCollectionName { get; set; }
        string OpenBountiesCollectionName { get; set; }
        string ClosedBountiesCollectionName { get; set; }
    }
}
