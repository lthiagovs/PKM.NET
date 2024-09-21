using Newtonsoft.Json;

namespace PKM.NET.Infrastructure.Map.Services
{
    public static class MapStorage
    {

        public static bool SaveMap(int[][] Data, string path)
        {


            string json = JsonConvert.SerializeObject(Data);


        }

    }

}
