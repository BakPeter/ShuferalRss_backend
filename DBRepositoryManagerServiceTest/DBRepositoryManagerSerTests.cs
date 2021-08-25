using DBRepositoryManagerContracts;
using DBRepositoryManagerService;
using NUnit.Framework;
using RssFeedParserContracts;
using RssFeedParserService;
using RssLoaderContracts;
using RssLoaderService;
using System.Threading;

namespace DBRepositoryManagerServiceTest
{
    public class Tests
    {
        private IRssLoaderSevice _loaderService;
        private IRssFeedParserService _parserService;
        private IDBRepositoryManagerService _repManservice;

        [SetUp]
        public void Setup()
        {
            _loaderService = new RssLoaderSeviceImpl();
            _parserService = new RssFeedParserServiceImpl();
            _repManservice = new DBRepositoryManagerServiceImpl(_loaderService, _parserService);
        }

        [Test]
        public void Test()
        {
            //var result1 = _loaderService.LoadRss(new RssLoaderDTO() { RssURL = "https://news.google.com/rss" });
            //var parseResult1 = _parserService.ParseRSS(new RssFeedParserDTO.RssParserDTO() { Feed = result1.Feed });
            //Assert.AreEqual(parseResult1.ParsedData.Count, 38);

            //var result2 = _loaderService.LoadRss(new RssLoaderDTO() { RssURL = "https://www.google.com/alerts/feeds/13583186640397089815/5906306061878099971" });
            //var parseResult2 = _parserService.ParseRSS(new RssFeedParserDTO.RssParserDTO() { Feed = result2.Feed });
            //Assert.AreEqual(true, parseResult2.RequestSuccess);
            //Assert.AreEqual(20, parseResult2.ParsedData.Count);
            var data = _repManservice.DownloadData(new DBRepositoryDTO.DBRepoDownloadDataDTO()
            { 
                URL = "https://www.google.com/alerts/feeds/13583186640397089815/5906306061878099971"
            });
            Assert.AreEqual(20, data.Data.Count);

            data = _repManservice.DownloadData(new DBRepositoryDTO.DBRepoDownloadDataDTO()
            {
                URL = "https://www.google.com/alerts/feeds/13583186640397089815/5906306061878099971"
            });
            Assert.AreEqual(38, data.Data.Count);

            data = _repManservice.DownloadData(new DBRepositoryDTO.DBRepoDownloadDataDTO()
            {
                URL = "https://www.badurl.com"
            });
            Assert.AreEqual(false, data.RequestSuccess);
        }
    }
}