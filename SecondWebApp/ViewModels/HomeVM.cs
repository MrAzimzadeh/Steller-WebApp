using SecondWebApp.Models;

namespace SecondWebApp.ViewModels
{
    public class HomeVM
    {
        public Banner Banner { get; set; }
        public About About { get; set; }
        public List<ClientCount> ClientCounts { get; set; }
    }
}
