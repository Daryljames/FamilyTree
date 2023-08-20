namespace FamilyTree.Commands.Validators;

public class ValidateSaveUser
{
	private Dictionary<string, object> payload;
	public Dictionary<string, List<string>> Errors { get; private set; }

	public ValidateSaveUser(Dictionary<string, object> payload)
	{
		this.payload = payload;

		this.Errors = new Dictionary<string, List<string>>();

		Errors.Add("firstName", new List<string>());
		Errors.Add("middleName", new List<string>());
		Errors.Add("lastName", new List<string>());
		//add regex for email address
		Errors.Add("emailAddress", new List<string>());
		//research about password auth etc.
		Errors.Add("password", new List<string>());
		Errors.Add("role", new List<string>());
		Errors.Add("mobileNumber", new List<string>());
		Errors.Add("birthday", new List<string>());
		Errors.Add("civilStatus", new List<string>());
	}

	public bool HasErrors()
	{
		bool ans = false;

		if (Errors["firstName"].Count > 0)
		{
			ans = true;
		}
		if (Errors["middleName"].Count > 0)
		{
			ans = true;
		}
		if (Errors["lastName"].Count > 0)
		{
			ans = true;
		}
		if (Errors["emailAddress"].Count > 0)
		{
			ans = true;
		}
		if (Errors["password"].Count > 0)
		{
			ans = true;
		}
		if (Errors["role"].Count > 0)
		{
			ans = true;
		}
		if (Errors["mobileNumber"].Count > 0)
		{
			ans = true;
		}
		if (Errors["birthday"].Count > 0)
		{
			ans = true;
		}
		if (Errors["civilStatus"].Count > 0)
		{
			ans = true;
		}

		return ans;
	}

	public bool HasNoErrors()
	{
		return !HasErrors();
	}

	public void Execute()
	{
		if (!payload.ContainsKey("firstName"))
		{
			Errors["firstName"].Add("First name is required");
		}
		if (!payload.ContainsKey("middleName"))
		{
			Errors["middleName"].Add("First name is required");
		}
		if (!payload.ContainsKey("lastName"))
		{
			Errors["lastName"].Add("First name is required");
		}
		if (!payload.ContainsKey("emailAddress"))
		{
			Errors["emailAddress"].Add("First name is required");
		}
		if (!payload.ContainsKey("password"))
		{
			Errors["password"].Add("First name is required");
		}
		if (!payload.ContainsKey("role"))
		{
			Errors["role"].Add("First name is required");
		}
		if (!payload.ContainsKey("mobileNumber"))
		{
			Errors["mobileNumber"].Add("First name is required");
		}
		if (!payload.ContainsKey("birthday"))
		{
			Errors["birthday"].Add("First name is required");
		}
		if (!payload.ContainsKey("civilStatus"))
		{
			Errors["civilStatus"].Add("First name is required");
		}
	}
}