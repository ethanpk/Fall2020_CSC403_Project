using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
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

    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      
      gametime = 75;
      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

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
                // move player
                player.Move();
                
                // check collision with walls
                if (HitAWall(player))
                {
                    player.MoveBack();
                }
              
                // check collision with enemies
                if (picEnemyPoisonPacket.Enabled == true & HitAChar(player, enemyPoisonPacket))
                {

                    Fight(enemyPoisonPacket);

                }
                else if (picEnemyCheeto.Enabled == true & HitAChar(player, enemyCheeto))
                {

                    Fight(enemyCheeto);
                }
                else if (picBossKoolAid.Enabled == true & HitAChar(player, bossKoolaid))
                {

                    Fight(bossKoolaid);
                }
                pause = true;
                // check character health 
                if (playerdied == false & player.Health <= 0) 
                { playerdied = true; playerHealth(); }
                else if (poisondied == false & enemyPoisonPacket.Health <= 0)
                { poisondied = true; poisonHealth(); }
                else if (cheetodied == false & enemyCheeto.Health <= 0) 
                { cheetodied = true; cheetoHealth(); }
                else if (bossdied == false & bossKoolaid.Health <= 0)
                { bossdied = true; bossHealth(); }
                
                if (victoryflag == false & bossdied == true && poisondied == true && cheetodied == true)
                {
                    victory();
                    victoryflag = true;
                }
                // update player's picture box
                picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
            }
        }

        private void destroyWall(PictureBox box)
        {
            if(box.Name== "picWall13")
            {
                box.Enabled = false;
                box.Visible= false;

            }
            if (box.Name == "picWall11")
            {
                box.Enabled = false;
                box.Visible = false;

            }
            if (box.Name == "picWall10")
            {
                
                box.Enabled = false;
                box.Visible = false;

            }
            if (box.Name == "picWall14")
            {
                box.Enabled = false;
                box.Visible = false;

            }
        }

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            //picWall13
            
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
                case Keys.Q:
                    //Write Health Code

                default:
                    player.ResetMoveSpeed();
                    break;
            }
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
    
  }
}
