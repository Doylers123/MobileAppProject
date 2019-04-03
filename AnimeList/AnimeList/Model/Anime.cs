using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Model
{
    class Anime
    {
        #region == Public Properties ==
        public string Title { get; set; }
        public string Year { get; set; }
        public string Seasons { get; set; }
        public string Episodes { get; set; }
        public string Status { get; set; }
        public string Rating { get; set; }

        #endregion

        #region  == constructors ==
        public Anime()
        {

        }
        public Anime(string t, string y, string s,
                    string e, string st, string r)
        {
            Title = t;
            Year = y;
            Seasons = s;
            Episodes = e;
            Status = st;
            Rating = r;
        }

        #endregion
    }
}
