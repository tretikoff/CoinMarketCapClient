﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinMarketCap.Enums
{
    /// <summary>
    /// Available Fiat currencies in CoinMarketCap Api.
    /// </summary>
    [Obsolete("Public API Version 1 will be taken offline on November 30th, 2018. Please modify your application to use Version 2 prior to shutdown.")]
    public enum ConvertEnum
    {
        /// <summary>
        /// United States Dollar.
        /// </summary>
        USD = 0, // To enforce default value.
        /// <summary>
        /// Australian Dollar.
        /// </summary>
        AUD,
        /// <summary>
        /// Brazilian Real.
        /// </summary>
        BRL,
        /// <summary>
        /// Canadian Dollar.
        /// </summary>
        CAD,
        /// <summary>
        /// Swiss Franc.
        /// </summary>
        CHF,
        /// <summary>
        /// Chinese Yuan.
        /// </summary>
        CNY,
        /// <summary>
        /// Euro.
        /// </summary>
        EUR,
        /// <summary>
        /// British Pound.
        /// </summary>
        GBP,
        /// <summary>
        /// Hong Kong Dollar
        /// </summary>
        HKD,
        /// <summary>
        /// Indonesian Rupiah.
        /// </summary>
        IDR,
        /// <summary>
        /// Indian Rupee.
        /// </summary>
        INR,
        /// <summary>
        /// Japanese Yen.
        /// </summary>
        JPY,
        /// <summary>
        /// South Korean Won.
        /// </summary>
        KRW,
        /// <summary>
        /// Mexican Peso.
        /// </summary>
        MXN,
        /// <summary>
        /// Russian Rubble.
        /// </summary>
        RUB
    }
}
