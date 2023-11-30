using System.Drawing.Text;
using System.Drawing;
using System.IO;

using GameboardGUI;
using System.Web;

namespace oneillogame
{
    public partial class Form1 : Form
    {
        GameboardImageArray BoardGUI;

        public string tileImagePath = Directory.GetCurrentDirectory() + @"\images\"; //Get images for the empty, black and white boxes
        public int[,] BoardArray = new int[8, 8]; //Size of the board
        public int currentPlayer = 1; // 1 for player 1 (white), 2 for player 2 (black)
        public int whiteTokenCount; //Amount of tokens white player have on the grid
        public int blackTokenCount;//Amount of tokens black player have on the grid
        string playerDefaultPlayer1 = "Player #1"; //default player 1 name if they leave it blank
        string playerDefaultPlayer2 = "Player #2"; //default player 2 name if they leave it blank
        public bool gameStarted = false; //condition of the game
        public bool informationPanelChecked = false;
        Point topCorner, bottomCorner;

        //SaveAndRestore saveAndRestore = new SaveAndRestore();

        public Form1()
        {
            InitializeComponent();

            PopulateBoardArray();

            DisplayBoardArray();


            menuInformationPanel.Checked = true;

            menuSpeak.Checked = false;




        }

        //Main form
        private void Form1_Load(object sender, EventArgs e)
        {
            //Hide Maximize and Minimize buttons when app launches
            MaximizeBox = false;
            MinimizeBox = false;
            //Player Indicator visibility before clicking Start Game
            playerIndicator.Visible = false;
            playerIndicator2.Visible = false;
            //Token counters hidden before clicking Start Game
            playerWhiteNumberOfTokens.Visible = false;
            playerBlackNumberOfTokens.Visible = false;

        }

        #region ///***All the options on Menu Strip***/// 
        /// ***All the options of Menu Strip***///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //Game tab> Game button
        private void menuGame_Click(object sender, EventArgs e)
        {

        }
        //Game tab>Start game option
        private void menuStartGame_Click(object sender, EventArgs e)
        {
            gameStarted = true;
            playerWhiteName.Enabled = false;
            playerBlackName.Enabled = false;
            playerWhiteNumberOfTokens.Visible = true;
            playerBlackNumberOfTokens.Visible = true;
            playerIndicator.Visible = true;
            playerIndicator2.Visible = true;
            SetupBoardGUI();

            // Set the default names for players if they leave blank
            if (string.IsNullOrEmpty(playerWhiteName.Text))
            {
                playerWhiteName.Text = playerDefaultPlayer1;
            }
            if (string.IsNullOrEmpty(playerBlackName.Text))
            {
                playerBlackName.Text = playerDefaultPlayer2;
            }

            // Check if the playerIndicator2 is visible
            if (playerIndicator.Visible)
            {
                // If it is, hide the playerIndicator
                playerIndicator2.Visible = false;
            }
            else
            {
                // If playerIndicator2 is not visible, show the playerIndicator
                playerIndicator.Visible = true;
            }

        }
        //Game tab> Save game option
        private void menuSaveGame_Click(object sender, EventArgs e)
        {
            //saveAndRestore.SaveGameState();
        }
        //Game tab> Restore game option
        private void menuRestoreGame_Click(object sender, EventArgs e)
        {
            //saveAndRestore.LoadGameState();
        }


        //Game tab>Exit game option
        private void menuExitGame_Click(object sender, EventArgs e)
        {
            Form1 exit = new();
            this.Close();
        }
        //Menu Strip (Settings Tab)
        private void menuStripSettings_Click(object sender, EventArgs e)
        {

        }
        //Settings tab>Information Panel
        private void menuInformationPanel_Click(object sender, EventArgs e)
        {
            playersGameStat.Visible = !playersGameStat.Visible;
            informationPanelChecked = !informationPanelChecked;
            menuInformationPanel.Checked = informationPanelChecked;
        }

        //Settings>Speak
        private void menuSpeak_Click(object sender, EventArgs e)
        {

        }
        //Menu strip (Help Tab)
        private void menuStripHelp_Click(object sender, EventArgs e)
        {

        }
        //Help>About
        private void menuAbout_Click(object sender, EventArgs e)
        {
            AboutPage about = new();
            about.Show();
        }
        #endregion

        #region///***Player Information Panel***/// 
        /// ***Player Information Panels***///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        #region///**White Player info**/// <summary>
        /// **White Player info**///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>er Tokens
        private void playerWhiteNumberOfTokens_Click(object sender, EventArgs e)
        {

        }
        //White Player name bar
        private void playerWhiteName_TextChanged(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                if (string.IsNullOrEmpty(playerWhiteName.Text))
                {
                    playerWhiteName.Text = playerDefaultPlayer1;
                }
            }
        }
        #endregion

        #region///**Black Plyer info**/// <summary>
        /// **Black Plyer info**///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>yer Tokens
        private void playerBlackNumberOfTokens_Click(object sender, EventArgs e)
        {

        }

        //Black Player name bar
        private void playerBlackName_TextChanged(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                if (string.IsNullOrEmpty(playerBlackName.Text))
                {
                    playerBlackName.Text = playerDefaultPlayer2;
                }
            }
        }
        #endregion
        #endregion

        #region///***Grid***/// 
        /// ***Grid***///
        /// </summary>

        public void DisplayBoardArray()
        {

        }

        private void ShowBoardArray_Clicked(object sender, EventArgs e)
        {

        }

        private void PopulateBoardArray()
        {
            {
                /// Clear the board ///
                for (int row = 0; row < 8; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        BoardArray[row, col] = 10; // Set all cells to empty initially
                    }
                }

                // Set the starting markers
                BoardArray[3, 3] = 0; // White marker
                BoardArray[4, 4] = 0; // White marker
                BoardArray[3, 4] = 1; // Black marker
                BoardArray[4, 3] = 1; // Black marker

                // Update the GUI/board display after setting initial markers
                //DisplayBoardArray();
            }
        }
        private void SetupBoardGUI()
        {
            topCorner = new Point(100, 30);
            bottomCorner = new Point(100, 100);

            BoardGUI = new GameboardImageArray(this, BoardArray, topCorner, bottomCorner, 0, tileImagePath);
            BoardGUI.TileClicked += new GameboardImageArray.TileClickedEventDelegate(Which_Element_Clicked);
            BoardGUI.UpdateBoardGui(BoardArray);


        }
        private void Which_Element_Clicked(Object sender, EventArgs e)
        {
            if (gameStarted)
            {
                int selectedRow = BoardGUI.GetCurrentRowIndex(sender);
                int selectedCol = BoardGUI.GetCurrentColumnIndex(sender);

                HandleBoxClick(selectedRow, selectedCol);
            }
        }

        private void HandleBoxClick(int row, int col)
        {

            // Check if the clicked box is empty (value 10)
            if (BoardArray[row, col] == 10)
            {
                // Set the box value based on the current player's turn
                if (currentPlayer == 1)
                {
                    BoardArray[row, col] = 1; // Mark as white
                    whiteTokenCount++;
                    playerWhiteNumberOfTokens.Text = $"{whiteTokenCount}";

                    // Show playerIndicator for player 2
                    playerIndicator.Visible = false;
                    playerIndicator2.Visible = true;
                }
                else if (currentPlayer == 0)
                {
                    BoardArray[row, col] = 0; // Mark as black
                    blackTokenCount++;
                    playerBlackNumberOfTokens.Text = $"{blackTokenCount}";

                    // Show playerIndicator for player 1
                    playerIndicator.Visible = true;
                    playerIndicator2.Visible = false;
                }

                // Switch player turns
                currentPlayer = (currentPlayer == 0) ? 1 : 0;

                BoardGUI.SetTile(row, col, currentPlayer.ToString());

            }
        }
        #endregion
    }
}