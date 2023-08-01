namespace crudApi
{
    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public DateOnly Date { get; set; }
        public Gender Gender { get; set; }



    }
}
