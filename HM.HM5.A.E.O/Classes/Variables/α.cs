namespace HM.HM5.A.E.O.Classes.Variables
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Indices;
    using HM.HM5.A.E.O.Interfaces.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.Interfaces.Variables;
    using HM.HM5.A.E.O.InterfacesFactories.ResultElements.OperatingRoomDayDaySwapAssignments;
    using HM.HM5.A.E.O.InterfacesFactories.Results.OperatingRoomDayDaySwapAssignments;

    internal sealed class α : Iα
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public α(
            VariableCollection<IrIndexElement, Id1IndexElement, Id2IndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IrIndexElement, Id1IndexElement, Id2IndexElement> Value { get; }

        public bool GetElementAt(
            IrIndexElement rIndexElement,
            Id1IndexElement d1IndexElement,
            Id2IndexElement d2IndexElement)
        {
            bool value = false;

            if (this.Value[rIndexElement, d1IndexElement, d2IndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.OperatingRoomDayDaySwapAssignments.Iα GetElementsAt(
            IαResultElementFactory αResultElementFactory,
            IαFactory αFactory,
            Id1 d1,
            Id2 d2,
            Ir r)
        {
            RedBlackTree<IrIndexElement, RedBlackTree<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>>> outerRedBlackTree = new();

            foreach (IrIndexElement rIndexElement in r.Value.Values)
            {
                RedBlackTree<Id1IndexElement, RedBlackTree<Id2IndexElement, IαResultElement>> firstInnerRedBlackTree = new();

                foreach (Id1IndexElement d1IndexElement in d1.Value.Values)
                {
                    RedBlackTree<Id2IndexElement, IαResultElement> secondInnerRedBlackTree = new();

                    foreach (Id2IndexElement d2IndexElement in d2.Value.Values)
                    {
                        secondInnerRedBlackTree.Add(
                            d2IndexElement,
                            αResultElementFactory.Create(
                                rIndexElement,
                                d1IndexElement,
                                d2IndexElement,
                                this.GetElementAt(
                                    rIndexElement,
                                    d1IndexElement,
                                    d2IndexElement)));
                    }

                    firstInnerRedBlackTree.Add(
                        d1IndexElement,
                        secondInnerRedBlackTree);
                }

                outerRedBlackTree.Add(
                    rIndexElement,
                    firstInnerRedBlackTree);
            }

            return αFactory.Create(
                outerRedBlackTree);
        }
    }
}