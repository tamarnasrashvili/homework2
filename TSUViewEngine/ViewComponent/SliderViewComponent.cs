using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSUViewEngine.ViewComponent
{
    public class SliderViewComponent: Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private Models.MovieRepository.IMovieRepository _movieRepository;

        public SliderViewComponent(Models.MovieRepository.IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IViewComponentResult Invoke()
        {
            IEnumerable<string> movies = _movieRepository.Movies("").Select(x => x.Thumb);

            return View(movies);
        }
    }
}
