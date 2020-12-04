using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using app.domain;
using app.repository;
using app.service.Movies.Commands.CreateMovie;
using app.service.Movies.Commands.EditMovie;
using app.service.Movies.Query.GetMovieById;

namespace app.service.Movies
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepo;
        public MovieService(IRepository<Movie> movieRepo)
        {
            this._movieRepo = movieRepo;
        }

        public CreateMovieResult CreateMovie(CreateMovieCommand movie)
        {
            var entity = new Movie
            {
                Title = movie.Title,
                ReleaseDate = movie.ReleaseDate,
                Genre = movie.Genre,
                Price = movie.Price,
                Rating = movie.Rating,
                DirectorID = movie.DirectorID
            };

            _movieRepo.Create(entity);
            _movieRepo.SaveChanges();

            return new CreateMovieResult
            {
                Id = entity.Id
            };
        }

        public EditMovieResult EditMovie(EditMovieCommand movie)
        {
            var entity = new Movie
            {

                Id = movie.Id,
                Title = movie.Title,
                ReleaseDate = movie.ReleaseDate,
                Genre = movie.Genre,
                Price = movie.Price,
                Rating = movie.Rating,
                DirectorID = movie.DirectorID
            };

            _movieRepo.Update(entity);
            _movieRepo.SaveChanges();

            return new EditMovieResult
            {
            };
        }

        public GetMovieByIdResult GetMovieById(GetMovieByIdQuery query)
        {
            var movie = _movieRepo.GetAll().FirstOrDefault(m => m.Id == query.Id);

            if (movie == null) return null;

            return new GetMovieByIdResult
            {
                Id = movie.Id,
                Title = movie.Title,
                ReleaseDate = movie.ReleaseDate,
                Genre = movie.Genre,
                Price = movie.Price,
                Rating = movie.Rating,
                DirectorID = movie.DirectorID

            };
        }
    }
}
