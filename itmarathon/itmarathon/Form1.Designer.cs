namespace itmarathon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.emailicon = new System.Windows.Forms.PictureBox();
            this.loginbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.passwordicon = new System.Windows.Forms.PictureBox();
            this.minimizebutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.closebutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.connectionerror = new System.Windows.Forms.Label();
            this.emailerror = new System.Windows.Forms.Label();
            this.passworderror = new System.Windows.Forms.Label();
            this.loginerror = new System.Windows.Forms.Label();
            this.watchpassbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.emailicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchpassbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Email";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(53, 369);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(221, 23);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(-15, -15);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(75, 23);
            this.materialSingleLineTextField2.TabIndex = 1;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.Text = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "Parolă";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(53, 419);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(221, 23);
            this.materialSingleLineTextField3.TabIndex = 2;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autentificare în cont";
            // 
            // emailicon
            // 
            this.emailicon.BackColor = System.Drawing.Color.Transparent;
            this.emailicon.Cursor = System.Windows.Forms.Cursors.Default;
            this.emailicon.Image = ((System.Drawing.Image)(resources.GetObject("emailicon.Image")));
            this.emailicon.Location = new System.Drawing.Point(14, 364);
            this.emailicon.Name = "emailicon";
            this.emailicon.Size = new System.Drawing.Size(33, 28);
            this.emailicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emailicon.TabIndex = 24;
            this.emailicon.TabStop = false;
            // 
            // loginbutton
            // 
            this.loginbutton.Activecolor = System.Drawing.Color.White;
            this.loginbutton.BackColor = System.Drawing.Color.White;
            this.loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbutton.BorderRadius = 7;
            this.loginbutton.ButtonText = "AUTENTIFICARE";
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.DisabledColor = System.Drawing.Color.Gray;
            this.loginbutton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginbutton.Iconimage")));
            this.loginbutton.Iconimage_right = null;
            this.loginbutton.Iconimage_right_Selected = null;
            this.loginbutton.Iconimage_Selected = null;
            this.loginbutton.IconMarginLeft = 0;
            this.loginbutton.IconMarginRight = 0;
            this.loginbutton.IconRightVisible = true;
            this.loginbutton.IconRightZoom = 0D;
            this.loginbutton.IconVisible = true;
            this.loginbutton.IconZoom = 35D;
            this.loginbutton.IsTab = false;
            this.loginbutton.Location = new System.Drawing.Point(14, 462);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Normalcolor = System.Drawing.Color.White;
            this.loginbutton.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.loginbutton.OnHoverTextColor = System.Drawing.Color.Black;
            this.loginbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loginbutton.selected = false;
            this.loginbutton.Size = new System.Drawing.Size(260, 37);
            this.loginbutton.TabIndex = 25;
            this.loginbutton.Text = "AUTENTIFICARE";
            this.loginbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginbutton.Textcolor = System.Drawing.Color.Black;
            this.loginbutton.TextFont = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // passwordicon
            // 
            this.passwordicon.BackColor = System.Drawing.Color.Transparent;
            this.passwordicon.Cursor = System.Windows.Forms.Cursors.Default;
            this.passwordicon.Image = ((System.Drawing.Image)(resources.GetObject("passwordicon.Image")));
            this.passwordicon.Location = new System.Drawing.Point(14, 414);
            this.passwordicon.Name = "passwordicon";
            this.passwordicon.Size = new System.Drawing.Size(33, 28);
            this.passwordicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordicon.TabIndex = 23;
            this.passwordicon.TabStop = false;
            // 
            // minimizebutton
            // 
            this.minimizebutton.BackColor = System.Drawing.Color.Transparent;
            this.minimizebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizebutton.Image = ((System.Drawing.Image)(resources.GetObject("minimizebutton.Image")));
            this.minimizebutton.ImageActive = null;
            this.minimizebutton.Location = new System.Drawing.Point(594, 12);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.Size = new System.Drawing.Size(30, 30);
            this.minimizebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizebutton.TabIndex = 116;
            this.minimizebutton.TabStop = false;
            this.minimizebutton.Tag = "";
            this.minimizebutton.Zoom = 10;
            this.minimizebutton.Click += new System.EventHandler(this.minimizebutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Transparent;
            this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebutton.Image = ((System.Drawing.Image)(resources.GetObject("closebutton.Image")));
            this.closebutton.ImageActive = null;
            this.closebutton.Location = new System.Drawing.Point(630, 12);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(30, 30);
            this.closebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closebutton.TabIndex = 117;
            this.closebutton.TabStop = false;
            this.closebutton.Tag = "";
            this.closebutton.Zoom = 10;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(559, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(390, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 31);
            this.label2.TabIndex = 119;
            this.label2.Text = "Aplicație de gestiune";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(437, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 31);
            this.label3.TabIndex = 120;
            this.label3.Text = "a companiei";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // connectionerror
            // 
            this.connectionerror.AutoSize = true;
            this.connectionerror.BackColor = System.Drawing.Color.Transparent;
            this.connectionerror.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectionerror.ForeColor = System.Drawing.Color.Red;
            this.connectionerror.Location = new System.Drawing.Point(50, 499);
            this.connectionerror.Name = "connectionerror";
            this.connectionerror.Size = new System.Drawing.Size(230, 15);
            this.connectionerror.TabIndex = 123;
            this.connectionerror.Text = "Nu sunteti conectat la o rețea de internet.";
            this.connectionerror.Visible = false;
            // 
            // emailerror
            // 
            this.emailerror.AutoSize = true;
            this.emailerror.BackColor = System.Drawing.Color.Transparent;
            this.emailerror.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailerror.ForeColor = System.Drawing.Color.Red;
            this.emailerror.Location = new System.Drawing.Point(50, 395);
            this.emailerror.Name = "emailerror";
            this.emailerror.Size = new System.Drawing.Size(181, 15);
            this.emailerror.TabIndex = 121;
            this.emailerror.Text = "Datele introduse sunt incorecte.";
            this.emailerror.Visible = false;
            // 
            // passworderror
            // 
            this.passworderror.AutoSize = true;
            this.passworderror.BackColor = System.Drawing.Color.Transparent;
            this.passworderror.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passworderror.ForeColor = System.Drawing.Color.Red;
            this.passworderror.Location = new System.Drawing.Point(50, 445);
            this.passworderror.Name = "passworderror";
            this.passworderror.Size = new System.Drawing.Size(181, 15);
            this.passworderror.TabIndex = 122;
            this.passworderror.Text = "Datele introduse sunt incorecte.";
            this.passworderror.Visible = false;
            // 
            // loginerror
            // 
            this.loginerror.AutoSize = true;
            this.loginerror.BackColor = System.Drawing.Color.Transparent;
            this.loginerror.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginerror.ForeColor = System.Drawing.Color.Red;
            this.loginerror.Location = new System.Drawing.Point(50, 499);
            this.loginerror.Name = "loginerror";
            this.loginerror.Size = new System.Drawing.Size(162, 15);
            this.loginerror.TabIndex = 124;
            this.loginerror.Text = "Te rugăm să încerci din nou.";
            this.loginerror.Visible = false;
            // 
            // watchpassbutton
            // 
            this.watchpassbutton.BackColor = System.Drawing.Color.Transparent;
            this.watchpassbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchpassbutton.Image = ((System.Drawing.Image)(resources.GetObject("watchpassbutton.Image")));
            this.watchpassbutton.ImageActive = null;
            this.watchpassbutton.Location = new System.Drawing.Point(280, 420);
            this.watchpassbutton.Name = "watchpassbutton";
            this.watchpassbutton.Size = new System.Drawing.Size(29, 22);
            this.watchpassbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.watchpassbutton.TabIndex = 220;
            this.watchpassbutton.TabStop = false;
            this.watchpassbutton.Tag = "";
            this.watchpassbutton.Zoom = 10;
            this.watchpassbutton.MouseEnter += new System.EventHandler(this.watchpassbutton_MouseEnter);
            this.watchpassbutton.MouseLeave += new System.EventHandler(this.watchpassbutton_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(559, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 221;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(672, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.watchpassbutton);
            this.Controls.Add(this.loginerror);
            this.Controls.Add(this.connectionerror);
            this.Controls.Add(this.emailerror);
            this.Controls.Add(this.passworderror);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minimizebutton);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.emailicon);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordicon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialSingleLineTextField3);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.emailicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchpassbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton minimizebutton;
        private Bunifu.Framework.UI.BunifuImageButton closebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox emailicon;
        private Bunifu.Framework.UI.BunifuFlatButton loginbutton;
        private System.Windows.Forms.PictureBox passwordicon;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton watchpassbutton;
        private System.Windows.Forms.Label loginerror;
        private System.Windows.Forms.Label connectionerror;
        private System.Windows.Forms.Label emailerror;
        private System.Windows.Forms.Label passworderror;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

