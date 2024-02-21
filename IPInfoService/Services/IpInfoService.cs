using IPInfoService.Models;

namespace IPInfoService.Services
{
    public class IpInfoService : IIPInfoService
    {
        private readonly DatabaseContext databaseContext;

        public IpInfoService(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public void SaveRequestIp(string ipAddress)
        {
            // Проверяем, существует ли уже запись с таким IP-адресом
            var existingRequest = databaseContext.RequestHistories.FirstOrDefault(r => r.IpAddress == ipAddress);

            // Если запись не существует, сохраняем ее
            if (existingRequest == null)
            {
                databaseContext.RequestHistories.Add(new RequestHistory
                {
                    IpAddress = ipAddress,
                    RequestTime = DateTime.UtcNow
                });
                databaseContext.SaveChanges();
            }
        }
    }
}
