using Catel.Data;
using Catel.MVVM;
using System.Threading.Tasks;
using Catel.Fody;
/// ^^^^error only in .net core wpf app^^^^^^

namespace CatelFodyWpfCoreTest.ViewModels
{

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
        }

        public override string Title { get { return "Main"; } }

        // TODO: Register properties using 'vmprop'
        // TODO: Register properties that represent models using 'vmpropmodel'
        // TODO: Register properties that map to models using 'vmpropviewmodeltomodel'
        // TODO: Register commands using 'vmcommand', 'vmcommandwithcanexecute', 'vmtaskcommand' or 'vmtaskcommandwithcanexecute'


        [Model]
        [Expose("Property")] //error with Catel.Fody in .net core WPF app
        public string Model { get; set; }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: Add initialization logic like subscribing to events
        }

        protected override async Task CloseAsync()
        {
            // TODO: Add uninitialization logic like unsubscribing from events

            await base.CloseAsync();
        }
    }
}
