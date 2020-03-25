using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.KeyChar ile hangi karaktere basıldığını ascii karşılıgını bulabiliriz.
            // Sadece sayilara izin vermek için 0 ile 9 un ascii karşılığını bulmamız gerek.
            // 0'ın ascii karşılığı 48   9'un ascii karşılığı ise 57
            //Hangi tuşa basildığını hafızaya alalım

            int basilantus = Convert.ToInt32(e.KeyChar); //stringden çevirme yapmadığımız için int.parse kullanamayız.

            // Eğer 48 ile 57 arası DEĞİLSE tuş basımını iptal etmek gerekir.

            // Backspace'in çalışması için   || basilantus == 8    koşulunu ekledik.

            if (!(basilantus >= 48 && basilantus <= 57 || basilantus == 8))
            {
                // Baştaki ! işareti tüm ifadeyi tersine çevirir.

                e.Handled = true;

                // Handled = true yapmamız basılan tuşu geçersiz saymak içindir.
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece harflerin yazılmasını istiyorsak üstteki koşulun tam tersini yapmamız gerek.

            // Hangi tuşa basildığını hafızaya alalım

            int basilantus = Convert.ToInt32(e.KeyChar); //stringden çevirme yapmadığımız için int.parse kullanamayız.

            // 48 ile 57 arası tuş basımını iptal etmek gerekir. Çünkü bu sayı araları klavyede 0 ile 9 sayıların basıldığına işarettir.

            if ((basilantus >= 48 && basilantus <= 57))
            {
                // Baştaki ! işareti tüm ifadeyi tersine çevirdiği için onu kaldırdık.

                e.Handled = true;

                // Handled = true yapmamız basılan tuşu geçersiz saymak içindir.
            }
        }
    }
}
