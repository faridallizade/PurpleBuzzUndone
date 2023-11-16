using PurpleBuzz.Models;

namespace PurpleBuzz.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Card> Cards { get; set; }   
        public List<Card> RecentCards { get; set; }
    }
}
