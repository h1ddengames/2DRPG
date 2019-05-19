# 2DRPG
Creation of an aRPG (Action-Adventure Role Playing Game) using Unity 2D 2019.1.0f2 -- Will switch to 2019.x.xfx when it comes out.

Note: 2019.1.0f2 has a bug with the palette editor so I have changed the project version to 2019.2.0a2

Current scope of project:
- Player movement
    - Satisfying feel
    - Satisfying animations
- Platforming
    - Satisfying feel
    - Parallax background (Satisfying animations)
- Stat system (STR, INT, DEX, LUK, HP, MP, EXP)
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
### Using a Tileset to Create the Environment
0. In order to use a Tileset, first either create one or find one online. 
1. Once you've made/found one, in Unity, click on Windows > 2D > Tile Palette.
2. Click on Create New Palette. Save this palette into it's own folder ie. Assets > Palettes > yournewpallete
3. Drag and drop your spritesheet/tileset into the Tile Palette editor.
4. Save these tiles into it's own folder ie. Assets > Tiles > Sunnyland
5. In the Hierarchy or under GameObject, select 2D > Tilemap to create a grid for the tiles. 
6. Rename Grid > Tilemap to background_tilemap
7. Add all the parts of the environment that will be your background.
8. Right click on Grid > 2D > Tilemap.
9. Depending on the complexity of the environment, rename Tilemap to midground_tilemap for complex scenes or forground_tilemap for more simple scenes.
10. If you named your tilemap midground_tilemap last time, repeat steps 8-9 for the forground_tilemap, otherwise you're done creating the environment.

#
### Changing Tilemap Colliders
When adding a collider to a tilemap, it will automatically generate the shape of the collider. If this shape doesn't fit the movement of the game (causes issues with crouching or jumping past an area) then you'll need to adjust the shape of the collider's boundries.

In order to change the shape of the collider's boudries:
1. Go to your project folder in the inspector. 
2. Select the folder where you've saved the generated tileset. 
3. Select one of the tiles and click on Sprite Editor. 
4. In the dropdown under the Sprite Editor tab, select Custom Physics Shape. 
5. Click Generate, then move the edges of the generated shape towards where you want the collider to be. You can create move edges just by clicking anywhere between two already created edges. 
6. Once you've finalized the new collider, hit apply.
7. Repeat steps 5-6 until you've changed the colliders for all the tiles that were not auto generated properly. 

#
### Creating the Player Movement



#
### Creating the Stat System



#
### Creating the Item System