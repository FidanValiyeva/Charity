﻿namespace Charity.ViewModels.ContactMessage
{
    public class ContactMessageItemVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime CreatedTime { get; set; } 
    }
}
