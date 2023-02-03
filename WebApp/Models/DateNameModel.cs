namespace WebApp.Models
{
    public class DateNameModel
    {
        public string Name { get; }
        public DateTime CurrentDate { get; set; }

        public DateNameModel(string name)
        {
            Name = name;
            CurrentDate = DateTime.Now;
        }
    }
}
