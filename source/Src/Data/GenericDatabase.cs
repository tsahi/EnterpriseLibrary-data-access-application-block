﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Data.Common;
using EnterpriseLibrary.Common.Configuration;
using EnterpriseLibrary.Data.Configuration;
using EnterpriseLibrary.Data.Properties;

namespace EnterpriseLibrary.Data
{
    /// <summary>
    /// The <see cref="GenericDatabase"/> is used when no specific behavior is required or known for a database.
    /// </summary>
    /// <remarks>
    /// This database exposes the <see cref="DbProviderFactory"/> used to allow for a provider 
    /// agnostic programming model.
    /// </remarks>
    [ConfigurationElementType(typeof(GenericDatabaseData))]
    public class GenericDatabase : Database
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericDatabase"/> class with a connection string and 
        /// a provider factory.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="dbProviderFactory">The provider factory.</param>
        public GenericDatabase(string connectionString, DbProviderFactory dbProviderFactory)
            : base(connectionString, dbProviderFactory)
        {
        }

        /// <summary>
        /// This operation is not supported in this class.
        /// </summary>
        /// <param name="discoveryCommand">The <see cref="DbCommand"/> to do the discovery.</param>
        /// <remarks>There is no generic way to do it, the operation is not implemented for <see cref="GenericDatabase"/>.</remarks>
        /// <exception cref="NotSupportedException">Thrown whenever this method is called.</exception>
        protected override void DeriveParameters(DbCommand discoveryCommand)
        {
            throw new NotSupportedException(Resources.ExceptionParameterDiscoveryNotSupportedOnGenericDatabase);
        }
    }
}
