﻿using System.Drawing;
using System.Windows.Forms;

namespace GraphEditor.Graph
{
    public enum State { Normal = 0, Selected = 1 }

    public delegate void MouseHoverHandler(object sender);
    public delegate void MouseLeaveHandler(object sender);
    public delegate void MouseClickHandler(object sender);
    public delegate void SelectHandler(object sender);
    public delegate void DeselectHandler(object sender);

    public abstract class GraphObject
    {
        public event MouseHoverHandler MouseHover;
        public event MouseLeaveHandler MouseLeave;
        public event MouseClickHandler MouseClick;
        public event SelectHandler Selected;
        public event DeselectHandler Deselected;
        public State State { get; set; }

        public abstract bool IsOnHover(MouseEventArgs e);
        public abstract void OnMouseHover(MouseEventArgs e);
        public abstract void OnMouseLeave(MouseEventArgs e);

        public void OnMouseClick(MouseEventArgs e)
        {
            if (State == State.Normal)
                Select();
            else if (State == State.Selected)
                Deselect();
        }

        public abstract void Draw(Graphics e, int num = 0);

        public void Select()
        {
            if (State == State.Normal)
            {
                State = State.Selected;
                Selected?.Invoke(this);
            }
        }

        public void Deselect()
        {
            if (State == State.Selected)
            {
                State = State.Normal;
                Deselected?.Invoke(this);
            }
        }
    }
}
