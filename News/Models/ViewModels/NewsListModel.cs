using System.Collections.Generic;

namespace SportsStore.Models.ViewModels
{
    public class NewsListModel
    {
        public IEnumerable<News> News { get; set; }
        public IEnumerable<News> SliderList { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}