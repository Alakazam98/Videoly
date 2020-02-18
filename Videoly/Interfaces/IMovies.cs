using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Videoly.Models;

namespace Videoly.Interfaces
{
    public interface IMovies
    {
        ActionResult Save(Movie movies);

        ActionResult MoviesForm(int id);
    }
}
