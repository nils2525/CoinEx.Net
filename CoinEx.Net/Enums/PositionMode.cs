using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters.SystemTextJson;

namespace CoinEx.Net.Enums
{
    /// <summary>
    /// Futures position mode.
    /// </summary>
    [JsonConverter(typeof(EnumConverter<PositionMode>))]
    public enum PositionMode
    {
        /// <summary>
        /// ["<c>one_way</c>"] One position direction per market.
        /// </summary>
        [Map("one_way")]
        OneWay,
        /// <summary>
        /// ["<c>hedge</c>"] Independent long and short positions.
        /// </summary>
        [Map("hedge")]
        Hedge
    }
}
