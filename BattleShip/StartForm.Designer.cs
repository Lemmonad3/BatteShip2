
namespace BattleShip
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.start_game = new System.Windows.Forms.Label();
            this.end_game = new System.Windows.Forms.Label();
            this.property = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_game
            // 
            this.start_game.AutoSize = true;
            this.start_game.BackColor = System.Drawing.SystemColors.Control;
            this.start_game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_game.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_game.ForeColor = System.Drawing.Color.Gold;
            this.start_game.Image = ((System.Drawing.Image)(resources.GetObject("start_game.Image")));
            this.start_game.Location = new System.Drawing.Point(41, 270);
            this.start_game.Name = "start_game";
            this.start_game.Size = new System.Drawing.Size(123, 26);
            this.start_game.TabIndex = 0;
            this.start_game.Text = "Начать Игру";
            this.start_game.Click += new System.EventHandler(this.start_game_Click);
            // 
            // end_game
            // 
            this.end_game.AutoSize = true;
            this.end_game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.end_game.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.end_game.ForeColor = System.Drawing.Color.Gold;
            this.end_game.Image = ((System.Drawing.Image)(resources.GetObject("end_game.Image")));
            this.end_game.Location = new System.Drawing.Point(218, 270);
            this.end_game.Name = "end_game";
            this.end_game.Size = new System.Drawing.Size(150, 26);
            this.end_game.TabIndex = 1;
            this.end_game.Text = "Выйти из игры";
            this.end_game.Click += new System.EventHandler(this.end_game_Click);
            // 
            // property
            // 
            this.property.AutoSize = true;
            this.property.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.property.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.property.ForeColor = System.Drawing.Color.Gold;
            this.property.Image = ((System.Drawing.Image)(resources.GetObject("property.Image")));
            this.property.Location = new System.Drawing.Point(277, 20);
            this.property.Name = "property";
            this.property.Size = new System.Drawing.Size(141, 26);
            this.property.TabIndex = 2;
            this.property.Text = "Правила игры";
            this.property.Click += new System.EventHandler(this.property_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "О программе";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(430, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.property);
            this.Controls.Add(this.end_game);
            this.Controls.Add(this.start_game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морской Бой";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label start_game;
        private System.Windows.Forms.Label end_game;
        private System.Windows.Forms.Label property;
        private System.Windows.Forms.Label label1;
    }
}

