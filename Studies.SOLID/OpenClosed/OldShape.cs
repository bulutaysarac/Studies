namespace Studies.SOLID.OpenClosed
{
    public class OldShape
    {
        public string Type { get; set; }

        public double Area()
        {
            double area = 0;

            if (Type == "Circle")
            {
                double radius = 5; //Assume a fixed radius.
                area = Math.PI * radius * radius;
            }
            else if (Type == "Rectangle")
            {
                double width = 4; //Assume a fixed width.
                double height = 6; //Assume a fixed height.
                area = width * height;
            }
            //New conditions can be added for more shape types.
            // ...

            return area;
        }

        /* In the example above, the Shape class represents any shape and performs area calculation operations. However, modifying the class itself is required to add each new shape type. This violates the Open/Closed principle because it necessitates modifying the existing class.

        For example, if we wanted to add a new shape type like a triangle, we would need to modify the Shape class. This means that the existing code needs to be changed. Consequently, adding each new shape type would require modifying the Shape class.

        To adhere to the Open/Closed principle, the Shape class should be extensible and allow for the addition of new shape types without modifying the existing code. This is often achieved using principles such as polymorphism and abstraction. */
    }
}