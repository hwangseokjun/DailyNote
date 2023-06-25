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
        private bool _isModifying;
        private bool _isDeleting;
        public Action<Category> OnSelected;
        public Action<Category> OnDeleting;
        public Action<Category> OnModifying;

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
        public bool IsModifying
        {
            get => _isModifying;
            set 
            {
                _isModifying = value;

                if (_isModifying) 
                {
                    OnModifying?.Invoke(this);
                }
            }
        }
        public bool IsDeleting
        {
            get => _isDeleting;
            set 
            {
                _isDeleting = value;

                if (_isDeleting) 
                {
                    OnDeleting?.Invoke(this);
                }
            }
        }
    }
}
