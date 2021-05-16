namespace HM.HM5.A.E.O.Classes.Variables
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.CrossJoins;
    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Variables;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;

    internal sealed class xHat : IxHat
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xHat(
            VariableCollection<IsIndexElement, IrIndexElement, ItIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, IrIndexElement, ItIndexElement> Value { get; }

        public bool GetElementAt(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            bool value = false;

            if (this.Value[sIndexElement, rIndexElement, tIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.SurgeonOperatingRoomDayAssignments.IxHat GetElementsAt(
            IxHatResultElementFactory xHatResultElementFactory,
            IxHatFactory xHatFactory,
            Isrt srt)
        {
            return xHatFactory.Create(
                srt.Value
                .Select(
                    i => xHatResultElementFactory.Create(
                        i.sIndexElement,
                        i.rIndexElement,
                        i.tIndexElement,
                        this.GetElementAt(
                            i.sIndexElement,
                            i.rIndexElement,
                            i.tIndexElement)))
                .ToImmutableList());
        }
    }
}