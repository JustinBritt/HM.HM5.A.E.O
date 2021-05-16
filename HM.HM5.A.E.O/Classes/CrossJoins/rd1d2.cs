namespace HM.HM5.A.E.O.Classes.CrossJoins
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;

    internal sealed class rd1d2 : Ird1d2
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rd1d2(
            ImmutableList<Ird1d2CrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Ird1d2CrossJoinElement> Value { get; }
    }
}