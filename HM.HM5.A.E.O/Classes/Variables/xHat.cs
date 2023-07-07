namespace HM.HM5.A.E.O.Classes.Variables
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
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
            Ir r,
            Is s,
            It t)
        {
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>>> outerRedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>>>();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>> firstInnerRedBlackTree = new RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxHatResultElement>>();

                foreach (IrIndexElement rIndexElement in r.Value.Values)
                {
                    RedBlackTree<ItIndexElement, IxHatResultElement> secondInnerRedBlackTree = new RedBlackTree<ItIndexElement, IxHatResultElement>();

                    foreach (ItIndexElement tIndexElement in t.Value.Values)
                    {
                        secondInnerRedBlackTree.Add(
                            tIndexElement,
                            xHatResultElementFactory.Create(
                                sIndexElement,
                                rIndexElement,
                                tIndexElement,
                                this.GetElementAt(
                                    sIndexElement,
                                    rIndexElement,
                                    tIndexElement)));
                    }

                    firstInnerRedBlackTree.Add(
                        rIndexElement,
                        secondInnerRedBlackTree);
                }

                outerRedBlackTree.Add(
                    sIndexElement,
                    firstInnerRedBlackTree);
            }

            return xHatFactory.Create(
                outerRedBlackTree);
        }
    }
}