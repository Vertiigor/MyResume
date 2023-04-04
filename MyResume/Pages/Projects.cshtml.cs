using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyResume.Models;

namespace MyResume.Pages
{
	public class ProjectsModel : PageModel
	{
		public string GithubUsername { get; set; }

		public List<Project>? Projects { get; set; }

		public void OnGet()
		{
			GithubUsername = "@Vertiigor";

			Projects = new List<Project> {
				new Project()
				{
					Title = "LiliumEngine",
					Description = "LiliumEngine is a small and simple game engine for creating visual novel games based on .Net programming languages (F#, C#, Visual Basic)",
					Year = 2023,
					Technologies = new List<string> {"SFML.Net", ".Net Core"}
				},
				new Project()
				{
					Title = "BrainFuck",
					Description = "A simple Brainfuck interpreter created in C# on the .Net Core platform.",
					Year = 2022,
					Technologies = new List<string> {".Net Core"}
				},
				new Project()
				{
					Title = "Pixelator",
					Description = "Still terrible implementation of image pixelization app.",
					Year = 2022,
					Technologies = new List<string> {".Net Framework"}
				},
				new Project()
				{
					Title = "Conway Life",
					Description = "Worst implementation of Conway's Life in C#.",
					Year = 2022,
					Technologies = new List<string> {".Net Framework"}
				}
			};
		}
	}
}
