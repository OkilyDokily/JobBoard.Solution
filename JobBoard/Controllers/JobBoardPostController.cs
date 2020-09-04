using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

public class JobBoardPostController : Controller
{
  [HttpGet("/JobBoardPosts")]
  public ActionResult Index()
  {
    return View(JobBoardPost.jobs);
  }

  [HttpGet("JobBoardPost/new")]
  public ActionResult Form()
  {
    return View();
  }

  [HttpPost("JobBoardPost/new")]
  public ActionResult Create(string title, string description, string name, string email, string phone)
  {
    JobBoardPost job = new JobBoardPost(title, description, name, email, phone);
    JobBoardPost.AddJob(job);
    return RedirectToAction("Index");
  }
}