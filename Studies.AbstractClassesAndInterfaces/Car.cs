namespace Studies.AbstractClassesAndInterfaces
{
    public abstract class Car : ICar
    {
        //Two properties that will behave like came from an interface. BUT they have to be overridden.
        public abstract int MaxSpeed { get; set; }
        public abstract int GearCount { get; set; }
        //A property that will behave like came from base class.
        public bool IsEngineStarted { get; set; }
        public int CurrentSpeed { get; set; } = 0;

        public void Accelerate()
        {
            CurrentSpeed += 10;
        }

        public void Deaccelerate()
        {
            CurrentSpeed -= 10;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //A method that will behave like came from base class.
        public void StartEngine()
        {
            IsEngineStarted = true;
        }

        //A method that will behave like came from an interface. BUT it has to be overridden.
        public abstract void StopEngine();
    }
}