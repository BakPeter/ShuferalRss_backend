using NUnit.Framework;
using RssLoaderContracts;
using RssLoaderService;

namespace RssLoaderTests
{
    public class Tests
    {
        private IRssLoaderSevice _service;
        [SetUp]
        public void Setup()
        {
            _service = new RssLoaderSeviceImpl();
        }

        [Test]
        public void TestRssLoad()
        {
            var result = _service.LoadRss(new RssLoaderDTO() { RssURL = "www.badurl.com" });
            Assert.AreEqual(result.LoadSuccess, false); ;

            result = _service.LoadRss(new RssLoaderDTO() { RssURL = "https://news.google.com/rss" });
            Assert.AreEqual(result.LoadSuccess, true);

            result = _service.LoadRss(new RssLoaderDTO() { RssURL = "https://www.google.com/alerts/feeds/13583186640397089815/5906306061878099971" });
            Assert.AreEqual(result.LoadSuccess, true);
        }
    }
}