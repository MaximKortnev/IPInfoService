namespace IPInfoService.Models
{
    /// <summary>
    /// Представляет историю запросов к сервису IP информации.
    /// </summary>
    public class RequestHistory
    {
        /// <summary>
        /// Уникальный идентификатор записи истории запроса.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// IP-адрес, для которого был сделан запрос.
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Время, когда запрос был сделан.
        /// </summary>
        public DateTime RequestTime { get; set; }
    }
}