﻿namespace Diplom.Application.Models
{
    public class Response<T>
    {
        public T Data { get; set; }
        public string Message { get; set; } = string.Empty;
        public bool Success { get; set; } = false;
    }
}
