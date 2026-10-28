namespace RAGDemo.Infrastructure.Common;

/// <summary>
/// Centralized configuration keys, section names, and environment variable identifiers.
/// Eliminates magic strings and guarantees consistent lookup across test, development, and production environments.
/// </summary>
public static class ConfigurationConstants
{
    /// <summary>
    /// Database configuration keys, environment variables, and fallback defaults.
    /// </summary>
    public static class Database
    {
        /// <summary>
        /// Standard configuration section key for connection strings.
        /// </summary>
        public const string ConnectionStringsSection = "ConnectionStrings";

        /// <summary>
        /// Default connection string name within configuration.
        /// </summary>
        public const string DefaultConnectionName = "DefaultConnection";

        /// <summary>
        /// Environment variable key for full PostgreSQL connection string.
        /// </summary>
        public const string ConnectionStringEnvVar = "RAGDEMO_DB_CONNECTION";

        /// <summary>
        /// Environment variable key for database host.
        /// </summary>
        public const string HostEnvVar = "RAGDEMO_DB_HOST";

        /// <summary>
        /// Environment variable key for database port.
        /// </summary>
        public const string PortEnvVar = "RAGDEMO_DB_PORT";

        /// <summary>
        /// Environment variable key for database name.
        /// </summary>
        public const string DatabaseNameEnvVar = "RAGDEMO_DB_NAME";

        /// <summary>
        /// Environment variable key for database username.
        /// </summary>
        public const string UserEnvVar = "RAGDEMO_DB_USER";

        /// <summary>
        /// Environment variable key for database password.
        /// </summary>
        public const string PasswordEnvVar = "RAGDEMO_DB_PASSWORD";

        /// <summary>
        /// Default fallback connection string aligned with standard local container configurations.
        /// </summary>
        public const string DefaultLocalConnectionString =
            "Host=localhost;Port=5432;Database=ragdemodb;Username=user;Password=password";
    }
}