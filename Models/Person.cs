namespace Test.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        
    
    }
}