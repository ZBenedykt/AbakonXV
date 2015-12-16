using System;
using System.Windows;
using System.Windows.Threading;

namespace AbakonXVWPF.Views
{
    public static class UIExtensionMethods
    {
        private static Action EmptyDelegate = delegate() { };
        public static void Refresh(this UIElement uiElement)
        {
            if (uiElement != null)
            {
                uiElement.Dispatcher.Invoke(DispatcherPriority.Render, EmptyDelegate);
            }
        }
    }
}
