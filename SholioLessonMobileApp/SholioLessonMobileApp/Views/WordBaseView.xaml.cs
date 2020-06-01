using SholioLessonMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SholioLessonMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WordBaseView : ContentPage
    {
        public List<Meaning> meaning;
        public WordBaseView()
        {
            InitializeComponent();
            Data();
            WordBaseListView.ItemsSource = meaning;
        }

        public void Data()
        {
            //Display temp data
            meaning = new List<Meaning>
            {
                new Meaning {Word="Ākwi", Translation="Cat", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="abok.3gpp"},
                new Meaning {Word="Ākwon", Translation="Tree", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="akwon.3gpp"},
                new Meaning {Word="Āpsiāh/Āpyia ", Translation="Head", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="apyia.3gpp"},
                new Meaning {Word="Ātyem", Translation="Hoe", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="atyem.3gpp"},
                new Meaning {Word="Ābaai", Translation="Knife", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="abaai.3gpp"},
                new Meaning {Word="Ābyin", Translation="Ground", RelatedWord="Mbyin",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="abyin.3gpp"},
                new Meaning {Word="Āte", Translation="Bow", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="ate.3gpp"},
                new Meaning {Word="Āli", Translation="House", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="alii.3gpp"},
                new Meaning {Word="Āghyi", Translation="Eyes", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="aghyi.3gpp"},
                new Meaning {Word="Ābwu", Translation="Dog", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="abwu.3gpp"},
                new Meaning {Word="Ākyetuk", Translation="Dark", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="akyetuk.3gpp"},
                new Meaning {Word="Āban", Translation="Welcome", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="aban.3gpp"},
                new Meaning {Word="Ābam", Translation="Fishing", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="abam.3gpp"},
                new Meaning {Word="Ābejeijei", Translation="Nomadic Fulani", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="abejeijei.3gpp"},
                new Meaning {Word="Ābibyai", Translation="Head board", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="abibyai.3gpp"},
                new Meaning {Word="Ābii", Translation="Grave", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="abii.3gpp"},
                new Meaning {Word="Ābiyen", Translation="Breast", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="abiyen.3gpp"},
                new Meaning {Word="Ābok", Translation="Native Doctor", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="abok.3gpp"},
                new Meaning {Word="Ābuk", Translation="Locust beans", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip="abuk.3gpp"},
                new Meaning {Word="Ābuk-ayin ", Translation="Foolish person", RelatedWord="",
                    ImageUrl="https://res.cloudinary.com/gidmak/image/upload/c_thumb,h_162,q_auto,r_100/v1587747183/logo_rx95bi.png", AudioClip=""},
            };
        }

        private void WordSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                WordBaseListView.ItemsSource = meaning;
            }
            else
            {
                WordBaseListView.ItemsSource = meaning.Where(x => x.Word.StartsWith(e.NewTextValue));
            }
        }

        private void WordBaseListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMeaning = e.SelectedItem as Meaning;
            await this.Navigation.PushAsync(new WordBaseDetailView(selectedMeaning));
        }
    }
}