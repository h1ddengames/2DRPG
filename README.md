# 2DRPG
## About this project
Creation of an aRPG (Action-Adventure Role Playing Game) using Unity 2D 2019.1.0f2 -- Will switch to 2019.x.xfx when it comes out.

Note: 2019.1.0f2 has a bug with the palette editor so I have changed the project version to 2019.2.0a2

Current scope of project:
- ~~Player movement~~
    - ~~Satisfying feel~~
    - ~~Satisfying animations~~
    - ~~Camera Follow~~
- ~~Platforming~~
    - ~~Satisfying feel~~
    - Parallax background (Satisfying animations)
- > Currently working on: Stat system (STR, INT, DEX, LUK, HP, MP, ATK, MATK, EXP)
    - > Create a UI to display stats
- Item system (Weapons, Armors, Use, Quest, Crafting)
    - Inventory
        - Item database (Local)
            - MySQL database
        - Picking up items
        - Dropping items
        - Using items
        - Player (Magical Expanding Storage)
        - Environmental storage (Chests, Barrels, Trees, etc)
    - Equipment system
- Crafing system
    - Assembling items from other items
    - Disassembling items
- Monster system
    - Monster movement
    - Monster attacks
- Combat System
    - Giving damage
    - Taking damage
        - Invincibility frames
    - Animations
        - Satisfying animations
- Currency system
    - ?? Cliche other metal ??    
    - Platinum
    - Gold
    - Silver
    - Copper

#
## How the game was created
### Using a Tileset to Create the Environment
0. In order to use a Tileset, first either create one or find one online. 
1. Once you've made/found one: in Unity, click on Windows > 2D > Tile Palette.
2. Click on Create New Palette. Save this palette into it's own folder ie. Assets > Palettes > yournewpallete
3. Drag and drop your spritesheet/tileset into the Tile Palette editor.
4. Save these tiles into it's own folder ie. Assets > Tiles > Sunnyland
5. In the Hierarchy or under GameObject, select 2D > Tilemap to create a grid for the tiles. 
6. Rename Grid > Tilemap to background-tilemap
7. Add all the parts of the environment that will be your background (EXCLUDING PLATFORMS)
8. Right click on Grid > 2D > Tilemap.
9. Depending on the complexity of the environment, rename Tilemap to midground-tilemap for complex scenes or forground-tilemap for more simple scenes. Continue adding things to the environment excluding platforms.
10. If you named your tilemap midground-tilemap last time, repeat steps 8-9 for the forground-tilemap, otherwise skip this step. 
11. Create a tilemap for your platforms, then create your platforms. 
12. Add a Tilemap Collider 2D, Rigidbody 2D, and a Composite Collider 2D to only the platform tilemap. 
13. In Tilemap Collider 2D, make sure the ```Used By Composite``` checkbox is checked.
14. In Rigidbody 2D make sure the ```Body Type``` is set to Static.

#
### Changing Tilemap Colliders
When adding a collider to a tilemap, it will automatically generate the shape of the collider. If this shape doesn't fit the movement of the game (causes issues with crouching or jumping past an area) then you'll need to adjust the shape of the collider's boundries.

In order to change the shape of the collider's boudries:
1. Go to your project folder in the inspector. 
2. Select the folder where you've saved the generated tileset. 
3. Select one of the tiles and click on Sprite Editor. 
4. In the dropdown under the Sprite Editor tab, select Custom Physics Shape. 
5. Select the tile to edit, then click Generate.
6. Move the edges of the generated shape towards where you want the collider to be. You can create move edges just by clicking anywhere between two already created edges. 
7. Once you've finalized the new collider, hit apply.
7. Repeat steps 5-7 until you've changed the colliders for all the tiles that were not auto generated properly. 

#
### Creating the Player Movement
Unity's Character Controller 2D script was used. 

In order to set it up and use it:
1. Download the CharacterController2D.cs file from Unity Asset Store. 
2. Attach the script to your player.
3. Set your player's layer to Player. (If the Player layer does not exist in your current project, add a layer by going to Edit > Project Settings > Tags and Layers)
4. Create a box collider that fits the upper half of your player.
5. Create a circle collider that fits the bottom half of your player.
6. Create an empty gameobject and make the Player it's parent. The center of this gameobject should be near the top of the head of the player. Name this gameobject something like CeilingCheck.
7. Create an empty gameobject and make the Player it's parent. The center of this gameobject should be near the bottom of the feet of the player. Name this gameobject something like GroundCheck.
8. Drag CeilingCheck to the Ceiling Check variable of the CharacterController2D script.
9. Drag GroundCheck to the Ground Check variable of the CharacterController2D script.
10. Drag the box collider to the Crouch Disable Collider variable of the CharacterController2D script.
11. Create a PlayerMovement script and attach it to the player.
12. Create the logic for moving your player in the PlayerMovement script.

#
### Creating the Stat System



#
### Creating the Item System



#
## FAQ

#### Question #1: 
- How do I stop my character from sliding down slopes?

    #### Answer
    - This is the cause of the issue:
    1. Physics will take place on every frame so in order to stop Physics from moving the character, the character's position must be frozen when no input is detected.

    - This is how to fix the issue:
    1. In a movement script, check that the player is not moving the character.
    2. If the player is not being moved then freeze the x position of the character:
        ```
        rigidbody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        ```
    3. Do not freeze the Y position or the character will freeze in midair when the player stops supplying input.
    4. Once player input resumes we want to get rid of the freeze on the X position while still keeping the rotation of the character frozen by doing the following:
        ```
        rb.constraints = RigidbodyConstraints2D.None | RigidbodyConstraints2D.FreezeRotation;
        ```

#### Question #2: 
- How do I setup a pixel perfect camera?

    #### Answer
    - This is how:
    1. On the Main Camera in the scene, click Add Component.
    2. Change the Assets Pixel Per Unit to the pixels per unit on your assets. Then turn on Run in Edit Mode.
    3. Change the reference resolution until the camera preview shows as much of the area that you want for the game.
    4. Turn off Run in Edit Mode when finished with the edits.

#### Question #3: 
- How do I smoothly camera follow a character?

    #### Answer
    - This is the cause of the issue:
    1. The camera is moving at a rate that is different from the PPU (Pixels Per Unit) of your 2D art assets. 

    - This is how to fix the issue:
    

#### Question #4: 
- How do I make the character keep jumping when holding down the jump button rather than tap it?

    #### Answer
    - This is how:
    1. We want to allow the player to jump on the first available frame while they are still holding down the button. In order to do that, we will keep the character in a jumping state until we get the input that the player has let go of the jump button.
        ```
        if(Input.GetButtonDown("Jump")) {
            jump = true;
            animator.SetBool("IsJumping", true);
        } else if (Input.GetButtonUp("Jump")) {
            jump = false;
            animator.SetBool("IsJumping", false);
        }
        ```
    2. By doing it this way, we have to drop the jumpForce of the character down, otherwise it's almost as if the character is able to double or triple jump.

#### Question #5: 
- How do I fix a frame of animation disappearing?

    #### Answer
    - This is the cause of the issue:
    1. The sorting order of your sprites. Most likely your background and your current sprite is on the same sorting layer so it's fighting for control.  

    - This is how to fix the issue:
    1. Change the sorting layer of forground objects to be higher than that of mid or background objects.

#### Question #6: 
- How do I create a UI that scales with resolution?

    #### Answer
    - This is how:
    1. Create a Canvas and make sure there is an EventSystem in the scene.
    2. Go to the Canvas Scaler component then select Scale with Screen Size.
    3. Whenever you make any UI element on the Canvas, make sure that you "dock" the UI element to a location on the screen.
    4. Test that everything scales properly by going to your Gamme tab, then changing the resolution.

#### Question #7: 
- Question

    #### Answer
    - This is the cause of the issue:

    - This is how to fix the issue:


#### Question #8: 
- Question

    #### Answer
    - This is the cause of the issue:

    - This is how to fix the issue:

#### Question #9: 
- Question

    #### Answer
    - This is the cause of the issue:

    - This is how to fix the issue:

#### Question #10: 
- Question

    #### Answer
    - This is the cause of the issue:

    - This is how to fix the issue:

#### Question #11: 
- Question

    #### Answer
    - This is the cause of the issue:

    - This is how to fix the issue:

#### Question #12: 
- Question

    #### Answer
    - This is the cause of the issue:

    - This is how to fix the issue: