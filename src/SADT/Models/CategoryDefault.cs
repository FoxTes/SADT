using System.Collections.ObjectModel;

namespace SADT.Models
{
    public class CategoryDefault : CategoryBase
    {
        public bool IsSelected { get; set; }

        public string Name { get; set; }

        public string NameModule { get; set; }

        public string Icon { get; set; }

        public ObservableCollection<CategoryDefault> Children { get; set; }
    }
}
