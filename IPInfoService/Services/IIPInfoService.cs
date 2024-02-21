namespace IPInfoService.Services
{
    /// <summary>
    /// Определяет сервис для сохранения истории запросов IP-адресов.
    /// </summary>
    public interface IIPInfoService
    {
        /// <summary>
        /// Сохраняет IP-адрес в истории запросов.
        /// </summary>
        /// <param name="ipAddress">IP-адрес, который необходимо сохранить.</param>
        void SaveRequestIp(string ipAddress);
    }
}