using FamilyTree.Models;

namespace FamilyTree.Commands.Builders;

public class BuildUserFromHash
{
	private Dictionary<string, object> data;

	public BuildUserFromHash(Dictionary<string, object> data)
	{
		this.data = data;
	}

	public User Execute()
	{
		User user = new User();

		if (data.ContainsKey("id"))
		{
			user.Id = int.Parse(this.data["id"].ToString());
		}

		user.FirstName = this.data["firstName"].ToString();
		user.MiddleName = this.data["middleName"].ToString();
		user.LastName = this.data["lastName"].ToString();
		user.EmailAddress = this.data["emailAddress"].ToString();
		user.Password = this.data["password"].ToString();
		user.Role = this.data["role"].ToString();
		user.MobileNumber = this.data["mobileNumber"].ToString();
		user.Birthday = DateTime.Parse(this.data["birthday"].ToString());
		user.CivilStatus = this.data["civilStatus"].ToString();
		user.CreatedBy = int.Parse(this.data["id"].ToString());
		user.CreatedOn = DateTime.Now;
		user.UpdatedBy = int.Parse(this.data["id"].ToString());
		user.UpdatedOn = DateTime.Now;
		user.IsActive = bool.Parse(this.data["isActive"].ToString());

		System.Console.WriteLine(user);
		return user;
	}
}
