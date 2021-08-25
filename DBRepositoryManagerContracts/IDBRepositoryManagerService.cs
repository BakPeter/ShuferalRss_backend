
using DBRepositoryDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositoryManagerContracts
{
    public interface IDBRepositoryManagerService
    {
        DBRepoDownloadDataResponseDTO DownloadData(DBRepoDownloadDataDTO dto);
        DBRepoDownloadDataResponseDTO UpdateData(DBRepoDownloadDataDTO dto);
    }
}
