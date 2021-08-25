using DBRepositoryDTO;
using DBRepositoryManagerContracts;
using DynamicLoaderContracts;
using RssFeedParserContracts;
using RssLoaderContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositoryManagerService
{
    [LoaderAttribute(typeof(IDBRepositoryManagerService), typeof(DBRepositoryManagerServiceImpl), Policy.Singelton)]
    public class DBRepositoryManagerServiceImpl : IDBRepositoryManagerService
    {
        private static readonly Object dataLock = new object();
        private List<Item> _data;

        private IRssLoaderSevice _rssLoderService;
        private IRssFeedParserService _rssParserService;

        public DBRepositoryManagerServiceImpl(IRssLoaderSevice rssLoderService, IRssFeedParserService rssParserService)
        {
            _rssLoderService = rssLoderService;
            _rssParserService = rssParserService;
        }

        public DBRepoDownloadDataResponseDTO DownloadData(DBRepoDownloadDataDTO dto)
        {
            lock (dataLock)
            {
                DBRepoDownloadDataResponseDTO retVal = new DBRepoDownloadDataResponseDTO();
                var feed = _rssLoderService.LoadRss(new RssLoaderDTO() { RssURL = dto.URL });
                var parsedData = _rssParserService.ParseRSS(new RssFeedParserDTO.RssParserDTO()
                {
                    Feed = feed.Feed
                });

                if (parsedData.RequestSuccess)
                {

                    SetData(parsedData.ParsedData);
                    return new DBRepoDownloadDataResponseDTO() { Data = GetData() };
                }
                else
                {
                    return new DBRepoDownloadDataResponseDTO() { Error = parsedData.Error };
                }
            }

        }

        public DBRepoDownloadDataResponseDTO UpdateData(DBRepoDownloadDataDTO dto)
        {
            return DownloadData(dto);
        }

        private void SetData(List<Item> dataToSet)
        {
            lock(dataLock)
            {
                _data = dataToSet;
            }
        }

        private List<Item> GetData()
        {
            lock (dataLock)
            {
                return _data;
            }
        }
    }
}
