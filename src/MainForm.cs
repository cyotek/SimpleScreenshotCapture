// Capturing screenshots using C# and p/invoke
// http://www.cyotek.com/blog/capturing-screenshots-using-csharp-and-p-invoke
// Copyright © 2017 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Cyotek.Windows.Forms;

namespace Cyotek.Demo.SimpleScreenshotCapture
{
  internal partial class MainForm : Form
  {
    #region Fields

    private Bitmap _preview;

    private int _timer;

    #endregion

    #region Constructors

    public MainForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    protected override void OnShown(EventArgs e)
    {
      this.InitializeMonitorList();
      currentWindowRadioButton.Checked = true;

      base.OnShown(e);
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (AboutDialog dialog = new AboutDialog())
      {
        dialog.ShowDialog(this);
      }
    }

    private void CaptureImage()
    {
      Bitmap result;
      ScreenshotCapture capture;
      bool onlyCaptureWorkingArea;

      capture = new ScreenshotCapture();

      onlyCaptureWorkingArea = workingAreaCheckBox.Checked;

      if (currentWindowRadioButton.Checked)
      {
        result = capture.CaptureActiveWindow();
      }
      else if (currentMonitorRadioButton.Checked)
      {
        result = capture.CaptureMonitor(Screen.FromControl(this), onlyCaptureWorkingArea);
      }
      else if (monitorRadioButton.Checked)
      {
        result = capture.CaptureMonitor(monitorComboBox.SelectedIndex, onlyCaptureWorkingArea);
      }
      else
      {
        result = capture.CaptureDesktop(onlyCaptureWorkingArea);
      }

      this.UpdatePreview(result);
    }

    private void captureToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CaptureImage();
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (_preview == null)
      {
        SystemSounds.Beep.Play();
      }
      else
      {
        try
        {
          Clipboard.SetImage(_preview);
        }
        catch (ExternalException ex)
        {
          MessageBox.Show("Failed to copy image. " + ex.GetBaseException().Message, "Copy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
    }

    private void delayCaptureTimer_Tick(object sender, EventArgs e)
    {
      _timer--;

      this.UpdateTimer();

      if (_timer < 0)
      {
        delayCaptureTimer.Stop();

        this.CaptureImage();
      }
    }

    private void delayCaptureToolStripButton_Click(object sender, EventArgs e)
    {
      this.DelayedCapture(3);
    }

    private void DelayedCapture(int seconds)
    {
      _timer = seconds;

      delayCaptureTimer.Stop();
      delayCaptureTimer.Start();

      this.UpdateTimer();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void InitializeMonitorList()
    {
      Screen[] screens;

      screens = Screen.AllScreens;

      for (int i = 0; i < screens.Length; i++)
      {
        monitorComboBox.Items.Add(screens[i].DeviceName);
      }

      monitorComboBox.SelectedIndex = 0;
    }

    private void monitorComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      monitorRadioButton.Checked = true;
    }

    private void previewImageBox_Zoomed(object sender, ImageBoxZoomEventArgs e)
    {
      previewImageBox.InterpolationMode = previewImageBox.Zoom < 100 ? InterpolationMode.HighQualityBicubic : InterpolationMode.NearestNeighbor;
    }

    private void SaveImage(string fileName)
    {
      try
      {
        _preview.Save(fileName, ImageFormat.Png);
      }
      catch (ExternalException ex)
      {
        MessageBox.Show("Failed to save image. " + ex.GetBaseException().Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (_preview == null)
      {
        MessageBox.Show("Nothing to save.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        using (SaveFileDialog dialog = new SaveFileDialog
                                       {
                                         Title = "Save Image As",
                                         Filter = "PNG Files (*.png)|*.png",
                                         DefaultExt = "png"
                                       })
        {
          if (dialog.ShowDialog(this) == DialogResult.OK)
          {
            this.SaveImage(dialog.FileName);
          }
        }
      }
    }

    private void UpdatePreview(Bitmap capture)
    {
      if (_preview != null)
      {
        previewImageBox.Image = null;
        _preview.Dispose();
        _preview = null;
      }

      _preview = capture;

      previewImageBox.Image = capture;
      previewImageBox.ZoomToFit();
    }

    private void UpdateTimer()
    {
      timerToolStripStatusLabel.Text = _timer >= 0 ? _timer + "s" : string.Empty;
    }

    #endregion
  }
}
