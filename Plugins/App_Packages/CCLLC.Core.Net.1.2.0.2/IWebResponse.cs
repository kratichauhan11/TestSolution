﻿using System.Net;

namespace CCLLC.Core.Net
{
    public interface IWebResponse
    {
        string Content { get; }
        byte[] Bytes { get; }
        WebHeaderCollection Headers { get; }
        int StatusCode { get; }
        string StatusDescription { get; }
        bool Success { get; }
    }
}
