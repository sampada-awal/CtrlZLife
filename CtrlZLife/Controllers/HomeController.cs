using System.Diagnostics;
using CtrlZLife.Models;
using Microsoft.AspNetCore.Mvc;
using CtrlZLife.Models;

namespace CtrlZLife.Controllers
{
    public class HomeController : Controller
    {
        private static List<Commit> commits = new List<Commit>();
        public IActionResult Index(int? repoId)
        {
            ViewBag.Repos = repos;
            var filteredCommits = commits;
            if (repoId != null)
            {
                filteredCommits = commits.Where(c => c.RepoId == repoId).ToList();
            }
            return View(filteredCommits);
        }

        private static List<Repo> repos = new List<Repo>
        {
            new Repo { Id = 1, Name = "Health", Description = "Physical & mental health", IsActive = true },
            new Repo { Id = 2, Name = "Career", Description = "Study & work", IsActive = false },
            new Repo { Id = 3, Name = "Mind", Description = "Focus & mindset", IsActive = true }
        };

        

        [HttpPost]
        public IActionResult AddCommit(int repoId, string message, string reason, string impact, string tag)
        {
            var commit = new Commit
            {
                Id = commits.Count + 1,
                Message = message,
                Reason = reason,
                Impact = impact,
                Tag = tag,
                Date = DateTime.Now
            };
            commits.Add(commit);
            return RedirectToAction("Index");
        }
         
    }
}
