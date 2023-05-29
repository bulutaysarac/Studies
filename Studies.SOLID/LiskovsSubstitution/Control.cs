namespace Studies.SOLID.LiskovsSubstitution
{
    public class Control
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Visible { get; set; }

        public virtual void Draw()
        {
            //Operations to draw control.
        }
    }
}