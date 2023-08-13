using System;


namespace R5T.Z0030
{
    public class Errors : IErrors
    {
        #region Infrastructure

        public static IErrors Instance { get; } = new Errors();


        private Errors()
        {
        }

        #endregion
    }
}
