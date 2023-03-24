using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WarhammerConsole.Annotations;
using WarhammerConsole.Model;

namespace WarhammerConsole.ViewModel
{ 
    class MainWindowViewModel : INotifyPropertyChanged
    {
	    private string _outputText;
	    private readonly List<string> _humanMaleFirstNames;
	    private readonly List<string> _humanLastNames;
	    private readonly List<string> _humanFemaleFirstNames;
	    private readonly List<string> _dwarvenMaleFirstName;
	    private readonly List<string> _dwarvenFemaleFirstName;
	    private readonly List<string> _dwarvenLastName;

	    public ICommand NameButton { get; set; }
		

	    public MainWindowViewModel()
	    {
		    var mwModel = new MainWindowModel();

		    _humanMaleFirstNames = mwModel.HumanMaleFirstNames;
		    _humanFemaleFirstNames = mwModel.HumanFemaleFirstNames;
		    _humanLastNames = mwModel.HumanLastNames;

		    _dwarvenMaleFirstName = mwModel.DwarvenMaleFirstName;
		    _dwarvenFemaleFirstName = mwModel.DwarvenFemaleFirstName;
		    _dwarvenLastName = mwModel.DwarvenLastName;

		    NameButton = new RelayCommand(o => NameButtonClick());
	    }

	    private void NameButtonClick()
	    {
			var rd = new Random();
			//Human names
			var hmfn = _humanMaleFirstNames[rd.Next(1, _humanMaleFirstNames.Count) - 1];
		    var ln = _humanLastNames[rd.Next(1, _humanLastNames.Count) - 1];
		    var humanMaleName = $"{hmfn} {ln}";

		    var hffn = _humanFemaleFirstNames[rd.Next(1, _humanFemaleFirstNames.Count) - 1];
		    ln = _humanLastNames[rd.Next(1, _humanLastNames.Count) - 1];
		    var humanFemaleName = $"{hffn} {ln}";

			//Dwarf names
		    var dmfn = _dwarvenMaleFirstName[rd.Next(1, _dwarvenMaleFirstName.Count) - 1];
		    ln = _dwarvenLastName[rd.Next(1, _dwarvenLastName.Count) - 1];
		    var dwarvenMaleName = $"{dmfn} {ln}";

		    var dffn = _dwarvenFemaleFirstName[rd.Next(1, _dwarvenFemaleFirstName.Count) - 1];
		    ln = _dwarvenLastName[rd.Next(1, _dwarvenLastName.Count) - 1];
		    var dwarvenFemaleName = $"{dffn} {ln}";

			//Elf names
			//Halfling names
			//Gnome names
			OutputText = $"Human \n{humanMaleName}\n{humanFemaleName}\n\n" +
			             $"Dwarf \n{dwarvenFemaleName}\n{dwarvenMaleName}\n\n" +
						 $"Elf \n\n" +
						$"Halfling \n\n";
	    }
	    public string OutputText
	    {
		    get => _outputText;
		    set
		    {
			    _outputText = value;
			    OnPropertyChanged(nameof(OutputText));
		    }
	    }


		public event PropertyChangedEventHandler PropertyChanged;

	    [NotifyPropertyChangedInvocator]
	    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	    {
		    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	    }
	    public class RelayCommand : ICommand
	    {
		    private readonly Action<object> _execute;
		    private readonly Predicate<object> _canExecute;

		    public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
		    {
			    _execute = execute ?? throw new ArgumentNullException("execute");
			    _canExecute = canExecute;
		    }

		    public bool CanExecute(object parameter)
		    {
			    return _canExecute == null || _canExecute(parameter);
		    }

		    public event EventHandler CanExecuteChanged
		    {
			    add { CommandManager.RequerySuggested += value; }
			    remove { CommandManager.RequerySuggested -= value; }
		    }

		    public void Execute(object parameter)
		    {
			    _execute(parameter ?? "<N/A>");
		    }
	    }
	}
}
