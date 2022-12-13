using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    internal class ConnInformation
    {
        private string connectionStr = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
        private string ownerId = "oqwfhhpiow"; //임시 owner id 사용
        public string GetConnStr() { return connectionStr; }
        public string GetOwnerId() { return ownerId; }
    }
}
