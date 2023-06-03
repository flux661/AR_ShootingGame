
# AR  3D Shooting Game

A light weight 3D mini shooting game with ARCore support!

Mini games are a great means for light entertainment. This game project lets the player shoot down virtual objects that appear on his smartphone screen in the real world and stack up a high score. The player wins points for shooting down the target objects but loses points and health if they shoot bombs.



## Tech Stack

##Tools and Frameworks :

**Unity 3D Game Engine**  
**Blender**  
**ARCore SDK**  
**Android SDK**   

##IDE and Programming Langugage used:  

**Microsoft Visual Studio**  
**C# Programming Language**  

      



## Features

This is an augmented reality game and players must use their smartphone to shoot down the virtual objects that appear on their screen. Key features of the game are:
- Assets made in Blender : Bomb, Heart, Soccer Ball, Diamond.
- Score count, health bar and highscore updation.
- Sound effects when player destroys objects.
- BGM volume controls
- Difficulty levels : Easy, Medium, Hard
- Variation of speed of game objects as the score increases and variation in the number of game objects spawning on screen according to the difficulty level chosen.
- Pause Menu with options to resume game, restart game or transition back to main menu. 
- Game built for Android API level 24 and above. 

##AR Components Used:  

- **AR Session:** AR session controls the lifecycle of an AR experience by enabling or disabling AR on the target platform
- **AR Session Origin:** The purpose of the AR Session Origin is to transform trackable features, such as planar surfaces and feature points, into their final position, orientation, and scale in the Unity Scene. It also has AR cam which is the device cam.
- **AR Raycast Manager:** also known as hit testing ray casting allows you to determine where a ray intersect with a trackable like a plane or a point closed.


 ```
 NOTE : The BGM used in the game has been created by the artist TOBU and proper credits have been given to the artist. You may use the below given links to include the credits in your project.
https://tobu.io/Hope/download
https://www.youtube.com/watch?v=Y1Z3Q3O7IRE 
```
 


## Project Setup on local machine and Deployment

Software prerequisites : Unity Hub, Microsoft Visual Studio 2022, AR Foundation, Android SDK.

Clone the project

```bash
  git clone https://github.com/flux661/AR_ShootingGame.git
```

- Open the project directory as a new project in Unity 
- In order to build, configure the build settings according to the requirements and build the APK file to install and run on Android.
