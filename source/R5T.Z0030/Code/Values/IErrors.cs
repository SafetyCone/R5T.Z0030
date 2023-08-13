using System;

using R5T.T0131;
using R5T.T0162;
using R5T.T0162.Extensions;


namespace R5T.Z0030
{
    [ValuesMarker]
    public partial interface IErrors : IValuesMarker
    {
        public IError Error01 => "!:System.Linq.XElementExtensions.y".ToError();
    }
}
