using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace CoinEx.Net.Objects.Models.V2
{
    /// <summary>
    /// Futures balance info
    /// </summary>
    [SerializationModel]
    public record CoinExFuturesBalance
    {
        /// <summary>
        /// ["<c>ccy</c>"] Asset
        /// </summary>
        [JsonPropertyName("ccy")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>account_balance</c>"] Transferred funds plus realized PNL, excluding unrealized PNL.
        /// </summary>
        [JsonPropertyName("account_balance")]
        public decimal AccountBalance { get; set; }
        /// <summary>
        /// ["<c>cross_balance</c>"] Account balance less allocated isolated margin.
        /// </summary>
        [JsonPropertyName("cross_balance")]
        public decimal CrossBalance { get; set; }
        /// <summary>
        /// ["<c>isolated_balance</c>"] Margin allocated to isolated positions.
        /// </summary>
        [JsonPropertyName("isolated_balance")]
        public decimal IsolatedBalance { get; set; }
        /// <summary>
        /// ["<c>cross_margin_avbl</c>"] Margin available for cross positions.
        /// </summary>
        [JsonPropertyName("cross_margin_avbl")]
        public decimal CrossMarginAvailable { get; set; }
        /// <summary>
        /// ["<c>isolated_margin_avbl</c>"] Margin available for isolated positions and transfers.
        /// </summary>
        [JsonPropertyName("isolated_margin_avbl")]
        public decimal IsolatedMarginAvailable { get; set; }
        /// <summary>
        /// ["<c>available</c>"] Deprecated alias for isolated margin available.
        /// </summary>
        [JsonPropertyName("available")]
        public decimal Available { get; set; }
        /// <summary>
        /// ["<c>frozen</c>"] Frozen balance
        /// </summary>
        [JsonPropertyName("frozen")]
        public decimal Frozen { get; set; }
        /// <summary>
        /// ["<c>margin</c>"] Allocated isolated position margin; excludes cross margin.
        /// </summary>
        [JsonPropertyName("margin")]
        public decimal Margin { get; set; }
        /// <summary>
        /// ["<c>unrealized_pnl</c>"] Unrealized profit and loss
        /// </summary>
        [JsonPropertyName("unrealized_pnl")]
        public decimal UnrealizedPnl { get; set; }
        /// <summary>
        /// ["<c>transferrable</c>"] Transferable balance
        /// </summary>
        [JsonPropertyName("transferrable")]
        public decimal Transferable { get; set; }
        /// <summary>
        /// ["<c>equity</c>"] Equity
        /// </summary>
        [JsonPropertyName("equity")]
        public decimal? Equity { get; set; }
    }
}
