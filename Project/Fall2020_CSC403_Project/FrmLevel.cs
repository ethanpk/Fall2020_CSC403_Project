using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using MyGameLibrary;
using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;
    
    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Health healthtrack;
    private Character[] walls;
    private TimeSpan span;
    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private int gametime;
    private bool pause = true;
    private bool gameover;
    private bool timerup = false;
    private bool poisondied = false;
    private bool cheetodied = false;
    private bool bossdied = false;
    private bool playerdied = false;
    private bool victoryflag=false;
    const int NUM_WALLS = 15;
    private bool speedstatus = false;
    private int efight;
    private bool trigger=false;
    
    private bool bulletavailable=false;


        SoundPlayer sound  = new SoundPlayer(Resources.wallbreak);
    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      sound.Load();
      gametime = 75;
      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
      healthtrack = new Health(CreatePosition(healthkit), CreateCollider(healthkit, PADDING));
      picEnemyCheeto.Location = new Point(951, 497) ;// cheetoHealthbar.Location;
      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
            //951, 497
      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }
     
      Game.player = player;
      timeBegin = DateTime.Now.AddSeconds(gametime);
             
    }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }
    private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            if (pause)
            {
                if (trigger == false)
                {
                    // update player's picture box
                    picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
                    playerHealthBar.Location = new Point((int)player.Position.x, (int)player.Position.y + 106);
                    // move player
                    player.Move();

                    // check collision with walls
                    if (HitAWall(player))
                    {
                        player.MoveBack();
                    }
                }
                if (HitAKit(player,healthtrack) && healthkit.Visible==true)
                {
                    player.Health = player.MaxHealth;
                    healthkit.Visible = false;
                    healthkit.Enabled = false;
                }
                if (player.Position.x <= 426 && player.Position.y >= 494) //300, 281
                {
                    poisionHealthbar.Visible = false;
                    poisionHealthbar.Enabled = false;
                    cheetoHealthbar.Visible = false;
                    cheetoHealthbar.Enabled = false;
                    bossHealthbar.Visible = false;
                    bossHealthbar.Enabled = false;
                    regeneratewalls();
                }
                    
                // check collision with enemies
                if (player.Position.x <= 500 && player.Position.y <= 233) //300, 281
                {
                    poisionHealthbar.Visible = true;
                    poisionHealthbar.Enabled = true;
                    cheetoHealthbar.Visible = false;
                    cheetoHealthbar.Enabled = false;
                    bossHealthbar.Visible = false;
                    bossHealthbar.Enabled = false;
                    regeneratewalls();
                   
                    if (picEnemyPoisonPacket.Enabled == true)
                    {
                        trigger = true;
                        picPlayer.Location = new Point((int)picEnemyPoisonPacket.Location.X-330, (int)picEnemyPoisonPacket.Location.Y);
                        fightChamber(enemyPoisonPacket);
                        //Fight(enemyPoisonPacket);

                    }
                }
                if (player.Position.x >= 687 && player.Position.y >= 474)
                {
                    poisionHealthbar.Visible = false;
                    poisionHealthbar.Enabled = false;
                    cheetoHealthbar.Visible = true;
                    cheetoHealthbar.Enabled = true;
                    bossHealthbar.Visible = false;
                    bossHealthbar.Enabled = false;
                    regeneratewalls();
                    if (picEnemyCheeto.Enabled == true)
                    {
                        trigger = true;

                        fightChamber(enemyCheeto);
                        //Fight(enemyCheeto);
                    }
                }
                if (player.Position.x >= 687 && player.Position.y <= 270)
                {
                    poisionHealthbar.Visible = false;
                    poisionHealthbar.Enabled = false;
                    cheetoHealthbar.Visible = false;
                    cheetoHealthbar.Enabled = false;
                    bossHealthbar.Visible = true;
                    bossHealthbar.Enabled = true;
                    regeneratewalls();
                    if (picBossKoolAid.Enabled == true)
                    {
                        trigger = true;
                        picPlayer.Location = new Point((int)picBossKoolAid.Location.X-280, (int)picBossKoolAid.Location.Y);
                        fightChamber(bossKoolaid);
                        // Fight(bossKoolaid);
                    }
                }
                
                pause = true;
                // check character health 
                if (playerdied == false & player.Health <= 0) 
                { playerdied = true; playerHealth(); trigger = false; healthui(); weaponsvisible(false); }
                else if (poisondied == false & enemyPoisonPacket.Health <= 0)
                { poisondied = true; poisonHealth(); trigger = false; healthui(); weaponsvisible(false); healthkit.Visible = true; healthkit.Enabled = true; }
                else if (cheetodied == false & enemyCheeto.Health <= 0) 
                { cheetodied = true; cheetoHealth(); trigger = false; healthui(); weaponsvisible(false); machinegun(); }
                else if (bossdied == false & bossKoolaid.Health <= 0)
                { bossdied = true; bossHealth(); trigger = false; healthui(); weaponsvisible(false); }
                
                if (victoryflag == false & bossdied == true && poisondied == true && cheetodied == true)
                {
                    victory();
                    victoryflag = true;
                    trigger = false;
                }
                
            }
        }

        
        private bool HitAKit(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }
        private void machinegun()
        {
            machinegn.Enabled = true;
            machinegn.Visible = true;
        }

        private void weaponsvisible(bool v)
        {
            gun.Enabled = v;
            gun.Visible = v;
            bullet.Enabled=v;
            bullet.Visible = v;
        }

        private void healthui()
        {
            playerHealthBar.Enabled = false;
            playerHealthBar.Visible = false;
        }

        private void fightChamber(Enemy enemy)
        {
            playerHealthBar.Enabled = true;
            playerHealthBar.Visible = true;
            Thread.Sleep(1000);
            int health = player.Health;
            if(enemy == enemyPoisonPacket)
            {

                efight = 1;
                player.Health -= 1;

            }
            else if(enemy == enemyCheeto)
            {
                efight = 2;
                player.Health -= 2;
            }
            else if(enemy == bossKoolaid)
            {
                efight = 3;
                player.Health -= 3;
            }
            UpdateHealthBars();
        }
        private void UpdateHealthBars()
        {
            playerHealthBar.Location = new Point((int)picPlayer.Location.X, (int)picPlayer.Location.Y + 106);
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 226;
            const float ehealth = 20;
            playerHealthBar.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            if (efight==1)
            {
                float enemyHealthPer = enemyPoisonPacket.Health / ehealth;
                poisionHealthbar.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);
            }
            else if (efight == 2)
            {
                float enemyHealthPer = enemyCheeto.Health / ehealth;
                cheetoHealthbar.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);
            }
            else if (efight == 3)
            {
                float enemyHealthPer = bossKoolaid.Health / ehealth;
                bossHealthbar.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);
                
            }
           
           

        }


        private void regeneratewalls()
        {
            picWall13.Enabled = true;
            picWall13.Visible = true;
            picWall14.Enabled = true;
            picWall14.Visible = true;
            picWall11.Enabled = true;
            picWall11.Visible = true;
            picWall10.Enabled = true;
            picWall10.Visible = true;
            
           

        }
        private void destroyWall(PictureBox box)
        {

            if(box.Name== "picWall13")
            {
                wallBreak(box);

            }
            if (box.Name == "picWall11")
            {
                wallBreak(box);

            }
            if (box.Name == "picWall10")
            {
                wallBreak(box);

            }
            if (box.Name == "picWall14")
            {
                wallBreak(box);

            }
        }

        public void wallBreak(PictureBox box)
        {
           
            sound.Play();

            box.Enabled = false;
            box.Visible = false;
                   
            

        }
        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            //picWall13
          
           sound.Load();
            for (int w = 0; w < walls.Length; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                if (c.Collider.Intersects(walls[w].Collider) && pic.Enabled==true)
                {
                    hitAWall = true;
                    destroyWall(pic);
                    break;
                }
               
            }
           
            return hitAWall;
        }
    
    private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }
    
    private void Fight(Enemy enemy)
    {
        
        player.ResetMoveSpeed();
        player.MoveBack();
        frmlevelplaypause.Visible = false;
        frmlevelrestart.Visible = false;
    
        frmBattle = FrmBattle.GetInstance(enemy);
    
        frmBattle.Show();
    
        if (enemy == bossKoolaid)
        {
            frmBattle.SetupForBossBattle();
        }
    
    }

    #region TimerControl
    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      if (pause)
      {
          span = timeBegin - DateTime.Now;
          string time = span.ToString(@"hh\:mm\:ss");
          lblInGameTime.Text = "Time: " + time.ToString();
          if (time.ToString() == "00:00:00") 
          { 
              timeUp();
              applicationPlayPause(); 
              controlWindowStatus(true, false);
              if(frmBattle != null)
              frmBattle.Close();
          }
      }
      else{
                timeBegin = DateTime.Now.Add(span);
      }
      
    }
    private void timeUp()
    {
        SoundPlayer simpleSound = new SoundPlayer(Resources.timeout);
        simpleSound.Play();
        windowpic.Image = Resources.timeout1;
    }
    #endregion

    #region HealthCheck
    private void bossHealth()
    {
            if (bossKoolaid.Health <= 0)
            {
                bossdied = true;
                picBossKoolAid.Visible = false;
                picBossKoolAid.Enabled = false;
                enemykill();
                gamePanel();
                

            }
            if (enemyCheeto.Health > 0 && enemyPoisonPacket.Health > 0) 
            { 
                enemyPanel();
            }
    }
    private void cheetoHealth()
    {
            if (enemyCheeto.Health <= 0)
            {
                cheetodied = true;
                picEnemyCheeto.Visible = false;
                picEnemyCheeto.Enabled = false;
                enemykill();
                gamePanel();
                enemyPanel();


            }
    }
    private void poisonHealth()
    {
            if (enemyPoisonPacket.Health <= 0)
            {
                poisondied = true;
                picEnemyPoisonPacket.Visible = false;
                picEnemyPoisonPacket.Enabled = false;
                enemykill();
                gamePanel();
                enemyPanel();

            }
    }
    private void playerHealth()
    {
        playerdied = true;
        playerDead();
        windowpic.Image = Resources.playerdead1;
        applicationPlayPause();
        controlWindowStatus(true, false);
        picPlayer.Visible = false;
        picPlayer.Enabled = false;
    }
    #endregion

    #region ConrtrolPanels
    private void enemyPanel()
        {
            pause = false;
            EnemyFormPopup enemyFormPopup = new EnemyFormPopup();
            enemyFormPopup.Show();
            Task.Run(() =>
            {
                Thread.Sleep(4000);
                this.Invoke(new Action(() =>
                {
                    enemyFormPopup.Close();
                    pause = true;
                }));
            });
        }
    private void gamePanel()
    {
        frmlevelplaypause.Visible = true;
        frmlevelrestart.Visible = true;

    }
    private void controlWindowStatus(bool v, bool v1)
    {
        controlswindow.Enabled = v;
        controlswindow.Visible = v;
        windowplaypause.Visible = v1;
        windowplaypause.Enabled = v1;
    }
    private void playerDead()
    {
         SoundPlayer simpleSound = new SoundPlayer(Resources.playerdead);
        simpleSound.Play();
        windowpic.Image = Resources.win;
    }
    private void victory()
    {
            SoundPlayer simpleSound = new SoundPlayer(Resources.victoryaudio);
            simpleSound.Play();
            windowpic.Image = Resources.win;
            controlWindowStatus(true, false);
            pause = false;
    }
    private void enemykill()
    {
            SoundPlayer simpleSound = new SoundPlayer(Resources.enemydeadaudio);
            simpleSound.Play();
            windowpic.Image = Resources.enemydead;
    }
    public void locationchange(PictureBox picture)
    {
            picture.Location = new Point(0, 0);
    }
    private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.GoLeft();
                    break;

                case Keys.Right:
                    player.GoRight();
                    break;

                case Keys.Up:
                    player.GoUp();
                    break;

                case Keys.Down:
                    player.GoDown();
                    break;
                case Keys.H:
                   // statusHealth();
                    break;
                case Keys.Q:
                    statusHealth();
                    break;
                case Keys.S:
                    speed();
                    break;
                case Keys.A:
                    attack();
                    break;
                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }

        private void attack()
        {
            
            if (trigger == true)
            {
                if (bulletavailable == false)
                {
                    weaponsvisible(true);
                    gun.Location = new Point(picPlayer.Location.X + 40, picPlayer.Location.Y);
                    bullet.Location = new Point(gun.Location.X, gun.Location.Y);
                }

                if (efight == 1)
                {
                    enemyPoisonPacket.Health -= 4;
                    
                }
                else if (efight == 2)
                {
                    enemyCheeto.Health -= 4;
                }
                else if (efight == 3)
                {
                    bossKoolaid.Health -= 4;


                }
                UpdateHealthBars();
            }
            
        }

        private void speed()
        {
            if (speedstatus == false)
            {
                player.GO_INC = 5;
                this.picPlayer.BackColor = System.Drawing.SystemColors.HotTrack;
                speedstatus = true;
            }
            else
            {
                player.GO_INC = 3;
                this.picPlayer.BackColor = System.Drawing.Color.Transparent;
                speedstatus = false;
            }
        }

        private void statusHealth()
        {
            playerHealthBar.Enabled = true;
            playerHealthBar.Visible = true;
           
            Task.Run(() =>
            {
                Thread.Sleep(500);
                this.Invoke(new Action(() =>
                {
                    playerHealthBar.Enabled = false;
                    playerHealthBar.Visible = false;
                }));
            });
                  }
        #endregion

        #region PlaypauseControl
    private void restarrt_Click(object sender, EventArgs e)
    {
        applicationRestart();
    }
    private void playpause_Click(object sender, EventArgs e)
    {
        applicationPlayPause();
        controlWindowStatus(true,true);
        SoundPlayer simpleSound = new SoundPlayer(Resources.pauseaudio);
        simpleSound.Play();
        windowpic.Image = Resources.gamepaused;
    }
    private void windowplaypause_Click(object sender, EventArgs e)
    {
        applicationPlayPause();
        controlWindowStatus(false,true);
    }
   
    public void applicationRestart()
    {
       Application.Restart();
        
    }
    public void applicationPlayPause() {
        pause = pause == true ? false : true;
    }
        #endregion

        private void windowpic_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            if (241 < coordinates.X && coordinates.X < 349 && 138 < coordinates.Y && coordinates.Y < 187)
            {
                Application.Restart();

            }
        }

        
    }
}
