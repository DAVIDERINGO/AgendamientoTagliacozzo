using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Net.Http;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace AgendamientoTagliacozzo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ingreso : ContentPage
    {
        private const string Url = "http://192.168.1.43/moviles/post1.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<AgendamientoTagliacozzo.DatosUsuario> _post;


        public Ingreso()
        {
            InitializeComponent();
        }
        public static IEnumerable<T_Registro> SELECT_WHERE(SQLiteConnection db, string usuario, string contra)
        {
            db.CreateTable<T_Registro>();
            return db.Query<T_Registro>("SELECT * FROM T_Registro where Usuario = ? and Contrasenia = ?", usuario, contra);

        }
        private async void btnValidar_Clicked(object sender, EventArgs e)
        {
            /*string usuario = txtDato1.Text;
            string clave = txtDato2.Text;
            if (usuario == "estudiante2021" && clave == "uisrael2021")
            {
                await Navigation.PushAsync(new PedidoMedico(usuario));
            }
            else
            {
                await Navigation.PushAsync(new EnvioCorreo());
            }


            var content = await client.GetStringAsync(Url);
            List<AgendamientoTagliacozzo.DatosUsuario> posts = JsonConvert.DeserializeObject<List<AgendamientoTagliacozzo.DatosUsuario>>(content);
            _post = new ObservableCollection<AgendamientoTagliacozzo.DatosUsuario>(posts);

            MyListView.ItemsSource = _post;
            */


            //try
            //{
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MySQLite.db3");
            var db = new SQLiteConnection(databasePath);

            IEnumerable<T_Registro> resultado = SELECT_WHERE(db, txtDato1.Text, txtDato2.Text);
            if (resultado.Count() > 0)
            {
                string usuario = txtDato1.Text;
                await Navigation.PushAsync(new PedidoMedico(usuario));
                txtDato1.Text = "";
                txtDato2.Text = "";
            }
            else
            {
                DisplayAlert("Error", "Genere solicitud de registro", "Ok");
                await Navigation.PushAsync(new EnvioCorreo());
                txtDato1.Text = "";
                txtDato2.Text = "";
            }
            //}catch (Exception)
            // {

            // }

        }

        private async void btnUbicacion_Clicked(object sender, EventArgs e)
        {
            await Map.OpenAsync(-0.16314, -78.47891, new MapLaunchOptions
            {
                Name = txtNombreUbica.Text,
                NavigationMode = NavigationMode.None
            });
        }

        private  void btn_Registrar_Clicked(object sender, EventArgs e)
        {
            txtDato1.Text = "";
            txtDato2.Text = "";
            Navigation.PushAsync(new RegistroUsuario());
        }
    }
}