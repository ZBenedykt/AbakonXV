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
    public class TaskVM : ViewModelBase, ITask
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
        public TaskVM()
        {
            if (!(bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
            {

            }
        }
    }
}
