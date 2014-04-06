﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Digital_Circuit
{
    class Gate
    {
        // Fields
        private int x, y; // The x and y coordinates of a gate
        private List<Connection> myConnections; // A list of connections of the gate
        private List<Boolean> myInputValues; // The input values of the gate
        private Boolean myOutputValue; // The output values of the gate
        // something to paint the pictures, we don't know yet how. (Or hold an image - private Image myimage).
        private int id;
        // Delegates and events

        // Constructor
        public Gate(int id,int x, int y)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            myConnections = new List<Connection>();
            myInputValues = new List<Boolean>();
            myOutputValue = false;
        }

        // Properties
        public int ID
        {
            get { return this.id; }
        }
        public int X
        {
            get { return this.x; }
        }

        public int Y
        {
            get { return this.y; }
        }


        // Methods


        /// <summary>
        /// checks if the point (xmouse,ymouse) is on this gate.
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns>Returns true or false</returns>
        public bool ContainsPoint(int xmouse, int ymouse)
        {
            if (this.x - 10 <= xmouse && xmouse <= this.x + 10 && this.y - 10 <= ymouse && ymouse <= this.y + 10)
            {

                return true;


            }
            return false;
       
        }

        /// <summary>
        /// Draws a gate on it's location
        /// </summary>
        /// <param name="gr"></param>
        public void DrawGate(Graphics gr)
        {
            int length = 20;
            int width = 10;
            Pen pen = new Pen(Color.Black, 4);
            Point a = new Point(x - 10, y - 10);
            Point b = new Point(x + 10, y + 10);
            Point c = new Point(x - 10, y + 10);
            Point d = new Point(x + 10, y - 10);

            gr.DrawLine(pen, a, c);
            gr.DrawLine(pen, c, b);
            gr.DrawLine(pen, b, d);
            gr.DrawLine(pen, d, a);
        }
    }
}
