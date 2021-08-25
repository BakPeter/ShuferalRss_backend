using DynamicLoaderContracts;
using RssLoaderContracts;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;

namespace RssLoaderService
{
    [LoaderAttribute(typeof(IRssLoaderSevice), typeof(RssLoaderSeviceImpl), Policy.Transient)]
    public class RssLoaderSeviceImpl : IRssLoaderSevice
    {
        public RssLoaderResponseDTO LoadRss(RssLoaderDTO dto)
        {
            RssLoaderResponseDTO retVal = new RssLoaderResponseDTO();
           
            try
            {
                using (var reader = XmlReader.Create(dto.RssURL))
                {
                    SyndicationFeed feed = SyndicationFeed.Load(reader);
                    retVal.Feed = feed;
                }
            }
            catch (Exception e)
            {
                retVal.Error = e;
            }

            return retVal;
        }
    }
}
