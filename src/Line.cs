// Capturing screenshots using C# and p/invoke
// http://www.cyotek.com/blog/capturing-screenshots-using-csharp-and-p-invoke
// Copyright © 2017 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms
{
#if PUBLICLIB
  [Designer(typeof(Design.LineDesigner))]
  public class Line : Control
#else
  internal class Line : Control
#endif
  {
    #region Constants

    private static readonly object _eventFlatStyleChanged = new object();

    private static readonly object _eventLineColorChanged = new object();

    private static readonly object _eventOrientationChanged = new object();

    #endregion

    #region Fields

    private FlatStyle _flatStyle = FlatStyle.Standard;

    private Color _lineColor;

    private Orientation _orientation;

    #endregion

    #region Constructors

    public Line()
    {
      this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
      this.SetStyle(ControlStyles.Selectable, false);
      this.LineColor = SystemColors.ControlDark;
      base.TabStop = false;
      base.TabIndex = 0;
    }

    #endregion

    #region Events

    [Category("Property Changed")]
    public event EventHandler FlatStyleChanged
    {
      add { this.Events.AddHandler(_eventFlatStyleChanged, value); }
      remove { this.Events.RemoveHandler(_eventFlatStyleChanged, value); }
    }

    [Category("Property Changed")]
    public event EventHandler LineColorChanged
    {
      add { this.Events.AddHandler(_eventLineColorChanged, value); }
      remove { this.Events.RemoveHandler(_eventLineColorChanged, value); }
    }

    [Category("Property Changed")]
    public event EventHandler OrientationChanged
    {
      add { this.Events.AddHandler(_eventOrientationChanged, value); }
      remove { this.Events.RemoveHandler(_eventOrientationChanged, value); }
    }

    #endregion

    #region Properties

    [Category("Appearance")]
    [DefaultValue(typeof(FlatStyle), "Standard")]
    public FlatStyle FlatStyle
    {
      get { return _flatStyle; }
      set
      {
        if (_flatStyle != value)
        {
          _flatStyle = value;

          this.OnFlatStyleChanged(EventArgs.Empty);
        }
      }
    }

    [Category("Appearance")]
    [DefaultValue(typeof(Color), "ControlDark")]
    public Color LineColor
    {
      get { return _lineColor; }
      set
      {
        if (this.LineColor != value)
        {
          _lineColor = value;

          this.OnLineColorChanged(EventArgs.Empty);
        }
      }
    }

    [Category("Appearance")]
    [DefaultValue(typeof(Orientation), "Horizontal")]
    public Orientation Orientation
    {
      get { return _orientation; }
      set
      {
        if (this.Orientation != value)
        {
          _orientation = value;

          this.OnOrientationChanged(EventArgs.Empty);
        }
      }
    }

    [DefaultValue(false)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new int TabIndex
    {
      get { return base.TabIndex; }
      set { base.TabIndex = value; }
    }

    [DefaultValue(false)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new bool TabStop
    {
      get { return base.TabStop; }
      set { base.TabStop = value; }
    }

    protected override Size DefaultSize
    {
      get { return new Size(100, 2); }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Raises the <see cref="FlatStyleChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected virtual void OnFlatStyleChanged(EventArgs e)
    {
      EventHandler handler;

      this.Invalidate();

      handler = (EventHandler)this.Events[_eventFlatStyleChanged];

      handler?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="LineColorChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected virtual void OnLineColorChanged(EventArgs e)
    {
      EventHandler handler;

      this.Invalidate();

      handler = (EventHandler)this.Events[_eventLineColorChanged];

      handler?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="OrientationChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
    protected virtual void OnOrientationChanged(EventArgs e)
    {
      EventHandler handler;

      this.Invalidate();

      handler = (EventHandler)this.Events[_eventOrientationChanged];

      handler?.Invoke(this, e);
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
      int x1;
      int y1;
      int x2;
      int y2;
      int xOffset;
      int yOffset;

      switch (this.Orientation)
      {
        case Orientation.Horizontal:
          x1 = 0;
          y1 = this.Height / 2 - 1;
          x2 = this.Width;
          y2 = y1;
          xOffset = 0;
          yOffset = 1;
          break;
        default:
          x1 = this.Width / 2 - 1;
          y1 = 0;
          x2 = x1;
          y2 = this.Height;
          xOffset = 1;
          yOffset = 0;
          break;
      }

      switch (this.FlatStyle)
      {
        case FlatStyle.System:
          using (Pen pen = new Pen(this.LineColor))
          {
            pe.Graphics.DrawLine(pen, x1, y1, x2, y2);
          }
          break;
        default:
          pe.Graphics.DrawLine(SystemPens.ControlDark, x1, y1, x2, y2);
          pe.Graphics.DrawLine(SystemPens.ControlLightLight, x1 + xOffset, y1 + yOffset, x2 + xOffset, y2 + yOffset);
          break;
      }
    }

    protected override void OnSystemColorsChanged(EventArgs e)
    {
      base.OnSystemColorsChanged(e);

      this.Invalidate();
    }

    #endregion
  }
}
