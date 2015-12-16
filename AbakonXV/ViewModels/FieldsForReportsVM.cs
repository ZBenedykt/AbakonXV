using System.Collections.Generic;
using AbakonXVWPF.Reports;
using System.ComponentModel;
using System.Windows;

namespace AbakonXVWPF.ViewModels
{
    class FieldsForReportsVM<E> : ViewModelBase
    {
        List<string> _FieldsList = FieldsForReports.CreateListOfFields(typeof(E));
        public List<string> FieldsList
        {
            get { return _FieldsList; }
        }

        public FieldsForReportsVM()
        {
            if (!(bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
            { }
        }
    }
}
