namespace UpWork.Core.Constants
{
    /// <summary>
    /// Defines the standard roles used throughout the application for authorization purposes.
    /// </summary>
    public static class ApplicationRoles
    {
        /// <summary>
        /// Administrator role with system-wide privileges.
        /// </summary>
        public const string Admin = "Admin";

        /// <summary>
        /// Client role for users who can post jobs and hire freelancers.
        /// </summary>
        public const string Client = "Client";

        /// <summary>
        /// Freelancer role for users who can apply to jobs and complete work.
        /// </summary>
        public const string Freelancer = "Freelancer";

        /// <summary>
        /// Default role assigned to newly registered users before verification.
        /// </summary>
        public const string User = "User";

        /// <summary>
        /// Returns all application roles as an array.
        /// </summary>
        public static string[] AllRoles => new[] { Admin, Client, Freelancer, User };
    }
}
