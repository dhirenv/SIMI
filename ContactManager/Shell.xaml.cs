using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ContactManager.Presenters;

namespace ContactManager
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window
    {
        public Shell()
        {
            InitializeComponent();
        }

        public void AddTab<T>(PresenterBase<T> presenter)
        {
            TabItem newTab = null;

            for (int i = 0; i < tabs.Items.Count; i++)
            {
                TabItem existingTab = (TabItem) tabs.Items[i];

                if (existingTab.DataContext.Equals(presenter))
                {
                    tabs.Items.Remove(existingTab);
                    newTab = existingTab;
                    break;
                }
            }

            if (newTab == null)
            {
                newTab = new TabItem();

                Binding headerBinding = new Binding(presenter.TabHeaderPath);
                BindingOperations.SetBinding(newTab, TabItem.HeaderProperty, headerBinding);

                newTab.DataContext = presenter;
                newTab.Content = presenter.View;
            }

            tabs.Items.Insert(0, newTab);
            newTab.Focus();
        }

        public void RemoveTab<T>(PresenterBase<T> presenter)
        {
            for (int i = 0; i < tabs.Items.Count; i++)
            {
                TabItem item = (TabItem)tabs.Items[i];

                if (item.DataContext.Equals(presenter))
                {
                    tabs.Items.Remove(item);
                    break;
                }
            }
        }
    }
}
