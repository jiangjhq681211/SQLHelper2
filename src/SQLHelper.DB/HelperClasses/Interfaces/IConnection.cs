/*
Copyright 2016 James Craig

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System.Data.Common;

namespace SQLHelperDB.HelperClasses.Interfaces
{
    /// <summary>
    /// Data source interface
    /// </summary>
    public interface IConnection
    {
        /// <summary>
        /// Connection string
        /// </summary>
        /// <value>The connection.</value>
        string ConnectionString { get; }

        /// <summary>
        /// Gets the database.
        /// </summary>
        /// <value>The database.</value>
        string? DatabaseName { get; }

        /// <summary>
        /// Gets the factory that the system uses to actually do the connection.
        /// </summary>
        /// <value>The factory that the system needs to actually do the connection.</value>
        DbProviderFactory Factory { get; }

        /// <summary>
        /// Name of the source
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }

        /// <summary>
        /// Parameter prefix that the source uses
        /// </summary>
        /// <value>The parameter prefix.</value>
        string ParameterPrefix { get; }

        /// <summary>
        /// Gets the number of retries if unable to connect.
        /// </summary>
        /// <value>The number of retries if unable to connect.</value>
        int Retries { get; }
    }
}