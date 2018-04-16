# Capstone Feel Like a Mice Planning Document

## Description

For my capstone final project, I will be building an interactive simulator about the life of a small house mice. The player will feel like a little mice, seeing the huge house furniture, with the fear to be crushed by a huge object or eaten by a cat.

At the beginning of the experience, the player will choose between to different storylines:

- The mice wants to reach some cheese and choose the direct path to these cheese, but he found a cat and the experience finish.
- The mice wants to reach some cheese and choose a large safe path avoiding the cat. Finally the mice reach the cheese and eats it.

## Features and dependencies

### Models

1. Cat 3D model (search it on asset store).
2. Room 3D model (will refurbish the tic tac toe room model).
3. Falling objects (will use tic tac toe pieces).
4. Cheese model (search it on asset store).
5. Potion model (search it on asset stores).

### Sounds

1. Game sounds: Main, win, game over (use mario sounds).
2. Falling objects collision sound (search it on internet).
3. Electric cable sound (search it on internet).

### Videos

1. Mice eating cheese video (search it on youtube).

### Game loop

1. Choose green or red path
   - Red Path Chosen:
     - Mice starts running to the direct cheese path.
     - Mice finds a cat in front and loses the game.
     - A potion appears and mice can revive.
   - Green Path Chosen:
     - Mice starts running choosing a large path to avoid the cat.
     - Some objects fall near to the mice.
     - The mice pas near from a lamp that emits electrical sound.
     - The mice reach the cheese and wins.
     - The player can click the cheese to see the video of the mice eating cheese.