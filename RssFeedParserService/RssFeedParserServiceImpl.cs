using DBRepositoryDTO;
using DynamicLoaderContracts;
using RssFeedParserContracts;
using RssFeedParserDTO;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;

namespace RssFeedParserService
{
    [LoaderAttribute(typeof(IRssFeedParserService), typeof(RssFeedParserServiceImpl), Policy.Transient)]
    public class RssFeedParserServiceImpl : IRssFeedParserService
    {
        public RssParserResponseDTO ParseRSS(RssParserDTO dto)
        {
            RssParserResponseDTO retVal = new RssParserResponseDTO();
            List<Item> data = new List<Item>();

            if(dto.Feed != null)
            {
                foreach (var elem in dto.Feed.Items)
                {
                    var item = new Item();
                    item.Title = elem.Title?.Text;

                    TextSyndicationContent tsc = (TextSyndicationContent)elem.Content;
                    item.Summary = tsc.Text;
                    
                    item.PubDate = elem.PublishDate.Date.ToString();
                    item.LatUpdateDate = elem.LastUpdatedTime.Date.ToString();
                    item.Link = elem.Links?[0].Uri.ToString();
                    
                    data.Add(item);
                }

                retVal.ParsedData = data;
            } else
            {
                retVal.Error = new ArgumentNullException("feed is null");
            }
            return retVal;
        }
    }
}
