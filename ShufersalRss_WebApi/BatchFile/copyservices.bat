@echo off
cls
xcopy /y "E:\Projects\ShufersalRss\ShufersalRss_backend\ShufersalRss_backend\DBRepositoryManagerService\bin\Debug\netcoreapp3.1\DBRepositoryManagerService.dll" "E:\Projects\ShufersalRss\ShufersalRss_backend\ShufersalRss_backend\ShufersalRss_WebApi\bin\Debug\netcoreapp3.1\services"
xcopy /y "E:\Projects\ShufersalRss\ShufersalRss_backend\ShufersalRss_backend\RssFeedParserService\bin\Debug\netcoreapp3.1\RssFeedParserService.dll"  "E:\Projects\ShufersalRss\ShufersalRss_backend\ShufersalRss_backend\ShufersalRss_WebApi\bin\Debug\netcoreapp3.1\services"
xcopy /y "E:\Projects\ShufersalRss\ShufersalRss_backend\ShufersalRss_backend\RssLoaderService\bin\Debug\netcoreapp3.1\RssLoaderService.dll" "E:\Projects\ShufersalRss\ShufersalRss_backend\ShufersalRss_backend\ShufersalRss_WebApi\bin\Debug\netcoreapp3.1\services"

pause