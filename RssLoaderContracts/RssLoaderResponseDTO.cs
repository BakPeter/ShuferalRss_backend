using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;

namespace RssLoaderContracts
{
    public class RssLoaderResponseDTO
    {
        public Exception Error { get; set; }
        public bool LoadSuccess { get => Error == null; }
        public SyndicationFeed Feed { get; set; }
    }
}
