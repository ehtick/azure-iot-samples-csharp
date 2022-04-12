﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Azure.Devices.Shared;

namespace Microsoft.Azure.Devices.Client.Samples
{
    // The specific response codes in this sample.
    public class ClientResponseCodes : CommonClientResponseCodes
    {
        /// <summary>
        /// This code does not comply with HTTP semantics. Instead, it indicates that the device client
        /// reports the default value with ACK when its properties are empty.
        /// </summary>
        public const int DeviceInitialProperty = 203;
    }
}
