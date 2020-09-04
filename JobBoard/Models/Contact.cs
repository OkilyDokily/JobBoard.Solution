namespace JobBoard.Models
{
    public class Contact
    {
        public Contact(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            PhoneNumber = phone;
        }
        public string Name{get;set;}
        public string Email{get;set;}
        public string PhoneNumber{get;set;}
    }
}