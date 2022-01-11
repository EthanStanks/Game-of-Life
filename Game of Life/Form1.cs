﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        // The universe array
        bool[,] universe = new bool[30, 30];

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        // Neighbor Bool - True if finite - False if Toroidal
        bool isFinite = true;

        // Random Number
        Random rng = new Random();


        public Form1()
        {
            InitializeComponent();

            // Color Change ComboBox Default
            ColorComboBox.SelectedIndex = 0;

            // CountNeighbors ComboBox Default
            CountNeighborsComboBox.SelectedIndex = 0;

            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
        }
        private int CountNeighborFinite(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;
                    // if xOffset and yOffset are both equal to 0 then continue
                    // if xCheck is less than 0 then continue
                    // if yCheck is less than 0 then continue
                    // if xCheck is greater than or equal too xLen then continue
                    // if yCheck is greater than or equal too yLen then continue



                    if (xOffset == 0 && yOffset == 0) continue;
                    else if (xCheck < 0) continue;
                    else if (yCheck < 0) continue;
                    else if (xCheck >= xLen) continue;
                    else if (yCheck >= yLen) continue;

                    if (universe[xCheck, yCheck] == true) count++;
                }
            }
            return count;
        }
        private int CountNeighborsToroidal(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;
                    // if xOffset and yOffset are both equal to 0 then continue
                    // if xCheck is less than 0 then set to xLen - 1
                    // if yCheck is less than 0 then set to yLen - 1
                    // if xCheck is greater than or equal too xLen then set to 0
                    // if yCheck is greater than or equal too yLen then set to 0
                    if (xOffset == 0 & yOffset == 0) continue;

                    if (xCheck < 0) xCheck = xLen - 1;

                    if (yCheck < 0) yCheck = yLen - 1;

                    if (xCheck >= xLen) xCheck = 0;

                    if (yCheck >= yLen) yCheck = 0;

                    if (universe[xCheck, yCheck] == true) count++;
                }
            }
            return count;
        }
        // Calculate the next generation of cells
        private void NextGeneration()
        {
            int uniX = universe.GetLength(0);
            int uniY = universe.GetLength(1);
            bool[,] scratchPad = new bool[uniX, uniY];
            for (int y = 0; y < scratchPad.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < scratchPad.GetLength(0); x++)
                {
                    scratchPad[x, y] = false;
                }
            }

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    int count = 0;

                    if (isFinite == true)
                        count = CountNeighborFinite(x, y);
                    else if (isFinite == false)
                        count = CountNeighborsToroidal(x, y);

                    bool cellLives = false;
                    // Apply the 4 rules to see if the cell dies or lives in the next gen
                    if (universe[x, y] == true) // if cell is alive
                    {
                        if (count < 2) // rule 1
                            cellLives = false; // cell dies
                        else if (count > 3) // rule 2
                            cellLives = false; // cell dies
                        else if (count == 2 || count == 3) // rule 3
                            cellLives = true; // cell lives
                        else cellLives = false;

                    }
                    else // if cell is dead
                    {
                        if (count == 3) // rule 4
                            cellLives = true; // cell lives
                        else cellLives = false;
                    }

                    // Turn it on/off in the scratchPad
                    if (cellLives == true)
                        scratchPad[x, y] = true;
                    else scratchPad[x, y] = false;
                }
            }

            // Copy from scratchPad to universe
            bool[,] temp = universe;
            universe = scratchPad;
            scratchPad = temp;

            // Increment generation count
            generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();

            graphicsPanel1.Invalidate();
        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // dont include Invalidate inside the Paint!!!!

            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            float cellWidth = graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            float cellHeight = graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    RectangleF cellRect = RectangleF.Empty;
                    cellRect.X = cellRect.X;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        #region Mouse Click Functions
        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                float cellWidth = graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
                float cellHeight = graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                float x = e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                float y = e.Y / cellHeight;

                // Toggle the cell's state
                universe[(int)x, (int)y] = !universe[(int)x, (int)y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // exit from menu
        {
            this.Close(); // close this window
        }

        private void toolStripButton3_Click(object sender, EventArgs e) // next gen button on tool bar
        {
            NextGeneration();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) // turn it on 
        {
            timer.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e) // turn it off
        {
            timer.Enabled = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e) // save button on tool bar
        {

        }

        private void openToolStripButton_Click(object sender, EventArgs e) // open button on tool bar
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e) // new button on tool bar
        {
            generations = 0;
            toolStripStatusLabelGenerations.Text = "Generations = 0";
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }

            graphicsPanel1.Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) // new from menu
        {
            generations = 0;
            toolStripStatusLabelGenerations.Text = "Generations = 0";
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }

            graphicsPanel1.Invalidate();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://linktr.ee/ethanstanks");
        }
        private void randomUniTimeToolStripMenuItem_Click(object sender, EventArgs e) // Random Time Click Event
        {
            // resets generation
            generations = 0;
            toolStripStatusLabelGenerations.Text = "Generations = 0";

            //Clears the Universe
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }

            // Makes Randoms Cells Alive in the Universe
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (rng.Next(1, 4) == 1) // if rng is 1 make cell alive
                        universe[x, y] = true;
                    else universe[x, y] = false;
                }
            }

            graphicsPanel1.Invalidate();
        }

        #endregion // Region of Click Functions

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ColorComboBox.Text == "Light Mode")
            {
                ColorComboBox.BackColor = Color.White;
                ColorComboBox.ForeColor = Color.Black;
                CountNeighborsComboBox.BackColor = Color.White;
                CountNeighborsComboBox.ForeColor = Color.Black;
                graphicsPanel1.BackColor = Color.White;
                toolStrip1.BackColor = Color.White;
                toolStrip1.ForeColor = Color.Black;
                menuStrip1.BackColor = Color.White;
                menuStrip1.ForeColor = Color.Black;
                statusStrip1.BackColor = Color.White;
                statusStrip1.ForeColor = Color.Black;
                gridColor = Color.Black;
                cellColor = Color.Gray;
                graphicsPanel1.Invalidate();
            }
            else if (ColorComboBox.Text == "Dark Mode")
            {
                ColorComboBox.BackColor = Color.Black;
                ColorComboBox.ForeColor = Color.LightSlateGray;
                CountNeighborsComboBox.BackColor = Color.Black;
                CountNeighborsComboBox.ForeColor = Color.LightSlateGray;
                graphicsPanel1.BackColor = Color.Black;
                toolStrip1.BackColor = Color.Black;
                toolStrip1.ForeColor = Color.LightSlateGray;
                menuStrip1.BackColor = Color.Black;
                menuStrip1.ForeColor = Color.LightSlateGray;
                statusStrip1.BackColor = Color.Black;
                statusStrip1.ForeColor = Color.LightSlateGray;
                gridColor = Color.DarkGray;
                cellColor = Color.LightSlateGray;
                graphicsPanel1.Invalidate();
            }
        } // Color Mode Combo Box

        private void CountNeighborsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CountNeighborsComboBox.Text == "Finite")
            {
                isFinite = true;
            }
            else if (CountNeighborsComboBox.Text == "Toroidal")
            {
                isFinite = false;
            }
        } // Count Neighbors Combo Box

    }
}
