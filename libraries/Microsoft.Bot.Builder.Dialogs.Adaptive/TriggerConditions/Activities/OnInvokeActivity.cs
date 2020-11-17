﻿// Licensed under the MIT License.
// Copyright (c) Microsoft Corporation. All rights reserved.

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Bot.Schema;
using Newtonsoft.Json;

namespace Microsoft.Bot.Builder.Dialogs.Adaptive.Conditions
{
    /// <summary>
    /// Actions triggered when an InvokeActivity is received.
    /// </summary>
    public class OnInvokeActivity : OnActivity
    {
        /// <summary>
        /// Class identifier.
        /// </summary>
        [JsonProperty("$kind")]
        public new const string Kind = "Microsoft.OnInvokeActivity";

        /// <summary>
        /// Initializes a new instance of the <see cref="OnInvokeActivity"/> class.
        /// </summary>
        /// <param name="actions">Optional, list of <see cref="Dialog"/> actions.</param>
        /// <param name="condition">Optional, condition which needs to be met for the actions to be executed.</param>
        /// <param name="callerPath">Optional, source file full path.</param>
        /// <param name="callerLine">Optional, line number in source file.</param>
        [JsonConstructor]
        public OnInvokeActivity(List<Dialog> actions = null, string condition = null, [CallerFilePath] string callerPath = "", [CallerLineNumber] int callerLine = 0)
            : base(type: ActivityTypes.Invoke, actions: actions, condition: condition, callerPath: callerPath, callerLine: callerLine)
        {
        }
    }
}
