using FamilyTree.Interfaces;
using FamilyTree.Models;

namespace FamilyTree.Services;

public class UsersMSSQLService : IUsersService
{
	private readonly DataContext _dataContext;

	public UsersMSSQLService(DataContext dataContext)
	{
		_dataContext = dataContext;
	}

	public async Task<List<User>> GetAll()
	{
		return await _dataContext.Users
			.Where(x => x.IsActive == true)
			.ToListAsync();
	}

	public async Task<User?> GetById(int id, bool tracking = false)
	{
		var query = tracking
			? _dataContext.Set<User>()
			: _dataContext.Users.AsNoTracking();

		return query.FirstOrDefault((o) => o.Id == id);
	}

	public async void Save(User hash)
	{
		if (hash.Id == 0)
		{
			_dataContext.Users.Add(hash);
		}
		else
		{
			User? temp = await GetById(hash.Id);
			temp!.FirstName = hash.FirstName;
			temp.MiddleName = hash.MiddleName;
			temp.LastName = hash.LastName;
			temp.EmailAddress = hash.EmailAddress;
			temp.Password = hash.Password;
			temp.Role = hash.Role;
			temp.MobileNumber = hash.MobileNumber;
			temp.Birthday = hash.Birthday;
			temp.CivilStatus = hash.CivilStatus;
			temp.CreatedBy = hash.CreatedBy;
			temp.CreatedOn = hash.CreatedOn;
			temp.UpdatedBy = hash.UpdatedBy;
			temp.UpdatedOn = hash.UpdatedOn;
			temp.IsActive = hash.IsActive;
		}
		_dataContext.SaveChanges();
	}
}