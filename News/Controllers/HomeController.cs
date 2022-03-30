using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Diagnostics;
using System.Linq;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewsRepository _repository;
        public int PageSize = 4;

        public HomeController(INewsRepository newsRepository)
        {
            _repository = newsRepository;
        }

        public ViewResult Index(string category, int newsPage = 1)
        {
            return View(new NewsListModel
            {
                News = _repository.News
                    .Skip((newsPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = newsPage,
                    ItemsPerPage = PageSize,
                    TotalItems = _repository.News.Count()
                },
                SliderList = _repository.News
            });
        }

        [Route("Home/NewsDetails/{newsId}")]
        public ActionResult NewsDetails(int newsId)
        {
            return View(new SingleNewsViewModel
            {
                News = _repository.News
                    .FirstOrDefault(n => n.NewsId == newsId)
            });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}