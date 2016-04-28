﻿using System;

namespace Vanilla.Infrastructure.Domain
{
    public class ValueObjectIsInvalidException : Exception
    {
        public ValueObjectIsInvalidException(string message)
            : base(message)
        {
        }
    }
}
