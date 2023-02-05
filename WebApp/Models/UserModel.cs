namespace WebApp.Models
{
    public class UserModel
    {
        public string Name { get; }
        public int Age { get; }
        public DateTime RegistrarionDateTime { get; }

        public UserModel(string name, int age)
        {
            Name = name;
            Age = age;
            RegistrarionDateTime = DateTime.Now;
        }
    }
}
