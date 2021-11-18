using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class WebBrowserForm : Form
    {
        public WebBrowserForm()
        {
            InitializeComponent();
            //wBrowser.Navigate("D:/DOCUMENTOS/TECNICATURA/Laboratorio ll/TP3/ctudocs/index.html");
            wBrowser.Navigate("https://litoralcreativo.github.io/ctudocs/");
        }
    }
}
