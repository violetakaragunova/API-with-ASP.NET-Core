﻿namespace WebApplication1.Services
{
    public interface IMailService
    {
        void Send(string subject, string message);
    }
}