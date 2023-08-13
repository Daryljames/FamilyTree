using FamilyTree.Models;
using Microsoft.AspNetCore.Mvc;

namespace FamilyTree.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SocialMediaController : ControllerBase
{
	private readonly DataContext _context;

	public SocialMediaController(DataContext context)
	{
		_context = context;
	}

	[HttpGet]
	public async Task<ActionResult<List<SocialMedia>>> Get(int userId)
	{
		var socialMedia = await _context.SocialMedias
			.Where(s => s.UserId == userId)
			.ToListAsync();

		return socialMedia;
	}
}