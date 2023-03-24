using System.Collections.Generic;

namespace WarhammerConsole.library
{
    public class Names
    {
	    public List<string> GetFirstNamesMale()
	    {
		    return new List<string>(new[] { "William", "john", "Tipp", "topp", "balls" });
		}

	    public List<string> GetFirstNamesFemale()
	    {
		    return new List<string>(new[] { "Rose", "Shara", "Kim", "Eve", "Doc" });
		}

	    public List<string> GetLastNames()
	    {
		    return new List<string>(new[] { "Wills", "johnser", "Tipps", "topps", "balls" });
		}

	    public List<string> GetDwarvenFirstNameMale()
	    {
		    return new List<string>(new[] { "Grog", "Bog", "dog", "Logg", "Fogg" });
		}

	    public List<string> GetDwarvenFirstNameFemale()
	    {
			return new List<string>(new string[]{"D1", "D2","D3"});
	    }

	    public List<string> GetDwarvenLastName()
	    {
		    return new List<string>(new string[] { "L1", "L2", "L3" });
		}
	}
}
