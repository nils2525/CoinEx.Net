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
        /// ["<c>position_mode</c>"] Global position mode. Not returned by the legacy API.
        /// </summary>
        [JsonPropertyName("position_mode")]
        public PositionMode? PositionMode { get; set; }
        /// <summary>
        /// ["<c>settle_switch</c>"] Legacy auto-settlement setting. Not returned by the position-mode API.
        /// </summary>
        [JsonPropertyName("settle_switch")]
        public int? SettleSwitch { get; set; }
    }
}
