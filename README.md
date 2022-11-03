# Fall2020_CSC403_Project</br>
In the game development team, spider is looking for two main experiences for the user: one to make the game interactive by adding featured sounds, graphics, and special powers; and the other to increase the intensity during the game play. </br>
As part of those features team started focusing on basic required funtionality for interaction and increase the intensity.

### SPIDER TEAM
:feelsgood: Pujith :goberserk: Ashok :godmode: Grumeet :rage1: Yeswanth

## Sprint 1 

**Planned Events for implementation**</br>

- As a User, I can see the enemy's dead body gets disappeared after victory.</br>
- As a user, I want to see Cut scenes and Victory popup in the game.</br>
- Game Timer - As a player, the game ends when the timer is complete.</br>
- As a player , I should be able to Pause or  Restart the Game.</br>
- As a player,I can add Speed Boster to walk fast.</br>
- As a player, I can feel the whole Game different Background Music.</br>
- As a player, I can Regain health by using health pack.</br>
- As a player, I can use extra Power Boosters during battle.</br>

**Planned Events with detail tasks**

- As a User, I can see the enemy's dead body gets disappeared after victory.</br>
- As a user, I want to see Cut scenes and Victory popup in the game.</br>
- Game Timer - As a player, the game ends when the timer is complete.</br>
- As a player , I should be able to Pause or  Restart the Game.</br>

**Feature Backlogs**

- As a player,I can add Speed Boster to walk fast.</br>
- As a player, I can feel the whole Game different Background Music.</br>
- As a player, I can Regain health by using health pack.</br>
- As a player, I can use extra Power Boosters during battle.</br>

### Individual Assigned Features

:rage1: Yeswanth </br>

- As a User, I can see the enemy's dead body gets disappeared after victory. </br>
- As a player,I can add Speed Boster to walk fast. </br>

:godmode: Grumeet </br>

- As a user, I want to see Cut scenes and Victory popup in the game.</br>
- As a player, I can feel the whole Game different Background Music. </br>

:feelsgood: Pujit

- Game Timer - As a player, the game ends when the timer is complete</br>
- As a player, I can Regain health by using health pack.</br>

:goberserk: Ashok

- As a player , I should be able to Pause or  Restart the Game. </br>
- As a player, I can use extra Power Boosters during battle. </br>


## Individual Developed feature summary

<details><summary>As a player, I should be able to Pause or Restart the Game.</summary>
<p>


Name: Chintagunta Ashok Vardhan Reddy</br>
CWID: 10400791</br>
Email Id: avc007@latech.edu</br>


### Game Resources:</br>
* Added game pause icon.
* Added game play icon.
* Added game Restart icon.
* Added Pause Audio.</br>


### Method Functionality:</br>

|Functionality| Methods|
|---|---|
|Game Restart| applicationRestart|
||restarrt_Click|
|Game Play pause| applicationPlayPause|
 ||playpause_Click|
|Window Popup |windowplaypause_Click|
   || controlWindowStatus|
   
</p>
</details>

<details><summary>As a user, I want to see Cut scenes and Victory popup in the game.</summary>
<p>


Name: Gurmeet Sindhu</br>
CWID: 10399085</br>
Email Id: gsi008@email.latech.edu</br>


### Game Resources:</br>
* Added Image for Victory screen with sound.
* Added Image and sound when enemy dies.
* Added Image and sound for when player dies.</br>


### Method Functionality:</br>

|Functionality| Methods|
|---|---|
|Victory Screen| victory()|
|Pop when enemy dies| enemykill()|
 ||Enemyformpopup.cs|
|Popup when player dies |playerDead()|
   
</p>
</details>

<details><summary>As a player, I should be able to disappear the enemy after death.</summary>
<p>


Name: Yashvanth Aditya Krishna Vorsu </br>
CWID: 10398115</br>
Email Id: yav001@latech.edu</br>


### Game Resources:</br>
* Added sound trigger for enemy dead.
* Added disappeared functionality after death.
* Added sound audio.</br>


### Method Functionality:</br>

|Functionality| Methods|
|---|---|
|Enemy Disable| Enemydisable()|
|Sound Trigger| Souundeffect()|
   
</p>
</details>

<details><summary>As a player, the game ends when the timer is complete</summary>
<p>


Name: Pujit Naga Sai Pavan Kumar Etha</br>
CWID: 10397658</br>
Email Id: pne005@latech.edu</br>

### Game Resources:</br>
* Added image for timeup 
* Added Timeup audio</br>


### Method Functionality:</br>

|Functionality| Methods|
|---|---|
|timer| tmrUpdateInGameTime_Tick|
||timeup()|

   
</p>
</details>













