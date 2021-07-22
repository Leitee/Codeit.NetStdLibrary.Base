﻿/// <summary>
/// 
/// </summary>
namespace Codeit.NetStdLibrary.Base.DataAccess
{
    using Codeit.NetStdLibrary.Base.Common;

    public class DALSettings : BaseSettings<DALSettings>
    {
        public bool UseDatabase { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseUrl { get; set; }
        public string LoggerServerUrl { get; set; }
    }
}
