# Unity - Assets: Models, Textures

## Learning Objectives

At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

- General
- How to import images to use in a user interface
- What is a canvas?
- What is the difference between Screenspace, Worldspace, and Localspace?
- What is a Sprite?
- How is a Sprite different from a Texture?
- How to use the Sprite Editor
- What is 9-slicing?
- How to create a Slider
- How to create a Toggle
- How to swap button images
- How to use PlayerPrefs and what are they used for?

## Technical description

This project focuses on the following key areas:

- **Importing Images:** Learn how to import images to use in a user interface.
- **Canvas Management:** Understand what a canvas is and the difference between Screenspace, Worldspace, and Localspace.
- **Sprites:** Learn what a sprite is and how it differs from a texture. Learn how to use the Sprite Editor and what 9-slicing is.
- **Interactive UI Elements:** Learn how to create a Slider and a Toggle, and how to swap button images.
- **PlayerPrefs:** Understand how to use PlayerPrefs and what they are used for.

Please create a separate Unity project under the holbertonschool-unity repo, naming it unity-assets_ui. Please also include the latest TextMeshPro package (this project was made with 3.0.6) found in Package Manager -> Unity Registry -> TextMeshPro.

Note: Using free or paid script assets from the Unity Asset Store or elsewhere is prohibited for this project. Focus on creating your own scripts that interact with Unity’s existing character controller components.

## Unity Tasks

### 0. Leveling up

We’ll be adding on to the last project to add a menu and UI (see example ). Duplicate your 0x05-unity-assets_models_textures directory and rename it unity-assets_ui.

Create two more Scenes in unity-assets_ui. For each new scene, create a new path of platforms for the Player to navigate through.

- Scene Name: Level02:
  - Skybox: CloudyCrown_Daybreak
  - 
![Scene Level02](C:\Users\axelg\OneDrive\Documents\Dev\Holberton\readmes\01.png)

- Scene Name: Level03:
  - Skybox: CloudyCrown_Midnight

### 1. Choose your own adventure

The next few tasks will be creating UI elements using imported images to build a menu that allows the player to choose a level.

Download the Google font “Changa” and place in a Changa folder into a new folder called Fonts in the Assets folder (the final path should be Assets/Fonts/Changa/<.ttf files>). All text should use this font, so change TimerText‘s font as well.

Please note you will use TextMeshPro for the text elements in this project. As TextMeshPro Text components use Font Assets you will have to create a Font Asset for each Changa-{Style}.tff file. These should be included under Assets/Fonts/Changa/ and be named according to this format Changa-{Style}.asset. For example: Changa-Regular.asset or Changa-ExtraBold.asset.

Download these images into a folder called UI in the Textures folder. Set their Texture Type to Sprite (2D and UI).

Create a new Scene called MainMenu.

Using this image as a guide, create a new Canvas with the following attributes and child objects:

- Canvas Name: MenuCanvas
  - Render mode: Screen Space - Overlay
  - Pixel Perfect: No
  - UI Scale Mode: Scale With Screen Size
  - Reference Resolution: X: 1280 Y: 800
  - Screen Match Mode: Match Width or Height
  - Match: 1 (Height)
  - Reference Pixels Per Unit: 100


- Image GameObject Name: MenuBG
  - Image: bg-menu.png
  - Anchors Min: X: 0 Y: 0
  - Anchors Max: X: 1 Y: 1
  - Left: 50
  - Top: 50
  - Right: 50
  - Bottom: 50


- Image GameObject Name: Title
  - Source image: bg-header.png
  - Child Text GameObject Name: TitleText
    - Text: LEVEL SELECT
    - Font: Changa-ExtraBold.ttf
    - Vertex Color: #ffffff
    - Font size: 60
    - Alignment: Center + Middle
    - Overflow: Overflow

- Level Buttons - You will need to use the Sprite Editor to slice these images. When the mouse is over the button, the button should highlight; when mouse clicks, the button should appear pressed.
  - Button GameObject Name: Level01
    - Background image: button-level01.png
  - Button GameObject Name: Level02
    - Background image: button-level02.png
  - Button GameObject Name: Level03
    - Background image: button-level03.png

- Other Buttons - You will need to use the Sprite Editor to slice these images. When mouse is over the button, the button should highlight; when mouse clicks, the button should appear pressed.
  - Button GameObject Name: OptionsButton
    - Width: 200
    - Height: 70
    - Background image: bg-button.png
  Text GameObject: OptionsText
    - Text: Options
    - Font: Changa-Medium.ttf
    - Vertex Color: #ffffff
    - Font size: 36
    - Alignment: Center + Middle
    - Overflow: Overflow
    - Transition: Sprite Swap
    - Highlighted Sprite: bg-button_1
    - Pressed Sprite: bg-button_2
    - Save this button into a folder called Prefabs in the Assets folder
  - Button GameObject Name: ExitButton
    - Width: 200
    - Height: 70
    - Background image: bg-button.png
    - Text GameObject: ExitText
    - Text: Exit
    - Font: Changa-Medium.ttf
    - Vertex Color: #ffffff
    - Font size: 36
    - Alignment: Center + Middle
    - Overflow: Overflow
    - Transition: Sprite Swap
    - Highlighted Sprite: bg-button_1
    - Pressed Sprite: bg-button_2
    - Save this button into a folder called Prefabs in the Assets folder

### 2. Pole position

Create a new Scene called Options.

Using this image as a guide, create a new Canvas with the following objects:

Canvas Name: OptionsCanvas
Render mode: Screen Space - Overlay
Pixel Perfect: No
UI Scale Mode: Scale With Screen Size
Reference Resolution: X: 1280 Y: 800
Screen Match Mode: Match Width or Height
Match: 1 (Height)

Image GameObject Name: MenuBG
Image: bg-menu.png
Anchors Min: X: 0 Y: 0
Anchors Max: X: 1 Y: 1
Left: 50
Top: 50
Right: 50
Bottom: 50

Image GameObject Name: Title
Source image: bg-header.png
Child Text GameObject Name: TitleText
Text: OPTIONS
Font: Changa-ExtraBold.ttf
Vertex Color: #ffffff
Font size: 60
Alignment: Center + Middle
Overflow: Overflow

Slider GameObject Name: BGMSlider
Child Text GameObject Name: BGMText
Text: BGM
Font: Changa-Medium.ttf
Vertex Color: #ffffff
Font size: 36
Handle image: slider-handle.png
Image Name: Mute
Image Source: sound-mute.png
Image Name: Full
Image Source: sound-full.png

Slider GameObject Name: SFXSlider
Text GameObject Name: SFXText
Text: SFX
Font: Changa-Medium.ttf
Vertex Color: #ffffff
Font size: 36
Handle image: slider-handle.png
Image Name: Mute
Image Source: sound-mute.png
Image Name: Full
Image Source: sound-full.png
Toggle GameObject Name: InvertYToggle
Child Text GameObject Name: InvertYToggleText
Text: Invert Y-Axis
Font: Changa-Medium.ttf
Vertex Color: #ffffff
Font size: 36
Background image: bg-toggle.png
Checkmark: check-toggle.png
Buttons
Button GameObject Name: BackButton
Background image: bg-button.png
Child Text GameObject Name: BackText
Text: Back
Font: Changa-Medium.ttf
Vertex Color: #ffffff
Font size: 36
Save this button into a folder called Prefabs in the Assets folder
Button GameObject Name: ApplyButton
Background image: bg-button.png
Child Text GameObject Name: ApplyText
Text: Apply
Font: Changa-Medium.ttf
Vertex Color: #ffffff
Font size: 36
Save this button into a folder called Prefabs in the Assets folder

### 3. Jump man

Create a new folder called Scripts. Inside that folder, create a new C# script called PlayerController and attach it to Player.

- The script should handle user input so the player can move left, right, forward, backward, and diagonally using the WASD keys
- The player should jump when the Space button is pressed

### 4. Camera ready

Position the Main Camera at an offset behind the player.

- Position: X: 0, Y: 2.5, Z: -6.25
- Rotation: X: 9, Y: 0, Z: 0

### 5. Steady cam

In the Scripts folder, create a new C# script called CameraController that allows the camera to follow the player. The script should also allow the player to rotate the camera on their own by moving the mouse, either by just moving the mouse or holding down right-click and dragging the mouse to move the camera.

### 6. Falling up

Currently if the player falls off a platform, it falls infinitely. Edit the PlayerController and CameraController scripts so that if the player falls from a platform and can’t get to another platform, the player instead falls from the top of the screen onto the start position, causing the player to need to start from the beginning again.

Currently if the player falls off a platform, it falls infinitely. Edit the PlayerController and CameraController scripts so that if the player falls from a platform and can’t get to another platform, the player instead falls from the top of the screen onto the start position, causing the player to need to start from the beginning again.

### 7. Time trial

Create a new Canvas and UI Text element that displays a timer on screen.

- Canvas Name: TimerCanvas
  - Pixel Perfect: No
  - UI Scale Mode: Scale With Screen Size
  - Reference Resolution: X: 1280 Y: 800
  - Screen Match Mode: Match Width or Height
  - Match: 1 (Height)
- Text GameObject Name: TimerText
- Width: 160
- Height: 30
- Anchor: Top, Center
- Position: X: 0, Y: -40, Z: 0
- Text: 0:00.00
- Font size: 48
- Font color: White
- Alignment: Center, Middle
- Horizontal Overflow: Overflow
- Vertical Overflow: Overflow
  
Save TimerCanvas as a Prefab. Make sure that when you make changes to the TimerCanvas Prefab, you Apply the changes at the top of the Inspector window.

### 8. Clock's ticking

Create a script called Timer and attach to the Player. Timer should have a public Text variable called Timer Text for the TimerText Text object.

The timer should start at 0:00.00 and count up.

Currently, the timer starts as soon as the scene loads. Instead, we want the timer to start as soon as the Player starts moving. Disable the Timer script attached to Player. Leave the TimerCanvas active so that 0:00.00 is displayed.

Create a Cube GameObject called TimerTrigger.

- Position: x: 0, y: 1.25, z: 0
- Scale: x: 0, y: 2, z: 0
- Disable the Mesh Renderer
- 
Create a new script called TimerTrigger and attach it to the TimerTrigger GameObject. This script should enable the Timer script and start counting up as soon as the Player exits the TimerTrigger‘s Collider.

If the Player falls and restarts, the timer should not reset – it should continue to run.

### 9. Finish line

Create a script called WinTrigger and attach to WinFlag.

When the Player touches the WinFlag collider, the timer should stop and the text size should increase and the color should change to green. The recommended increased font size is 60 but the value is at your discretion as long as the size increase is noticeable to the user.

### 10. The sky's the limit

In the Unity Asset Store, find Farland Skies - Cloudy Crown, a free set of skyboxes. Add them to a folder called Skyboxes in the Assets/Materials folder in your unity-assets project.

Create a skybox with the CloudyCrown_Midday material.

### 11. The great outdoors

Download Kenney’s Nature Pack Extended. Import the asset package and place the files in a directory called Models. For the sake of organization, inside the Assets folder, create a new directory called Materials and move the materials in Models into Materials.

Replace your cube placeholders with the 3D models. The 3D models need mesh colliders otherwise the player cannot jump on them. Make sure the player can jump and move between platforms, that the distance and the player’s jump are reasonable, and that the player can reach the end from the starting point.

In your README, include the following credit: Models: Kenney's Nature Pack Extended with a link to the website.

### 12. Environmental awareness

From the Nature Pack asset package in your Models folder, add trees, rocks, flowers, etc. to the platforms as you like. Organize your objects in your Hierarchy using empty GameObjects.

Keep in mind the placement of the objects so as not to block or hinder the player from being able to jump between platforms (unless that’s part of your design!). The player should also not be able to walk through rocks, trees, etc., but may walk through flowers, grass, etc.

### 13. What's left of the flag

Download this flag model. Place it in the Models directory. Add Flag to your scene and make it a child of the WinFlag GameObject. The pole of the flag should be positioned inside WinFlag‘s collider. Resize or reposition the collider if necessary.

### 14. (Sea)horse race

Download this flag texture. Place it in a new directory called Textures.

Import Settings:

- Texture Type: Default
- Texture Shape: 2D
- Wrap Mode: Repeat
- 
Inside the Materials folder, create a new Material called Flag and apply it to the rectangular flag portion of the Flag model. Apply the existing Wood Material to the flagpost portion of the model.

### 15. Under development

Scenes in Build:

1. Level01

Create three builds of Level01 in a directory called Builds.

- Windows and Linux builds should be set to x86_64 architecture
- 
**Build Folder Hierarchy:**

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
- 
Upload the three .zip files to Google Drive or Dropbox. Add the links to the files below.
