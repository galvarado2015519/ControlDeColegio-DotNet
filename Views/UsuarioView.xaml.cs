using System.Windows;
using ControlDeColegio.ModelView;
using MahApps.Metro.Controls;

namespace ControlDeColegio.Views
{
    public partial class UsuarioView : MetroWindow
    {
        public UsuarioView(UsuariosViewModel UsuariosViewModel)
        {
            InitializeComponent();
            UsuarioViewModel model =  new UsuarioViewModel(UsuariosViewModel);
            this.DataContext = model;
            
        }
    }
}