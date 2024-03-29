﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        // The universe array
        private bool[,] universe = new bool[30, 30];

        // Drawing colors
        private Color gridColor = Color.Black;
        private Color cellColor = Color.Gray;

        // The Timer class
        private Timer timer = new Timer();

        // Generation count
        private int generations = 0;

        // Neighbor Bool - True if finite - False if Toroidal
        private bool isFinite = true;

        // Show/Hide Grid Bool - True if show - False if hide
        private bool showGrid = true;

        // Show/Hide Count Neighbor Bool - True if show - False if hide
        private bool showCount = true;

        // Show/Hide HUD Bool - True if show - False if hide
        private bool showHUD = true;

        // Current Amount of Living Cells
        private int aliveCount = 0;

        // Time Variable
        private int miliTime = 100;

        // Seed Variable
        private Int32 seed = 0;

        // Time Variable RNG
        private string rngTime = string.Empty;

        // File Name String
        private string FileName = string.Empty;

        // X and Y variables for Universe for Settings
        private int updateX = 30;
        private int updateY = 30;



        public Form1()
        {
            InitializeComponent();

            // Color Change ComboBox Default
            ColorComboBox.SelectedIndex = 1;
            // CountNeighbors ComboBox Default
            CountNeighborsComboBox.SelectedIndex = 0;

            // Reading the Properties
            ReadProperties();

            // Setup the timer
            timer.Interval = miliTime; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
        }

        #region Random Methods
        private void RandomSeed(Int32 seed) // Random.Next with a seed
        {
            // Random Number with Seed
            Random rngS = new Random(seed); // instance of Random with a passed seed
            RandomNext(rngS); // calls the random universe method with the Random Seed instance

        }
        private void RandomTime()
        {
            // Random Number with Time
            Random rngT = new Random(); // instance of Random with time
            seed = Environment.TickCount;
            RandomNext(rngT); // calls the random universe method with time rng instance
        }
        private void RandomNext(Random objRng)
        {
            ClearUniverse(); // Clears the Universe and resets the status bar

            // Makes Randoms Cells Alive in the Universe
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (objRng.Next(1, 4) == 1) // if objRng.Next is 1 make cell alive
                        universe[x, y] = true;
                    else universe[x, y] = false;
                }
            }
            toolStripStatusLabelSeed.Text = "Seed: " + seed.ToString();
            graphicsPanel1.Invalidate();
        }
        #endregion

        #region Properties Settings Methods
        private void ReadProperties()
        {
            ColorComboBox.SelectedIndex = Properties.Settings.Default.ColorComboBoxIndex; // Sets the Color Combo Box Index to the saved index
            ColorComboBox.Text = Properties.Settings.Default.ColorComboBoxText; // Sets the Color Combo Box Text to the saved text
            miliTime = Properties.Settings.Default.MiliTime; // Sets the Generation Speed to the saved speed
            CountNeighborsComboBox.SelectedIndex = Properties.Settings.Default.CountComboBoxIndex; // Sets the CountNeighbors Combo Box Index to the saved index
            CountNeighborsComboBox.Text = Properties.Settings.Default.CountComboBoxText; // Sets the CountNeighbors Combo Box Text to the saved text
            isFinite = Properties.Settings.Default.IsFinite; // Sets isFinite to the saved bool value
            showCount = Properties.Settings.Default.ShowCount; // Sets showCount to the saved bool value
            hideNeighborCountToolStripMenuItem.Text = Properties.Settings.Default.HideCountText; // Sets the Hide Count button text
            showGrid = Properties.Settings.Default.ShowGrid; // Sets showGrid to the saved bool value
            hideGridToolStripMenuItem.Text = Properties.Settings.Default.HideGridText; // Sets the Hide Grid button text
            showHUD = Properties.Settings.Default.ShowHud; // Sets the showHUD to the saved bool value
            hideHeadsUpDisplayToolStripMenuItem.Text = Properties.Settings.Default.HideHudText; // Sets the Hide Hud button text

            updateX = Properties.Settings.Default.X; // Sets the X of the universe to the saved default
            updateY = Properties.Settings.Default.Y; // Sets the Y of the universe to the saved default
            UpdateUniSize(updateX, updateY);
            graphicsPanel1.Invalidate();
        }
        private void UpdateProperties()
        {
            Properties.Settings.Default.ColorComboBoxIndex = ColorComboBox.SelectedIndex; // Saves the Color Combo Box Index
            Properties.Settings.Default.ColorComboBoxText = ColorComboBox.Text; // Saves the Color Combo Box Text
            Properties.Settings.Default.MiliTime = miliTime; // Saves the Generation Speed

            Properties.Settings.Default.CountComboBoxIndex = CountNeighborsComboBox.SelectedIndex; // Saves the CountNeighbors Combo Box Index
            Properties.Settings.Default.CountComboBoxText = CountNeighborsComboBox.Text; // Saves the CountNeighbors Combo Box Text
            Properties.Settings.Default.IsFinite = isFinite; // Saves isFinite value
            Properties.Settings.Default.ShowCount = showCount; // Saves showCount value
            Properties.Settings.Default.ShowGrid = showGrid; // Saves showGrid value

            Properties.Settings.Default.HideGridText = hideGridToolStripMenuItem.Text; // Saves the Hide Grid button text
            Properties.Settings.Default.HideCountText = hideNeighborCountToolStripMenuItem.Text; // Saves the Hide Count button text

            Properties.Settings.Default.X = updateX;
            Properties.Settings.Default.Y = updateY;

            Properties.Settings.Default.ShowHud = showHUD; // Saves the showHUD bool
            Properties.Settings.Default.HideHudText = hideHeadsUpDisplayToolStripMenuItem.Text; // Sabes the Hide HUD button text
        }
        #endregion

        #region Universe Methods

        private void UpdateUniSize(int x, int y)
        {
            bool[,] updateUni = new bool[x, y];
            bool[,] temp = universe;
            universe = updateUni;
            updateUni = temp;
        }
        private void ClearUniverse()
        {
            generations = 0; // resets generation count to 0
            toolStripStatusLabelGenerations.Text = "Generations = 0"; // resets the generation status bar
            aliveCount = 0; // resets alive count to 0
            livingCellStripStatusLabel1.Text = "Cells Alive = 0"; // resets the alive count status bar
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false; // sets the current cell to dead
                }
            }

            graphicsPanel1.Invalidate();
        }

        #endregion

        #region Count Methods
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
                    if (xOffset == 0 && yOffset == 0) continue;

                    if (xCheck < 0) xCheck = xLen - 1;

                    if (yCheck < 0) yCheck = yLen - 1;

                    if (xCheck >= xLen) xCheck = 0;

                    if (yCheck >= yLen) yCheck = 0;

                    if (universe[xCheck, yCheck] == true) count++;
                }
            }
            return count;
        }

        // gets the count for either Finite or Toroidal
        private int GetCount(int x, int y)
        {
            int count = 0;
            if (isFinite == true)
                count = CountNeighborFinite(x, y);
            else if (isFinite == false)
                count = CountNeighborsToroidal(x, y);
            return count;
        }
        #endregion

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            aliveCount = 0;  // resetting the alive cell status to 0
            int uniX = universe.GetLength(0);
            int uniY = universe.GetLength(1);
            bool[,] scratchPad = new bool[uniX, uniY];
            for (int y = 0; y < scratchPad.GetLength(1); y++)
            {
                // Iterate through the scratchPad in the x, left to right to set everything to dead
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
                    int count = GetCount(x, y);

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
                    {
                        scratchPad[x, y] = true;
                        aliveCount++; // updates the status count of Alive Cells
                    }
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

            // Update status strip Living Cells
            livingCellStripStatusLabel1.Text = "Cells Alive = " + aliveCount.ToString();

            graphicsPanel1.Invalidate();
        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        } // everytime the timer ticks

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
                    if (showGrid == true) e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

                    // Show Neighbor Count if True
                    if (showCount == true)
                    {
                        int count = GetCount(x, y); // gets the cells 

                        Font font = new Font("Arial", 10f);
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;

                        if (universe[x, y] == true) e.Graphics.DrawString(count.ToString(), font, Brushes.MistyRose, cellRect, stringFormat);
                        else if (count > 0) e.Graphics.DrawString(count.ToString(), font, Brushes.MistyRose, cellRect, stringFormat);

                    }

                }
            } // end of for loop

            // If Show HUD is true
            if (showHUD == true)
            {
                Font font = new Font("Segoe UI", 16f);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Near;
                stringFormat.LineAlignment = StringAlignment.Far;

                string HUD = "Generations: " + generations + "\nCell Count: " + aliveCount + "\nBoundary Type: " + CountNeighborsComboBox.Text + "\nUniverse Size: [" + universe.GetLength(0) + "," + universe.GetLength(1) + "]";
                if (ColorComboBox.Text == "Light Mode" || ColorComboBox.Text == "Turtle Mode")
                {
                    e.Graphics.DrawString(HUD, font, Brushes.Black, graphicsPanel1.ClientRectangle, stringFormat);
                }
                else
                {
                    e.Graphics.DrawString(HUD, font, Brushes.White, graphicsPanel1.ClientRectangle, stringFormat);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();

            livingCellStripStatusLabel1.Text = "Cells Alive = " + aliveCount; // update the status bar
        }

        #region Mouse Click Functions
        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e) // if user clicks on a cell
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
                if (universe[(int)x, (int)y] == true)
                {
                    aliveCount++;
                    livingCellStripStatusLabel1.Text = "Cells Alive = " + aliveCount;
                }
                else
                {
                    if (aliveCount >= 1) aliveCount--;
                    livingCellStripStatusLabel1.Text = "Cells Alive = " + aliveCount;
                }

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
            SaveFile();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) // save button menu click event
        {
            SaveFile();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) // Save as button menu click event
        {
            SaveAs();
        }

        private void openToolStripButton_Click(object sender, EventArgs e) // open button on tool bar
        {
            OpenFile();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e) // open from menu strip
        {
            OpenFile();
        }
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportFile();
        }

        private void newToolStripButton_Click(object sender, EventArgs e) // new button on tool bar
        {
            timer.Enabled = false; // Stop the timer
            ClearUniverse(); // Clears the Universe and Resets Status Bar
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) // new from menu
        {
            ClearUniverse(); // Clears the Universe and Resets Status Bar
        }

        private void toolStripButton4_Click(object sender, EventArgs e) // button that takes the user to my link tree
        {
            System.Diagnostics.Process.Start("https://linktr.ee/ethanstanks");
        }
        private void randomUniTimeToolStripMenuItem_Click(object sender, EventArgs e) // Random Time Click Event
        {
            RandomTime(); // calls the Random Time method
            
        }
        private void changeSizeToolStripMenuItem_Click(object sender, EventArgs e) // change size of universe
        {
            UniSizeForm uniSize = new UniSizeForm(); // creates the instance of DialogForm
            uniSize.X = universe.GetLength(0); // sets the DialogForm x to the x of universe
            uniSize.Y = universe.GetLength(1); // sets the DialogForm y to the y of universe
            if (DialogResult.OK == uniSize.ShowDialog())
            {
                int x = uniSize.X; // sets x to DialogForm x
                updateX = uniSize.X;
                int y = uniSize.Y; // sets y to DialogForm y
                updateY = uniSize.Y;
                // resizes the universe array
                UpdateUniSize(x, y);
                graphicsPanel1.Invalidate();
            }
        }
        private void hideGridToolStripMenuItem_Click(object sender, EventArgs e) // Hide/Show Grid under View tab
        {
            // hiding the grid
            if (hideGridToolStripMenuItem.Text == "Hide Grid")
            {
                hideGridToolStripMenuItem.Text = "Show Grid";
                showGrid = false;
            }
            else // showing the gride
            {
                hideGridToolStripMenuItem.Text = "Hide Grid";
                showGrid = true;
            }
            graphicsPanel1.Invalidate();
        }
        private void raToolStripMenuItem_Click(object sender, EventArgs e) // Generate new universe with a seed
        {
            RandomSeedForm dlg = new RandomSeedForm(); // Making an instance of the RandomSeedForm
            if (DialogResult.OK == dlg.ShowDialog()) // If dlg.ShowDialog returns with OK
            {
                seed = dlg.GetNumber(); // gets the seed that the user enters
                RandomSeed(seed); // calls the RandomSeed method passing the seed
            }
        }
        private void generationSpeedToolStripMenuItem_Click(object sender, EventArgs e) // Change generation time click
        {
            SpeedForm dlg = new SpeedForm(); // Making an instance of the Speed Form
            dlg.Speed = miliTime; // displays the current set time in the form
            if (DialogResult.OK == dlg.ShowDialog()) // If dlg.ShowDialog returns with OK
            {
                miliTime = dlg.Speed; // sets miliTime to the number the user inputed
                timer.Interval = miliTime; // updates the time interval
            }
        }
        private void hideNeighborCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hiding the neighbor count
            if (hideNeighborCountToolStripMenuItem.Text == "Hide Neighbor Count")
            {
                hideNeighborCountToolStripMenuItem.Text = "Show Neighbor Count";
                showCount = false;
            }
            else // showing neighbor count
            {
                hideNeighborCountToolStripMenuItem.Text = "Hide Neighbor Count";
                showCount = true;
            }
            graphicsPanel1.Invalidate();

        } // Hide Neighbor Count

        private void hideHeadsUpDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hiding HUD
            if (hideHeadsUpDisplayToolStripMenuItem.Text == "Hide HUD")
            {
                hideHeadsUpDisplayToolStripMenuItem.Text = "Show HUD";
                showHUD = false;
            }
            else // showing HUD
            {
                hideHeadsUpDisplayToolStripMenuItem.Text = "Hide HUD";
                showHUD = true;
            }
            graphicsPanel1.Invalidate();
        } // Hide HUD

        #endregion // Region of Click Functions

        #region Combo Box Functions

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ColorComboBox.Text == "Light Mode")
            {
                ColorComboBox.BackColor = Color.White; // Color Changer Combo Box Background
                ColorComboBox.ForeColor = Color.Black; // Color Changer Combo Box Text
                CountNeighborsComboBox.BackColor = Color.White; // Count Neighbor Combo Box Background
                CountNeighborsComboBox.ForeColor = Color.Black; // Count Neighbor Combo Box Text
                toolStrip1.BackColor = Color.White; // Tool Strip Background
                toolStrip1.ForeColor = Color.Black; // Tool Strip Text
                menuStrip1.BackColor = Color.White; // Menu Strip Background
                menuStrip1.ForeColor = Color.Black; // Menu Strip Text
                statusStrip1.BackColor = Color.White; // Status Strip Background
                statusStrip1.ForeColor = Color.Black; // Status Strip Text

                graphicsPanel1.BackColor = Color.Silver; // Dead Cells
                gridColor = Color.Black; // Grid Lines
                cellColor = Color.DarkGray; // Alive Cells
                graphicsPanel1.Invalidate();
            }
            else if (ColorComboBox.Text == "Dark Mode")
            {
                ColorComboBox.BackColor = Color.Black; // Color Changer Combo Box Background
                ColorComboBox.ForeColor = Color.LightSlateGray; // Color Changer Combo Box Text
                CountNeighborsComboBox.BackColor = Color.Black; // Count Neighbor Combo Box Background
                CountNeighborsComboBox.ForeColor = Color.LightSlateGray; // Count Neighbor Combo Box Text
                toolStrip1.BackColor = Color.Black; // Tool Strip Background
                toolStrip1.ForeColor = Color.LightSlateGray; // Tool Strip Text
                menuStrip1.BackColor = Color.Black; // Menu Strip Background
                menuStrip1.ForeColor = Color.LightSlateGray; // Menu Strip Text
                statusStrip1.BackColor = Color.Black; // Status Strip Background
                statusStrip1.ForeColor = Color.LightSlateGray; // Status Strip Text

                graphicsPanel1.BackColor = Color.Black; // Dead Cells
                gridColor = Color.DarkGray; // Grid Lines
                cellColor = Color.LightSlateGray; // Alive Cells
                graphicsPanel1.Invalidate();
            }
            else if (ColorComboBox.Text == "Bee Mode")
            {
                ColorComboBox.BackColor = Color.LightGoldenrodYellow; // Color Changer Combo Box Background
                ColorComboBox.ForeColor = Color.Black; // Color Changer Combo Box Text
                CountNeighborsComboBox.BackColor = Color.LightGoldenrodYellow; // Count Neighbor Combo Box Background
                CountNeighborsComboBox.ForeColor = Color.Black; // Count Neighbor Combo Box Text
                toolStrip1.BackColor = Color.Goldenrod; // Tool Strip Background
                toolStrip1.ForeColor = Color.Black; // Tool Strip Text
                menuStrip1.BackColor = Color.LightGoldenrodYellow; // Menu Strip Background
                menuStrip1.ForeColor = Color.Black; // Menu Strip Text
                statusStrip1.BackColor = Color.LightGoldenrodYellow; // Status Strip Background
                statusStrip1.ForeColor = Color.Black; // Status Strip Text

                graphicsPanel1.BackColor = Color.DarkGoldenrod; // Dead Cells
                gridColor = Color.Black; // Grid Lines
                cellColor = Color.Black; // Alive Cells
                graphicsPanel1.Invalidate();
            }
            else if (ColorComboBox.Text == "Turtle Mode")
            {
                ColorComboBox.BackColor = Color.DarkSeaGreen; // Color Changer Combo Box Background
                ColorComboBox.ForeColor = Color.Black; // Color Changer Combo Box Text
                CountNeighborsComboBox.BackColor = Color.DarkSeaGreen; // Count Neighbor Combo Box Background
                CountNeighborsComboBox.ForeColor = Color.Black; // Count Neighbor Combo Box Text
                toolStrip1.BackColor = Color.OliveDrab; // Tool Strip Background
                toolStrip1.ForeColor = Color.Black; // Tool Strip Text
                menuStrip1.BackColor = Color.DarkSeaGreen; // Menu Strip Background
                menuStrip1.ForeColor = Color.Black; // Menu Strip Text
                statusStrip1.BackColor = Color.DarkSeaGreen; // Status Strip Background
                statusStrip1.ForeColor = Color.Black; // Status Strip Text

                graphicsPanel1.BackColor = Color.DarkOliveGreen; // Dead Cells
                gridColor = Color.Ivory; // Grid Lines
                cellColor = Color.BurlyWood; // Alive Cells
                graphicsPanel1.Invalidate();
            }
            else if (ColorComboBox.Text == "Mr.Mime Mode")
            {
                ColorComboBox.BackColor = Color.Thistle; // Color Changer Combo Box Background
                ColorComboBox.ForeColor = Color.BlueViolet; // Color Changer Combo Box Text 
                CountNeighborsComboBox.BackColor = Color.Thistle; // Count Neighbor Combo Box Background
                CountNeighborsComboBox.ForeColor = Color.BlueViolet; // Count Neighbor Combo Box Text
                toolStrip1.BackColor = Color.MediumOrchid; // Tool Strip Background
                toolStrip1.ForeColor = Color.BlueViolet; // Tool Strip Text
                menuStrip1.BackColor = Color.Thistle; // Menu Strip Background
                menuStrip1.ForeColor = Color.BlueViolet; // Menu Strip Text
                statusStrip1.BackColor = Color.Thistle; // Status Strip Background
                statusStrip1.ForeColor = Color.BlueViolet; // Status Strip Text

                graphicsPanel1.BackColor = Color.DarkSlateBlue; // Dead Cells
                gridColor = Color.DarkOrchid; // Grid Lines
                cellColor = Color.Plum; // Alive Cells
                graphicsPanel1.Invalidate();
            }
            else if (ColorComboBox.Text == "Strawberry Mode")
            {
                ColorComboBox.BackColor = Color.DarkRed; // Color Changer Combo Box Background
                ColorComboBox.ForeColor = Color.White; // Color Changer Combo Box Text 
                CountNeighborsComboBox.BackColor = Color.DarkRed; // Count Neighbor Combo Box Background
                CountNeighborsComboBox.ForeColor = Color.White; // Count Neighbor Combo Box Text
                toolStrip1.BackColor = Color.PaleGreen; // Tool Strip Background
                toolStrip1.ForeColor = Color.Black; // Tool Strip Text
                menuStrip1.BackColor = Color.DarkRed; // Menu Strip Background
                menuStrip1.ForeColor = Color.White; // Menu Strip Text
                statusStrip1.BackColor = Color.PaleGreen; // Status Strip Background
                statusStrip1.ForeColor = Color.Black; // Status Strip Text

                graphicsPanel1.BackColor = Color.LightCoral; // Dead Cells
                gridColor = Color.PaleGreen; // Grid Lines
                cellColor = Color.DarkRed; // Alive Cells
                graphicsPanel1.Invalidate();
            }
        } // Color Mode Combo Box

        private void CountNeighborsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if the combo box selection is changed to Finite or Toroidal
            if (CountNeighborsComboBox.Text == "Finite")
            {
                isFinite = true;
                graphicsPanel1.Invalidate();
            }
            else if (CountNeighborsComboBox.Text == "Toroidal")
            {
                isFinite = false;
                graphicsPanel1.Invalidate();
            }
        } // Count Neighbors Combo Box
        #endregion


        #region Context Menu for Graphics Panel 1

        private void clickEvent1ToolStripMenuItem_Click(object sender, EventArgs e) // Random Universe from Time - Context Menu
        {
            RandomTime(); // calls the Random Time method
        }

        private void clickEvent2ToolStripMenuItem_Click(object sender, EventArgs e) // Random Universe from Seed - Context Menu
        {
            RandomSeedForm dlg = new RandomSeedForm(); // Making an instance of the RandomSeedForm
            if (DialogResult.OK == dlg.ShowDialog()) // If dlg.ShowDialog returns with OK
            {
                seed = dlg.GetNumber(); // gets the seed that the user enters
                RandomSeed(seed); // calls the RandomSeed method passing the seed
            }
        }
        private void changeSizeToolStripMenuItem1_Click(object sender, EventArgs e) // Changes the Size of the Universe - Context Menu
        {
            UniSizeForm uniSize = new UniSizeForm(); // creates the instance of DialogForm
            uniSize.X = universe.GetLength(0); // sets the DialogForm x to the x of universe
            uniSize.Y = universe.GetLength(1); // sets the DialogForm y to the y of universe
            if (DialogResult.OK == uniSize.ShowDialog())
            {
                int x = uniSize.X; // sets x to DialogForm x
                int y = uniSize.Y; // sets y to DialogForm y
                // resizes the universe array
                bool[,] newUni = new bool[x, y];
                bool[,] temp = universe;
                universe = newUni;
                newUni = temp;
                graphicsPanel1.Invalidate();
            }
        }
        private void changeSpeedToolStripMenuItem_Click(object sender, EventArgs e) // Changes the Generation Speed - Context Menu
        {
            SpeedForm dlg = new SpeedForm(); // Making an instance of the Speed Form
            dlg.Speed = miliTime; // displays the current set time in the form
            if (DialogResult.OK == dlg.ShowDialog()) // If dlg.ShowDialog returns with OK
            {
                miliTime = dlg.Speed; // sets miliTime to the number the user inputed
                timer.Interval = miliTime; // updates the time interval
            }
        }

        #endregion

        #region Settings
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // when the form is closed
        {
            // Updating the Properties
            UpdateProperties();

            // Saves the Update
            Properties.Settings.Default.Save();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e) // Reset Click Event
        {
            Properties.Settings.Default.Reset();

            // Reading the Properties
            ReadProperties();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e) // Reload Click Event
        {
            Properties.Settings.Default.Reload();

            // Reading the Properties
            ReadProperties();

        }
        #endregion

        #region Save and Opening Functions

        private void SaveAs()
        {
            SaveFileDialog dlg = new SaveFileDialog(); // creates an instance of the save file dialog
            dlg.Filter = "All Files|*.*|Cells|*.cells"; // default ending for the file
            dlg.FilterIndex = 2; dlg.DefaultExt = "cells"; // selects which default to use and if they don't include one to just use .cells

            DateTime dateTime = DateTime.Now; // creates an instance of the date and time

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                FileName = dlg.FileName; // sets the FileName variable to what the user inputs
                // Write any comments you want to include
                writer.WriteLine("! " + dateTime.ToString("F")); // writes the current date and time into a comment

                int uniX = universe.GetLength(0);
                int uniY = universe.GetLength(1);
                // Iterate through the universe one row at a time.
                for (int y = 0; y < uniY; y++)
                {
                    // Create a string to represent the current row.
                    String currentRow = string.Empty;

                    // Iterate through the current row one cell at a time.
                    for (int x = 0; x < uniX; x++)
                    {
                        if (universe[x, y] == true) currentRow += "O"; // if alive append O to the row string
                        else if (universe[x, y] == false) currentRow += "."; // if dead append . to the row string
                    }

                    writer.WriteLine(currentRow); // write the current row to the file
                }

                writer.Close(); // closes the file after everything has been written
            }
        } //SaveAs function

        private void SaveFile()
        {
            if (string.IsNullOrEmpty(this.FileName)) SaveAs();
            else
            {
                StreamWriter writer = new StreamWriter(FileName);
                DateTime dateTime = DateTime.Now; // creates an instance of the date and time
                writer.WriteLine("! " + dateTime.ToString("F")); // writes the current date and time into a comment

                int uniX = universe.GetLength(0);
                int uniY = universe.GetLength(1);
                // Iterate through the universe one row at a time.
                for (int y = 0; y < uniY; y++)
                {
                    // Create a string to represent the current row.
                    String currentRow = string.Empty;

                    // Iterate through the current row one cell at a time.
                    for (int x = 0; x < uniX; x++)
                    {
                        if (universe[x, y] == true) currentRow += "O"; // if alive append O to the row string
                        else if (universe[x, y] == false) currentRow += "."; // if dead append . to the row string
                    }

                    writer.WriteLine(currentRow); // write the current row to the file
                }

                writer.Close(); // closes the file after everything has been written
            }
        } // Save Function

        private void OpenFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                timer.Enabled = false;
                generations = 0;

                for (int h = 0; h < universe.GetLength(1); h++)
                {
                    // Iterate through the universe in the x, left to right
                    for (int w = 0; w < universe.GetLength(0); w++)
                    {
                        universe[w, h] = false;
                    }
                }
                StreamReader reader = new StreamReader(dlg.FileName);
                aliveCount = 0; // resets aliveCount
                int maxWidth = 0; // width of the data in the file
                int maxHeight = 0; // height of the data in the file

                while (!reader.EndOfStream) // Iterates through the file once to get its size
                {
                    string row = reader.ReadLine(); // reads one row at a time

                    if (row[0] == '!') continue; // if the row starts with ! then it will continue
                    else
                    {
                        maxHeight++; // adds one to maxHeight to calculate the height of the data
                        maxWidth = row.Length; // sets the width to how long the row is of the data
                    }
                }

                int x = maxWidth; // sets x to maxWidth
                int y = maxHeight; // sets y to maxHeight
                // resizes the universe array
                bool[,] newUni = new bool[x, y];
                bool[,] temp = universe;
                universe = newUni;
                newUni = temp;
                graphicsPanel1.Invalidate();

                reader.BaseStream.Seek(0, SeekOrigin.Begin); // resets the file pointer to the beginning of the file

                int yPos = 0; // for the y position
                while (!reader.EndOfStream) // Iterates through the file again, this time reading in the cells
                {
                    string row = reader.ReadLine(); // reads one row at a time

                    if (row[0] == '!') continue; // if the row starts with ! then it will continue
                    else // if it's not !
                    {
                        for (int xPos = 0; xPos < row.Length; xPos++) // the row needs to be iterated through
                        {
                            if (row[xPos] == 'O') // if it is O then set that cell to alive
                            {
                                universe[xPos, yPos] = true;
                                aliveCount++; // update the aliveCount
                            }
                            else if (row[xPos] == '.') universe[xPos, yPos] = false; // if it is . then set that cell to dead
                        }
                        yPos++; // adds one to the yPos counter
                    }
                }
                FileName = dlg.FileName; // sets the FileName variable to the opened name
                livingCellStripStatusLabel1.Text = "Cells Alive = " + aliveCount; // updates alive count on status bar
                updateX = universe.GetLength(0);
                updateY = universe.GetLength(1);
                graphicsPanel1.Invalidate();
                reader.Close(); // closes the file
            }
        } // Open Function
        private void ImportFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                timer.Enabled = false;
                generations = 0;

                for (int h = 0; h < universe.GetLength(1); h++)
                {
                    // Iterate through the universe in the x, left to right
                    for (int w = 0; w < universe.GetLength(0); w++)
                    {
                        universe[w, h] = false; // sets everything to dead
                    }
                }
                StreamReader reader = new StreamReader(dlg.FileName);
                aliveCount = 0; // resets aliveCount
                int maxWidth = 0; // width of the data in the file
                int maxHeight = 0; // height of the data in the file

                while (!reader.EndOfStream) // Iterates through the file once to get its size
                {
                    string row = reader.ReadLine(); // reads one row at a time

                    if (row[0] == '!') continue; // if the row starts with ! then it will continue
                    else
                    {
                        maxHeight++; // adds one to maxHeight to calculate the height of the data
                        maxWidth = row.Length; // sets the width to how long the row is of the data
                    }
                }

                int x = maxWidth; // sets x to maxWidth
                int y = maxHeight; // sets y to maxHeight
                // makes a copy universe set to the size of the data
                bool[,] newUni = new bool[x, y];

                reader.BaseStream.Seek(0, SeekOrigin.Begin); // resets the file pointer to the beginning of the file

                int yPos = 0; // for the y position
                while (!reader.EndOfStream) // Iterates through the file again, this time reading in the cells
                {
                    string row = reader.ReadLine(); // reads one row at a time

                    if (row[0] == '!') continue; // if the row starts with ! then it will continue
                    else // if it's not !
                    {
                        for (int xPos = 0; xPos < row.Length; xPos++) // the row needs to be iterated through
                        {
                            if (row[xPos] == 'O') // if it is O then set that cell to alive
                            {
                                newUni[xPos, yPos] = true;
                            }
                            else if (row[xPos] == '.') newUni[xPos, yPos] = false; // if it is . then set that cell to dead
                        }
                        yPos++; // adds one to the yPos counter
                    }
                }
                int uniW = universe.GetLength(0);
                int uniH = universe.GetLength(1);
                if (uniW <= maxWidth && uniH <= maxHeight) // if the universe size is less than the copy
                {
                    for (int h = 0; h < uniH; h++)
                    {
                        // Iterate through the universe in the x, left to right
                        for (int w = 0; w < uniW; w++)
                        {
                            if (newUni[w, h] == true) // if the cell is alive in the copy uni
                            {
                                universe[w, h] = true;
                                aliveCount++; // update the aliveCount
                            }
                            else if (newUni[w, h] == false) universe[w, h] = false; // if the cell is dead in the copy uni
                        }
                    }
                }
                else
                { // if the copy size is less than the universe
                    reader.BaseStream.Seek(0, SeekOrigin.Begin); // resets the file pointer to the beginning of the file

                    yPos = 0; // for the y position
                    while (!reader.EndOfStream) // Iterates through the file again, this time reading in the cells
                    {
                        string row = reader.ReadLine(); // reads one row at a time

                        if (row[0] == '!') continue; // if the row starts with ! then it will continue
                        else // if it's not !
                        {
                            for (int xPos = 0; xPos < row.Length; xPos++) // the row needs to be iterated through
                            {
                                if (row[xPos] == 'O') // if it is O then set that cell to alive
                                {
                                    universe[xPos, yPos] = true;
                                }
                                else if (row[xPos] == '.') universe[xPos, yPos] = false; // if it is . then set that cell to dead
                            }
                            yPos++; // adds one to the yPos counter
                        }
                    }
                }


                FileName = dlg.FileName; // sets the FileName variable to the opened name
                livingCellStripStatusLabel1.Text = "Cells Alive = " + aliveCount; // updates alive count on status bar
                universe.GetLength(0);
                universe.GetLength(1);
                graphicsPanel1.Invalidate();
                reader.Close(); // closes the file


            }
        } // Importing Function

        private void OpenCell(string cellName)
        {
            // This will open a saved cell file that is in the debug folder

            timer.Enabled = false;
            generations = 0;

            for (int h = 0; h < universe.GetLength(1); h++)
            {
                // Iterate through the universe in the x, left to right
                for (int w = 0; w < universe.GetLength(0); w++)
                {
                    universe[w, h] = false;
                }
            }
            StreamReader reader = new StreamReader(@"Cells\" + cellName + ".cells");
            aliveCount = 0; // resets aliveCount
            int maxWidth = 0; // width of the data in the file
            int maxHeight = 0; // height of the data in the file

            while (!reader.EndOfStream) // Iterates through the file once to get its size
            {
                string row = reader.ReadLine(); // reads one row at a time

                if (row[0] == '!') continue; // if the row starts with ! then it will continue
                else
                {
                    maxHeight++; // adds one to maxHeight to calculate the height of the data
                    maxWidth = row.Length; // sets the width to how long the row is of the data
                }
            }

            int x = maxWidth; // sets x to maxWidth
            int y = maxHeight; // sets y to maxHeight
                               // resizes the universe array
            bool[,] newUni = new bool[x, y];
            bool[,] temp = universe;
            universe = newUni;
            newUni = temp;
            graphicsPanel1.Invalidate();

            reader.BaseStream.Seek(0, SeekOrigin.Begin); // resets the file pointer to the beginning of the file

            int yPos = 0; // for the y position
            while (!reader.EndOfStream) // Iterates through the file again, this time reading in the cells
            {
                string row = reader.ReadLine(); // reads one row at a time

                if (row[0] == '!') continue; // if the row starts with ! then it will continue
                else // if it's not !
                {
                    for (int xPos = 0; xPos < row.Length; xPos++) // the row needs to be iterated through
                    {
                        if (row[xPos] == 'O') // if it is O then set that cell to alive
                        {
                            universe[xPos, yPos] = true;
                            aliveCount++; // update the aliveCount
                        }
                        else if (row[xPos] == '.') universe[xPos, yPos] = false; // if it is . then set that cell to dead
                    }
                    yPos++; // adds one to the yPos counter
                }
            }
            livingCellStripStatusLabel1.Text = "Cells Alive = " + aliveCount; // updates alive count on status bar
            updateX = universe.GetLength(0);
            updateY = universe.GetLength(1);
            graphicsPanel1.Invalidate();
            reader.Close(); // closes the file
        }

        #endregion

        #region Saved Cells

        private void ethanStanksToolStripMenuItem_Click(object sender, EventArgs e) // Custom Cell Save - Ethan Stanks
        {
            OpenCell("EthanStanks");
        }

        private void germToolStripMenuItem_Click(object sender, EventArgs e) // Custom Cell Save - Germ
        {
            OpenCell("Germ");
        }

        private void glassesToolStripMenuItem_Click(object sender, EventArgs e) // Custom Cell Save - Glasses
        {
            OpenCell("Glasses");
        }

        private void gliderToolStripMenuItem_Click(object sender, EventArgs e) // Custom Cell Save - Glider
        {
            OpenCell("Glider");
        }

        private void gliderGunToolStripMenuItem_Click(object sender, EventArgs e) // Custom Cell Save - Glider Gun
        {
            OpenCell("Glider Gun");
        }

        private void growByOneToolStripMenuItem_Click(object sender, EventArgs e) // Custom Cell Save - Grow-By-One
        {
            OpenCell("GrowByOne");
        }

        private void oscillatorToolStripMenuItem_Click(object sender, EventArgs e) // Custom Cell Save - Oscillator
        {
            OpenCell("Oscillator");
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e) // Custom Cell Save - T
        {
            OpenCell("T");
        }

        private void gardenOfEdenToolStripMenuItem_Click(object sender, EventArgs e) // Custom Cell Save - Garden of Eden
        {
            OpenCell("GardenOfEden");
        }
        #endregion
    }
}
