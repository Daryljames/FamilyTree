using FamilyTree.Models;

namespace FamilyTree.Interfaces;

public interface IUsersService
{
	Task<List<User>> GetAll();
	Task<User?> GetById(int id, bool tracking = false);
	public void Save(User hash);
}