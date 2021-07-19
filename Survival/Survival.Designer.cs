namespace Survival
{
    partial class Survive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Survive));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Movimiento = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CoolDown = new System.Windows.Forms.Timer(this.components);
            this.Meteor2 = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Meteor = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Rocket = new System.Windows.Forms.PictureBox();
            this.Meteor3 = new System.Windows.Forms.PictureBox();
            this.Meteor4 = new System.Windows.Forms.PictureBox();
            this.EnemyBullet = new System.Windows.Forms.PictureBox();
            this.RESET = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBullet)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Movimiento
            // 
            this.Movimiento.Interval = 60;
            this.Movimiento.Tick += new System.EventHandler(this.Movimiento_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "SALIR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(593, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "PUNTAJE: ";
            // 
            // CoolDown
            // 
            this.CoolDown.Interval = 60;
            this.CoolDown.Tick += new System.EventHandler(this.CoolDown_Tick);
            // 
            // Meteor2
            // 
            this.Meteor2.BackColor = System.Drawing.Color.Transparent;
            this.Meteor2.Enabled = false;
            this.Meteor2.Image = ((System.Drawing.Image)(resources.GetObject("Meteor2.Image")));
            this.Meteor2.Location = new System.Drawing.Point(17, 165);
            this.Meteor2.Margin = new System.Windows.Forms.Padding(0);
            this.Meteor2.Name = "Meteor2";
            this.Meteor2.Size = new System.Drawing.Size(76, 65);
            this.Meteor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Meteor2.TabIndex = 7;
            this.Meteor2.TabStop = false;
            this.Meteor2.Visible = false;
            // 
            // Enemy
            // 
            this.Enemy.Image = ((System.Drawing.Image)(resources.GetObject("Enemy.Image")));
            this.Enemy.Location = new System.Drawing.Point(347, 1);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(90, 102);
            this.Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemy.TabIndex = 5;
            this.Enemy.TabStop = false;
            // 
            // Meteor
            // 
            this.Meteor.BackColor = System.Drawing.Color.Transparent;
            this.Meteor.Image = global::Survival.Properties.Resources.Fireball1;
            this.Meteor.Location = new System.Drawing.Point(608, 405);
            this.Meteor.Name = "Meteor";
            this.Meteor.Size = new System.Drawing.Size(85, 63);
            this.Meteor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Meteor.TabIndex = 3;
            this.Meteor.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Survival.Properties.Resources.SpaceShip2;
            this.Player.Location = new System.Drawing.Point(347, 345);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(64, 94);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // Rocket
            // 
            this.Rocket.BackColor = System.Drawing.Color.Transparent;
            this.Rocket.Image = global::Survival.Properties.Resources.Bullet;
            this.Rocket.Location = new System.Drawing.Point(370, 364);
            this.Rocket.Name = "Rocket";
            this.Rocket.Size = new System.Drawing.Size(15, 56);
            this.Rocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Rocket.TabIndex = 6;
            this.Rocket.TabStop = false;
            this.Rocket.Visible = false;
            // 
            // Meteor3
            // 
            this.Meteor3.BackColor = System.Drawing.Color.Transparent;
            this.Meteor3.Enabled = false;
            this.Meteor3.Image = ((System.Drawing.Image)(resources.GetObject("Meteor3.Image")));
            this.Meteor3.Location = new System.Drawing.Point(72, 41);
            this.Meteor3.Margin = new System.Windows.Forms.Padding(0);
            this.Meteor3.Name = "Meteor3";
            this.Meteor3.Size = new System.Drawing.Size(66, 85);
            this.Meteor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Meteor3.TabIndex = 9;
            this.Meteor3.TabStop = false;
            this.Meteor3.Visible = false;
            // 
            // Meteor4
            // 
            this.Meteor4.BackColor = System.Drawing.Color.Transparent;
            this.Meteor4.Enabled = false;
            this.Meteor4.Image = global::Survival.Properties.Resources.OrangeFireBall1;
            this.Meteor4.Location = new System.Drawing.Point(543, 9);
            this.Meteor4.Margin = new System.Windows.Forms.Padding(0);
            this.Meteor4.Name = "Meteor4";
            this.Meteor4.Size = new System.Drawing.Size(52, 86);
            this.Meteor4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Meteor4.TabIndex = 8;
            this.Meteor4.TabStop = false;
            this.Meteor4.Visible = false;
            // 
            // EnemyBullet
            // 
            this.EnemyBullet.BackColor = System.Drawing.Color.Transparent;
            this.EnemyBullet.Image = global::Survival.Properties.Resources.Bullet;
            this.EnemyBullet.Location = new System.Drawing.Point(383, 39);
            this.EnemyBullet.Name = "EnemyBullet";
            this.EnemyBullet.Size = new System.Drawing.Size(15, 56);
            this.EnemyBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnemyBullet.TabIndex = 10;
            this.EnemyBullet.TabStop = false;
            this.EnemyBullet.Visible = false;
            // 
            // RESET
            // 
            this.RESET.AutoSize = true;
            this.RESET.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESET.ForeColor = System.Drawing.Color.White;
            this.RESET.Location = new System.Drawing.Point(3, 440);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(138, 27);
            this.RESET.TabIndex = 11;
            this.RESET.Text = "REINICIAR";
            this.RESET.Visible = false;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // Survive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(734, 469);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.Meteor2);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Meteor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Rocket);
            this.Controls.Add(this.Meteor3);
            this.Controls.Add(this.Meteor4);
            this.Controls.Add(this.EnemyBullet);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Survive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Survival";
            this.Load += new System.EventHandler(this.Survive_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Survive_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Survive_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Meteor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBullet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer Movimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Meteor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox Rocket;
        private System.Windows.Forms.Timer CoolDown;
        private System.Windows.Forms.PictureBox Meteor2;
        private System.Windows.Forms.PictureBox Meteor4;
        private System.Windows.Forms.PictureBox Meteor3;
        private System.Windows.Forms.PictureBox EnemyBullet;
        private System.Windows.Forms.Label RESET;
    }
}