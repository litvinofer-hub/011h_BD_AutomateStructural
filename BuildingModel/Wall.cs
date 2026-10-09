using Structural_Automation.Utils.Geometry;

namespace Structural_Automation.BuildingModel
{
    /// <summary>
    /// A vertical rectangular wall, described by the rectangle running through the
    /// middle of the box. That rectangle stands vertically, with one edge parallel to
    /// Z giving the height and the other parallel to the XY plane giving the length,
    /// so the wall length may sit at any angle in XY plane. Thickness spreads half to
    /// either side.
    /// </summary>
    public class Wall(Rectangle midSurface, double thickness)
        : VerticalBox(midSurface, thickness), IFlattenable
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        /// <summary>
        /// Returns the four corners of the mid-surface, the wall flattened. For the eight
        /// corners of the wall itself, see <see cref="Box.GetCorners"/>.
        /// </summary>
        public IEnumerable<Point3d> GetFlatBuildingPoints()
        {
            return MidSurface.GetCorners();
        }

        public override bool Equals(object? obj)
        {
            return obj is Wall other && Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
