using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WarhammerConsole.Annotations;
using WarhammerConsole.library;

namespace WarhammerConsole.Model
{
    class MainWindowModel : INotifyPropertyChanged
    {

	    public MainWindowModel()
	    {
			var names = new Names();
			var species = new Species();
			var character = new Character();

			//Humans
			HumanMaleFirstNames = names.GetFirstNamesMale();
		    HumanFemaleFirstNames = names.GetFirstNamesFemale();
		    HumanLastNames = names.GetLastNames();
			//Dwarfs
		    DwarvenMaleFirstName = names.GetDwarvenFirstNameMale();
		    DwarvenFemaleFirstName = names.GetDwarvenFirstNameMale();
		    DwarvenLastName = names.GetDwarvenFirstNameMale();

		}

		public List<string> HumanMaleFirstNames { get; set; }
		public List<string> HumanFemaleFirstNames { get; set; }
		public List<string> HumanLastNames { get; set; }

		public List<string> DwarvenMaleFirstName { get; set; }
	    public List<string> DwarvenFemaleFirstName { get; set; }
	    public List<string> DwarvenLastName { get; set; }



		public event PropertyChangedEventHandler PropertyChanged;

	    [NotifyPropertyChangedInvocator]
	    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	    {
		    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	    }
    }
}
