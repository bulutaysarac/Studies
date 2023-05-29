namespace Studies.AbstractClassesAndInterfaces
{
    public class Mercedes : Car
    {
        //Abstract properties that came from base abstract class.
        public override int MaxSpeed { get; set; } = 310;
        public override int GearCount { get; set; } = 6;

        //Abstract method that came from base abstract class.
        public override void StopEngine()
        {
            //Standart property that came from base abstract class.
            IsEngineStarted = false;
        }
    }
}