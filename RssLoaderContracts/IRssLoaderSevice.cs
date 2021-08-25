using System;
using System.Collections.Generic;
using System.Text;

namespace RssLoaderContracts
{
    public interface IRssLoaderSevice
    {
        RssLoaderResponseDTO LoadRss(RssLoaderDTO dto);
    }
}
