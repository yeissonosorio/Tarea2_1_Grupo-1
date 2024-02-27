using System.Collections.ObjectModel;

namespace Tarea2_1_Grupo_1
{
    public partial class MainPage : ContentPage
    {

        public ObservableCollection<Models.CountryInfo> Posts { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Posts = new ObservableCollection<Models.CountryInfo>();
            LoadData();
        }

        public async void LoadData()
        {
            var posts = await Controllers.Controls.GetPosts();
            if (posts != null)
            {
                foreach (var post in posts)
                {
                    Posts.Add(post);
                }
            }
            else
            {

            }
        }

    }

}
