namespace MauiAppGradiantBorder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private Brush? _gradiantPurpleBrush => App.Current.Resources.TryGetValue("PurpleGradiant", out object laColor) ? (Brush)laColor : null;
        private Brush? _gradiantGreyBrush => App.Current.Resources.TryGetValue("GreyFakeGradiant", out object laColor) ? (Brush)laColor : null;

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            if (laBorderGradiant.Stroke == _gradiantPurpleBrush)
                laBorderGradiant.Stroke = _gradiantGreyBrush;
            else
                laBorderGradiant.Stroke = _gradiantPurpleBrush;
        }

        private void TapGestureRecognizer_Tapped2(object sender, TappedEventArgs e)
        {
            if (laBorderFailedSolidBrush.Stroke == _gradiantPurpleBrush)
                laBorderFailedSolidBrush.Stroke = Colors.Gray;
            else
                laBorderFailedSolidBrush.Stroke = _gradiantPurpleBrush;
        }
    }

}
