namespace test {
partial class Form1 {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed;
  /// otherwise, false.</param>
  protected override void Dispose(bool disposing) {
    if (disposing && (components != null)) {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

#region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent() {
    this.label1 = new System.Windows.Forms.Label();
    this.lbPlayer = new System.Windows.Forms.Label();
    this.label2 = new System.Windows.Forms.Label();
    this.lbWinner = new System.Windows.Forms.Label();
    this.pb1x1 = new System.Windows.Forms.PictureBox();
    this.pb1x2 = new System.Windows.Forms.PictureBox();
    this.pb1x3 = new System.Windows.Forms.PictureBox();
    this.pb2x3 = new System.Windows.Forms.PictureBox();
    this.pb2x2 = new System.Windows.Forms.PictureBox();
    this.pb2x1 = new System.Windows.Forms.PictureBox();
    this.pb3x3 = new System.Windows.Forms.PictureBox();
    this.pb3x2 = new System.Windows.Forms.PictureBox();
    this.pb3x1 = new System.Windows.Forms.PictureBox();
    this.label3 = new System.Windows.Forms.Label();
    this.btRestart = new System.Windows.Forms.Button();
    ((System.ComponentModel.ISupportInitialize)(this.pb1x1)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb1x2)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb1x3)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb2x3)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb2x2)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb2x1)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb3x3)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb3x2)).BeginInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb3x1)).BeginInit();
    this.SuspendLayout();
    //
    // label1
    //
    this.label1.AutoSize = true;
    this.label1.Font = new System.Drawing.Font(
        "Monorama-SemiBold", 26.25F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label1.ForeColor = System.Drawing.SystemColors.Control;
    this.label1.Location = new System.Drawing.Point(30, 21);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(107, 44);
    this.label1.TabIndex = 0;
    this.label1.Text = "Turn:";
    //
    // lbPlayer
    //
    this.lbPlayer.AutoSize = true;
    this.lbPlayer.Font = new System.Drawing.Font(
        "Tahoma", 26.25F, System.Drawing.FontStyle.Italic,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.lbPlayer.ForeColor = System.Drawing.SystemColors.Control;
    this.lbPlayer.Location = new System.Drawing.Point(65, 84);
    this.lbPlayer.Name = "lbPlayer";
    this.lbPlayer.Size = new System.Drawing.Size(160, 42);
    this.lbPlayer.TabIndex = 1;
    this.lbPlayer.Text = "Player 01";
    //
    // label2
    //
    this.label2.AutoSize = true;
    this.label2.Font = new System.Drawing.Font(
        "Monorama-SemiBold", 26.25F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label2.ForeColor = System.Drawing.SystemColors.Control;
    this.label2.Location = new System.Drawing.Point(30, 155);
    this.label2.Name = "label2";
    this.label2.Size = new System.Drawing.Size(148, 44);
    this.label2.TabIndex = 2;
    this.label2.Text = "Winner:";
    //
    // lbWinner
    //
    this.lbWinner.AutoSize = true;
    this.lbWinner.Font = new System.Drawing.Font(
        "Tahoma", 26.25F, System.Drawing.FontStyle.Italic,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.lbWinner.ForeColor = System.Drawing.SystemColors.Control;
    this.lbWinner.Location = new System.Drawing.Point(65, 224);
    this.lbWinner.Name = "lbWinner";
    this.lbWinner.Size = new System.Drawing.Size(195, 42);
    this.lbWinner.TabIndex = 3;
    this.lbWinner.Text = "In Progress";
    //
    // pb1x1
    //
    this.pb1x1.Cursor = System.Windows.Forms.Cursors.Hand;
    this.pb1x1.Image = global::test.Properties.Resources.question_mark_96;
    this.pb1x1.Location = new System.Drawing.Point(444, 113);
    this.pb1x1.Name = "pb1x1";
    this.pb1x1.Size = new System.Drawing.Size(120, 120);
    this.pb1x1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    this.pb1x1.TabIndex = 13;
    this.pb1x1.TabStop = false;
    this.pb1x1.Click += new System.EventHandler(this.pb1x1_Click);
    //
    // pb1x2
    //
    this.pb1x2.Cursor = System.Windows.Forms.Cursors.Hand;
    this.pb1x2.Image = global::test.Properties.Resources.question_mark_96;
    this.pb1x2.Location = new System.Drawing.Point(658, 113);
    this.pb1x2.Name = "pb1x2";
    this.pb1x2.Size = new System.Drawing.Size(120, 120);
    this.pb1x2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    this.pb1x2.TabIndex = 14;
    this.pb1x2.TabStop = false;
    this.pb1x2.Click += new System.EventHandler(this.pb1x2_Click);
    //
    // pb1x3
    //
    this.pb1x3.Cursor = System.Windows.Forms.Cursors.Hand;
    this.pb1x3.Image = global::test.Properties.Resources.question_mark_96;
    this.pb1x3.Location = new System.Drawing.Point(872, 113);
    this.pb1x3.Name = "pb1x3";
    this.pb1x3.Size = new System.Drawing.Size(120, 120);
    this.pb1x3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    this.pb1x3.TabIndex = 15;
    this.pb1x3.TabStop = false;
    this.pb1x3.Click += new System.EventHandler(this.pb1x3_Click);
    //
    // pb2x3
    //
    this.pb2x3.Cursor = System.Windows.Forms.Cursors.Hand;
    this.pb2x3.Image = global::test.Properties.Resources.question_mark_96;
    this.pb2x3.Location = new System.Drawing.Point(872, 305);
    this.pb2x3.Name = "pb2x3";
    this.pb2x3.Size = new System.Drawing.Size(120, 120);
    this.pb2x3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    this.pb2x3.TabIndex = 18;
    this.pb2x3.TabStop = false;
    this.pb2x3.Click += new System.EventHandler(this.pb2x3_Click);
    //
    // pb2x2
    //
    this.pb2x2.Cursor = System.Windows.Forms.Cursors.Hand;
    this.pb2x2.Image = global::test.Properties.Resources.question_mark_96;
    this.pb2x2.Location = new System.Drawing.Point(658, 305);
    this.pb2x2.Name = "pb2x2";
    this.pb2x2.Size = new System.Drawing.Size(120, 120);
    this.pb2x2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    this.pb2x2.TabIndex = 17;
    this.pb2x2.TabStop = false;
    this.pb2x2.Click += new System.EventHandler(this.pb2x2_Click);
    //
    // pb2x1
    //
    this.pb2x1.Cursor = System.Windows.Forms.Cursors.Hand;
    this.pb2x1.Image = global::test.Properties.Resources.question_mark_96;
    this.pb2x1.Location = new System.Drawing.Point(444, 305);
    this.pb2x1.Name = "pb2x1";
    this.pb2x1.Size = new System.Drawing.Size(120, 120);
    this.pb2x1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    this.pb2x1.TabIndex = 16;
    this.pb2x1.TabStop = false;
    this.pb2x1.Click += new System.EventHandler(this.pb2x1_Click);
    //
    // pb3x3
    //
    this.pb3x3.Cursor = System.Windows.Forms.Cursors.Hand;
    this.pb3x3.Image = global::test.Properties.Resources.question_mark_96;
    this.pb3x3.Location = new System.Drawing.Point(872, 483);
    this.pb3x3.Name = "pb3x3";
    this.pb3x3.Size = new System.Drawing.Size(120, 120);
    this.pb3x3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    this.pb3x3.TabIndex = 21;
    this.pb3x3.TabStop = false;
    this.pb3x3.Click += new System.EventHandler(this.pb3x3_Click);
    //
    // pb3x2
    //
    this.pb3x2.Cursor = System.Windows.Forms.Cursors.Hand;
    this.pb3x2.Image = global::test.Properties.Resources.question_mark_96;
    this.pb3x2.Location = new System.Drawing.Point(658, 483);
    this.pb3x2.Name = "pb3x2";
    this.pb3x2.Size = new System.Drawing.Size(120, 120);
    this.pb3x2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    this.pb3x2.TabIndex = 20;
    this.pb3x2.TabStop = false;
    this.pb3x2.Click += new System.EventHandler(this.pb3x2_Click);
    //
    // pb3x1
    //
    this.pb3x1.Cursor = System.Windows.Forms.Cursors.Hand;
    this.pb3x1.Image = global::test.Properties.Resources.question_mark_96;
    this.pb3x1.Location = new System.Drawing.Point(444, 483);
    this.pb3x1.Name = "pb3x1";
    this.pb3x1.Size = new System.Drawing.Size(120, 120);
    this.pb3x1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
    this.pb3x1.TabIndex = 19;
    this.pb3x1.TabStop = false;
    this.pb3x1.Click += new System.EventHandler(this.pb3x1_Click);
    //
    // label3
    //
    this.label3.AutoSize = true;
    this.label3.Font = new System.Drawing.Font(
        "Monorama-SemiBold", 47.99999F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label3.ForeColor = System.Drawing.SystemColors.Control;
    this.label3.Location = new System.Drawing.Point(485, 9);
    this.label3.Name = "label3";
    this.label3.Size = new System.Drawing.Size(428, 79);
    this.label3.TabIndex = 22;
    this.label3.Text = "Tic-Tac-Toe";
    this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    //
    // btRestart
    //
    this.btRestart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
    this.btRestart.Location = new System.Drawing.Point(37, 361);
    this.btRestart.Name = "btRestart";
    this.btRestart.Size = new System.Drawing.Size(223, 64);
    this.btRestart.TabIndex = 23;
    this.btRestart.Text = "Restart";
    this.btRestart.UseVisualStyleBackColor = true;
    this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
    //
    // Form1
    //
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
    this.CancelButton = this.btRestart;
    this.ClientSize = new System.Drawing.Size(1064, 681);
    this.Controls.Add(this.btRestart);
    this.Controls.Add(this.label3);
    this.Controls.Add(this.pb3x3);
    this.Controls.Add(this.pb3x2);
    this.Controls.Add(this.pb3x1);
    this.Controls.Add(this.pb2x3);
    this.Controls.Add(this.pb2x2);
    this.Controls.Add(this.pb2x1);
    this.Controls.Add(this.pb1x3);
    this.Controls.Add(this.pb1x2);
    this.Controls.Add(this.pb1x1);
    this.Controls.Add(this.lbWinner);
    this.Controls.Add(this.label2);
    this.Controls.Add(this.lbPlayer);
    this.Controls.Add(this.label1);
    this.Name = "Form1";
    this.Text = "Tic-Tac-Toe";
    this.Load += new System.EventHandler(this.Form1_Load);
    this.Paint +=
        new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
    ((System.ComponentModel.ISupportInitialize)(this.pb1x1)).EndInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb1x2)).EndInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb1x3)).EndInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb2x3)).EndInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb2x2)).EndInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb2x1)).EndInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb3x3)).EndInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb3x2)).EndInit();
    ((System.ComponentModel.ISupportInitialize)(this.pb3x1)).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

#endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label lbPlayer;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label lbWinner;
  private System.Windows.Forms.PictureBox pb1x1;
  private System.Windows.Forms.PictureBox pb1x2;
  private System.Windows.Forms.PictureBox pb1x3;
  private System.Windows.Forms.PictureBox pb2x3;
  private System.Windows.Forms.PictureBox pb2x2;
  private System.Windows.Forms.PictureBox pb2x1;
  private System.Windows.Forms.PictureBox pb3x3;
  private System.Windows.Forms.PictureBox pb3x2;
  private System.Windows.Forms.PictureBox pb3x1;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Button btRestart;
}
}
