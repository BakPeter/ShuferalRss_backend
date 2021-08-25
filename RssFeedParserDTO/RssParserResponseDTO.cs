using DBRepositoryDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RssFeedParserDTO
{
    public class RssParserResponseDTO
    {
        public Exception Error { get; set; }
        public bool RequestSuccess { get => Error == null; }
        public List<Item> ParsedData{ get; set; }

        public override bool Equals(object obj)
        {
            return obj is RssParserResponseDTO dTO &&
                   EqualityComparer<Exception>.Default.Equals(Error, dTO.Error) &&
                   RequestSuccess == dTO.RequestSuccess &&
                   EqualityComparer<List<Item>>.Default.Equals(ParsedData, dTO.ParsedData);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Error, RequestSuccess, ParsedData);
        }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
