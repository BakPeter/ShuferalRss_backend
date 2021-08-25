using RssFeedParserDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RssFeedParserContracts
{
    public interface IRssFeedParserService
    {
        RssParserResponseDTO ParseRSS(RssParserDTO dto);
    }
}
