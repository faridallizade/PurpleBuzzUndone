using PurpleBuzz.Models;

namespace PurpleBuzz.ViewModels
{
    public class WorkVM
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; internal set; }
    }
}
