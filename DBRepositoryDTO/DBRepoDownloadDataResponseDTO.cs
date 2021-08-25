using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositoryDTO
{
    public class DBRepoDownloadDataResponseDTO
    {
        public List<Item> Data{ get; set; }

        public Exception Error { get; set; }

        public bool RequestSuccess { get => Error == null;  }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
