using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositoryDTO
{
    public class DBRepoDownloadDataDTO
    {
        public string URL { get; set; }

        public override bool Equals(object obj)
        {
            return obj is DBRepoDownloadDataDTO dTO &&
                   URL == dTO.URL;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(URL);
        }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
