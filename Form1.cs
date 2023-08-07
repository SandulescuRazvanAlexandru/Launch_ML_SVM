using ControlUtilizator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lansare_ML_SVM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            tbMes.Clear();

            var proc = new Process();

            proc.StartInfo.FileName = "D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\mySvmTrain\\Debug\\mySvmTrain.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;

            proc.Start();
            var sw = proc.StandardInput;
            var sr = proc.StandardOutput;
            sw.WriteLine("D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\mySvmTrain\\Debug\\Data_Set.txt");
            sw.WriteLine("D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\mySvmTrain\\Debug\\Data_Set.model"); 
            sw.Close();
            proc.WaitForExit();
            string output = null;
            while ((output = sr.ReadLine()) != null) 
            {
                tbMes.Text += "\r\n" + output;
            }
            proc.Close();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            tbMes.Clear();

            var proc = new Process();

            proc.StartInfo.FileName = "D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\MySvmTest\\Debug\\MySvmTest.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;

            proc.Start();
            var sw = proc.StandardInput;
            var sr = proc.StandardOutput;

            // param 1
            sw.WriteLine("D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\MySvmTest\\Debug\\Data_Set_For_Test.txt"); 
            // .model creat la train
            sw.WriteLine("D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\mySvmTrain\\Debug\\Data_Set.model");
            // rezultat.txt
            sw.WriteLine("D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\MySvmTest\\Debug\\rezultat.txt");

            sw.Close();
            proc.WaitForExit();
            string output = null;
            while ((output = sr.ReadLine()) != null) // citesc ce a zis cout in C++
            {
                tbMes.Text += "\r\n" + output;
            }
            proc.Close();
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            tbMes.Clear();

            var proc = new Process();

            proc.StartInfo.FileName = "D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\MySvmPredict\\Debug\\MySvmPredict.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;

            proc.Start();
            var sw = proc.StandardInput;
            var sr = proc.StandardOutput;
            
            // creating the file 
            var originalFilePath = "D:\\Aplicatie_Disertatie\\TestProcese\\TestProcese\\bin\\Debug\\ransomware.txt";
            var newFilePath = "D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\MySvmPredict\\Debug\\Data_Set_For_Predict.txt";

            using (var srr = new StreamReader(originalFilePath))
            using (var sww = new StreamWriter(newFilePath))
            {
                string line;
                // Regex pattern to match the lines like "-1 1:2 2:1 3:6 4:1 5:1"
                var pattern = new Regex(@"^-1 1:\d+ 2:\d+ 3:\d+ 4:\d+ 5:\d+$");

                while ((line = srr.ReadLine()) != null)
                {
                    if (pattern.IsMatch(line))
                    {
                        sww.WriteLine(line);
                    }
                }
            }

            // param 1
            sw.WriteLine("D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\MySvmPredict\\Debug\\Data_Set_For_Predict.txt");

            // .model creat la train
            sw.WriteLine("D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\mySvmTrain\\Debug\\Data_Set.model");
            // predict.txt
            sw.WriteLine("D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\MySvmPredict\\Debug\\predict.txt");

            sw.Close();
            proc.WaitForExit();
            string output = null;
            while ((output = sr.ReadLine()) != null) // citesc ce a zis cout in C++
            {
                tbMes.Text += "\r\n" + output;
            }
            proc.Close();
        }

        TipVector tip = TipVector.SIMPLU;
        private void btnPointsVis_Click(object sender, EventArgs e)
        {
            System.IO.Stream fileStream = null;
            OpenFileDialog ofd = new OpenFileDialog();
            string fisier = "D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\mySvmTrain\\Debug\\Data_Set_For_Graphic_Complex.txt";
            ofd.FileName = fisier; fileStream = ofd.OpenFile();

            DateVectoriale dateVect = new DateVectoriale(fileStream, tip);
            // partea de adte
            // citeste din fisier puncte cu 3 coordonate si adauga in pointList

            VizualizareDate afisareGrafic = new VizualizareDate();
            // partea grafica: tine panel grafic + dialog setari grafic + grid tabela
            // form-ul din app consumator necesita using ControlUtilizator;

            afisareGrafic.Grafic.C3DrawChart.ChartType = TipuriDeGrafice.ChartTypeEnum.NorDePuncte;
            afisareGrafic.Grafic.C3DataSeries = dateVect.CopyWithNewList();

            afisareGrafic.date = Vector3D.CopyList(afisareGrafic.Grafic.C3DataSeries.PointList);

            afisareGrafic.ShowDialog();
        }

        private void btn3DFunctions_Click(object sender, EventArgs e)
        {
            VizualizareFunctii vizualizareFunctii = new VizualizareFunctii();
            // form din app consumator; necesita using ControlUtilizator;
            // tine panel grafic + dialog setari grafic + radio alegere functii

            vizualizareFunctii.Show();
        }

        // TipVector tip2 = TipVector.SIMPLU;
        TipVector tip2 = TipVector.CALITATIV; //cele 3 plus clasa
        private void btnPointsComplex_Click(object sender, EventArgs e)
        {
            System.IO.Stream fileStream = null;
            OpenFileDialog ofd = new OpenFileDialog();
            string fisier = "D:\\Aplicatie_Disertatie\\Lansare_ML_SVM\\mySvmTrain\\Debug\\Data_Set_For_Graphic_Complex_Calitativ.txt";
            ofd.FileName = fisier; fileStream = ofd.OpenFile();

            DateVectoriale dateVect = new DateVectoriale(fileStream, tip2);
            // partea de adte
            // citeste din fisier puncte cu 3 coordonate si adauga in pointList

            VizualizareDate afisareGrafic = new VizualizareDate();
            // partea grafica: tine panel grafic + dialog setari grafic + grid tabela
            // form-ul din app consumator necesita using ControlUtilizator;

            afisareGrafic.Grafic.C3DrawChart.ChartType = TipuriDeGrafice.ChartTypeEnum.NorDePuncte;
            afisareGrafic.Grafic.C3DataSeries = dateVect.CopyWithNewList();

            afisareGrafic.date = Vector3D.CopyList(afisareGrafic.Grafic.C3DataSeries.PointList);

            afisareGrafic.ShowDialog();
        }
    }
}
