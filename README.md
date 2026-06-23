# Challenge 2 – Play Fetch

A Unity challenge where balls randomly fall from the sky, and you must send your dog out to catch them before they hit the ground. This project was built as part of the **Create with Code** curriculum, applying array and random number generation skills learned in Unit 2.

## 🎮 Game Overview

Balls fall from random positions above the screen. Your goal is to **press the Spacebar** to spawn a dog that runs to catch the falling ball. If the dog catches it, the ball is destroyed. If the ball hits the ground, the game is over. This challenge focuses on debugging and reinforcing core programming concepts.

This challenge demonstrates:
- **Arrays** for managing multiple ball types
- **Random number generation** for spawn positions and ball selection
- **If-statements** for game logic and collision detection
- **Collision detection** for dog–ball interactions
- **Object destruction** when objects leave the screen

## ✨ Key Features

- **Random Ball Generation** – One of three different ball types spawns at a random X position above the screen.
- **Dog Launch** – Press the **Spacebar** to spawn a dog that runs to catch the ball.
- **Collision Detection** – The ball is destroyed when the dog makes direct contact with it.
- **Game Over Condition** – If a ball hits the ground, a "Game Over" debug message is displayed.
- **Cleanup System** – Dogs and balls are automatically removed from the scene when they leave the screen.

## 🛠️ Technologies Used

- **Unity Editor** – Game engine and development environment.
- **C#** – All game logic, including spawning, movement, and collision handling.
- **Unity Physics** – Collision detection for dog–ball interactions.

## 🚀 Getting Started

### Prerequisites

- Unity Hub with Unity Editor installed (any recent version).
- Git (optional, for cloning).

### Installation

1. Clone this repository:
   ```bash
   git clone https://github.com/JMacopio/Challenge-2.git
   ```
2. Open Unity Hub, click **Add**, and select the cloned project folder.
3. Once the project loads, navigate to `Assets/Scenes/` and open the main scene.
4. Press the **Play** button in the Editor to start the challenge.

## 🎮 How To Play

1. **Watch the Sky** – A ball will spawn at a random position above the screen.
2. **Send the Dog** – Press the **Spacebar** to spawn a dog that runs to catch the ball.
3. **Catch or Lose** – If the dog catches the ball, it's destroyed. If the ball hits the ground, the game is over.
4. **Repeat** – New balls continue to spawn at random intervals. Keep sending your dog to catch them!

## 📁 Project Structure

```plaintext
Challenge-2/
├── Assets/
│   ├── Scenes/               – The main game scene
│   ├── Scripts/              – All C# logic
│   │   ├── SpawnManager.cs   – Handles random ball spawning and selection from an array
│   │   ├── PlayerController.cs – Spawns the dog when Spacebar is pressed
│   │   ├── Dog.cs            – Manages dog movement and collision with balls
│   │   ├── Ball.cs           – Handles ball behavior and ground collision detection
│   │   ├── DestroyOutOfBounds.cs – Removes objects when they leave the screen
│   │   └── (other scripts)   – Additional logic as needed
│   ├── Prefabs/              – Reusable objects (balls, dog)
│   └── ...
├── Packages/                 – Unity dependency manifests
├── ProjectSettings/          – Editor and player settings
└── README.md
```

## 🧠 What I Learned

- Working with **arrays** to store and randomly select from multiple ball prefabs.
- Using **random number generation** to determine spawn positions and intervals.
- Implementing **if-statements** to control game flow and collision logic.
- Setting up **collision detection** to trigger events when objects interact.
- Managing **object lifetimes** by destroying objects when they leave the screen.
- Debugging common issues such as incorrect spawn positions, wrong prefab assignments, and improper collision detection.

## 🤝 Contributing

This is a coursework challenge, but feel free to fork it, experiment, and submit pull requests with improvements or new features.

## 📄 License

All rights reserved. For educational use only – please contact the author for permissions beyond personal learning.

## 👨‍💻 Author

**Jorge Matthew Acopio** ([JMacopio](https://github.com/JMacopio))

---

*Built in May 2026 as part of the Create with Code Unity course – Challenge 2: Play Fetch.*
```
