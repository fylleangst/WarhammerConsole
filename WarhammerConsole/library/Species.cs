using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerConsole.library
{
    public class Species
    {
	    public List<string> PlayerSpecies()
	    {
			return new List<string>(new []{"Human","Dwarf","Elf", "Halfing","Gnome"});
	    }

	    public List<string> NpcSpecies()
	    {
			return new List<string>(new []{"Orc","Goblin","Skaven"});
	    }

	    public List<string> Monsters()
	    {
			return new List<string>(new []{"Rat","Dragon"});
	    }
    }
}
