﻿namespace FastPaceTransferTest2022.Api.Models.Responses
{
    public class BaseResponse<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}