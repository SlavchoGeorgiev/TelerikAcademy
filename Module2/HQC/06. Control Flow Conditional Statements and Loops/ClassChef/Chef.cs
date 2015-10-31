namespace ClassChef
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);
            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);
            Bowl bowl = this.GetBowl();
            this.bowl.Add(potato);
            this.bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            //... 
        }

        private Carrot GetCarrot()
        {
            //...
        }

        private Potato GetPotato()
        {
            //...
        }

        private void Cut(Vegetable potato)
        {
            //...
        }
    }
}
