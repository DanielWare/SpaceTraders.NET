using SpaceTraders.NET.Models;

namespace SpaceTraders.NET.Response
{
    public class GetYourUserResponse : BaseResponse
    {
        public YourUser User { get; set; }
    }
}