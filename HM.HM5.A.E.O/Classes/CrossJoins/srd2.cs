namespace HM.HM5.A.E.O.Classes.CrossJoins
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM5.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM5.A.E.O.Interfaces.CrossJoins;

    internal sealed class srd2 : Isrd2
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srd2(
            ImmutableList<Isrd2CrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Isrd2CrossJoinElement> Value { get; }
    }
}