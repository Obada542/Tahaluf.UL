using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface IRatingService
    {
        List<Ratingul> GetBookRating(int id);
        string AddRating(Ratingul rate);
    }
}
