using System;

namespace SpaceTraders.NET.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Picture { get; set; }
        public string Email { get; set; }
        public int Credits { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}