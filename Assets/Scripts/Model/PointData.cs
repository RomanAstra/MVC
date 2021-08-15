namespace Model
{
    public sealed class PointData : IPointData
    {
        public int CurrentPoint { get; }
        
        public PointData(int currentPoint)
        {
            CurrentPoint = currentPoint;
        }
    }
}
