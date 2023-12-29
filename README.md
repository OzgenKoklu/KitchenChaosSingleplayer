# CodeMonkey2023-Overcooked-Clone

/WORK IN PROGRESS/
This is a learning project based on Code Monkey's 2023 complete tutorial. (https://www.youtube.com/watch?v=AmGSEH7QcDg)
Note: I've built the entire game with multiplayer aspect, than I realized the source code got too cluttered with the multiplayer logic which needs completely different architechture,
So I'm sharing this version of the game seperatly because I feel much familiarity with the syntax and the way its put together, the multiplayer project is in this link, the step by step process of making it can be observed in the commit history, I've also added descriptions on those commits.
(Multiplayer Repo Link added here)

Disclaimer: All assets were borrowed from Code Monkey and are not used for commercial use, this is a learning project and I've built this on my own under instructions by Code Monkey. 

ABOUT THE GAME: This is a small scale casual game that is highly inspired by OverCooked, where you have to deliver specific orders in a time limit. 
It is a complete package with scene cycle, sound and animation, options menu, savable settings and key bindings.

/IMAGES AND VIDEO TO BE ADDED/
Also some images and gifs to give a better impression: 
![Main Menu](https://github.com/OzgenKoklu/KitchenChaosSingleplayer/tree/main/ReadmeMedia/png/1.MainMenu.png)
![Tutorial UI](https://github.com/OzgenKoklu/KitchenChaosSingleplayer/tree/main/ReadmeMedia/png/2.TutorialUI.png)
![Gameplay SS](https://github.com/OzgenKoklu/KitchenChaosSingleplayer/tree/main/ReadmeMedia/png/3.Gameplay.png)
![Settings UI](https://github.com/OzgenKoklu/KitchenChaosSingleplayer/tree/main/ReadmeMedia/png/4.SettingsUI.png)
![Gameover](https://github.com/OzgenKoklu/KitchenChaosSingleplayer/tree/main/ReadmeMedia/png/5.Gameover.png)

***GIFs
![Game Flow](https://github.com/OzgenKoklu/KitchenChaosSingleplayer/tree/main/ReadmeMedia/gif/GameStartFlow.gif)
![Delivery Success](https://github.com/OzgenKoklu/KitchenChaosSingleplayer/tree/main/ReadmeMedia/gif/DeliverySuccess.gif)

Also a youtube link to show the entire game loop:
[![Youtube Link](https://img.youtube.com/vi/92pFdvhzqCg/0.jpg)](https://youtu.be/92pFdvhzqCg)

TLDR: I know most of you whos checking this has no time to read these walls of texts so I'll list what I've learned in a summarized way.
-Properly use intermediate C# features and concepts: Events, Scriptable Objects, Interfaces, Inheritence, Delegates, Callbacks, Enums
-Properly implementing Observer and State Machine design patterns
-Not to be afraid of refactoring. You dont need to think the architecture from the get-go, you just refactor if you need to adapt a new system.
-Using methods in a more versatile way, out parameter, using methods withs all kinds of return types.
-Seperating Logic & Visuals & Sounds etc, properly equipping the classes



If you are more interested in me or my route: 


About my background:
Last year, I started my journey as a game developer, first couple of months was about getting used to the Unity Editor, learning about the different components etc. I've completed Unity's official Jr pathway, 
and got a basic idea on how to make a game. Than I made my first complete project in a bootcamp, I actually have a repository of the said project here: (bootcamp project link) While making this project, I realized that I know all these components,
but putting together an architecture for a working game is actually way harder than what I thought it would be. I had no idea on how to use events or delegates so I used public boolean flags everywhere to control game mechanics! 20 different bools to change the states of a game? 
What about using state machine design pattern? Or Observer to decouple the logic? Well, I was just crawling at the time. Got obsessed with "best practice" and was paralised by my perfectionism for couple of months, 
was trying to learn all those more advanced topics but everyone kept telling me I should make more prototypes. Also, there was no cohesive tutorials on these topics, those 10 minute out of context tutorials on scriptable objects, interfaces, events, delegates, or design patterns did not help me learning these complex topics, I needed something cohesive.
I searched for source codes of complete projects, found some and definetly learned these topics better. But then comes this project, I think I've made the biggest progress in my coding while following this 10 hour course, 
bacause I've seen a senior developer building systems from scratch, unlike what I thought about the process, Code monkey refactor the code as much as it is needed.



What I've learned from this building this project: 
THhe most important & TLDR: 
Most important stuff I've learned from this building this project:

More About the course: 
Code Monkey's website have course curriculum in this page: https://unitycodemonkey.com/kitchenchaoscourse.php
Although, I also wanted to cover what I've learned by re-reading the commit history, which is in the multiplayer repo, not this one. 
To revise the techniques and make a readme that is belonging to me. 

Concepts, techniques and game development patterns used in this project:
1) Global volume - Postprocessing effect 
2) Player Input - old & new input system, InputActions, ReadValue, Interact.Performed
3) Movement & positioning - Transform, Lerp, Slerp, vector normalization, .localposition
4) Player Animation - Seperating Logic and visuals, animator usage (setbool, settriger)
5) Raycast / Capsulecast - LayerMask - out RayCastHit 
6) Cinemachine 
7) Prefabs - Prefab variants 
8) Unity Events - Events with extended arguments
?subcribing and invoking
?/ "xxx?.Invoke()" syntax 
?
9) Generics <T> - EventHandler<T>
9) Using singleton Instance with
10) Writing setter and getter in one line  { get; private set;  }
11) Scriptable Objects - data holders, data for specific object (prefab, sprite, string) or 
data for function inputs and outputs.
12) Attributes - [CreateAssetMenu()]
13) Interfaces - IKitchenObjectParent: Includes guidelines to be a kitchenobject parent, IHasProgress
14) Methods with many different return types: 
Bool, Transform, Class. Good for clean and strong code.
Truly utilizing abstaction and making readable good clean code, etcc etc 
player.GetKitchenObject().SetKitchenObjectParent(this);
player.GetKitchenObject().TryGetPlate(out PlateKitchenObject plateKitchenObject)
 if (HasKitchenObject() && HasRecipeWithInput(GetKitchenObject().GetKitchenObjectSO()))
15) Inheritence - virtual/override methods 
16) UI - Worldspace UI, basic Show(), Hide() functions 
17) enum usage - Switch/Case - State machine
18) Simple Vector Maths for camera work - LookAt and transform.forward 
19) Particle System
20) how to use Interface from serializedfield
21) Stack mechanic ? 
22) Out Parameter in methods. (trygetplatekitchenObject)
23) shadergraph basics (delivery counter texture) - details
24) List comparison algorithms (deliveryManager, platecompletevisual)
25) vertical layout group (Delivery manager, platecomplete uI)
26) Sound Manager (Observer) 
27) methods with two different argumants PlaySOund(5 args vs 4 args or something.
28) Delegate - Lambda expression (MainManuUı) 
29) Scene Manager Loader Loading (callback-isFirstupdate)***
30) Player prefs 
31) Options setting main menu scene manager loop
32) Button Binding. ??? Araştır tekrar 
33) Saving to JSON using playerprefs 
34) Genel polish detayları 



---Eklemeler yapılacak, gramer check / typo check / new additions from notes:
 
ABSTRACT NOTES//
onanycut(static method for no singleton object) 

( CuttingCounter cuttingCounter  = sender as CuttingCounter;) as keyword. 
this is PlateKitchenObject syntax 

Concepts: 
1)Seperating logic & visuals
Many examples in this project: PlatesCounter.cs/PlatesCounterVisual.cs 

2)Decoupling logic (using events, different method return types)
3)Static Classes or methods 
5)Scriptable Objects (data holders) 
5)Interfaces - how to use Interface from serializedfield
6)Inheritence - BaseCounter > ClearCounter - ContainerCounter Etc. 
7)Naming Convention. UI scripts end with UI etc.
8)Strings are vulnarable. Usage of Const strings. 
9)State machine - States stored in Enum
10)Execution order Awake>start , update Late update
11)Struct usage (as data holder / plateKitchenObjecVisual - Gameobject ) 
12) 


Reference: 
https://www.youtube.com/watch?v=AmGSEH7QcDg 

/WORK IN PROGRESS/
