using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
    public interface IRatingRepository
    {
        List<Ratingul> GetBookRating(int id);
        List<Ratingul> GetAllRating();

        string AddRating(Ratingul rate);

    }
}
