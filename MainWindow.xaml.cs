using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TecladoEGP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Boolean isUpperCase = false; // Boolean para conmprobar que esté mayusculas 
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Función que escribe la tecla correspondiente según que tecla se le haya
        /// pulsado.
        /// 
        /// -> Primero checkeamos que tecla ha sido pulsada. En función de que tecla fue
        /// pulsada, al textblock se le añadirá la palabra correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bLetterClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender; // Transforma el object en Button para trabjar en esta misma función correctamente
            string letra = button.Content.ToString(); // Pasa el content del button a un string

            tbmText.Text += letra; // Hace un append del botton substraido al textbox multilinea
        }

        private void bM_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Función que se encarga de cambiar a minusculas o mayusculas en función de su estado actual.
        /// 
        /// -> Hago un foreach de todos los objetos y sólo recojo aquellos que contengan 1 letra. En caso de
        /// estar en minuscula, cambiarán a mayuscula, y al revés en caso contrario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bShift_Click(object sender, RoutedEventArgs e)
        {

            foreach (var button in GetAllButtonsInWindow(this))
            {
                if (button.Content is string content && content.Length == 1)
                {
                    if (isUpperCase)
                    {
                        button.Content = content.ToUpper();

                    }
                    else
                    {
                        button.Content = content.ToLower();
                    }

                }
            }
            isUpperCase = !isUpperCase;
        }

        /// <summary>
        /// Recoge todos los button (a partir de una función extra)
        /// de la ventana correspondiente y los devuelve en una lista
        /// </summary>
        /// <param name="window"></param>
        /// <returns></returns>
        private IEnumerable<Button> GetAllButtonsInWindow(Window window)
        {
            var buttons = new List<Button>();
            GetAllButtons(window, buttons);
            return buttons;
        }

        /// <summary>
        /// Recoge todas las teclas existentes en la ventana
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="buttons"></param>
        private void GetAllButtons(DependencyObject parent, List<Button> buttons)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is Button button)
                {
                    buttons.Add(button);
                }
                else
                {
                    GetAllButtons(child, buttons);
                }
            }
        }

        /// <summary>
        /// Cambio solo las letras del teclado virtual para cambiarlas a numeros y signos
        /// de puntuación, y si vuelvo a usar este mismo método y ya están cambiados, vuelven
        /// a ser letras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNum_Click(object sender, RoutedEventArgs e)
        {

            foreach (var button in GetAllButtonsInWindow(this))
            {
                if (button.Content is string content && content.Length == 1)
                {
                    if (Char.IsLetter(Char.Parse(button.Content.ToString())))
                    {
                        switch (button.Name)
                        {
                            case "bQ":
                                button.Content = "0"; break;
                            case "bW":
                                button.Content = "1"; break;
                            case "bE":
                                button.Content = "2"; break;
                            case "bR":
                                button.Content = "3"; break;
                            case "bT":
                                button.Content = "4"; break;
                            case "bY":
                                button.Content = "5"; break;
                            case "bU":
                                button.Content = "6"; break;
                            case "bI":
                                button.Content = "7"; break;
                            case "bO":
                                button.Content = "8"; break;
                            case "bP":
                                button.Content = "9"; break;
                            case "bA":
                                button.Content = "!"; break;
                            case "bS":
                                button.Content = "·"; break;
                            case "bD":
                                button.Content = "$"; break;
                            case "bF":
                                button.Content = "%"; break;
                            case "bG":
                                button.Content = "&"; break;
                            case "bH":
                                button.Content = "/"; break;
                            case "bJ":
                                button.Content = "("; break;
                            case "bK":
                                button.Content = ")"; break;
                            case "bL":
                                button.Content = "="; break;
                            case "bZ":
                                button.Content = "?"; break;
                            case "bX":
                                button.Content = "¿"; break;
                            case "bC":
                                button.Content = "¡"; break;
                            case "bV":
                                button.Content = "'"; break;
                            case "bB":
                                button.Content = "+"; break;
                            case "bN":
                                button.Content = "_"; break;
                            case "bM":
                                button.Content = ":"; break;

                        }
                    }
                    else
                    {
                        switch (button.Name)
                        {
                            case "bQ":
                                button.Content = "q"; break;
                            case "bW":
                                button.Content = "w"; break;
                            case "bE":
                                button.Content = "e"; break;
                            case "bR":
                                button.Content = "r"; break;
                            case "bT":
                                button.Content = "t"; break;
                            case "bY":
                                button.Content = "y"; break;
                            case "bU":
                                button.Content = "u"; break;
                            case "bI":
                                button.Content = "i"; break;
                            case "bO":
                                button.Content = "o"; break;
                            case "bP":
                                button.Content = "p"; break;
                            case "bA":
                                button.Content = "a"; break;
                            case "bS":
                                button.Content = "s"; break;
                            case "bD":
                                button.Content = "d"; break;
                            case "bF":
                                button.Content = "f"; break;
                            case "bG":
                                button.Content = "g"; break;
                            case "bH":
                                button.Content = "h"; break;
                            case "bJ":
                                button.Content = "j"; break;
                            case "bK":
                                button.Content = "k"; break;
                            case "bL":
                                button.Content = "l"; break;
                            case "bZ":
                                button.Content = "z"; break;
                            case "bX":
                                button.Content = "x"; break;
                            case "bC":
                                button.Content = "c"; break;
                            case "bV":
                                button.Content = "v"; break;
                            case "bB":
                                button.Content = "b"; break;
                            case "bN":
                                button.Content = "n"; break;
                            case "bM":
                                button.Content = "m"; break;
                        }
                    }
                }
            }
            bShift.IsEnabled = !bShift.IsEnabled;
            if (bShift.IsEnabled)
            {
                isUpperCase = false;
            }
        }

        /// <summary>
        /// Se ocupa de borrar el último cáracter del textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bErase_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(tbmText.Text))
            {
                tbmText.Text = tbmText.Text.Substring(0, tbmText.Text.Length - 1);
            }
        }

        /// <summary>
        /// Crea un espaciado en el texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bReturn_Click(object sender, RoutedEventArgs e)
        {
            tbmText.Text += Environment.NewLine;
        }
    }
}
