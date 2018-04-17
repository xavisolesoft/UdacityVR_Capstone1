# Capstone Feel Like a Mice Planning Document

## Description

For my capstone final project, I will be building an interactive simulator about the life of a small house mice. The player will feel like a little mice, seeing the huge house furniture, with the fear to be crushed by a huge object or eaten by a cat.

At the beginning of the experience, the player will choose between to different storylines:

- The mice wants to reach some cheese and choose the direct path to these cheese, but he found a cat and the experience finish.
- The mice wants to reach some cheese and choose a large safe path avoiding the cat. Finally the mice reach the cheese and eats it.

## Features and dependencies

### Models

1. Cat 3D model (search it on asset store).
2. Room 3D model (search it on asset store).
3. Falling objects (search it on asset store).
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

## Scoping

### Models

1. Cat 3D model (search it on asset store).
   - *An appropriate free cat 3D model was found at asset store.*
2. Room 3D model (search it on asset store).
   - *No appropriated room 3D model was found at asset store. As solution we have refurbished the tic tac toe room 3D Model.*
3. Falling objects (search it on asset store).
   - *No falling object was found at asset store. As solution we have refurbished the tic tac toe pieces.*
4. Cheese model (search it on asset store).
   - *An appropriate cheese 3D model was found on asset store.*
5. Potion model (search it on asset stores).
   - *An appropriate potion 3D model was found on asset store.*

### Sounds

1. Game sounds: Main, win, game over (use mario sounds).
   - *Mario sounds were found on google.*
2. Falling objects collision sound (search it on internet).
   - *Falling object collision sound was found on google.*
3. Electric cable sound (search it on internet).
   - *Electric cable sound was found on google.*

### Videos

1. Mice eating cheese video (search it on youtube).
   - *Mice eating cheese video was found on youtube and cropped using Adobe Premier.*

### Game loop

1. Choose green or red path
   - Red Path Chosen:
     - Mice starts running to the direct cheese path.
       - *The movement was implemented using iTween package.*
     - Mice finds a cat in front and loses the game.
       - *Implemented.*
     - A potion appears and mice can revive.
       - *Implemented with a unity script.*
   - Green Path Chosen:
     - Mice starts running choosing a large path to avoid the cat.
       - The movement was implemented using iTween package.
     - Some objects fall near to the mice.
       - *Object falling was implemented using unity physics gravity.*
     - The mice pas near from a lamp that emits electrical sound.
       - *Electrical sound was implemented using Gvr spatial audio.*
     - The mice reach the cheese and wins.
       - *Implemented.*
     - The player can click the cheese to see the video of the mice eating cheese.
       - *A shader was implemented to project de video inside a capsule object.*