using System;
using System.Drawing;
using System.Windows.Forms;

namespace test {
public partial class Form1 : Form {
  public Form1() {
    InitializeComponent();

    Boxes[0, 0] = pb1x1;
    Boxes[0, 1] = pb1x2;
    Boxes[0, 2] = pb1x3;
    Boxes[1, 0] = pb2x1;
    Boxes[1, 1] = pb2x2;
    Boxes[1, 2] = pb2x3;
    Boxes[2, 0] = pb3x1;
    Boxes[2, 1] = pb3x2;
    Boxes[2, 2] = pb3x3;
  }

  // VARIABLES
  PictureBox[,] Boxes = new PictureBox[3, 3];
  private int[,] Grid = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
  private byte Player = 1;
  private byte MoveCount = 0;

  // FUNCTIONS
  private void SetPlayerLableText(string S) { lbPlayer.Text = S; }

  private void SetPlayerLableColor(System.Drawing.Color C) {
    lbPlayer.ForeColor = C;
  }

  private void SetWinnerLableText(string S) { lbWinner.Text = S; }

  private void SetWinnerLableColor(System.Drawing.Color C) {
    lbWinner.ForeColor = C;
  }

  private void MakeMove(byte x, byte y, PictureBox pix) {
    MoveCount++;
    Grid[x, y] = Player;
    CheckPixBox(x, y, pix);

    if (MoveCount < 9) {
      SetPlayerLableText("Player 0" + Convert.ToString(Player));

      if (CheckTheGrid(Player)) {
        GameOver();
        return;
      }

      Player = (Player == 1)? Player = 2 : Player = 1;
      return;
    } else if (MoveCount >= 9) {
      GameOver();
    }
  }

  private void DisablePixBox(PictureBox pix) { pix.Enabled = false; }

  private void DisableAllPixBox() {
    for (byte i = 0; i < 3; i++) {
      for (byte j = 0; j < 3; j++) {
        DisablePixBox(Boxes[i, j]);
      }
    }
  }

  private void EnablePixBox(PictureBox pix) { pix.Enabled = true; }

  private void EnableAllPixBox() {
    for (byte i = 0; i < 3; i++) {
      for (byte j = 0; j < 3; j++) {
        EnablePixBox(Boxes[i, j]);
      }
    }
  }

  private void SetPixBoxImage(PictureBox pix, System.Drawing.Image Pix) {
    pix.Image = Pix;
  }

  private void SetAllPixBoxImage(System.Drawing.Image Pix) {
    for (byte i = 0; i < 3; i++) {
      for (byte j = 0; j < 3; j++) {
        SetPixBoxImage(Boxes[i, j], Pix);
      }
    }
  }

  private void SetPixBoxColor(System.Drawing.Color Col, PictureBox Pix) {
    Pix.BackColor = Col;
  }

  private void SetAllPixBoxColor(System.Drawing.Color Col) {
    for (byte i = 0; i < 3; i++) {
      for (byte j = 0; j < 3; j++) {
        SetPixBoxColor(Col, Boxes[i, j]);
      }
    }
  }

  private void GameOver() {
    DisableAllPixBox();

    SetWinnerLableColor(Color.Green);
    SetPlayerLableColor(Color.Red);

    // INVERTED IF TRICK
    if (!CheckPlayer(1) || MoveCount >= 9) {
      if (CheckPlayer(2) && MoveCount < 9) {
        SetWinnerLableText("Player 02");
      } else {
        SetWinnerLableText("DRAW");
      }
    } else {
      SetWinnerLableText("Player 01");
    }

    SetPlayerLableText("GAME OVER");
  }

  private void ResetAllPixBox() {
    EnableAllPixBox();
    SetAllPixBoxImage(Properties.Resources.question_mark_96);
    SetAllPixBoxColor(Color.Transparent);
  }

  private void RestartGame() {
    ResetGrid();
    ResetAllPixBox();
    SetPlayerLableText("Player 01");
    SetPlayerLableColor(Color.White);

    SetWinnerLableText("In Progress");
    SetWinnerLableColor(Color.White);

    Player = 1;
    MoveCount = 0;
  }

  private void ResetGrid() {
    for (byte i = 0; i < 3; i++) {
      for (byte j = 0; j < 3; j++) {
        Grid[i, j] = 0;
      }
    }
  }

  private bool CheckTheGrid(int x) {
    // ROWS
    for (int row = 0; row < 3; row++) {
      if (Grid[row, 0] != 0 && Grid[row, 0] == Grid[row, 1] &&
          Grid[row, 1] == Grid[row, 2])
        return true;
    }

    // COLUMNS
    for (int col = 0; col < 3; col++) {
      if (Grid[0, col] != 0 && Grid[0, col] == Grid[1, col] &&
          Grid[1, col] == Grid[2, col])
        return true;
    }

    // DIAGNOALS
    if (Grid[0, 0] != 0 && Grid[0, 0] == Grid[1, 1] &&
        Grid[1, 1] == Grid[2, 2]) {
      SetPixBoxColor(Color.Green, Boxes[0, 0]);
      SetPixBoxColor(Color.Green, Boxes[1, 1]);
      SetPixBoxColor(Color.Green, Boxes[2, 2]);

      return true;
    }

    if (Grid[0, 2] != 0 && Grid[0, 2] == Grid[1, 1] &&
        Grid[1, 1] == Grid[2, 0]) {
      SetPixBoxColor(Color.Green, Boxes[0, 2]);
      SetPixBoxColor(Color.Green, Boxes[1, 1]);
      SetPixBoxColor(Color.Green, Boxes[2, 0]);

      return true;
    }

    return false;
  }

  private bool CheckPlayer(byte x) { return Player == x; }

  private bool CheckPixBox(byte x, byte y, PictureBox pix) {
    if (CheckPlayer(1)) {
      SetPixBoxImage(pix, Properties.Resources.X);
      return true;
    } else if (CheckPlayer(2)) {
      SetPixBoxImage(pix, Properties.Resources.O);
      return true;
    }

    return false;
  }

  private void Form1_Paint_1(object sender, PaintEventArgs e) {
    Color white = Color.White;
    Pen pen = new Pen(white);
    pen.Width = 10;

    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

    e.Graphics.DrawLine(pen, 400, 460, 1050, 460);
    e.Graphics.DrawLine(pen, 400, 260, 1050, 260);

    e.Graphics.DrawLine(pen, 610, 140, 610, 620);
    e.Graphics.DrawLine(pen, 810, 140, 810, 620);
  }

  private void Form1_Load(object sender, EventArgs e) {
    Form form = new Form();
    form.Text = "Tic-Tac-Toe";
  }

  private void pb1x1_Click(object sender, EventArgs e) {
    MakeMove(0, 0, Boxes[0, 0]);
  }

  private void pb1x2_Click(object sender, EventArgs e) {
    MakeMove(0, 1, Boxes[0, 1]);
  }

  private void pb1x3_Click(object sender, EventArgs e) {
    MakeMove(0, 2, Boxes[0, 2]);
  }

  private void pb2x1_Click(object sender, EventArgs e) {
    MakeMove(1, 0, Boxes[1, 0]);
  }

  private void pb2x2_Click(object sender, EventArgs e) {
    MakeMove(1, 1, Boxes[1, 1]);
  }

  private void pb2x3_Click(object sender, EventArgs e) {
    MakeMove(1, 2, Boxes[1, 2]);
  }

  private void pb3x1_Click(object sender, EventArgs e) {
    MakeMove(2, 0, Boxes[2, 0]);
  }

  private void pb3x2_Click(object sender, EventArgs e) {
    MakeMove(2, 1, Boxes[2, 1]);
  }

  private void pb3x3_Click(object sender, EventArgs e) {
    MakeMove(2, 2, Boxes[2, 2]);
  }

  private void btRestart_Click(object sender, EventArgs e) { RestartGame(); }
}
}
