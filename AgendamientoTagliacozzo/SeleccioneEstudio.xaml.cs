using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendamientoTagliacozzo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeleccioneEstudio : ContentPage
    {
        public SeleccioneEstudio(string usuario)
        {
            InitializeComponent();
            lblUser.Text =  usuario;
            Estudios.Items.Add("TOMOGRAFIA SIMPLE DE TORAX");
            Estudios.Items.Add("TOMOGRAFIA CONTRASTADA DE TORAX");
            Estudios.Items.Add("TOMOGRAFIA TORAX CON CONTRASTE");
            Estudios.Items.Add("TOMOGRAFIA TORAX CON 3D");
            Estudios.Items.Add("TOMOGRAFIA DE CRANEO");
            Estudios.Items.Add("ECOGRAFIA DE HIGADO");
            Estudios.Items.Add("ECOGRAFIA PELVICA");
            Estudios.Items.Add("ECOGRAFIA RENAL");
            Estudios.Items.Add("ECOGRAFIA CARDIACA");
            Estudios.Items.Add("DENSITOMETRIA OSEA");
            Estudios.Items.Add("ECOGRAFIA DE MUÑECA");
            Estudios.Items.Add("RAYOS X DE COLUMNA");
            Estudios.Items.Add("RAYOS X DE BRAZO");
            Estudios.Items.Add("RAYOS X DE PIERNA AP Y LATERAL");
            Estudios.Items.Add("RAYOS X EXTREMIDADES SUPERIORES");
            Estudios.Items.Add("RAYOS X TOBILLO");
            Estudios.Items.Add("RESONANCIA CEREBRAL");
            Estudios.Items.Add("RESONANCIA LUMBAR");
            Estudios.Items.Add("RESONANCIA COLUMNA");
            Estudios.Items.Add("RESONANCIA DE HOMBRO");
            Estudios.Items.Add("RESONANCIA EXTREMIDADES INFERIORES");
            Estudios.Items.Add("RESONANCIA EXTREMIDADES SUPERIORES");
            Estudios.Items.Add("RESONANCIA DE ABDOMEN");
            Estudios.Items.Add("PANORAMICO DENTAL");
            Estudios.Items.Add("MAMOGRAFIA 2D");
            Estudios.Items.Add("MAMOGRAFIA CON TOMOSINTESIS");
            Estudios.Items.Add("MAMOGRAFIA CON BIOPSIA");
            
        }

        private async  void btnSeleccionarHorario_Clicked(object sender, EventArgs e)
        {
            var usuario = lblUser.Text;
            var estudioenvia = Estudios.Items[Estudios.SelectedIndex];
            await Navigation.PushAsync(new SeleccioneFecha(usuario, estudioenvia));
            var estudio = Estudios.Items[Estudios.SelectedIndex];
            DisplayAlert(estudio, "Estudio Seleccionado", "Aceptar");
        }
    }
}