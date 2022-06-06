using System;
using System.IO;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace nato_text_2_speech
{
    public partial class Main : Form
    {
        public SpeechSynthesizer synth = new SpeechSynthesizer();
        public Main() => InitializeComponent();
        private void timer1_Tick(object sender, EventArgs e) => date_and_time.Text = "" + DateTime.Now.ToLongDateString().ToString() + "   " + DateTime.Now.ToLongTimeString().ToString();
        private void import_file_btn_Click(object sender, EventArgs e)
        {
            Stream strm;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt";
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if ((strm = ofd.OpenFile()) != null)
                    {
                        string file = ofd.FileName, filetxt = File.ReadAllText(file);
                        text_field.Text = filetxt;
                    }
                }
            }catch (Exception) { MessageBox.Show("Uh Oh! Be sure to check the filetype, .txt is the required file format."); }
        }
        private void speak_btn_Click(object sender, EventArgs e) => synth.SpeakAsync(text_field.Text);
        private void speed_selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (speed_selection.Text)
            {
                case "Extra Fast":
                    synth.Rate = 8; break;
                case "Fast":
                    synth.Rate = 6; break;
                case "Medium":
                    synth.Rate = 4; break;
                case "Slow":
                    synth.Rate = -1; break;
                case "Extra Slow":
                    synth.Rate = -3; break;
                default:
                    synth.Rate = 2; break;
            }
        }
    }
}