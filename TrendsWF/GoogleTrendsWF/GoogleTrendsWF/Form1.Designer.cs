namespace GoogleTrendsWF
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.RadioButton2 = new MetroFramework.Controls.MetroRadioButton();
      this.InputBox = new MetroFramework.Controls.MetroTextBox();
      this.RadioButton3 = new MetroFramework.Controls.MetroRadioButton();
      this.RadioButton1 = new MetroFramework.Controls.MetroRadioButton();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.searchPictureBox = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel1.Location = new System.Drawing.Point(10, 78);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(123, 25);
      this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
      this.metroLabel1.TabIndex = 0;
      this.metroLabel1.Text = "Еnter keyword:";
      this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
      // 
      // RadioButton2
      // 
      this.RadioButton2.AutoSize = true;
      this.RadioButton2.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
      this.RadioButton2.Location = new System.Drawing.Point(13, 198);
      this.RadioButton2.Name = "RadioButton2";
      this.RadioButton2.Size = new System.Drawing.Size(114, 19);
      this.RadioButton2.Style = MetroFramework.MetroColorStyle.Black;
      this.RadioButton2.TabIndex = 1;
      this.RadioButton2.Text = "Only countries";
      this.RadioButton2.Theme = MetroFramework.MetroThemeStyle.Light;
      this.RadioButton2.UseSelectable = true;
      // 
      // InputBox
      // 
      // 
      // 
      // 
      this.InputBox.CustomButton.Image = null;
      this.InputBox.CustomButton.Location = new System.Drawing.Point(220, 2);
      this.InputBox.CustomButton.Name = "";
      this.InputBox.CustomButton.Size = new System.Drawing.Size(25, 25);
      this.InputBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.InputBox.CustomButton.TabIndex = 1;
      this.InputBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.InputBox.CustomButton.UseSelectable = true;
      this.InputBox.CustomButton.Visible = false;
      this.InputBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
      this.InputBox.Lines = new string[0];
      this.InputBox.Location = new System.Drawing.Point(13, 107);
      this.InputBox.MaxLength = 50;
      this.InputBox.Name = "InputBox";
      this.InputBox.PasswordChar = '\0';
      this.InputBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.InputBox.SelectedText = "";
      this.InputBox.SelectionLength = 0;
      this.InputBox.SelectionStart = 0;
      this.InputBox.ShortcutsEnabled = true;
      this.InputBox.ShowClearButton = true;
      this.InputBox.Size = new System.Drawing.Size(248, 30);
      this.InputBox.Style = MetroFramework.MetroColorStyle.Blue;
      this.InputBox.TabIndex = 4;
      this.InputBox.Theme = MetroFramework.MetroThemeStyle.Light;
      this.InputBox.UseSelectable = true;
      this.InputBox.UseStyleColors = true;
      this.InputBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.InputBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      // 
      // RadioButton3
      // 
      this.RadioButton3.AutoSize = true;
      this.RadioButton3.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
      this.RadioButton3.Location = new System.Drawing.Point(13, 222);
      this.RadioButton3.Name = "RadioButton3";
      this.RadioButton3.Size = new System.Drawing.Size(88, 19);
      this.RadioButton3.Style = MetroFramework.MetroColorStyle.Black;
      this.RadioButton3.TabIndex = 5;
      this.RadioButton3.Text = "Only cities";
      this.RadioButton3.Theme = MetroFramework.MetroThemeStyle.Light;
      this.RadioButton3.UseSelectable = true;
      // 
      // RadioButton1
      // 
      this.RadioButton1.AutoSize = true;
      this.RadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
      this.RadioButton1.Location = new System.Drawing.Point(13, 176);
      this.RadioButton1.Name = "RadioButton1";
      this.RadioButton1.Size = new System.Drawing.Size(40, 19);
      this.RadioButton1.Style = MetroFramework.MetroColorStyle.Black;
      this.RadioButton1.TabIndex = 6;
      this.RadioButton1.Text = "All";
      this.RadioButton1.Theme = MetroFramework.MetroThemeStyle.Light;
      this.RadioButton1.UseSelectable = true;
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel2.Location = new System.Drawing.Point(9, 148);
      this.metroLabel2.Margin = new System.Windows.Forms.Padding(0);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(170, 25);
      this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
      this.metroLabel2.TabIndex = 8;
      this.metroLabel2.Text = "Select type of results:";
      this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
      // 
      // searchPictureBox
      // 
      this.searchPictureBox.BackColor = System.Drawing.Color.Transparent;
      this.searchPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
      this.searchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("searchPictureBox.Image")));
      this.searchPictureBox.Location = new System.Drawing.Point(260, 101);
      this.searchPictureBox.Name = "searchPictureBox";
      this.searchPictureBox.Size = new System.Drawing.Size(39, 40);
      this.searchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.searchPictureBox.TabIndex = 13;
      this.searchPictureBox.TabStop = false;
      this.searchPictureBox.Click += new System.EventHandler(this.searchPictureBox_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.BackLocation = MetroFramework.Forms.BackLocation.BottomLeft;
      this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
      this.ClientSize = new System.Drawing.Size(310, 258);
      this.Controls.Add(this.searchPictureBox);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.RadioButton1);
      this.Controls.Add(this.RadioButton3);
      this.Controls.Add(this.InputBox);
      this.Controls.Add(this.RadioButton2);
      this.Controls.Add(this.metroLabel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Resizable = false;
      this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
      this.Style = MetroFramework.MetroColorStyle.Red;
      this.Text = "Google Trends Analisys";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroRadioButton RadioButton2;
    private MetroFramework.Controls.MetroTextBox InputBox;
    private MetroFramework.Controls.MetroRadioButton RadioButton3;
    private MetroFramework.Controls.MetroRadioButton RadioButton1;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private System.Windows.Forms.PictureBox searchPictureBox;
  }
}

