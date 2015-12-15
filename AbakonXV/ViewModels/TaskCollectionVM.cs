using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbakonXVWPF.Infrastructure;
using System.ComponentModel;
using System.Windows;
using System.Collections.Specialized;
using AbakonXVWPF.Interfaces;
using System.Collections.ObjectModel;
using AbakonDataModel;
namespace AbakonXVWPF.ViewModels
{
    public class TaskCollectionVM : ViewModelBase, ITask
    {
        #region ITask Members

        public ITask CurrentTask
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        private FilterPanelVM _myFilteredPanel = new FilterPanelVM();
        public FilterPanelVM MyFilteredPanel
        {
            get { return _myFilteredPanel; }
            set { SetField(ref _myFilteredPanel, value, () => MyFilteredPanel); }
        }

        public TaskCollectionVM()
        {
            if (!(bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
            {

            }
        }
    }
}
