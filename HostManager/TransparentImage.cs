using System;
using System.Windows.Forms;
using System.Drawing;

public class TransparentImageControl : Control
{
    private enum HoverState
    {
        On,
        Off
    }
    private readonly Timer refresher;
    private Image _image;
    private bool _toggleHover;
    private Image _hoverImage;
    private HoverState _hoverState = HoverState.Off;

    public TransparentImageControl()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        BackColor = Color.Transparent;
        refresher = new Timer();
        refresher.Tick += TimerOnTick;
        refresher.Interval = 50;
        refresher.Enabled = true;
        refresher.Start();
    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x20;
            return cp;
        }
    }

    protected override void OnMove(EventArgs e)
    {
        RecreateHandle();
    }


    protected override void OnPaint(PaintEventArgs e)
    {
        Image img = (_hoverState == HoverState.Off ? _image : _hoverImage);
        if (img != null)
        {
            e.Graphics.DrawImage(img, (Width / 2) - (img.Width / 2), (Height / 2) - (img.Height / 2));
        }
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        //Do not paint background
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        if (_toggleHover)
        {
            if (_hoverState == HoverState.Off)
            {
                _hoverState = HoverState.On;
                RecreateHandle();
            }
        }
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        if (_toggleHover)
        {
            if (_hoverState == HoverState.On)
            {
                _hoverState = HoverState.Off;
                RecreateHandle();
            }
        }
    }

    //Hack
    public void Redraw()
    {
        RecreateHandle();
    }

    private void TimerOnTick(object source, EventArgs e)
    {
        RecreateHandle();
        refresher.Stop();
    }

    public Image Image
    {
        get
        {
            return _image;
        }
        set
        {
            _image = value;
            RecreateHandle();
        }
    }
    public Image HoverImage
    {
        get
        {
            return _hoverImage;
        }
        set
        {
            _hoverImage = value;
        }
    }
    public bool ToggleOnHover
    {
        get { return _toggleHover; }
        set { _toggleHover = value; }
    }
}