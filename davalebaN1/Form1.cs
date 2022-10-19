using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davalebaN1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Studenti obj_student = new Studenti();
            obj_student.universiteti = textBox1.Text;
            obj_student.kursi = int.Parse(textBox2.Text);
            label1.Text = obj_student.universiteti + "   " + obj_student.kursi.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Matarebeli obj_matarebeli = new Matarebeli();
            obj_matarebeli.fasi = int.Parse(textBox1.Text);
            obj_matarebeli.gayiduli_bil_raod = int.Parse(textBox2.Text);
            label1.Text = obj_matarebeli.fasi + "  " + obj_matarebeli.gayiduli_bil_raod;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Samkutxedi obj_samkutxedi = new Samkutxedi();
            obj_samkutxedi.gverdi1 = int.Parse(textBox3.Text);
            obj_samkutxedi.gverdi2 = int.Parse(textBox4.Text);
            obj_samkutxedi.gverdi3 = int.Parse(textBox5.Text);
            label2.Text = " gverdi1 - " + obj_samkutxedi.gverdi1 + " gverdi2 - " + obj_samkutxedi.gverdi2 + " gverdi3 - " + obj_samkutxedi.gverdi3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Avtomanqana obj_manqana = new Avtomanqana();
            obj_manqana.mflob_gvari = textBox1.Text;
            obj_manqana.gamomshv_firma = textBox2.Text;
            label1.Text = obj_manqana.mflob_gvari + "  " + obj_manqana.gamomshv_firma;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Matarebeli obj_matarebeli = new Matarebeli();
            int vagonebis_raod, mgzavrebis_raod_1, gayiduli_bil_raod;
            double fasi, tanxa;
            vagonebis_raod = int.Parse(textBox6.Text);
            mgzavrebis_raod_1 = int.Parse(textBox7.Text);
            fasi = double.Parse(textBox8.Text);
            gayiduli_bil_raod = int.Parse(textBox9.Text);
            obj_matarebeli.Minicheba(vagonebis_raod, mgzavrebis_raod_1, fasi, gayiduli_bil_raod);
            obj_matarebeli.Gamotana(label3);
            tanxa = obj_matarebeli.Tanxa();
            label4.Text = tanxa.ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Kvadrati obj_kvadrati = new Kvadrati();
            int gverdi1, fartobi;
            gverdi1 = int.Parse(textBox10.Text);
            obj_kvadrati.Minicheba(gverdi1);
            obj_kvadrati.Gamotana(label5);
            fartobi = obj_kvadrati.Fartobi();
            label6.Text = fartobi.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Studenti obj_studenti = new Studenti();
            string a, b;
            int c;
            a = textBox11.Text;
            b = textBox12.Text;
            c = int.Parse(textBox13.Text);
            obj_studenti.Minicheba(a, b, c);
            obj_studenti.Gamotana2(label7);

        }
        private void button8_Click(object sender, EventArgs e)
        {
            Studenti obj_studenti = new Studenti();
            string a, b;
            int c;
            a = textBox11.Text;
            b = textBox12.Text;
            c = int.Parse(textBox13.Text);
            obj_studenti.Mnishvnelobebi(textBox11, textBox12, textBox13);
            obj_studenti.Gamotana2(label7);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Tvitmprinavi obj_tvitmprinavi = new Tvitmprinavi();
            obj_tvitmprinavi.mgzavrebis_raod = int.Parse(textBox1.Text);
            obj_tvitmprinavi.gayiduli_bil_raod = int.Parse(textBox2.Text);
            label1.Text = obj_tvitmprinavi.mgzavrebis_raod + "  " + obj_tvitmprinavi.gayiduli_bil_raod;
            
        }
    }
}


namespace davalebaN1
{
    class Tvitmprinavi
    {
        private int bakis_tevadoba_1, mandzili_1;
        public int mgzavrebis_raod, gayiduli_bil_raod;
    }
    class Studenti
    {
        private string saxeli, gvari;
        private int asaki;
        public string universiteti;
        public int kursi;
        public void Minicheba(String a, String b, int c)
        {
            saxeli = a;
            gvari = b;
            asaki = c;
        }
        private void Mincheba_Private(String a, String b, int c)
        {
            saxeli = a;
            gvari = b;
            asaki = c;
        }
        public void Mnishvnelobebi(TextBox text1, TextBox text2, TextBox text3)
        {
            String a = text1.Text;
            String b = text2.Text;
            int c = int.Parse(text3.Text);
            Mincheba_Private(a, b, c);
        }
        public void Gamotana2(Label lab1)
        {
            lab1.Text = saxeli + "\n" +
                gvari + "\n" +
                asaki.ToString() + "\n";
        }
    }

    class Matarebeli
    {
        private int vagonebis_raod, mgzavrebis_raod_1;
        public double fasi;
        public int gayiduli_bil_raod;
        public void Minicheba(int p1, int p2, double p3, int p4)
        {
            vagonebis_raod = p1;
            mgzavrebis_raod_1 = p2;
            fasi = p3;
            gayiduli_bil_raod = p4;
        }
        public void Gamotana(Label lab1)
        {
            lab1.Text = vagonebis_raod.ToString() + "\n" +
            mgzavrebis_raod_1.ToString() + "\n" +
            fasi.ToString() + "\n" +
            gayiduli_bil_raod.ToString();
        }
        public double Tanxa()
        {
            return fasi * gayiduli_bil_raod;
        }

    }

    class Kvadrati
    {
        public int gverdi1;
        int fartobi;
        public void Minicheba(int p1)
        {
            gverdi1 = p1;
        }
        public void Gamotana(Label lab1)
        {
            lab1.Text = gverdi1.ToString();
        }
        public int Fartobi()
        {
            fartobi = gverdi1 * gverdi1;
            return fartobi;
        }
    }

    class Avtomanqana
    {
        private string feri;
        private int fartokarebis_raod;
        public string mflob_gvari, gamomshv_firma;
    }

    class Samkutxedi
    {
        private int perimetri, fartobi;
        public int gverdi1, gverdi2, gverdi3;
    }

}



