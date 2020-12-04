using System;
using System.Collections.Generic;
using System.Text;
using app.domain;

namespace app.service.Directors.Query.GetDirectorById
{
    public class GetDirectorByIdResult
    {

        public GetDirectorByIdResult()
        {
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
