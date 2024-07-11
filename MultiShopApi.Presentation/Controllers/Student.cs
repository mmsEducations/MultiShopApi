namespace MultiShopApi.Presentation.Controllers
{
    public class Student
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
