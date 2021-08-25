using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;

namespace RssFeedParserDTO
{
    public class RssParserDTO
    {
        public SyndicationFeed Feed { get; set; }

        public override bool Equals(object obj)
        {
            return obj is RssParserDTO dTO &&
                   EqualityComparer<SyndicationFeed>.Default.Equals(Feed, dTO.Feed);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Feed);
        }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
