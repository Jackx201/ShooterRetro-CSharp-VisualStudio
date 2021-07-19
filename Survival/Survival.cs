using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace Survival
{
    public partial class Survive : Form
    {
        /***********************   GLOBAL  ***********************/
        int anim = 0, mov = 7, puntaje = 0, hits = 0, life = 1, CD = 0;
        int speed = 5, speed2 = 5, speed3 = 5, speed4 = 5, speed5 = 5;

        WindowsMediaPlayer player = new WindowsMediaPlayer();

        Image[] Idle = new Image[2];
        Image[] Enememigo = new Image[2];
        Image[] Enemigo2 = new Image[2];
        Image[] Explotion = new Image[2];
        Image[] Explotion2 = new Image[2];
        Image[] Obstacle1 = new Image[2];
        Image[] Obstacle2 = new Image[2];
        Image[] Obstacle3 = new Image[2];
        Image[] Obstacle4 = new Image[2];
        Image[] FinalBoss = new Image[2];

        bool W, A, S, D, O, X, Y, Z;

        
        /***********************   GLOBAL  ***********************/

        public Survive()
        {
            InitializeComponent();

            player.URL = "PachelbelsCanon.mp3";

            Idle[0] = Survival.Properties.Resources.SpaceShip1;
            Idle[1] = Survival.Properties.Resources.SpaceShip2;

            Enememigo[0] = Survival.Properties.Resources.Enemy1;
            Enememigo[1] = Survival.Properties.Resources.Enemy2;

            Enemigo2[0] = Survival.Properties.Resources.MidEnemy1;
            Enemigo2[1] = Survival.Properties.Resources.MidEnemy2;

            Explotion[0] = Survival.Properties.Resources.GameOver1;
            Explotion[1] = Survival.Properties.Resources.GameOver2;

            Explotion2[0] = Survival.Properties.Resources.Explotion1;
            Explotion2[1] = Survival.Properties.Resources.Explotion2;

            Obstacle1[0] = Survival.Properties.Resources.Fireball1;
            Obstacle1[1] = Survival.Properties.Resources.Fireball2;

            Obstacle2[0] = Survival.Properties.Resources.PinkFireBall;
            Obstacle2[1] = Survival.Properties.Resources.PinkFireBall2;

            Obstacle3[0] = Survival.Properties.Resources.OrangeFireBall1;
            Obstacle3[1] = Survival.Properties.Resources.OrangeFireBall2;

            Obstacle4[0] = Survival.Properties.Resources.BlueAsteroid1;
            Obstacle4[1] = Survival.Properties.Resources.BlueAsteroid2;
    
            FinalBoss[0] = Survival.Properties.Resources.Final_Boss1;
            FinalBoss[1] = Survival.Properties.Resources.Final_Boss2;
        
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            /*********** IDLE ANIMATION ***********/
                Player.Image = Idle[anim];
                if (anim == 1)
                {
                    anim = -1;
                }
                anim++;
            /**************************************/


            /*********** OTRAS ANIMACIONES ***********/
            Meteor.Image = Obstacle1[anim];
            Meteor2.Image = Obstacle2[anim];
            Meteor4.Image = Obstacle3[anim];
            Meteor3.Image = Obstacle4[anim];
            /*****************************************/


            /*************** ENEMIGOS ****************/
            if (puntaje >= 0)
            {
                Enemy.Image = Enememigo[anim];
            }
            if (puntaje >= 11)
            {
                Enemy.Image = Enemigo2[anim];
            }
            if (puntaje >= 26)
            {
                Enemy.Image = FinalBoss[anim];
            }
            if (puntaje == 10 || puntaje == 25 || puntaje >= 60)
            {
                X = true;
                Z = true;
                label2.Visible = false;
                EnemyBullet.Visible = false;
                if (puntaje >= 65)
                {
                    label2.Visible = true;
                }
                Enemy.Image = Explotion2[anim];
            }
           /******************************************/

           /*************************** Cool Down Enemigo ***************************/
           if ((CD >= 15) && (X == false))
           {
            Y = true;
            EnemyBullet.Visible = true;
            EnemyBullet.Enabled = true;
            EnemyBullet.Location = new Point(Enemy.Location.X + 10, Enemy.Location.Y);
            CD = 0;
           }
           CD++;
           /************************************************************************/


            /********************************************** GAME OVER **************************************************/
            if((Player.Bounds.IntersectsWith(Meteor.Bounds) || Player.Bounds.IntersectsWith(Enemy.Bounds)) && X == false)
            {
                GameOver();
            }
            if(Player.Bounds.IntersectsWith(Meteor2.Bounds) && Meteor2.Enabled && X == false)
            {
                GameOver();
            }
            if (Player.Bounds.IntersectsWith(Meteor3.Bounds) && Meteor3.Enabled && X == false)
            {
                GameOver();
            }
            if (Player.Bounds.IntersectsWith(Meteor4.Bounds) && Meteor4.Enabled && X == false)
            {
                GameOver();
            }
            if (Player.Bounds.IntersectsWith(EnemyBullet.Bounds) && X == false)
            {
                GameOver();
            }
            if(Player.Top >= this.Height || Player.Left >= this.Width || Player.Right <= 0 || Player.Bottom <= 0){
                GameOver();
            }

            /************************************************************************************************************/

            /***************** HIT  *****************/
            if (Rocket.Bounds.IntersectsWith(Enemy.Bounds) && Z == false)
            {
                Hit();
            }
            /****************************************/
        }

        private void Survive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                W = true;
            }
            if (e.KeyCode == Keys.A)
            {
                A = true;
            }
            if (e.KeyCode == Keys.S)
            {
                S = true;
            }
            if (e.KeyCode == Keys.D)
            {
                D = true;
            }
            if (e.KeyCode == Keys.O)
            {
                O = true;
            }
        }
        private void Survive_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public void GameOver()
        {
            RESET.Visible = true;
            player.controls.stop();
            life--;
            Meteor.Visible = false;
            Meteor2.Visible = false;
            Meteor3.Visible = false;
            Meteor4.Visible = false;
            EnemyBullet.Visible = false;
            Rocket.Visible = false;
            
            if (life <= 1)
            {
                timer1.Stop();
                CoolDown.Start();
                Movimiento.Stop();
                if (Player.Top >= this.Height || Player.Left >= this.Width || Player.Right <= 0 || Player.Bottom <= 0)
                {
                    MessageBox.Show("Te has perdido en el espacio.");
                }
                else
                {
                    MessageBox.Show("Fin del Juego\n" + "Hiciste: " + puntaje + " puntos");
                }
            }
        }

        public void Hit()
        {
            O = false;
            Rocket.Visible = false;
            puntaje++;
            Rocket.Location = new Point(Player.Location.X, Player.Location.Y);
            label2.Text = "PUNTAJE: " + puntaje;
            hits++;
            Momentum();
        }

        private void Momentum()
        {
            if (speed >= 0 && hits >= 5)
            {
                speed++;
            }
            else if (speed <= 0 && hits >= 5)
            {
                speed--;
            }
            if (speed2 >= 0 && hits >= 5)
            {
                speed2++;
            }
            else if (speed2 <= 0 && hits >= 5)
            {
                speed2--;
            }
            if (speed3 >= 0 && hits >= 5)
            {
                speed3++;
            }
            else if (speed3 <= 0 && hits >= 5)
            {
                speed3--;
            }
            if (speed4 >= 0 && hits >= 5)
            {
                speed4++;
            }
            else if (speed4 <= 0 && hits >= 5)
            {
                speed4--;
            }
            if (speed5 >= 0 && hits >= 5)
            {
                speed5++;
            }
            else if (speed5 <= 0 && hits >= 5)
            {
                speed5--;
            }
            if (hits >= 5)
            {
                hits = 0;
            }
        }

        private void FlipOB1()
        {
            Obstacle1[0].RotateFlip(RotateFlipType.Rotate180FlipY);
            Obstacle1[1].RotateFlip(RotateFlipType.Rotate180FlipY);

            if (puntaje == 10 || puntaje == 25 || puntaje >= 60)
            {
                puntaje++;
            }
        }

        private void FlipOb2()
        {
            Obstacle2[0].RotateFlip(RotateFlipType.Rotate180FlipY);
            Obstacle2[1].RotateFlip(RotateFlipType.Rotate180FlipY);
        }

        private void FlipOb3()
        {
            Obstacle4[0].RotateFlip(RotateFlipType.Rotate180FlipX);
            Obstacle4[1].RotateFlip(RotateFlipType.Rotate180FlipX);
        }
        private void FlipOB4()
        {
            Obstacle3[0].RotateFlip(RotateFlipType.Rotate180FlipX);
            Obstacle3[1].RotateFlip(RotateFlipType.Rotate180FlipX);
        }

        private void Survive_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                W = false;
            }
            if (e.KeyCode == Keys.A)
            {
                A = false;
            }
            if (e.KeyCode == Keys.S)
            {
                S = false;
            }
            if (e.KeyCode == Keys.D)
            {
                D = false;
            }
            if (e.KeyCode == Keys.O)
            {
                O = true;
                Rocket.Visible = true;
                Rocket.Location = new Point(Player.Location.X + 24, Player.Location.Y - 10);
            }
        }


        //TIMER1
        private void Movimiento_Tick(object sender, EventArgs e)
        {
            /************************* MOVIMIENTO DEL JUGADOR *************************/
            if (W)
            {
                Player.Location = new Point(Player.Location.X, Player.Location.Y - mov);
            }
            if (A)
            {
                Player.Location = new Point(Player.Location.X - mov, Player.Location.Y);
            }
            if (S)
            {
                Player.Location = new Point(Player.Location.X, Player.Location.Y + mov);
            }
            if (D)
            {
                Player.Location = new Point(Player.Location.X + mov, Player.Location.Y);
            }
            /**************************************************************************/



            /************************* MOVIMIENTO DE OBSTACULOS ***********************/
            Meteor.Location = new Point(Meteor.Location.X + speed, Meteor.Location.Y);
            if(Meteor.Left <= 0){
                speed = speed * (-1);
                FlipOB1();
            }
            if(Meteor.Right >= this.Width){
                speed = speed * (-1);
                FlipOB1();
            }

            if (Meteor2.Enabled)
            {
                Meteor2.Location = new Point(Meteor2.Location.X + speed3, Meteor2.Location.Y);
                if (Meteor2.Left <= 0)
                {
                    speed3 = speed3 * (-1);
                    FlipOb2();
                }
                if (Meteor2.Right >= this.Width)
                {
                    speed3 = speed3 * (-1);
                    FlipOb2();
                }
            }

            if (Meteor3.Enabled)
            {
                Meteor3.Location = new Point(Meteor3.Location.X, Meteor3.Location.Y + speed4);
                if (Meteor3.Top <= 0)
                {
                    speed4 = speed4 * (-1);
                    FlipOb3();
                }
                if (Meteor3.Bottom >= this.Height)
                {
                    speed4 = speed4 * (-1);
                    FlipOb3();
                }
            }

            if (Meteor4.Enabled)
            {
                Meteor4.Location = new Point(Meteor4.Location.X, Meteor4.Location.Y + speed5);
                if (Meteor4.Top <= 0)
                {
                    speed5 = speed5 * (-1);
                    FlipOB4();
                }
                if (Meteor4.Bottom >= this.Height)
                {
                    speed5 = speed5 * (-1);
                    FlipOB4();
                }
            }
            /**************************************************************************/



            /************************* MOVIMIENTO DEL ENEMIGO *************************/
            Enemy.Location = new Point(Enemy.Location.X - speed2, Enemy.Location.Y);
            if (Enemy.Left <= 128)
            {
                speed2 = speed2 * -1;
            }
            if (Enemy.Right >= this.Width - 180)
            {
                speed2 = speed2 * -1;
            }
            /*************************************************************************/



            /***************************** MOVIMIENTO DE BALA ************************/
            if(O){
                Rocket.Location = new Point(Rocket.Location.X, Rocket.Location.Y - 63);
            }
            /*************************************************************************/



            /************************* MOVIMIENTO DE BALA ENEMIGA ********************/
            if (Y)
            {
                EnemyBullet.Location = new Point(EnemyBullet.Location.X, EnemyBullet.Location.Y + 20);
            }
            /*************************************************************************/



            /***************************** FLUJO DEL JUEGO ************************/
            switch (puntaje)
            {
                case 5:
                    Meteor2.Visible = true;
                    Meteor2.Enabled = true;
                    break;

                case 10:
                    Meteor3.Visible = true;
                    Meteor3.Enabled = true;
                    break;

                case 15:
                    Meteor4.Visible = true;
                    Meteor4.Enabled = true;
                    break;

                case 11:
                    X = false;
                    Z = false;
                    label2.Visible = true;
                    EnemyBullet.Visible = true;
                    EnemyBullet.Location = new Point(EnemyBullet.Location.X, EnemyBullet.Location.Y);
                    break; 

                case 26:
                    X = false;
                    Z = false;
                    label2.Visible = true;
                    Enemy.Location = new Point(256, 9);
                    Enemy.Size = new Size(222, 159);
                    EnemyBullet.Visible = true;
                    EnemyBullet.Location = new Point(EnemyBullet.Location.X, EnemyBullet.Location.Y);
                    break;

                case 65:
                    X = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    Meteor.Visible = false;
                    Meteor2.Visible = false;
                    Meteor3.Visible = false;
                    Meteor4.Visible = false;
                    Enemy.Visible = false;
                    EnemyBullet.Visible = false;
                    label2.Text = "¡GANASTE!";
                    label2.Location = new Point(342, 194);
                    label1.Location = new Point(342, 224);
                    break;
            }
            /**********************************************************************/
        }
        //TIMER1

        //SALIR
        private void label1_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            timer1.Stop();
            //CoolDown.Start();
            Movimiento.Stop();
            if (puntaje >= 60)
            {
                MessageBox.Show("¡Felicidades Eres Increíble :D!");
            }
            Form1 MainMenu = new Form1();
            MainMenu.Show(this);
            this.Hide();
        }
        //SALIR

        private void Survive_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Movimiento.Start();
            player.controls.play();
        }

        private void CoolDown_Tick(object sender, EventArgs e)
        {
            /***************** EXPLOTION ANIMATION *****************/
            if (life <= 0)
            {
                Player.Image = Explotion[anim];
                if (anim == 1)
                {
                    anim = -1;
                }
                anim++;
            }
            /***********************************************************/
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            RESET.Visible = false;
            life = 1;
            Player.Location = new Point(347, 345);
            puntaje = 0;
            label2.Text = "PUNTAJE: 0";
            timer1.Start();
            Movimiento.Start();
            player.controls.play();
            Meteor.Location = new Point(608, 405);
            Meteor.Visible = true;
            Meteor2.Location = new Point(17, 165);
            Meteor2.Enabled = false;
            Meteor3.Enabled = false;
            Meteor4.Enabled = false;
            W = false;
            A = false;
            S = false;
            D = false;
            Enemy.Size = new Size(90, 102);
            speed = 5;
            speed2 = 5;
            speed3 = 5;
            speed4 = 5;
            speed5 = 5;
        }
    }
}
