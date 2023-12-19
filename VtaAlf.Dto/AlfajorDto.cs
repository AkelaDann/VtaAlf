
using CommunityToolkit.Mvvm.ComponentModel;
namespace VtaAlf.Dto
{
    // All the code in this file is included in all platforms.
    public partial class AlfajorDto: ObservableObject
    {
        
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public string glosa;
        [ObservableProperty]
        public decimal precio;
        [ObservableProperty]
        public string tipo;
    }
}
