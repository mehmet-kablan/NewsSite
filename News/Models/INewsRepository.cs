using System.Linq;

namespace SportsStore.Models
{
    public interface INewsRepository
    {
        IQueryable<News> News { get; }
        void SaveNews(News news);
        void CreateNews(News news);
        void DeleteNews(News news);
    }
}