﻿// Capturing screenshots using C# and p/invoke
// http://www.cyotek.com/blog/capturing-screenshots-using-csharp-and-p-invoke
// Copyright © 2017-2019 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Cyotek.Windows.Forms;

namespace Cyotek.Demo.SimpleScreenshotCapture
{
  internal sealed class ScreenshotCapture
  {
    #region Public Methods

    public Bitmap CaptureActiveWindow()
    {
      return this.CaptureWindow(NativeMethods.GetForegroundWindow());
    }

    public Bitmap CaptureDesktop()
    {
      return this.CaptureDesktop(false);
    }

    public Bitmap CaptureDesktop(bool workingAreaOnly)
    {
      return this.CaptureDesktop(workingAreaOnly, Color.Transparent);
    }

    public Bitmap CaptureDesktop(Color invalidColor)
    {
      return this.CaptureDesktop(false, invalidColor);
    }

    public Bitmap CaptureDesktop(bool workingAreaOnly, Color invalidColor)
    {
      return CaptureDesktop(workingAreaOnly, invalidColor, index => true);
    }

    public Bitmap CaptureDesktop(Predicate<int> includeScreen)
    {
      return CaptureDesktop(false, Color.Transparent, includeScreen);
    }

    public Bitmap CaptureDesktop(bool workingAreaOnly, Color invalidColor, Predicate<int> includeScreen)
    {
      DesktopLayout layout;
      Bitmap bitmap;

      layout = new DesktopLayout
      {
        WorkingAreaOnly = workingAreaOnly
      };

      bitmap = new Bitmap(layout.Width, layout.Height, PixelFormat.Format32bppArgb);

      using (Graphics g = Graphics.FromImage(bitmap))
      {
        g.Clear(invalidColor);

        for (int i = 0; i < layout.Count; i++)
        {
          if (includeScreen(i))
          {
            Rectangle bounds;

            bounds = layout.GetDisplayBounds(i);

            using (Bitmap displayImage = CaptureRegion(bounds))
            {
              g.DrawImageUnscaled(displayImage, layout.GetNormalizedDisplayBounds(bounds));
            }
          }
        }
      }

      return bitmap;
    }

    public Bitmap CaptureMonitor(Screen monitor)
    {
      return this.CaptureMonitor(monitor, false);
    }

    public Bitmap CaptureMonitor(Screen monitor, bool workingAreaOnly)
    {
      Rectangle region;

      region = workingAreaOnly ? monitor.WorkingArea : monitor.Bounds;

      return this.CaptureRegion(region);
    }

    public Bitmap CaptureMonitor(int index)
    {
      return this.CaptureMonitor(index, false);
    }

    public Bitmap CaptureMonitor(int index, bool workingAreaOnly)
    {
      return this.CaptureMonitor(Screen.AllScreens[index], workingAreaOnly);
    }

    public Bitmap CaptureRegion(Rectangle region)
    {
      IntPtr desktophWnd;
      IntPtr desktopDc;
      IntPtr memoryDc;
      IntPtr bitmap;
      IntPtr oldBitmap;
      bool success;
      Bitmap result;

      desktophWnd = NativeMethods.GetDesktopWindow();
      desktopDc = NativeMethods.GetWindowDC(desktophWnd);
      memoryDc = NativeMethods.CreateCompatibleDC(desktopDc);
      bitmap = NativeMethods.CreateCompatibleBitmap(desktopDc, region.Width, region.Height);
      oldBitmap = NativeMethods.SelectObject(memoryDc, bitmap);

      success = NativeMethods.BitBlt(memoryDc, 0, 0, region.Width, region.Height, desktopDc, region.Left, region.Top, NativeMethods.RasterOperations.SRCCOPY | NativeMethods.RasterOperations.CAPTUREBLT);

      try
      {
        if (!success)
        {
          throw new Win32Exception();
        }

        result = Image.FromHbitmap(bitmap);
      }
      finally
      {
        NativeMethods.SelectObject(memoryDc, oldBitmap);
        NativeMethods.DeleteObject(bitmap);
        NativeMethods.DeleteDC(memoryDc);
        NativeMethods.ReleaseDC(desktophWnd, desktopDc);
      }

      return result;
    }

    public Bitmap CaptureWindow(IntPtr hWnd)
    {
      NativeMethods.RECT region;

      if (Environment.OSVersion.Version.Major < 6)
      {
        NativeMethods.GetWindowRect(hWnd, out region);
      }
      else
      {
        if (NativeMethods.DwmGetWindowAttribute(hWnd, NativeMethods.DWMWA_EXTENDED_FRAME_BOUNDS, out region, Marshal.SizeOf(typeof(NativeMethods.RECT))) != 0)
        {
          NativeMethods.GetWindowRect(hWnd, out region);
        }
      }

      return this.CaptureRegion(Rectangle.FromLTRB(region.left, region.top, region.right, region.bottom));
    }

    public Bitmap CaptureWindow(Form form)
    {
      return this.CaptureWindow(form.Handle);
    }

    #endregion Public Methods
  }
}