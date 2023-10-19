﻿using Loans.Shared.Responses;

namespace Loans.API.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string servicePrefix, string controller);

    }
}
