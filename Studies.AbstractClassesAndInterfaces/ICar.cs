namespace Studies.AbstractClassesAndInterfaces
{
    public interface ICar
    {
        int CurrentSpeed { get; set; }
        void Accelerate();
        void Deaccelerate();
    }
}