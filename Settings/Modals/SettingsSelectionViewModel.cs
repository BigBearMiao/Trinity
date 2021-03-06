using System.Collections.Generic;
using System.Linq;
using Trinity.Framework;
using System.Windows.Forms;
using System.Windows.Input;
using Trinity.Framework.Helpers;
using Trinity.UI.UIComponents;


namespace Trinity.Settings.Modals
{
    public class SettingsSelectionViewModel : NotifyBase
    {
        private bool _isWindowOpen;
        private List<SettingsSelectionItem> _selections;
        private string _title;
        private string _description;
        private DialogResult _dialogResult;
        private string _okButtonText;

        public SettingsSelectionViewModel()
        {
            Selections = GetDefaultSelections();
        }

        public static List<SettingsSelectionItem> GetDefaultSelections()
        {
            var result = new List<SettingsSelectionItem>();
            
            foreach (var item in default(SettingsSection).ToList<SettingsSection>(true).Where(i => i != SettingsSection.Dynamic))
            {
                result.Add(new SettingsSelectionItem(item));
            }

            foreach (var item in SettingsManager.GetDynamicSettings())
            {                
                if(item == null) continue;
                result.Add(new SettingsSelectionItem(SettingsSection.Dynamic, item.GetName()));
            }            

            return result;
        }
    
        public bool IsWindowOpen
        {
            get => _isWindowOpen;
            set => SetField(ref _isWindowOpen, value);
        }

        public FullyObservableCollection<SettingsSelectionItem> Items
        {
            get => new FullyObservableCollection<SettingsSelectionItem>(Selections);
            set => Selections = value.ToList();
        }

        public List<SettingsSelectionItem> Selections
        {
            get => _selections;
            set => SetField(ref _selections, value);
        }

        public string Title
        {
            get => _title;
            set => SetField(ref _title, value);
        }

        public string Description
        {
            get => _description;
            set => SetField(ref _description, value);
        }

        public string OkButtonText
        {
            get => _okButtonText;
            set => SetField(ref _okButtonText, value);
        }

        public DialogResult DialogResult
        {
            get => _dialogResult;
            set => SetField(ref _dialogResult, value);
        }

        public ICommand OkCommand => new RelayCommand(param =>
        {
            DialogResult = DialogResult.OK;
            IsWindowOpen = false;
        });

        public ICommand CancelCommand => new RelayCommand(param =>
        {
            DialogResult = DialogResult.Cancel;
            IsWindowOpen = false;
        });

        public ICommand SelectAllCommand => new RelayCommand(param =>
        {

            Core.Logger.Log("SelectAllCommand fired");

            foreach (var item in Selections)
            {
                if (item.IsEnabled)
                    item.IsSelected = true;
            }
        });

        public ICommand SelectNoneCommand => new RelayCommand(param =>
        {
            Core.Logger.Log("SelectNoneCommand fired");

            foreach (var item in Selections)
            {
                if (item.IsEnabled)
                    item.IsSelected = false;
            }
        });
    }
}