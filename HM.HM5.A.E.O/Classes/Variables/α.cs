namespace HM.HM5.A.E.O.Classes.Variables
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM5.A.E.O.Interfaces.IndexElements;
    using HM.HM5.A.E.O.Interfaces.Variables;

    internal sealed class α : Iα
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public α(
            VariableCollection<IrIndexElement, Id1IndexElement, Id2IndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IrIndexElement, Id1IndexElement, Id2IndexElement> Value { get; }
    }
}