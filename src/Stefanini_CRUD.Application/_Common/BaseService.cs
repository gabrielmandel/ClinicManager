﻿using Microsoft.Extensions.Logging;

namespace Stefanini_CRUD.Application.Common
{
    public abstract class BaseService<T>
    {
        public readonly ILogger<T> _logger;

        public BaseService(ILogger<T> logger)
        {
            _logger = logger;
        }
    }
}
