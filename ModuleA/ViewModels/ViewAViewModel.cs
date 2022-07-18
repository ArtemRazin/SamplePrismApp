using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string title;

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public ViewAViewModel()
        {
            Title = "View A";
        }
    }
}
