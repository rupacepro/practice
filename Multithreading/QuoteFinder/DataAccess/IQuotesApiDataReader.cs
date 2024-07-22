﻿public interface IQuotesApiDataReader : IDisposable
{
    Task<string> ReadAsync(int page, int quotesPerPage);
}

