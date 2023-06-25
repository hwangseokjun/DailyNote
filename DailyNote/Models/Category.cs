using DailyNote.DataAccess.Values;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyNote.Models
{
    public class Category
    {
        private bool _isSelected;
        public Action<Category> OnSelected;

        public int? Id { get; set; }
        public string Name { get; set; }
        public bool IsSelected
        { 
            get => _isSelected;
            set
            {
                _isSelected = value;

                if (_isSelected)
                {
                    OnSelected?.Invoke(this);
                }
            }
        }
    }
}
