using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTQuickTrippin
{
    class StoreRepository
    {

        static List<Store> _stores = new List<Store>();

        public List<Store> GetStores()

    {

        return _stores;
    }

    public static void AddStoreList(Store newStore)
    {
            _stores.Add(newStore); 
    }

}
}
