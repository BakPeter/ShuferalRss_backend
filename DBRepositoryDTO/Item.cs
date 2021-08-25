using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositoryDTO
{
    public class Item
    {
        public string Title { get; set; }
        public string PubDate { get; set; }
        public string LatUpdateDate { get; set; }
        public string Summary { get; set; }
        public string Link { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Item item &&
                   Title == item.Title &&
                   PubDate == item.PubDate &&
                   LatUpdateDate == item.LatUpdateDate &&
                   Summary == item.Summary &&
                   Link == item.Link;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, PubDate, LatUpdateDate, Summary, Link);
        }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
