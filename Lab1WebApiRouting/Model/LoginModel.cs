namespace Lab1WebApiRouting.Model
{
   public  class LoginModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public LoginModel()
        {
        }
    }
}