using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using VtaAlf.Dal;
using VtaAlf.Dto;


namespace VtaAlf.ViewModels
{
    public partial class AlfajorViewModel : ObservableObject, IQueryAttributable
    {
        private readonly AlfajorDbContext _dbContext;
        [ObservableProperty]
        private AlfajorDto alfajorDto = new AlfajorDto();

        [ObservableProperty]
        private string tituloPagina;
        private int Id;
        [ObservableProperty]
        private bool loadingVisible = false;

        public AlfajorViewModel(AlfajorDbContext context)
        {
             _dbContext = context;            
        }
        public async void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            var _id = int.Parse(query["id"].ToString());
            Id = _id;

            if (Id.Equals(0))
            {
                TituloPagina = "Ingreso Alfajores";
            }
            else
            {
                TituloPagina = "Egreso Alfajores";
                loadingVisible = true;
                await Task.Run(async () =>
                {
                    var encontrado = await _dbContext.alfajores.FirstAsync(e => e.ID == _id) ;
                    AlfajorDto = encontrado;

                    MainThread.BeginInvokeOnMainThread(() => { loadingVisible = false; });
                });
            }
        }
    }
}
