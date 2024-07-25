

#region using statements

using DataJuggler.PixelDatabase;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using System.Drawing.Design;
using System.Text;
using DataJuggler.UltimateHelper;
using DataJuggler.UltimateHelper.Objects;
using System.Xml.Schema;

#endregion

namespace TextImagery
{

    #region class MainForm
    /// <summary>
    /// This class is the MainForm for this app.
    /// </summary>
    public partial class MainForm : Form, ITextChanged
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events
            
            #region OnTextChanged(Control sender, string path)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string path)
            {
                // If the text Exists On Disk
                if (FileHelper.Exists(path))
                {
                    // get the documentText
                    string documentText = File.ReadAllText(path);

                    // Get the lines
                    List<TextLine> lines = TextHelper.GetTextLines(documentText);

                    // If the lines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(lines))
                    {
                        // Set the count
                        CountControl.Text = lines.Count.ToString();

                        // update the UI
                        Refresh();
                        Application.DoEvents();
                    }
                }
            }
            #endregion

            #region StartButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'StartButton' is clicked.
            /// </summary>
            private void StartButton_Click(object sender, EventArgs e)
            {
                // Options - This was used for debugging, it could be taken out now that it works
                bool drawNumberRectangle = true;
                bool drawNumberText = true;
                bool changeColorNumberText = true;
                bool drawBottomRectangle = true;
                bool drawBottomext = true;
                bool changeColorBottomText = true;

                // locals
                string query = "";                
                PixelInformation pixel = null;
                PixelQuery pixelQuery = null;
                string text = "";

                // Get the path
                string listFile = ListFileSelector.Text;

                // Get the document text
                string documentText = File.ReadAllText(listFile);

                // Parse on space only
                char[] delimiters = new char[] { ' ' };

                // Get the lines
                List<TextLine> textLines = TextHelper.GetTextLines(documentText, true, delimiters);

                // Get the source path
                string source = FileSelector.Text;

                // Set the outputfolder
                string outputFolder = OutputFolderSelector.Text;

                // Set the count
                int count = CountControl.IntValue;

                // Setup the Graph
                SetupGraph(true, true, "Starting...", count, 0);

                // Create a font
                Font font = new Font(FontNameControl.Text, FontSizeControl.IntValue, FontStyle.Regular);

                // Shortcut
                string newLine = Environment.NewLine;

                // Load the pixelDatabase
                PixelDatabase pixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(source, null);

                // Load the pixelDatabase
                int margin = pixelDatabase.Height - 200;

                // Where to draw the number
                Point location = new Point(100, 100);

                 // Where to draw the number
                Point location2 = new Point(960, margin + 100);

                // iterate 1 - count
                for (int x = 0; x < count; x++)
                {
                    // Clone the pixelDatabase
                    PixelDatabase copy = pixelDatabase.Clone();

                    // if drawNumberRectangle is true
                    if (drawNumberRectangle)
                    {
                        // Draw a Rectangle
                        query = "Update" + newLine + "Set Color " + BackgroundColorControl.Text + newLine + "Where" + newLine + "X < 200" + newLine + "Y < 200" + newLine;

                        // Apply the query
                        pixelQuery = copy.ApplyQuery(query, null);

                        // Get the pixel
                        pixel = copy.GetPixel(0, 0);
                    }

                    // if the pixel exists
                    if (NullHelper.Exists(pixel))
                    {
                        // if drawNumberText is true
                        if (drawNumberText)
                        {
                            // Get the text
                            text = (x + 1).ToString();

                            // Draw Text
                            copy.DrawText(text, font, location, StringAlignment.Center, StringAlignment.Center);
                        }

                        // if changeColorNumberText is true
                        if (changeColorNumberText)
                        {
                            // Run a query to change the text to the text color
                            query = "Update" + newLine + "Set Color " + TextColor.Text + newLine + "Where" + newLine + "Total < " + (pixel.Total -1) + newLine + "X < 200" + newLine + "Y < 200" + newLine;

                            // Apply Query
                            pixelQuery = copy.ApplyQuery(query, null);
                        }

                        // Now update the bottom
                        if (ListHelper.HasXOrMoreItems(textLines, x + 1))
                        {
                            // if drawBottomRectangle is true
                            if (drawBottomRectangle)
                            {
                                // Now draw the bottom rectangle
                                query = "Update" + newLine + "Set Color " + BackgroundColorControl.Text + newLine + "Where" + newLine + "Y > " + margin;

                                // Apply this query
                                pixelQuery = copy.ApplyQuery(query, null);
                            }

                            if (drawBottomext)
                            {
                                // Set the text
                                TextLine textLine = textLines[x];

                                // If the value for the property textLine.HasWords is true
                                if (textLine.HasWords)
                                {
                                    // iterate the words                            
                                    foreach (Word word in textLine.Words)
                                    {
                                        // Set each word to Uppercase
                                        word.Text = TextHelper.CapitalizeFirstChar(word.Text);
                                    }
                                }

                                // Export the words
                                text = TextHelper.ExportWords(textLine.Words);

                                // Draw Text
                                copy.DrawText(text, font, location2, StringAlignment.Center, StringAlignment.Center);
                            }

                            if (changeColorBottomText)
                            {
                                // Run a second query to update the color to TextColor
                                query = "Update" + newLine + "Set Color" + TextColor.Text + newLine + "Where" + newLine + "Total < " + (pixel.Total - 1) + newLine + "Y > " + margin;

                                // Apply this query
                                pixelQuery = copy.ApplyQuery(query, null);
                            }
                        }

                        // Get the outputFile
                        string outputFile = Path.Combine(outputFolder, "Image" + (x + 1) + ".png");

                        // Save the file
                        copy.SaveAs(outputFile);

                        // Setup the graph
                        SetupGraph(true, true, "Status: Image: " + text, count, x);
                    }
                }

                // Setup the graph
                SetupGraph(true, false, "Done", count, 0);
            }
            #endregion

        #endregion

        #region Methods

            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Set the projectPath
                string projectPath = FolderHelper.FindParentDirectory(Environment.CurrentDirectory, "TextImagery");

                // Wire up
                ListFileSelector.OnTextChangedListener = this;

                // Set the default font name
                FontNameControl.Text = "Impact";

                // Default size
                FontSizeControl.Text = "80";
                
                // If the projectPath string exists
                if (TextHelper.Exists(projectPath))
                {
                    // Set hte listFilePath
                    string listFilePath = Path.Combine(projectPath, "Data", "List of 100.txt");

                    // Set the text
                    ListFileSelector.Text = listFilePath;

                    // Test Only
                    FileSelector.Text = Path.Combine(projectPath, "Images", "StableAudio.png");
                }

                // If you don't have a Temp directory on C, what is wrong with you?
                if (Directory.Exists(@"C:\Temp"))
                {
                    // Set Output Folder
                    OutputFolderSelector.Text = "C:\\Temp";
                }

                // Set to a dark gray
                BackgroundColorControl.Text = "12 12 18";
                TextColor.Text = "GhostWhite";
            }
            #endregion

            #region SetupGraph()
            /// <summary>
            /// Setup Graph
            /// </summary>
            public void SetupGraph(bool statusLabelVisible, bool graphVisible, string text, int max, int graphValue)
            {
                // Show or hide
                StatusLabel.Visible = statusLabelVisible;
                StatusLabel.Text = text;
                Graph.Visible = graphVisible;
                Graph.Value = graphValue;

                // Update the UI
                Refresh();
                Application.DoEvents();
            }
            #endregion

        #endregion

    }
    #endregion

}
