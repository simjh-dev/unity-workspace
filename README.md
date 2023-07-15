Unity Developer Roadmap

- reference: https://medium.com/@amichelidebard/self-taught-learning-path-for-unity-developers-cedbc0e2c73a

> Appreciate the author of the article. It was an article that solved my worries about my career as a Unity developer at once. Thank you.

--------------------------------------------------------------------------------

I built this roadmap as a general guide for people on the self-taught learning path aiming toward getting into the game development industry using Unity.

Being self-taught demands responsibility in taking care of your own learning path, and sometimes it&s easy to get lost or not be sure about your next learning step.

> This guide is based on my personal experience getting into the gamedev industry, mostly as a self-taught developer without a college degree.

Also, while this guide may not be the most in-depth out there, the main intention is to highlight the steps where I found most people get stuck or fail to take care of in their learning.

# Getting the basics right: C#

<img src="https://miro.medium.com/v2/resize:fit:1100/format:webp/1*g4SaKClS06Q75Uy67t9tPg.png" />

Personally, the first and most important step is getting a good and eep knowledge of all the essential C# syntax and concepts before even opening the Unity Editor.

I see a lot of people failing this and struggling a lot with basic OOP concepts later on when they should completely understand them before attempting to deal with Unity-related topics.

I strongly advise you to fisrt get started with Visual Studio, and play around with simple Console Apps before taking the leap to Unity.
It helps a lot to be able to only focus on the programming concepts without all the Unity-specific overheads such as Monobehaviours, the Update cycle, and the rest of the game stuff.

It also gives you an overview of how the execution cycle of more traditional apps works, as opposed to the game's frame-based execution loop.

So in general, I would recommend starting out with some C# specific courses, and be sure to have a good grasp of concepts like Methods, Classes, Constructors, Inheritance, Interfaces, built-in C# types and classes, and even Polymorphism.

# Time for Unity

<img src="https://miro.medium.com/v2/resize:fit:1100/format:webp/1*OQpqUg3H6sIclX-Nr8gdiA.png" />

After getting to a confident level with C#, its time to jump into Unity and learn the new concepts it brings to the table:
Be sure to fully understand the Update execution loop and Script Lifecycle.

The differences between Awake() and Start() should be as clear as those from Update() and FixedUpdate(), the following documentation page is a reliable source for that:

[link](https://docs.unity3d.com/Manual/ExecutionOrder.html)

Concepts like serialization, framerate independence, and features like Coroutines and Events are really important to understand fully and be able to use correctly.

Also, don't get used to debugging by just placing Debug.Log() everywhere, learn how to preperly debug code with your IDE:

[link](https://docs.unity3d.com/Manual/ManagedCodeDebugging.html)

And then, all the graphics-related concepts come into play: Materials, Textures, Meshes, Sprites, Draw Calls, and Shaders.
You might not be the one making the assets for the game (or maybe you are), but you should be able to know how to correctly integrate them into the game.
You can easily practice this by making small games using free pre-made assets.

# Planning Focus Platform.

<img src="https://miro.medium.com/v2/resize:fit:1100/format:webp/1*M288wYhHtu3KhSG0GIzhBw.png" />

Your next step would be researching which platform/target would you like to aim into.
Mobile? AR/VR? AAA Desktop games? there are many fields inside game developement where you can specialize, at this point, you can either try and learn a bit of everything or focus on some particular area to increase your chances of landing something in that market.

Always take into account market sizze and demand for each topic;
for example, if you came out as a mobile game developer, with experience dealing with common SDKs such as Admob, Firebase, Unity Gaming Services suite, and such, I can bet there are amny companies out there waiting for you.

# Git

<img src="https://miro.medium.com/v2/resize:fit:786/format:webp/1*W4EDAV9l9gqCKLQZqJZgmA.png" />

Having good handling of Git is essential for a developer, more so when working in a team.

Usually, when working alone it's easy to not get into many problems with Git, so it's good idea to try and simulate those experiences by trying to get the most out of Git by practicing things like GitFlow, making extensive use of branches, and resolving occasional merge conflicts in your own personal projects.

Also be sure to know how to use mainstream Git hosting platforms such as GitHub, having some projects there you can showcase is always a plus for your portfolio.

> I recently made an article explaining how to quickly setup Git + GitHub for Unity Projects, it should give you a good quick start on the subject

# Modern programming design patterns

<img src="https://miro.medium.com/v2/resize:fit:828/format:webp/1*otXwpWopON0qJFs2sY1Ddw.png" />

After getting used to just coding stuff the first way you think about doing them, you can start learning about the different programming patterns that are used frequently in game developement, so you can be able to recognize them later on because there are always many different ways to approach every problem, and usually later on when joining a team, they might have the desired approach already defined, and knowing these patterns helps you out to understand those ideas easily.

Patterns such as Singleton, Observer, Factory Method, Builder, and State should be familiar to you.

Also, concepts such as Dependency Injection, or different game architecture approaches should be in your book, but this depends a lot on where you end up working, each company work in their games in their own ways.

# Portfolio projects

<img src="https://miro.medium.com/v2/resize:fit:720/format:webp/1*Zkl9PjDTK5dJ2RH3g3rrJg.png" />

Your portfolio would be your first impression and living proof of your amount of knowledge in the field.

This part is very different from the previous ones because it's more about actually building and showcasing things, and not learning.

Your portfolio should include at least the following:
- A byte-size technical prototype, showing off an interesting and complex game mechanic of your liking.
This one should have its code available on GitHub and would show off your core programming skills.
- A vertical slice of a complete game, showing off at least surface-level implementation of all features a game should have.
Doesn't have to be a commercial success, just something that shows off that in the correct team, your skillset as a developer would be able to cover all areas of interest.
You can even attempt to publish it to an actual store.

Having lots of random prototypes around might also help a bit, but I would focus the main efforts on those 2 previous points.

# Keep on learning
Whatever your end goal is, just keep on learning and doing, there is no better way to get used to new concepts than working and applying them.
So keep making prototypes, try participating in game jams (those games can be shown nicely in your portfolio later on), and always look for your next step.
As I said at the start of this post, I tried to emphasize the points where I found most people fail in their learning, each point can be dug really deep into, but that would be just anotehr topic of discussion.

