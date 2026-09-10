using CryptoExchange.Net.Objects;
using System.Threading;
using System.Threading.Tasks;
using CoinEx.Net.Objects.Models.V2;
using CoinEx.Net.Enums;
using System.Collections.Generic;

namespace CoinEx.Net.Interfaces.Clients.FuturesApi
{
    /// <summary>
    /// CoinEx account endpoints. Account endpoints include balance info, withdraw/deposit info and requesting and account settings
    /// </summary>
    public interface ICoinExRestClientFuturesApiAccount
    {
        /// <summary>
        /// Get trading fees for a symbol
        /// <para><a href="https://docs.coinex.com/api/v2/account/fees/http/get-account-trade-fees" /></para>
        /// </summary>
        /// <param name="symbol">["<c>market</c>"] Symbol, for example `ETHUSDT`</param>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinExTradeFee>> GetTradingFeesAsync(string symbol, CancellationToken ct = default);

        /// <summary>
        /// Get balances
        /// <para><a href="https://docs.coinex.com/api/v2/assets/balance/http/get-futures-balance" /></para>
        /// </summary>
        /// <param name="ct">Cancelation token</param>
        /// <returns></returns>
        Task<HttpResult<CoinExFuturesBalance[]>> GetBalancesAsync(CancellationToken ct = default);

        /// <summary>
        /// Set leverage for a symbol
        /// <para><a href="https://docs.coinex.com/api/v2/futures/position/http/adjust-position-leverage" /></para>
        /// </summary>
        /// <param name="symbol">["<c>market</c>"] Symbol, for example `ETHUSDT`</param>
        /// <param name="mode">["<c>margin_mode</c>"] Margin mode</param>
        /// <param name="leverage">["<c>leverage</c>"] Leverage</param>
        /// <param name="ct">Cancelation token</param>
        /// <param name="positionSide">["<c>position_side</c>"] Position side in hedge mode; omit in one-way mode.</param>
        /// <returns></returns>
        Task<HttpResult<CoinExLeverage>> SetLeverageAsync(string symbol, MarginMode mode, int leverage, CancellationToken ct = default, PositionSide? positionSide = null);

        /// <summary>
        /// Get account-wide futures market settings.
        /// <para><a href="https://docs.coinex.com/api/v2/account/settings/http/accquire-futures-market-settings" /></para>
        /// </summary>
        /// <param name="ct">Cancellation token.</param>
        Task<HttpResult<CoinExFuturesMarketSettings>> GetMarketSettingsAsync(CancellationToken ct = default);

        /// <summary>
        /// Set the account-wide futures position mode.
        /// <para><a href="https://docs.coinex.com/api/v2/account/settings/http/modify-futures-market-settings" /></para>
        /// </summary>
        /// <param name="positionMode">["<c>position_mode</c>"] Global position mode.</param>
        /// <param name="ct">Cancellation token.</param>
        Task<HttpResult> SetPositionModeAsync(PositionMode positionMode, CancellationToken ct = default);
    }
}
