using System;
using System.Drawing;
using System.Windows.Forms;

// Capturing screenshots using C# and p/invoke
// http://www.cyotek.com/blog/capturing-screenshots-using-csharp-and-p-invoke
// Copyright © 2017-2019 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

namespace Cyotek.Windows.Forms
{
  internal sealed class DesktopLayout
  {
    #region Private Fields

    private Rectangle _bounds;

    private int _count;

    private Rectangle[] _displays;

    private bool _workingAreaOnly;

    #endregion Private Fields

    #region Public Constructors

    public DesktopLayout()
    {
      this.Initialize();
    }

    #endregion Public Constructors

    #region Public Properties

    public Rectangle Bounds
    { get { return _bounds; } }

    public int Count
    { get { return _count; } }

    public int Height
    { get { return _bounds.Height; } }

    public int Width
    { get { return _bounds.Width; } }

    public bool WorkingAreaOnly
    {
      get { return _workingAreaOnly; }
      set
      {
        if (_workingAreaOnly != value)
        {
          _workingAreaOnly = value;

          this.Initialize();
        }
      }
    }

    #endregion Public Properties

    #region Public Methods

    public Rectangle GetDisplayBounds(int index)
    {
      return _displays[index];
    }

    public Rectangle GetNormalizedDisplayBounds(int index)
    {
      return this.GetNormalizedDisplayBounds(_displays[index]);
    }

    public Rectangle GetNormalizedDisplayBounds(Rectangle bounds)
    {
      return new Rectangle(bounds.X - _bounds.X, bounds.Y - _bounds.Y, bounds.Width, bounds.Height);
    }

    #endregion Public Methods

    #region Private Methods

    private void Initialize()
    {
      Screen[] screens;
      int minX;
      int minY;
      int maxX;
      int maxY;

      screens = Screen.AllScreens;
      minX = 0;
      minY = 0;
      maxX = 0;
      maxY = 0;

      _count = screens.Length;
      _displays = new Rectangle[_count];

      for (int i = 0; i < _count; i++)
      {
        Screen screen;
        Rectangle bounds;

        screen = screens[i];
        bounds = _workingAreaOnly ? screen.WorkingArea : screen.Bounds;

        _displays[i] = bounds;

        minX = Math.Min(minX, bounds.X);
        minY = Math.Min(minY, bounds.Y);
        maxX = Math.Max(maxX, bounds.Right);
        maxY = Math.Max(maxY, bounds.Bottom);
      }

      _bounds = new Rectangle(minX, minY, maxX - minX, maxY - minY);
    }

    #endregion Private Methods
  }
}