namespace Studies.SOLID.LiskovsSubstitution
{
    public class TextBox : Control
    {
        public string Text { get; set; }

        public override void Draw()
        {
            //Operations to draw TextBox. 
        }

        //This method breaks the Liskov's Substitution.
        //public void ClearText()
        //{
        //    //Clear text.
        //}
    }
}