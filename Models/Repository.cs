// data storage 

using FirstProject.Models;

namespace FirstProject.Models
{
    public static class Repository
    {
        private static List<GuestResponse> Responses = new();

        public static IEnumerable<GuestResponse> ResponsesList => Responses;

        public static void AddResponse(GuestResponse response)
        {
            Console.WriteLine(response);
            Responses.Add(response);

        }


    }
}