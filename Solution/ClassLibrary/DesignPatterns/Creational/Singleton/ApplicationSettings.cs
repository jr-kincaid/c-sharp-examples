namespace ClassLibrary.DesignPatterns.Creational.Singleton
{
    public class ApplicationSettings
    {
        /// <summary>
        /// Single shared instance.
        /// </summary>
        private static ApplicationSettings? _Instance = null;

        /// <summary>
        /// In order for it to be thread safe its needs a private object to lock.
        /// </summary>
        private static readonly object _Lock = new();


        /// <summary>
        /// Constructor is private for Singleton to Encourage folks to use the GetInstance Method.
        /// </summary>
        private ApplicationSettings(DateTime startDate, string name)
        {
            StartDate = startDate;
            Name = name;
        }

        /// <summary>
        /// In Keeping with the Singleton Pattern, Get Instance Method generates a User Setting Once per Application Run. 
        /// </summary>
        /// <param name="startDate">Start Date</param>
        /// <param name="applicationName">Application Name</param>
        public static ApplicationSettings GetInstance(DateTime startDate, string applicationName)
        {
            lock(_Lock)
            {
                _Instance ??= new ApplicationSettings(startDate, applicationName);
            }
            return _Instance;
        }

        /// <summary>
        /// The Start Date of the Current Application Instance.
        /// </summary>
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// Application Name
        /// </summary>
        public string Name { get; private set; }
    }
}
