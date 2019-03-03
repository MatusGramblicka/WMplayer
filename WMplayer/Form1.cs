using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMplayer
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        LessonsNames lName = new LessonsNames();

        FirstLessonSentences firstLessonSent = new FirstLessonSentences();
        SecondLessonSentences secondLessonSent = new SecondLessonSentences();        

        int intervalCounter = 0;
        int[][] interval = new int[3][];
        int sentenceNumber = 0;
        int sentenceInterval = 0;
        int repeat = 0;
        int plus = 0;
        int lectionIndex;
        int sentenceIndex;
        int sentecesCount = 0;

        static double speed = 1;
        double intervalCoeficient = 1 / speed;

        string[] sentence = new string[3];
        string[] wordsDE;
        string[] wordsSK;
        string slovakSentence, firstSentence, secondSentence;

        bool newSelection = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial", 16f, FontStyle.Bold);
            richTextBox1.BackColor = Color.White;

            richTextBox2.Font = new Font("Arial", 14f);
            richTextBox2.BackColor = Color.White;

            for (int f = 1; f < 19; f++)
            {
                listBox1.Items.Add(f.ToString() + ". lekcia");
            }
        }

        private void Play(string[] sentence)
        {
            wplayer.URL = @sentence[sentenceNumber];
            wplayer.settings.rate = speed;
            wplayer.controls.play();

            intervalCoeficient = 1 / speed;

            if (chBoxWithSlovak.Checked)
            {
                switch (sentenceNumber)
                {
                    case 0:
                        label9.Text = "Playing slovak sentence";
                        break;
                    case 1:
                        label9.Text = "Playing german sentence 1";
                        break;
                    case 2:
                        label9.Text = "Playing german sentence 2";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (sentenceNumber)
                {
                    case 0:
                        label9.Text = "Playing german sentence 1";
                        break;
                    case 1:
                        label9.Text = "Playing german sentence 2";
                        break;
                    default:
                        break;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (wplayer.status.Contains("Playing"))
            {
                richTextBox1.Clear();
                richTextBox2.Clear();

                for (int j = 0; j < wordsSK.Length; j++)
                {
                    int wordsNumbering = j + 1;// later delete                  

                    string wordSK = wordsNumbering.ToString()/*later delete*/ + wordsSK[j];
                    string wordDE = wordsNumbering.ToString()/*later delete*/ + wordsDE[j];

                    if (intervalCounter == j)
                    {
                        if (checkBox2.Checked)
                            ColorGermanSentence();
                        if (checkBox5.Checked)
                            ColorSlovakSentence();
                    }
                    else
                    {
                        richTextBox1.SelectionColor = Color.Black;
                        richTextBox2.SelectionColor = Color.Black;
                    }

                    richTextBox1.AppendText(wordSK);
                    richTextBox1.SelectionBackColor = Color.White;
                    richTextBox1.AppendText(" ");

                    richTextBox2.AppendText(wordDE);
                    richTextBox2.SelectionBackColor = Color.White;
                    richTextBox2.AppendText(" ");
                }

                if (intervalCounter == interval[sentenceInterval].Length)
                {
                    intervalCounter = 0;
                    timer2.Stop();
                }
                else
                {
                    timer2.Stop();
                    timer2.Interval = (int)(interval[sentenceInterval][intervalCounter] * intervalCoeficient);
                    timer2.Start();

                    intervalCounter++;
                }
            }
        }
        private void ColorSlovakSentence()
        {
            richTextBox2.SelectionColor = Color.Red;
        }

        private void ColorGermanSentence()
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = wplayer.status;

            if (wplayer.status.Contains("Stopped"))
            {
                repeat++;

                // sentenceInterval = SwapInterval(repeat);

                // sentenceNumber = SwapSentence(repeat);

                sentenceInterval = SwapInterval2(repeat);

                sentenceNumber = SwapSentence2(repeat);

                RestartWordsColoring();

                Play(sentence);
            }
        }
        private int SwapInterval(int repeat)
        {
            int nextInterval;

            if (chBoxWithSlovak.Checked)
                nextInterval = repeat % 3;
            else
                nextInterval = (repeat % 2) + 1; // +1 because we need 2. a 3. intervale because it is bound to 2. and 3. german sentence

            return nextInterval;
        }

        private int SwapInterval2(int repeat)
        {
            int nextInterval = 0;

            switch (plus)
            {
                case 1:
                    nextInterval = 0;
                    break;
                case 2:
                    nextInterval = repeat % 2;
                    break;
                case 3:
                    nextInterval = repeat % 3;
                    break;
            }

            return nextInterval;
        }

        private int SwapSentence2(int repeat)
        {
            int nextSentence = 0;

            switch (plus)
            {
                case 1:
                    nextSentence = 0;
                    break;
                case 2:
                    nextSentence = repeat % 2;
                    break;
                case 3:
                    nextSentence = repeat % 3;
                    break;
            }

            return nextSentence;
        }

        private int SwapSentence(int repeat)
        {
            int nextSentence;

            if (chBoxWithSlovak.Checked)
                nextSentence = repeat % 3;
            else
                nextSentence = repeat % 2;

            return nextSentence;
        }

        private void RestartWordsColoring()
        {
            timer2.Stop();

            intervalCounter = 0;

            timer2.Start();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            lectionIndex = this.listBox1.IndexFromPoint(e.Location);

            lectionIndex = lectionIndex + 1;

            label11.Text = "Lekcia " + lectionIndex;

            FillSentenceList(lectionIndex);

            GetLessonsName(lectionIndex);
        }

        private void GetLessonsName(int lectionIndex)
        {
            switch (lectionIndex)
            {
                case 1:
                    label15.Text = lName.LessonName[lectionIndex - 1];
                    break;
                case 2:
                    label15.Text = lName.LessonName[lectionIndex - 1];
                    break;
            }
        }

        private void FillSentenceList(int lectionIndex)
        {
            listBox2.Items.Clear();

            switch (lectionIndex)
            {
                case 1:
                    sentecesCount = firstLessonSent.SentencesDE.Count;
                    for (int b = 1; b <= sentecesCount; b++)
                    {
                        listBox2.Items.Add("Veta " + b);
                    }
                    break;
                case 2:
                    sentecesCount = secondLessonSent.SentencesDE.Count;
                    for (int b = 1; b <= sentecesCount; b++)
                    {
                        listBox2.Items.Add("Veta " + b);
                    }
                    break;
            }
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            newSelection = true;

            if (newSelection)
            {
                EnableAssets();
            }

            sentenceIndex = this.listBox2.SelectedIndex;

            sentenceIndex = sentenceIndex + 1;

            UpdateSentenceLabel();

            PlaySentence(sentenceIndex);
        }

        private void PlaySentence(int index)
        {
            String baseDirectory = System.AppDomain.CurrentDomain.BaseDirectory;

            slovakSentence = baseDirectory + "L" + lectionIndex + "\\L" + lectionIndex + "V" + sentenceIndex + "s.mp3";

            firstSentence = baseDirectory + "L" + lectionIndex + "\\L" + lectionIndex + "V" + sentenceIndex + "n1.mp3";
            secondSentence = baseDirectory + "L" + lectionIndex + "\\L" + lectionIndex + "V" + sentenceIndex + "n2.mp3";


            //LoadSoundSentences(slovakSentence, firstSentence, secondSentence);
            LoadSoundSentences2(slovakSentence, firstSentence, secondSentence);
            DebugLoadIntervals();


            PrepareSenteces(lectionIndex);


            RestartWordsColoring();

            Play(sentence);
        }

        private void LoadSoundSentences(string slovakSentence, string firstSentence, string secondSentence)
        {
            if (chBoxWithSlovak.Checked)
                sentence = new string[] { slovakSentence, firstSentence, secondSentence };
            else
                sentence = new string[] { firstSentence, secondSentence };
        }

        private void LoadSoundSentences2(string slovakSentence, string firstSentence, string secondSentence)
        {
            if (newSelection) // need to allocate all interval variable in array when swapping on new sentence, because of overflow, when not all sentence checkboxes were checked and swapping from shorter sentence to longer
            {
                int inc = 0;

                sentence[inc] = slovakSentence;
                interval[inc] = firstLessonSent.IntervalSK[sentenceIndex - 1];
                inc++;
                sentence[inc] = firstSentence;
                interval[inc] = firstLessonSent.IntervalDE1[sentenceIndex - 1];
                inc++;
                sentence[inc] = secondSentence;
                interval[inc] = firstLessonSent.IntervalDE2[sentenceIndex - 1];

                newSelection = false;
            }
            
            plus = 0;

            if (chbSK.Checked)
            {
                sentence[plus] = slovakSentence;
                interval[plus] = firstLessonSent.IntervalSK[sentenceIndex - 1];

                plus++;
            }
            if (chbDE1.Checked)
            {
                sentence[plus] = firstSentence;
                interval[plus] = firstLessonSent.IntervalDE1[sentenceIndex - 1];

                plus++;
            }
            if (chbDE2.Checked)
            {
                sentence[plus] = secondSentence;
                interval[plus] = firstLessonSent.IntervalDE2[sentenceIndex - 1];

                plus++;
            }
        }

        private void EnableAssets()
        {
            button2.Enabled = true;
            button3.Enabled = true;
            btnPause.Enabled = true;
            btnPlay.Enabled = true;

            chbSK.Enabled = true;
            chbDE1.Enabled = true;
            chbDE2.Enabled = true;
        }

        private void DebugLoadIntervals()
        {
            txtSlovakDebug.Clear();
            txtGerman1Debug.Clear();
            txtGerman2Debug.Clear();

            for (int o = 0; o < interval[0].Length; o++)
            {
                txtSlovakDebug.Text += interval[0][o].ToString() + " ";
                txtGerman1Debug.Text += interval[1][o].ToString() + " ";
                txtGerman2Debug.Text += interval[2][o].ToString() + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string intervTxtSk = txtSlovakDebug.Text;
            intervTxtSk = intervTxtSk.TrimEnd();

            string intervTxt2GE1 = txtGerman1Debug.Text;
            intervTxt2GE1 = intervTxt2GE1.TrimEnd();

            string intervTxt3Ge2 = txtGerman2Debug.Text;
            intervTxt3Ge2 = intervTxt3Ge2.TrimEnd();

            string[] tempSlovak = intervTxtSk.Split(' ');
            string[] tempGerman1 = intervTxt2GE1.Split(' ');
            string[] tempGerman2 = intervTxt3Ge2.Split(' ');

            /*  for (int t = 0; t < tempSlovak.Length; t++)     // all temp variables are the same lenght, so tempSlovak is there
              {
                  interval[0][t] = Int32.Parse(tempSlovak[t]);
                  interval[1][t] = Int32.Parse(tempGerman1[t]);
                  interval[2][t] = Int32.Parse(tempGerman2[t]);
              }
              */

            for (int t = 0; t < tempSlovak.Length; t++)     // all temp variables are the same lenght, so tempSlovak is there
            {
                int indexSentence = 0;

                if (chbSK.Checked)
                {
                    interval[indexSentence][t] = Int32.Parse(tempSlovak[t]);

                    indexSentence++;
                }
                if (chbDE1.Checked)
                {
                    interval[indexSentence][t] = Int32.Parse(tempGerman1[t]);

                    indexSentence++;
                }
                if (chbDE2.Checked)
                {
                    interval[indexSentence][t] = Int32.Parse(tempGerman2[t]);

                    indexSentence++;
                }
            }

            txtSlovakTransfer.Text = intervTxtSk.Replace(" ", ", ");
            txtGerman1Transfer.Text = intervTxt2GE1.Replace(" ", ", ");
            txtGerman2Transfer.Text = intervTxt3Ge2.Replace(" ", ", ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newSelection = true;

            if (sentenceIndex == 1) // are we at first sentence? Then play last. If not play next previous. 
            {
                sentenceIndex = sentecesCount;
                listBox2.SelectedIndex = sentecesCount - 1;
            }
            else
            {
                sentenceIndex = sentenceIndex - 1;
                listBox2.SelectedIndex--;
            }

            UpdateSentenceLabel();

            PlaySentence(sentenceIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newSelection = true;

            if (sentenceIndex == sentecesCount) // are we at last sentence? Then play first. If not play next sentence. 
            {
                sentenceIndex = 1;
                listBox2.SelectedIndex = 0;
            }
            else
            {
                sentenceIndex = sentenceIndex + 1;
                listBox2.SelectedIndex++;
            }


            UpdateSentenceLabel();

            PlaySentence(sentenceIndex);
        }

        private void UpdateSentenceLabel()
        {
            label12.Text = "Veta " + sentenceIndex;

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                richTextBox1.Visible = false;
            else
                richTextBox1.Visible = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                richTextBox2.Visible = false;
            else
                richTextBox2.Visible = true;
        }

        private void PrepareSenteces(int lectionIndex)
        {
            switch (lectionIndex)
            {
                case 1:
                    wordsDE = firstLessonSent.SentencesDE[sentenceIndex - 1].Split(' ');
                    wordsSK = firstLessonSent.SentencesSK[sentenceIndex - 1].Split(' ');
                    /*    interval[0] = firstLessonSent.IntervalSK[sentenceIndex - 1]; 
                        interval[1] = firstLessonSent.IntervalDE1[sentenceIndex - 1];
                        interval[2] = firstLessonSent.IntervalDE2[sentenceIndex - 1];

                        for (int o = 0; o < interval[0].Length; o++)
                        {
                            txtSlovakDebug.Text += interval[0][o].ToString() + " ";
                            txtGerman1Debug.Text += interval[1][o].ToString() + " ";
                            txtGerman2Debug.Text += interval[2][o].ToString() + " ";
                        }
                        */
                    PreparePersonas(lectionIndex, firstLessonSent.Persona[sentenceIndex - 1]);
                    PrepareVerbs(lectionIndex, firstLessonSent.Verb[sentenceIndex - 1]);

                    break;
                case 2:
                    wordsDE = secondLessonSent.SentencesDE[sentenceIndex - 1].Split(' '); ;
                    wordsSK = secondLessonSent.SentencesSK[sentenceIndex - 1].Split(' '); ;                    

                    PreparePersonas(lectionIndex, secondLessonSent.Persona[sentenceIndex - 1]);
                    PrepareVerbs(lectionIndex, secondLessonSent.Verb[sentenceIndex - 1]);

                    break;
            }
        }

        private void PreparePersonas(int lectionIndex, string firstLessonSentPersona)
        {
            label1.Text = firstLessonSentPersona;
            label14.Text = firstLessonSentPersona;
        }
        private void PrepareVerbs(int lectionIndex, string firstLessonSentVerb)
        {
            lblVerbs.Text = firstLessonSentVerb;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wplayer.controls.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            wplayer.controls.play();
        }

        private void chbSK_CheckedChanged(object sender, EventArgs e)
        {
            LoadSoundSentences2(slovakSentence, firstSentence, secondSentence);

            if (chbSK.Checked)
                txtSlovakDebug.ForeColor = SystemColors.WindowText;
            else
                txtSlovakDebug.ForeColor = Color.Red;
        }

        private void chbDE1_CheckedChanged(object sender, EventArgs e)
        {
            LoadSoundSentences2(slovakSentence, firstSentence, secondSentence);

            if (chbDE1.Checked)
                txtGerman1Debug.ForeColor = SystemColors.WindowText;
            else
                txtGerman1Debug.ForeColor = Color.Red;
        }

        private void chbDE2_CheckedChanged(object sender, EventArgs e)
        {
            LoadSoundSentences2(slovakSentence, firstSentence, secondSentence);

            if (chbDE2.Checked)
                txtGerman2Debug.ForeColor = SystemColors.WindowText;
            else
                txtGerman2Debug.ForeColor = Color.Red;
        }

        private void listBox2_MouseHover(object sender, EventArgs e)
        {
            listBox2.Focus();
        }

        private void numUDSpeed_ValueChanged(object sender, EventArgs e)
        {
            speed = (double)numUDSpeed.Value;
        }
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadSoundSentences(slovakSentence, firstSentence, secondSentence);
        }
    }
}
