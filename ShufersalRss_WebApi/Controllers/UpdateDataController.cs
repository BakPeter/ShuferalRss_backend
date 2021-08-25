using DBRepositoryDTO;
using DBRepositoryManagerContracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShufersalRss_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateDataController : ControllerBase
    {
        private IDBRepositoryManagerService _dbRepManService;

        public UpdateDataController(IDBRepositoryManagerService dbRepManService)
        {
            _dbRepManService = dbRepManService;
        }

        // Post: api/<UpdateDataController>
        [HttpGet]
        public DBRepoDownloadDataResponseDTO Get()
        {
            return _dbRepManService.DownloadData(new DBRepoDownloadDataDTO()
            {
                URL = "https://www.google.com/alerts/feeds/13583186640397089815/5906306061878099971"
            });
        }
    }
}
