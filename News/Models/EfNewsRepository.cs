using System.Linq;


namespace SportsStore.Models
{
    public class EfNewsRepository : INewsRepository
    {
        private readonly NewsContext _context;

        public EfNewsRepository(NewsContext newsContext)
        {
            _context = newsContext;
        }

        public IQueryable<News> News => _context.News;

        public void CreateNews(News news)
        {
            _context.Add(news);
            _context.SaveChanges();
        }

        public void DeleteNews(News news)
        {
            _context.Remove(news);
            _context.SaveChanges();
        }

        public void SaveNews(News news)
        {
            _context.SaveChanges();
        }
    }
}