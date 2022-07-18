using Prism.Mvvm;

namespace ModuleB.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        public ViewBViewModel()
        {

        }

        private string someProperty;
        public string SomeProperty
        {
            get => someProperty;
            set => SetProperty(ref someProperty, value);
        }
        
    }
}
