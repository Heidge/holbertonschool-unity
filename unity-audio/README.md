# Unity - Audio

## Learning Objectives

At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

- What is an Audio Source
- What is an Audio Listener
- What is an Audio Filter
- What is an Audio Mixer
- What are snapshots
- What is a channel
- What is attenuation
- What is ducking
- How to control audio elements with scripts

## Unity Tasks

### 0. Sound check, one two

Duplicate 0x07-unity-animation and rename it unity-audio.

Download this .zip file. It contains all the audio clips we’ll be using for this project (see example). Place them in a folder in the Assets folder called Audio. Don’t change the folder hierarchy inside the Audio folder.

In your README.md, add the following attribution for the audio clips we’ll be using:

Kenney: https://kenney.nl/
Oculus Audio Pack: https://developer.oculus.com/downloads/package/oculus-audio-pack-1/
Mindful Audio: https://mindful-audio.com/
“Wallpaper”, “Cheery Monday” Kevin MacLeod (incompetech.com)
Licensed under Creative Commons: By Attribution 3.0
http://creativecommons.org/licenses/by/3.0/
In the MainMenu scene, create an empty GameObject named MenuSFX. Make button-rollover.ogg a child object of MenuSFX.

Add the button-rollover sound clip to all menu buttons (all three level select buttons, Options, Exit) so that when the player’s mouse hovers over a button, it plays the sound clip.

### 1. Click

In the MainMenu scene, make button-click.ogg a child object of MenuSFX.

Add the button-click sound clip to all menu buttons (all three level select buttons, Options, Exit) so that when the player’s mouse clicks on a button, it plays the sound clip.

Save MenuSFX as a prefab inside the Prefabs folder.

The OptionsButton and ExitButton prefabs should be updated with the sound effect clips

### 2. Pole position

In the MainMenu scene, add Wallpaper as background music. It should start playing when the scene loads and stop when the player loads a different scene. The music should also loop.

Inside the Audio folder, create an AudioMixer named MasterMixer. Inside MasterMixer, create a new Audio Mixer Group called BGM. Set the music’s Audio Mixer Group to BGM. By default, BGM audio levels should be at 0.00dB.

### 3. Tap-tap-tap

In the Level01 scene, add footstep sound clips to the Player so that when the Player is running, the sound plays in a loop until the Player stops running.

- When the Player runs on a grassy platform, footsteps_running_grass should play
- When the Player runs on a stone platform, footsteps_running_rock should play
- If you’ve used both types of platforms in your levels, find a way to trigger different sounds on different surfaces.
- The footstep sounds should line up with the animation of the Player’s feet touching the ground
- The footstep sounds should not play while the Player is jumping or falling

Create a new Audio Mixer Group named Running in MasterMixer and set the footsteps sound clips’ Audio Mixer Group to Running. By default this group’s audio level should be -20.00dB. Add filters to the group to make the sound fit the movement / terrain better.

### 4. Thump

In the Level01 scene, add a landing sound clip to play when the player hits the ground from falling off the platforms and restarting. If the player lands on a grassy platform, footsteps_landing_grass should play. If the player lands on a stone platform, footsteps_landing_rock should play.

Create a new Audio Mixer Group named Landing in MasterMixer and set the sound clip’s Audio Mixer Group to Landing. By default this group’s audio level should be 2.00dB. Add filters to the group to make the fall sound more substantial.


### 5. Cheery Monday

In the Level01 scene, add CheeryMonday as background music. It should start playing when the level loads and stop when the player touches the WinFlag or returns to the MainMenu scene. The player sound effects should still play while the BGM plays and it should loop.

Set the music’s Audio Mixer Group to BGM.

### 6. Victory fanfare

In the Level01 scene, add VictoryPiano as a win sting that plays once when the Player touches the WinFlag. The background music CheeryMonday should stop playing when VictoryPiano starts.

Set the Win music’s Audio Mixer Group to BGM.

### 7. Ambience

Add ambient audio to at least one tree (birds) or at least one rock/grass/flower (crickets). This audio should be quiet or muted from a distance and grow louder as the player gets closer to the GameObject.

Create a new Audio Mixer Group named Ambience in MasterMixer and set birds and crickets Audio Mixer Group to Ambience. By default, Ambience‘s audio level should be 5.00dB.

### 8. Shhh

Using Snapshots, create functionality so that when the Player pauses the game, the BGM should become muffled. (Check the playable demo to hear the desired effect.) When the player returns to the game, the sound should return to its original settings.

### 9. Volume control #0

In the Options scene, make sure the OptionsButton and ExitButton prefabs are updated to have the button-rollover and button-click sound effect events applied.

In OptionsMenu.cs, script the BGMSlider so that when the slider’s value is changed by dragging the slider handle, the BGM audio decreases and increases from fully muted to max volume. These values should persist through all levels and when the game is quit and re-opened.

Hint: Converting dB to float

### 10. Volume control #1

In the Options scene and OptionsMenu.cs, script the SFXSlider so that when the slider’s value is changed by dragging the slider handle, the SFX audio decreases and increases from fully muted to max volume. These values should persist through all levels and when the game is quit and re-opened. SFX audio includes the ambient sounds and UI button sounds.

Hint: Converting dB to float

### 11. Sound system gonna bring me back up

Add music and sound effects to scenes Level02 and Level03, using the same Audio Mixer you created for Level01. Make sure your player sounds, options, etc. work in these scenes as well.

- Level02 BGM: PorchSwingDays
- Level03 BGM: BrittleRille

### 12. We're done!

Scenes in Build:

    1. MainMenu
    2. Options
    3. Level01
    4. Level02
    5. Level03

Create three builds of all scenes above in the Builds directory.

- Windows and Linux builds should be set to x86_64 architecture

Build Folder Hierarchy:

- Builds
  - Linux
    - Platformer_Data
    - Platformer.x86_64
  - Mac
    - Platformer.app
  - Windows
    - Platformer_Data
    - Platformer.exe
    - UnityPlayer.dll
    - 
Make sure to run your build and make sure it works! Test your build on all three platforms if possible, but at the very least test on your own computer.

Create a .zip of each build:

- Platformer_Mac.zip
- Platformer_Linux_x86_64.zip
- Platformer_Windows_x86_64.zip

Upload the three .zip files to Google Drive or Dropbox. Add the links to the files below.