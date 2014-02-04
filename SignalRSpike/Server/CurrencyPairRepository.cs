﻿using System.Collections.Generic;
using Dto;

namespace Server
{
    class CurrencyPairRepository : ICurrencyPairRepository
    {
        private readonly Dictionary<string, CurrencyPair> _currencyPairs = new Dictionary<string, CurrencyPair>
        {
            {"EURUSD", new CurrencyPair("EURUSD", 5, 3)},
            {"EURGBP", new CurrencyPair("EURGBP", 5, 3)},
        }; 

        public IEnumerable<CurrencyPair> GetAllCurrencyPairs()
        {
            return _currencyPairs.Values;
        }

        public CurrencyPair GetCurrencyPair(string symbol)
        {
            return _currencyPairs[symbol];
        }

        public bool Exists(string symbol)
        {
            return _currencyPairs.ContainsKey(symbol);
        }
    }
}