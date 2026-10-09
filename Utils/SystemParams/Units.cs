namespace Structural_Automation.Utils.SystemParams
{
    public class Units(LengthUnit unit = LengthUnit.Meters)
    {
        public LengthUnit Unit { get; private set; } = unit;
    }
}
