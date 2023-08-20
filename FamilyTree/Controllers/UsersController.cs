using FamilyTree.Commands.Builders;
using FamilyTree.Commands.Validators;
using FamilyTree.Interfaces;
using FamilyTree.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FamilyTree.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
	public readonly IUsersService _usersService;

	public UsersController(IUsersService usersService)
	{
		_usersService = usersService;
	}
	[HttpGet]
	public async Task<ActionResult<List<User>>> GetUsers()
	{
		var users = await _usersService.GetAll();
		if( users == null)
		{
			return NotFound();
		}
		else
		{
			return Ok(users);
		}
	}

	[HttpGet("id")]
	public async Task<ActionResult<User>> GetUserById(int userId)
	{
		var user = await _usersService.GetById(userId);

		if(user == null)
		{
			return NotFound();
		}

		return Ok(user);
	}

	[HttpPost("")]
	public IActionResult Save([FromBody] object payload)
	{
		Dictionary<string, object> hash = JsonSerializer.Deserialize<Dictionary<string, object>>(payload.ToString());

		ValidateSaveUser validator = new(hash);
		validator.Execute();

		if (validator.HasErrors())
		{
			return UnprocessableEntity(validator.Errors);
		}
		else
		{
			BuildUserFromHash cmd = new(hash);

			User user = cmd.Execute();
			_usersService.Save(user);

			Dictionary<string, object> message = new()
			{
				{ "message", "Ok" }
			};
			return Ok(message);
		}
	}
}