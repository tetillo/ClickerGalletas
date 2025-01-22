namespace App
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

            count++;
            GalletaCountLabel.Text = $"Galleta clickada veces: {count}";

            var animation = new Animation(v => Galletabutton.Scale = v, 1, 0.8, Easing.CubicInOut);
            animation.Commit(Galletabutton, "ScaleUp", length: 100, finished: (v, c) =>
            {

                var resetAnimation = new Animation(v => Galletabutton.Scale = v, 0.8, 1, Easing.CubicInOut);
                resetAnimation.Commit(Galletabutton, "ScaleDown", length: 100);
            });

            if (count % 100 == 0)
            {
                DisplayAlert("¡Enhorabuena!", "Has conseguido " + count + " galletas", "OK");
            }
        }


    }
}


