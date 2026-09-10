using CoinEx.Net.Enums;
using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace CoinEx.Net.Objects.Models.V2
{
    /// <summary>
    /// Account-wide futures market settings.
    /// </summary>
    [SerializationModel]
    public record CoinExFuturesMarketSettings
    {
        /// <summary>
        /// ["<c>position_mode</c>"] Global position mode.
        /// </summary>
        [JsonPropertyName("position_mode")]
        public PositionMode PositionMode { get; set; }
    }
}
