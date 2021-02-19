using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TextToSpeech
{
    public partial class Frm_TexttoSpeech : Form
    {
        SpeechSynthesizer speech;
        public Frm_TexttoSpeech()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }

        private void btn_speak_Click(object sender, EventArgs e)
        {
            if (rtb.Text != "")
            {
                speech.SpeakAsync(rtb.Text);
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Speaking)
            {
                speech.Pause();
            }
        }

        private void btn_resume_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Paused)
            {
                speech.Resume();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
