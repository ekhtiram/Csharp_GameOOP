using System;
using System.Drawing;
using System.Windows.Forms;

namespace NDPProje
{
    public partial class Form1 : Form
    {
        AtikKutusu OrganikAtikKutusu, KagitAtikKutusu, CamAtikKutusu, MetalAtikKutusu;
        Atik camSise, bardak, gazete, dergi, domates, salatalik, kolaKutusu, salcaKutusu;

        private void btnBosaltCam_Click(object sender, EventArgs e)
        {
            if (CamAtikKutusu.Bosalt() == true)
            {
                labelPuan.Text = (CamAtikKutusu.BosaltmaPuani + Convert.ToInt32(labelPuan.Text)).ToString();
                pBarCam.Value = 0;
                labelSure.Text = (Convert.ToInt32(labelSure.Text) + 3).ToString();
                lBoxCam.Items.Clear();
            }
        }

        private void btnBosaltMetal_Click(object sender, EventArgs e)
        {
            if (MetalAtikKutusu.Bosalt() == true)
            {
                labelPuan.Text = (MetalAtikKutusu.BosaltmaPuani + Convert.ToInt32(labelPuan.Text)).ToString();
                pBarMetal.Value = 0;
                labelSure.Text = (Convert.ToInt32(labelSure.Text) + 3).ToString();
                lBoxMetal.Items.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSure.Text = (Convert.ToInt32(labelSure.Text) - 1).ToString();

            if (labelSure.Text == "0")
            {
                btnCam.Enabled = false;
                btnBosaltCam.Enabled = false;
                btnKagit.Enabled = false;
                btnBosaltKagit.Enabled = false;
                btnMetal.Enabled = false;
                btnBosaltMetal.Enabled = false;
                btnOrganik.Enabled = false;
                btnBosaltOrganik.Enabled = false;

                timer1.Enabled = false;
            }
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBosaltKagit_Click(object sender, EventArgs e)
        {
            if (KagitAtikKutusu.Bosalt() == true)
            {
                labelPuan.Text = (KagitAtikKutusu.BosaltmaPuani + Convert.ToInt32(labelPuan.Text)).ToString();
                pBarKagit.Value = 0;
                labelSure.Text = (Convert.ToInt32(labelSure.Text) + 3).ToString();
                lBoxKagit.Items.Clear();
            }
        }

        private void btnBosaltOrganik_Click(object sender, EventArgs e)
        {
            if (OrganikAtikKutusu.Bosalt() == true)
            {
                labelPuan.Text = (OrganikAtikKutusu.BosaltmaPuani + Convert.ToInt32(labelPuan.Text)).ToString();
                pBarOrganik.Value = 0;
                labelSure.Text = (Convert.ToInt32(labelSure.Text) + 3).ToString();
                lBoxOrganik.Items.Clear();
            }
        }

        private void btnMetal_Click(object sender, EventArgs e)
        {
            if (pBox.Image == kolaKutusu.Image)
            {
                if (MetalAtikKutusu.Ekle(kolaKutusu))
                {
                    MetalAtikKutusu.DolulukOrani = ((100 * MetalAtikKutusu.DoluHacim) / MetalAtikKutusu.Kapasite);
                    pBarMetal.Value = MetalAtikKutusu.DolulukOrani;

                    lBoxMetal.Items.Add("Kola kutusu ( " + kolaKutusu.Hacim.ToString() + " )");
                    labelPuan.Text = (kolaKutusu.Hacim + Convert.ToInt32(labelPuan.Text)).ToString();

                    pBox.Image = atik[_random.Next(1, 8)];
                }
            }
            else if (pBox.Image == salcaKutusu.Image)
            {
                if (MetalAtikKutusu.Ekle(salcaKutusu))
                {
                    MetalAtikKutusu.DolulukOrani = ((100 * MetalAtikKutusu.DoluHacim) / MetalAtikKutusu.Kapasite);
                    pBarMetal.Value = MetalAtikKutusu.DolulukOrani;

                    lBoxMetal.Items.Add("Salça kutusu ( " + salcaKutusu.Hacim.ToString() + " )");
                    labelPuan.Text = (salcaKutusu.Hacim + Convert.ToInt32(labelPuan.Text)).ToString();

                    pBox.Image = atik[_random.Next(1, 8)];
                }
            }
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            if (pBox.Image == camSise.Image)
            {
                if (CamAtikKutusu.Ekle(camSise))
                {
                    CamAtikKutusu.DolulukOrani = ((100 * CamAtikKutusu.DoluHacim) / CamAtikKutusu.Kapasite);
                    pBarCam.Value = CamAtikKutusu.DolulukOrani;

                    lBoxCam.Items.Add("Cam şişe ( " + camSise.Hacim.ToString() + " )");
                    labelPuan.Text = (camSise.Hacim + Convert.ToInt32(labelPuan.Text)).ToString();

                    pBox.Image = atik[_random.Next(1, 8)];
                }
            }
            else if (pBox.Image == bardak.Image)
            {
                if (CamAtikKutusu.Ekle(bardak))
                {
                    CamAtikKutusu.DolulukOrani = ((100 * CamAtikKutusu.DoluHacim) / CamAtikKutusu.Kapasite);
                    pBarCam.Value = CamAtikKutusu.DolulukOrani;

                    lBoxCam.Items.Add("Cam bardak ( " + bardak.Hacim.ToString() + " )");
                    labelPuan.Text = (bardak.Hacim + Convert.ToInt32(labelPuan.Text)).ToString();

                    pBox.Image = atik[_random.Next(1, 8)];
                }
            }
        }

        private void btnKagit_Click(object sender, EventArgs e)
        {
            if (pBox.Image ==gazete.Image)
            {
                if (KagitAtikKutusu.Ekle(gazete))
                {
                    KagitAtikKutusu.DolulukOrani = ((100 * KagitAtikKutusu.DoluHacim) / KagitAtikKutusu.Kapasite);
                    pBarKagit.Value = KagitAtikKutusu.DolulukOrani;

                    lBoxKagit.Items.Add("Gazete ( " + gazete.Hacim.ToString() + " )");
                    labelPuan.Text = (gazete.Hacim + Convert.ToInt32(labelPuan.Text)).ToString();

                    pBox.Image = atik[_random.Next(1, 8)];
                }
            }
            else if (pBox.Image == dergi.Image)
            {
                if (KagitAtikKutusu.Ekle(dergi))
                {
                    KagitAtikKutusu.DolulukOrani = ((100 * KagitAtikKutusu.DoluHacim) / KagitAtikKutusu.Kapasite);
                    pBarKagit.Value = KagitAtikKutusu.DolulukOrani;

                    lBoxKagit.Items.Add("Dergi ( " + dergi.Hacim.ToString() + " )");
                    labelPuan.Text = (dergi.Hacim + Convert.ToInt32(labelPuan.Text)).ToString();

                    pBox.Image = atik[_random.Next(1, 8)];
                }
            }
        }

        private void btnOrganik_Click(object sender, EventArgs e)
        {
            if (pBox.Image == domates.Image)
            {
                if (OrganikAtikKutusu.Ekle(domates))
                {
                    OrganikAtikKutusu.DolulukOrani = ((100 * OrganikAtikKutusu.DoluHacim) / OrganikAtikKutusu.Kapasite);
                    pBarOrganik.Value = OrganikAtikKutusu.DolulukOrani;

                    lBoxOrganik.Items.Add("Domates ( " + domates.Hacim.ToString() + " )");
                    labelPuan.Text = (domates.Hacim + Convert.ToInt32(labelPuan.Text)).ToString();

                    pBox.Image = atik[_random.Next(1, 8)];
                }
            }
            else if (pBox.Image == salatalik.Image)
            {
                if (OrganikAtikKutusu.Ekle(salatalik))
                {
                    OrganikAtikKutusu.DolulukOrani = ((100 * OrganikAtikKutusu.DoluHacim) / OrganikAtikKutusu.Kapasite);
                    pBarOrganik.Value = OrganikAtikKutusu.DolulukOrani;

                    lBoxOrganik.Items.Add("Salatalık ( " + salatalik.Hacim.ToString() + " )");
                    labelPuan.Text = (salatalik.Hacim + Convert.ToInt32(labelPuan.Text)).ToString();

                    pBox.Image = atik[_random.Next(1, 8)];
                }
            }
        }

        Image[] atik = new Image[8];
        Random _random = new Random();
        public Form1()
        {
            InitializeComponent();

            camSise = new Atik();
            camSise.Hacim = 600;
            camSise.Image = Image.FromFile("camSise.jpg");
            atik[0] = camSise.Image;

            bardak = new Atik();
            bardak.Hacim = 250;
            bardak.Image = Image.FromFile("bardak.jpg");
            atik[1] = bardak.Image;

            gazete = new Atik();
            gazete.Hacim = 250;
            gazete.Image = Image.FromFile("gazete.jpg");
            atik[2]=gazete.Image;

            dergi = new Atik();
            dergi.Hacim = 200;
            dergi.Image = Image.FromFile("dergi.jpg");
            atik[3] = dergi.Image;

            domates = new Atik();
            domates.Hacim = 150;
            domates.Image = Image.FromFile("domates.jpg");
            atik[4] = domates.Image;

            salatalik = new Atik();
            salatalik.Hacim = 120;
            salatalik.Image = Image.FromFile("salatalik.jpg");
            atik[5]=salatalik.Image;

            kolaKutusu = new Atik();
            kolaKutusu.Hacim = 350;
            kolaKutusu.Image = Image.FromFile("kolaKutusu.jpg");
            atik[6]=kolaKutusu.Image;

            salcaKutusu = new Atik();
            salcaKutusu.Hacim = 550; 
            salcaKutusu.Image = Image.FromFile("salcaKutusu.jpg");
            atik[7] = salcaKutusu.Image;

            OrganikAtikKutusu = new AtikKutusu();
            OrganikAtikKutusu.BosaltmaPuani = 0; 
            OrganikAtikKutusu.Kapasite = 700;
            OrganikAtikKutusu.DoluHacim = 0;
            OrganikAtikKutusu.DolulukOrani = 0;
            
            KagitAtikKutusu = new AtikKutusu();
            KagitAtikKutusu.BosaltmaPuani = 1000; 
            KagitAtikKutusu.Kapasite = 1200;
            KagitAtikKutusu.DoluHacim = 0;
            KagitAtikKutusu.DolulukOrani = 0;

            CamAtikKutusu = new AtikKutusu();
            CamAtikKutusu.BosaltmaPuani = 600;
            CamAtikKutusu.Kapasite = 2200;
            CamAtikKutusu.DoluHacim = 0;
            CamAtikKutusu.DolulukOrani = 0;

            MetalAtikKutusu = new AtikKutusu();
            MetalAtikKutusu.BosaltmaPuani = 800;
            MetalAtikKutusu.Kapasite = 2300;
            MetalAtikKutusu.DoluHacim = 0;
            MetalAtikKutusu.DolulukOrani = 0;
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            lBoxCam.Items.Clear();
            lBoxKagit.Items.Clear();
            lBoxMetal.Items.Clear();
            lBoxOrganik.Items.Clear();

            labelPuan.Text = "0";
            labelSure.Text = "60";

            pBarCam.Value = 0;
            pBarKagit.Value = 0;
            pBarMetal.Value = 0;
            pBarOrganik.Value = 0;

            btnCam.Enabled = true;
            btnBosaltCam.Enabled = true;
            btnKagit.Enabled = true;
            btnBosaltKagit.Enabled = true;
            btnMetal.Enabled = true;
            btnBosaltMetal.Enabled = true;
            btnOrganik.Enabled = true;
            btnBosaltOrganik.Enabled = true;

            OrganikAtikKutusu.DoluHacim = 0;
            MetalAtikKutusu.DoluHacim = 0;
            KagitAtikKutusu.DoluHacim = 0;
            CamAtikKutusu.DoluHacim = 0;

            pBox.Image = atik[_random.Next(1, 8)];
            timer1.Enabled = true;
        }


    }
}
