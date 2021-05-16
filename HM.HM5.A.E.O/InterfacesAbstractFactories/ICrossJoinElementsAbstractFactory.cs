namespace HM.HM5.A.E.O.InterfacesAbstractFactories
{
    using HM.HM5.A.E.O.InterfacesFactories.CrossJoinElements;

    public interface ICrossJoinElementsAbstractFactory
    {
        Ird1CrossJoinElementFactory Createrd1CrossJoinElementFactory();

        Ird1d2CrossJoinElementFactory Createrd1d2CrossJoinElementFactory();

        Ird2CrossJoinElementFactory Createrd2CrossJoinElementFactory();

        IrtCrossJoinElementFactory CreatertCrossJoinElementFactory();

        IslCrossJoinElementFactory CreateslCrossJoinElementFactory();

        IslΛCrossJoinElementFactory CreateslΛCrossJoinElementFactory();

        IsrCrossJoinElementFactory CreatesrCrossJoinElementFactory();

        Isrd2CrossJoinElementFactory Createsrd2CrossJoinElementFactory();

        Isrd2tCrossJoinElementFactory Createsrd2tCrossJoinElementFactory();

        IsrtCrossJoinElementFactory CreatesrtCrossJoinElementFactory();

        IstCrossJoinElementFactory CreatestCrossJoinElementFactory();

        IsΛCrossJoinElementFactory CreatesΛCrossJoinElementFactory();

        ItΛCrossJoinElementFactory CreatetΛCrossJoinElementFactory();
    }
}