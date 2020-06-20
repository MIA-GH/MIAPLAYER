using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIAPLAYER
{
    public partial class MiaPlayer : Form
    {
        public MiaPlayer()
        {
            InitializeComponent();
        }

        int Startindex = 0;
        string[] FileNames, FilePaths;
        Boolean PlayNext = false;
        bool _playing = false;
        bool isVolume = true;
        int currentIndex = 0;
        bool loopAll = true;

        #region Window Controls
        // The quit button functionality
        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // The maximize button functionality
        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        // the minimize button functionality
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion Window Controls

        // on window load
        private void MiaPlayer_Load(object sender, EventArgs e)
        {
            Startindex = 0;
            currentIndex = Startindex;
            PlayNext = false;
            StopPlayer();
            axWindowsMediaPlayer1.settings.volume = 50;
            volumeBar.Value = 50;
            volumeLevel.Text = "50" + "%";
        }

        private void BrowseFilesButton_Click(object sender, EventArgs e)
        {
            Startindex = 0;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "(mp3, wav, mp4, mov, wmv, mpg, avi, 3gp, flv)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg;*.avi;*.3gp;*.flv|all files|*.*";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileNames = openFileDialog.SafeFileNames;
                FilePaths = openFileDialog.FileNames;
                for(int i = 0; i <= FileNames.Length - 1; i++)
                {
                    PlayList.Items.Add(FileNames[i]);
                }
                Startindex = 0;
            }
        }

        private void PlayListButton_Click(object sender, EventArgs e)
        {
            PlayList.BringToFront();
        }

        private void NowPlayingButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.BringToFront();
        }

        private void volumeBar_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = volumeBar.Value;
            volumeLevel.Text = volumeBar.Value.ToString() + "%";
        }

        public void PlayNextFile(int nextIndex)
        {
            PlayFile(nextIndex);
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            if (_playing == false)
            {
                currentIndex = Startindex;
                PlayFile(Startindex);
                songTitle.Text = PlayList.Text;
                _playing = true;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        } 
 

        private void PlayList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Startindex = PlayList.SelectedIndex;
            currentIndex = Startindex;
            PlayFile(Startindex);
            songTitle.Text = PlayList.Text;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            currentIndex += 1;
            PlayFile(currentIndex);
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (currentIndex == 0)
            {
                return;
            }
            else
            {
                int previousIndex = currentIndex - 1;
                currentIndex = previousIndex;
                StopPlayer();
                PlayFile(previousIndex);
            }
            
        }

        private void RepeatButton_Click(object sender, EventArgs e)
        {
            return;
        }
        int volume = 0;
        private void VolumeButton_Click(object sender, EventArgs e)
        {
            if (isVolume)
            {
                volume = volumeBar.Value;
                axWindowsMediaPlayer1.settings.volume = 0;
                volumeBar.Value = 0;
                volumeLevel.Text = volumeBar.Value.ToString() + "%";
                isVolume = false;

            }
            else if(isVolume == false)
            {
                axWindowsMediaPlayer1.settings.volume = volume;
                volumeBar.Value = volume;
                volumeLevel.Text = volumeBar.Value.ToString() + "%";
                isVolume = true;
            }
        }

        private void PlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Startindex = PlayList.SelectedIndex;
        }

        // stop playing file
        private void StopPlayer()
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopPlayer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            fullTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                ProgressBar.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                ProgressBar.MaximumValue = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                ProgressBar.Value = 0;
            }
        }

        // start playing file
        public void PlayFile(int PlayListIndex)
        {
            if(PlayList.Items.Count <= 0)
            {
                return;
            }
            if (PlayList.Items.Count < 0)
            {
                return;
            }
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.URL = FilePaths[PlayListIndex];
            axWindowsMediaPlayer1.Ctlcontrols.next();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
