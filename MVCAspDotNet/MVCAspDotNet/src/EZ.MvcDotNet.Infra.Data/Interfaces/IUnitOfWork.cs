﻿namespace EZ.MvcDotNet.Infra.Data.Interfaces
{
    public interface IUnitOfWork
    {
        void BeginTransaction();

        void SaveChanges();
    }
}