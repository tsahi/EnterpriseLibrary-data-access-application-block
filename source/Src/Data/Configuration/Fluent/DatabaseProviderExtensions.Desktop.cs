﻿using System.Data.OleDb;
using EnterpriseLibrary.Data.Configuration.Fluent;

namespace EnterpriseLibrary.Common.Configuration
{
    public static partial class DatabaseProviderExtensions
    {
        /// <summary>
        /// An OleDb database for use with the <see cref="System.Data.OleDb"/> namespace.
        /// </summary>
        /// <returns></returns>
        public static IOleDbDatabaseConfiguration AnOleDbDatabase(this IDatabaseConfigurationProviders context)
        {
            return new OleDbConfigurationExtension(context);
        }
    }
}
