﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Bot.Builder.Expressions
{
    public class ExpressionParsingException: Exception
    {
        public ExpressionParsingException(string message)
            : base(message)
        {
           
        }

    }

    public class ExpressionEvaluationException: Exception
    {
        public ExpressionEvaluationException(string message)
            : base(message)
        {
        }
    }

    public class NoSuchFuntionException: ExpressionEvaluationException
    {
        public NoSuchFuntionException(string message)
            : base(message)
        {
        }
    }
    
    public class GetPropertyValueFailException: ExpressionEvaluationException
    {
        public GetPropertyValueFailException(string message)
            :base(message)
        {

        }
    }

    public class ExpressionPropertyMissingException : ExpressionEvaluationException
    {
        public ExpressionPropertyMissingException(string message = null)
            : base(message)
        {
        }
    }
}
