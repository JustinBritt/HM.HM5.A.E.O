namespace HM.HM5.A.E.O.Classes.CrossJoins
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;

    internal sealed class rd1 : Ird1
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rd1(
            ImmutableList<Ird1CrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Ird1CrossJoinElement> Value { get; }
    }
}