using System.Collections.Generic;

namespace JobBoard.Models
{
    public class JobBoardPost
    {
       public static List<JobBoardPost> jobs = new List<JobBoardPost>();

       public static void AddJob(JobBoardPost job)
       {
           jobs.Add(job);
       }

       public JobBoardPost(string title, string description, string name, string email, string phone)
       {
           Title = title;
           Description = description;
           ContactInfo = new Contact(name, email, phone);
       }
       public string Title {get; set;}
       public string Description{get;set;}
       public Contact ContactInfo{get;set;}

       

    }
}