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
- > Currently working on: Stat system (STR, INT, DEX, LUK, HP, MP, EXP)
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

    - This is how to fix the issue:

#### Question #2: 
- How do I setup a pixel perfect camera?

    #### Answer
    - This is the cause of the issue:

    - This is how to fix the issue:

#### Question #3: 
- How do I smoothly camera follow a character?

    #### Answer
    - This is the cause of the issue:

    - This is how to fix the issue:

#### Question #4: 
- How do I make the character keep jumping when holding down the jump button rather than tap it?

    #### Answer
    - This is the cause of the issue:

    - This is how to fix the issue:

#### Question #5: 
- How 

    #### Answer
    - This is the cause of the issue:

    - This is how to fix the issue:
