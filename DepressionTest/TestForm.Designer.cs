using System.ComponentModel;

namespace DepressionTest
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.minMaxButton = new FontAwesome.Sharp.IconButton();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LabelName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CheckBox3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CheckBox0 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.minMaxButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 47);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 35;
            this.minimizeButton.Location = new System.Drawing.Point(822, 11);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(38, 35);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // minMaxButton
            // 
            this.minMaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minMaxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minMaxButton.FlatAppearance.BorderSize = 0;
            this.minMaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minMaxButton.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.minMaxButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.minMaxButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minMaxButton.IconSize = 35;
            this.minMaxButton.Location = new System.Drawing.Point(866, 9);
            this.minMaxButton.Name = "minMaxButton";
            this.minMaxButton.Size = new System.Drawing.Size(38, 38);
            this.minMaxButton.TabIndex = 1;
            this.minMaxButton.UseVisualStyleBackColor = true;
            this.minMaxButton.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.closeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 35;
            this.closeButton.Location = new System.Drawing.Point(910, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 38);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 488);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.LabelName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 80);
            this.panel4.TabIndex = 0;
            // 
            // LabelName
            // 
            this.LabelName.Font = new System.Drawing.Font("Bebas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.White;
            this.LabelName.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LabelName.Location = new System.Drawing.Point(88, 20);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(277, 46);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Тест на Депрессию\r\n";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.guna2Button1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(359, 368);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 74);
            this.panel5.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CustomizableEdges = customizableEdges1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(12, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.guna2Button1.Size = new System.Drawing.Size(189, 74);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Далее";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(12, 74);
            this.panel6.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.CheckBox3);
            this.panel3.Controls.Add(this.CheckBox2);
            this.panel3.Controls.Add(this.CheckBox1);
            this.panel3.Controls.Add(this.CheckBox0);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(371, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 488);
            this.panel3.TabIndex = 2;
            // 
            // CheckBox3
            // 
            this.CheckBox3.Animated = true;
            this.CheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox3.CheckedState.BorderRadius = 0;
            this.CheckBox3.CheckedState.BorderThickness = 0;
            this.CheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox3.Font = new System.Drawing.Font("Bebas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox3.ForeColor = System.Drawing.Color.White;
            this.CheckBox3.Location = new System.Drawing.Point(29, 275);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(531, 79);
            this.CheckBox3.TabIndex = 5;
            this.CheckBox3.Text = "Я не чувствую себя расстроенным печальным";
            this.CheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBox3.UncheckedState.BorderRadius = 0;
            this.CheckBox3.UncheckedState.BorderThickness = 0;
            this.CheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // CheckBox2
            // 
            this.CheckBox2.Animated = true;
            this.CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox2.CheckedState.BorderRadius = 0;
            this.CheckBox2.CheckedState.BorderThickness = 0;
            this.CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox2.Font = new System.Drawing.Font("Bebas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox2.ForeColor = System.Drawing.Color.White;
            this.CheckBox2.Location = new System.Drawing.Point(29, 190);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(531, 79);
            this.CheckBox2.TabIndex = 4;
            this.CheckBox2.Text = "Я не чувствую себя расстроенным печальным";
            this.CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBox2.UncheckedState.BorderRadius = 0;
            this.CheckBox2.UncheckedState.BorderThickness = 0;
            this.CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // CheckBox1
            // 
            this.CheckBox1.Animated = true;
            this.CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox1.CheckedState.BorderRadius = 0;
            this.CheckBox1.CheckedState.BorderThickness = 0;
            this.CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox1.Font = new System.Drawing.Font("Bebas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox1.ForeColor = System.Drawing.Color.White;
            this.CheckBox1.Location = new System.Drawing.Point(29, 20);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(531, 79);
            this.CheckBox1.TabIndex = 3;
            this.CheckBox1.Text = "Я не чувствую себя расстроенным печальным";
            this.CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBox1.UncheckedState.BorderRadius = 0;
            this.CheckBox1.UncheckedState.BorderThickness = 0;
            this.CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBox1.UseVisualStyleBackColor = false;
            // 
            // CheckBox0
            // 
            this.CheckBox0.Animated = true;
            this.CheckBox0.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox0.CheckedState.BorderRadius = 0;
            this.CheckBox0.CheckedState.BorderThickness = 0;
            this.CheckBox0.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox0.Font = new System.Drawing.Font("Bebas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox0.ForeColor = System.Drawing.Color.White;
            this.CheckBox0.Location = new System.Drawing.Point(29, 105);
            this.CheckBox0.Name = "CheckBox0";
            this.CheckBox0.Size = new System.Drawing.Size(531, 79);
            this.CheckBox0.TabIndex = 2;
            this.CheckBox0.Text = "Я не чувствую себя расстроенным печальным";
            this.CheckBox0.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBox0.UncheckedState.BorderRadius = 0;
            this.CheckBox0.UncheckedState.BorderThickness = 0;
            this.CheckBox0.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 535);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private FontAwesome.Sharp.IconButton minMaxButton;
        private FontAwesome.Sharp.IconButton minimizeButton;

        private FontAwesome.Sharp.IconButton closeButton;

        private Guna.UI2.WinForms.Guna2CheckBox CheckBox1;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBox2;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBox3;

        private Guna.UI2.WinForms.Guna2CheckBox CheckBox0;

        private Guna.UI2.WinForms.Guna2Button guna2Button1;

        private System.Windows.Forms.Label LabelName;

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;

        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

        #endregion
    }
}