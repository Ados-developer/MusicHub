using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.UI
{
    public class TitleBarButton : Button
    {
        private Color _bgNormal = Color.FromArgb(30, 41, 59);
        private Color _fgNormal = Color.FromArgb(56, 189, 248);

        private Color _bgHover = Color.FromArgb(56, 189, 248);
        private Color _fgHover = Color.FromArgb(30, 41, 59);

        public TitleBarButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = _bgHover;
            FlatAppearance.MouseOverBackColor = _bgHover;

            BackColor = _bgNormal;
            ForeColor = _fgNormal;

            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Cursor = Cursors.Hand;

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint, true);
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = _bgHover;
            ForeColor = _fgHover;
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = _bgNormal;
            ForeColor = _fgNormal;
        }
    }
}
