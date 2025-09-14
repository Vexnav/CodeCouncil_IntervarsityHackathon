⚙️ Setup in Unity

IMPORTANT!!!: To run the game, please drag both scenes into your scene manager. Then unload the Game-Over scene. Then your project will be safe to run!

1. Player (Shark)

Add a SpriteRenderer with your shark sprite.

Attach Rigidbody2D (Dynamic, Gravity Scale = 0).

Attach BoxCollider2D or PolygonCollider2D for collisions.

Add the SharkMovement.cs script.

2. Fish

Create a prefab Fish with:

SpriteRenderer (default fish sprite).

Rigidbody2D (Kinematic).

BoxCollider2D (IsTrigger = true).

FishEmail.cs script.

The script assigns:

Random type (Phishing or Normal).

Random email text.

Color (Red = phishing, Green = safe).

3. FishSpawner

Empty GameObject named FishSpawner.

Attach FishSpawner.cs.

Assign the Fish prefab.

In Inspector:

Add email text examples to phishingEmails[] and normalEmails[].

4. UI

Create a Canvas → Panel (for email prompt).

Add Text (TMP) for the email body.

Add Buttons: "Phishing" and "Safe".

Hook buttons to methods that check the answer and resume game.

📂 Scripts Overview

SharkMovement.cs → moves shark with WASD.

FishSpawner.cs → spawns fish at random heights, assigns type & email.

FishEmail.cs → stores email text & phishing/safe flag, colors fish.

CollisionHandler.cs → handles shark-fish collisions, pauses game, shows prompt.

🚀 How to Play

Press Play in Unity.

Move shark with WASD.

Eat fish → read the email → decide Phishing or Safe.

Try to learn & spot phishing attempts!

🛠 Future Improvements

Fish swim animations (not just sliding).

Score system (points for correct answers).

Timer / challenge mode.

More realistic phishing vs safe email examples.
