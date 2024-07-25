using ASP.Net_Intro.Entities;
using System.Collections.Generic;

namespace ASP.Net_Intro.ViewModels
{
    public class DataTotalViewModels
    {

        public List<Drink> drinks { get; set; }
        public List<FastFood> fastFood { get; set; }
        public List<HotMeal> hotMeal { get; set; }
    }
}
