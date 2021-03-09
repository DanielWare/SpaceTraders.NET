using SpaceTraders.NET.Models;

namespace SpaceTraders.NET.Response
{
    public class CreateUserResponse : BaseResponse
    {
        public string Token { get; set; }
        public User User { get; set; }
    }
}