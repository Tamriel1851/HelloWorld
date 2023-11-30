using System;
using System.Drawing;
using System.Windows.Forms;

public class ONeilloGame : Form
{
    private Label titleLabel;
    private MenuStrip menuStrip;
    private ToolStripMenuItem fileMenuItem;
    private ToolStripMenuItem exitMenuItem;
    private ToolStripMenuItem helpMenuItem;
    private ToolStripMenuItem aboutMenuItem;
    private Panel gameplayArea;
    private Panel gameInformationPanel;
    private Label player1Label;
    private Label player2Label;
    private Label nextPlayerLabel;

    public ONeilloGame()
    {
        this.Text = APP_NAME;
        this.Icon = APP_ICON;
        this.Size = new Size(WINDOW_WIDTH, WINDOW_HEIGHT);

        // Title bar
        titleLabel = new Label
        {
            Text = APP_NAME,
            Font = new Font("Arial", 20, FontStyle.Bold),
            Location = new Point(350, 20),
            AutoSize = true
        };
        this.Controls.Add(titleLabel);

        // Menu bar
        menuStrip = new MenuStrip
        {
            Location = new Point(0, 0),
            Size = new Size(WINDOW_WIDTH, 24)
        };

        fileMenuItem = new ToolStripMenuItem
        {
            Text = "&File"
        };
        menuStrip.Items.Add(fileMenuItem);

        exitMenuItem = new ToolStripMenuItem
        {
            Text = "&Exit"
        };
        fileMenuItem.DropDownItems.Add(exitMenuItem);
        exitMenuItem.Click += (sender, e) => Application.Exit();

        helpMenuItem = new ToolStripMenuItem
        {
            Text = "&Help"
        };
        menuStrip.Items.Add(helpMenuItem);

        aboutMenuItem = new ToolStripMenuItem
        {
            Text = "&About"
        };
        helpMenuItem.DropDown