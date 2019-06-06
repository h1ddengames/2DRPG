# 2DRPG
## Table of Contents
<!-- vscode-markdown-toc -->
- [2DRPG](#2drpg)
  - [Table of Contents](#table-of-contents)
  - [1. <a name='About'></a>About](#1-a-nameaboutaabout)
  - [2. <a name='Scope'></a>Scope](#2-a-namescopeascope)
  - [3. <a name='How-to'></a>How-to](#3-a-namehow-toahow-to)
    - [3.1. <a name='UsingaTilesettoCreatetheEnvironment'></a>Using a Tileset to Create the Environment](#31-a-nameusingatilesettocreatetheenvironmentausing-a-tileset-to-create-the-environment)
    - [3.2. <a name='ChangingTilemapColliders'></a>Changing Tilemap Colliders](#32-a-namechangingtilemapcollidersachanging-tilemap-colliders)
    - [3.3. <a name='CreatingthePlayerMovement'></a>Creating the Player Movement](#33-a-namecreatingtheplayermovementacreating-the-player-movement)
    - [3.4. <a name='CreatingtheStatSystem'></a>Creating the Stat System](#34-a-namecreatingthestatsystemacreating-the-stat-system)
    - [3.5. <a name='CreatingtheItemSystem'></a>Creating the Item System](#35-a-namecreatingtheitemsystemacreating-the-item-system)
    - [3.6. <a name='SettingupItemsforPickup'></a>Setting up Items for Pickup](#36-a-namesettingupitemsforpickupasetting-up-items-for-pickup)
    - [3.7. <a name='TypesofAnimations'></a>Types of Animations](#37-a-nametypesofanimationsatypes-of-animations)
    - [3.8. <a name='CreatingAnimationsforMovementBasedAnimations'></a>Creating Animations for Movement Based Animations](#38-a-namecreatinganimationsformovementbasedanimationsacreating-animations-for-movement-based-animations)
  - [4. <a name='FrequentlyAskedQuestionsFAQ'></a>Frequently Asked Questions (FAQ)](#4-a-namefrequentlyaskedquestionsfaqafrequently-asked-questions-faq)
      - [4.1. <a name='Question1:HowdoIstopmycharacterfromslidingdownslopes'></a>Question #1: How do I stop my character from sliding down slopes?](#41-a-namequestion1howdoistopmycharacterfromslidingdownslopesaquestion-1-how-do-i-stop-my-character-from-sliding-down-slopes)
      - [4.2. <a name='Question2:HowdoIsetupapixelperfectcamera'></a>Question #2: How do I setup a pixel perfect camera?](#42-a-namequestion2howdoisetupapixelperfectcameraaquestion-2-how-do-i-setup-a-pixel-perfect-camera)
      - [4.3. <a name='Question3:HowdoIsmoothlycamerafollowacharacter'></a>Question #3: How do I smoothly camera follow a character?](#43-a-namequestion3howdoismoothlycamerafollowacharacteraquestion-3-how-do-i-smoothly-camera-follow-a-character)
      - [4.4. <a name='Question4:HowdoImakethecharacterkeepjumpingwhenholdingdownthejumpbuttonratherthantapit'></a>Question #4: How do I make the character keep jumping when holding down the jump button rather than tap it?](#44-a-namequestion4howdoimakethecharacterkeepjumpingwhenholdingdownthejumpbuttonratherthantapitaquestion-4-how-do-i-make-the-character-keep-jumping-when-holding-down-the-jump-button-rather-than-tap-it)
      - [4.5. <a name='Question5:HowdoIfixaframeofanimationdisappearing'></a>Question #5: How do I fix a frame of animation disappearing?](#45-a-namequestion5howdoifixaframeofanimationdisappearingaquestion-5-how-do-i-fix-a-frame-of-animation-disappearing)
      - [4.6. <a name='Question6:HowdoIcreateaUIthatscaleswithresolution'></a>Question #6: How do I create a UI that scales with resolution?](#46-a-namequestion6howdoicreateauithatscaleswithresolutionaquestion-6-how-do-i-create-a-ui-that-scales-with-resolution)
      - [4.7. <a name='Question7:Whydoesmytilenotfitmygrid'></a>Question #7: Why does my tile not fit my grid?](#47-a-namequestion7whydoesmytilenotfitmygridaquestion-7-why-does-my-tile-not-fit-my-grid)
      - [4.8. <a name='Question8:HowdoIchangethesamplesnumberforananimation'></a>Question #8: How do I change the samples number for an animation?](#48-a-namequestion8howdoichangethesamplesnumberforananimationaquestion-8-how-do-i-change-the-samples-number-for-an-animation)
      - [4.9. <a name='Question9:HowdoIknowwhenavariablehaschanged'></a>Question #9: How do I know when a variable has changed?](#49-a-namequestion9howdoiknowwhenavariablehaschangedaquestion-9-how-do-i-know-when-a-variable-has-changed)
      - [4.10. <a name='Question10:HowdoIuseadelegateandorevent'></a>Question #10: How do I use a delegate and/or event?](#410-a-namequestion10howdoiuseadelegateandoreventaquestion-10-how-do-i-use-a-delegate-andor-event)
      - [4.11. <a name='Question11:Question'></a>Question #11: Question](#411-a-namequestion11questionaquestion-11-question)
      - [4.12. <a name='Question12:Question'></a>Question #12: Question](#412-a-namequestion12questionaquestion-12-question)
      - [4.13. <a name='Question13:Question'></a>Question #13: Question](#413-a-namequestion13questionaquestion-13-question)
      - [4.14. <a name='Question14:Question'></a>Question #14: Question](#414-a-namequestion14questionaquestion-14-question)
      - [4.15. <a name='Question15:Question'></a>Question #15: Question](#415-a-namequestion15questionaquestion-15-question)

<!-- vscode-markdown-toc-config
	numbering=true
	autoSave=true
	/vscode-markdown-toc-config -->
<!-- /vscode-markdown-toc -->
##  1. <a name='About'></a>About
Creation of an aRPG (Action-Adventure Role Playing Game) using Unity 2D 2019.1.0f2 -- Will switch to 2019.x.xfx when it comes out.

Note: 2019.1.0f2 has a bug with the palette editor so I have changed the project version to 2019.2.0a2

##  2. <a name='Scope'></a>Scope
This is a list of things that I would like to have in my game for now.
- ~~Player movement~~
    - ~~Satisfying feel~~
    - ~~Satisfying animations~~
    - ~~Camera Follow~~
- ~~Platforming~~
    - ~~Satisfying feel~~
    - Parallax background (Satisfying animations)
- ~~Currently working on: Stat system (STR, INT, DEX, LUK, HP, MP, ATK, MATK, EXP)~~
    - ~~Create a UI to display stats~~
- > Item system (Weapons, Armors, Use, Quest, Crafting)
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
##  3. <a name='How-to'></a>How-to
###  3.1. <a name='UsingaTilesettoCreatetheEnvironment'></a>Using a Tileset to Create the Environment
1. In order to use a Tileset, first either create one or find one online. 
2. Once you've made/found one: in Unity, click on Windows > 2D > Tile Palette.
3. Click on Create New Palette. Save this palette into it's own folder ie. Assets > Palettes > yournewpallete
4. Drag and drop your spritesheet/tileset into the Tile Palette editor.
5. Save these tiles into it's own folder ie. Assets > Tiles > Sunnyland
6. In the Hierarchy or under GameObject, select 2D > Tilemap to create a grid for the tiles. 
7. Rename Grid > Tilemap to background-tilemap
8. Add all the parts of the environment that will be your background (EXCLUDING PLATFORMS)
9. Right click on Grid > 2D > Tilemap.
10. Depending on the complexity of the environment, rename Tilemap to midground-tilemap for complex scenes or forground-tilemap for more simple scenes. Continue adding things to the environment excluding platforms.
11. If you named your tilemap midground-tilemap last time, repeat steps 8-9 for the forground-tilemap, otherwise skip this step. 
12. Create a tilemap for your platforms, then create your platforms. 
13. Add a Tilemap Collider 2D, Rigidbody 2D, and a Composite Collider 2D to only the platform tilemap. 
14. In Tilemap Collider 2D, make sure the ```Used By Composite``` checkbox is checked.
15. In Rigidbody 2D make sure the ```Body Type``` is set to Static.

#
###  3.2. <a name='ChangingTilemapColliders'></a>Changing Tilemap Colliders
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
###  3.3. <a name='CreatingthePlayerMovement'></a>Creating the Player Movement
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
###  3.4. <a name='CreatingtheStatSystem'></a>Creating the Stat System



#
###  3.5. <a name='CreatingtheItemSystem'></a>Creating the Item System


#
###  3.6. <a name='SettingupItemsforPickup'></a>Setting up Items for Pickup
1. In the item animator, drag and drop in the Item_Feedback animation clip.
2. Create an IsCollected boolean.
3. Create a transition from Any State to Item_Feedback and set IsCollected = true.
4. Create a transition from Item_Feedback to the item's idle animation and set IsCollected = false.
5. Create a transition from item's idle animation and set IsCollected = true.
6. Any State -> Item_Feedback may have Exit Time enabled but is not required unless it is messing up the look and feel of the animation.
7. Item_Feedback -> item's idle MUST have Exit Time enabled.
8. Item's idle -> Item_Feedback MUST have Exit Time disabled.

#
###  3.7. <a name='TypesofAnimations'></a>Types of Animations
1. Sprite Based:
   - This type of animation involves using a different spite in each frame of an animation.
   - Really simple to animate, just put a new sprite on each new frame where you want the sprite to change.
2. Movement Based:
   - This type of animation involves using the same sprite in each frame of an animation.
   - Have to create a parent empty gameobject that will stay stationary. The sprite itself will be the first child and will be the only object that moves when an animation is being created.
   - IMPORTANT NOTE: YOU CANNOT USE THE SAME ITEM_FEEDBACK ANIMATION WITH THIS TYPE OF ANIMATION AS YOU DO WITH SPRITE BASED. YOU MUST CREATE A NEW ANIMATION FOR IT.

#
###  3.8. <a name='CreatingAnimationsforMovementBasedAnimations'></a>Creating Animations for Movement Based Animations
Note: The first child should always be named GFX or something similar and must always be named the same for this type of animation.
1. You MUST have a Box Collider2D on the parent gameobject (Empty GameObject) If it is on a child gameobject then even with isTrigger enabled, the character will still interact physically with it.
2. In the Animation tab, add the BoxCollider2D offset and size properties from the parent gameobject.
3. Add all the Transform properties and Sprite property from the SpriteRenderer from your GFX gameobject.
4. Create any animations as needed.
5. While your new item is selected in the Hierarchy, go to the Animation tab and select ```Create New Clip``` then name it Item_Feedback_Movement.
6. Change samples to 4 then add each of the four sprites from Item_Feedback.
7. Add Item_Feed_Back_Movement to the Animator window. 
8. Create transitions based on the section in this guide titled ```Setting up Items for Pickup```
9. You may skip step 5 and 6 for every new item you create after the first one. In other words, you only have to create two sets of Item_Feedback. One for Sprite Based animation and one for Movement Based animation. Just make sure to give the proper Item_Feedback based on the type of animation to make it work.


#
##  4. <a name='FrequentlyAskedQuestionsFAQ'></a>Frequently Asked Questions (FAQ)

####  4.1. <a name='Question1:HowdoIstopmycharacterfromslidingdownslopes'></a>Question #1: How do I stop my character from sliding down slopes?
- #### Answer:
    - ##### This is the cause of the issue:
      1. Physics will take place on every frame so in order to stop Physics from moving the character, the character's position must be frozen when no input is detected.

    - ##### This is how to fix the issue:
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

####  4.2. <a name='Question2:HowdoIsetupapixelperfectcamera'></a>Question #2: How do I setup a pixel perfect camera?
- #### Answer:
    - ##### This is how:
      1. On the Main Camera in the scene, click Add Component.
      2. Change the Assets Pixel Per Unit to the pixels per unit on your assets. Then turn on Run in Edit Mode.
      3. Change the reference resolution until the camera preview shows as much of the area that you want for the game.
      4. Turn off Run in Edit Mode when finished with the edits.

####  4.3. <a name='Question3:HowdoIsmoothlycamerafollowacharacter'></a>Question #3: How do I smoothly camera follow a character?
- #### Answer:
    - ##### This is the cause of the issue:
      1. The camera is moving at a rate that is different from the PPU (Pixels Per Unit) of your 2D art assets. 

    - ##### This is how to fix the issue:
      1. Haven't figured it out yet.

####  4.4. <a name='Question4:HowdoImakethecharacterkeepjumpingwhenholdingdownthejumpbuttonratherthantapit'></a>Question #4: How do I make the character keep jumping when holding down the jump button rather than tap it?
- #### Answer:
    - ##### This is how:
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

####  4.5. <a name='Question5:HowdoIfixaframeofanimationdisappearing'></a>Question #5: How do I fix a frame of animation disappearing?
- #### Answer:
    - ##### This is the cause of the issue:
      1. The sorting order of your sprites. Most likely your background and your current sprite is on the same sorting layer so it's fighting for control.  

    - ##### This is how to fix the issue:
      1. Change the sorting layer of forground objects to be higher than that of mid or background objects.

####  4.6. <a name='Question6:HowdoIcreateaUIthatscaleswithresolution'></a>Question #6: How do I create a UI that scales with resolution?
- #### Answer:
    - ##### This is how:
      1. Create a Canvas and make sure there is an EventSystem in the scene.
      2. Go to the Canvas Scaler component then select Scale with Screen Size.
      3. Whenever you make any UI element on the Canvas, make sure that you "dock" the UI element to a location on the screen.
      4. Test that everything scales properly by going to your Gamme tab, then changing the resolution.

####  4.7. <a name='Question7:Whydoesmytilenotfitmygrid'></a>Question #7: Why does my tile not fit my grid?
- #### Answer
    - ##### These are possible causes:
      1. You are using assets that were made for a different resolution (16x16 vs 32x32 etc)
    - ##### This is how to fix the issue:
      1. Drag and drop the sprite onto the Scene and move it to where you like it. The benefit of doing it this way is that you can hide the edges of the sprite behind your tilemap.

####  4.8. <a name='Question8:HowdoIchangethesamplesnumberforananimation'></a>Question #8: How do I change the samples number for an animation?
- #### Answer
    - ##### This is how:
        1. Open up your Animation tab.
        2. Click on the Cog icon on the far top right, just past the number line.
        3. Enable ```Show Sample Rate```

####  4.9. <a name='Question9:HowdoIknowwhenavariablehaschanged'></a>Question #9: How do I know when a variable has changed?
- #### Answer:
    - ##### This is how:
        ```
        // Stats.cs
        // Create a delegate and an event.
        // These will be used by whatever class cares that the variable has changed.
        public delegate void StatDelegate();
        // I made this event static so that it can be accessed by using Stats.statsHaveChangedEvent
        public static event StatDelegate statsHaveChangedEvent;

        // This is the variable that you care about the value changing.
        [SerializeField] private int _strength; 

        // This is a getter and setter method.
        // In order to call this method try this:
        // var newVar = Strength; if(Strength == 22) { ... } else { ... }
        // var otherVar = 4; Strength = otherVar; Strength = 22; 
        public int Strength { 
            // This a lambda function that will return the value of _strength when called.
            get => _strength; 
            // This is where you put your custom logic to do what you want when the variable changes.
            set {
                // First make sure that the variabe has actually changed.
                if(value != _strength) { 
                    // If it did, then do what you want here.
                    _strength = value;
                    // Fire the event so that any other class that's listening for this event will do what they need to do when this variable has changed value.
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent(); 
                } else { return; }
            } 
        }
        ```

####  4.10. <a name='Question10:HowdoIuseadelegateandorevent'></a>Question #10: How do I use a delegate and/or event?
- #### Answer:
    - ##### This is how to fix the issue:
        ```
        // EntityStats.cs
        // Can be in Awake(), OnEnable(), or Start()
        private void OnEnable() {
            // Subscribe to the event by saying "I will run OnStatsChanged() method when you fire the event."
            Stats.statsHaveChangedEvent += OnStatsChanged;
            // Since this event wont fire at the very start of the game, we'll run the methods we want now.
            ResetStatsToZero();
            CalculateStats();
        }

        // This method is called when the event has fired. Put your custom logic here.
        public void OnStatsChanged() {
            // When calculating stats, we must first set them to zero so we can't the same stat source twice.
            ResetStatsToZero();
            CalculateStats();
        }

        // Called when the object might be destroyed in response to Object.Destroy 
        // or at the closure of a scene (ending playmode as well!)
        private void OnDestroy() {
            // This is done to prevent memory leaks since: 
            // "As long as the publishing object holds that reference, your subscriber object will not be garbage collected." 
            Stats.statsHaveChangedEvent -= OnStatsChanged;
        }
        ```

####  4.11. <a name='Question11:Question'></a>Question #11: Question
- #### Answer:
    - ##### This is the cause of the issue:

    - ##### This is how to fix the issue:

####  4.12. <a name='Question12:Question'></a>Question #12: Question
- #### Answer:
    - ##### This is the cause of the issue:

    - ##### This is how to fix the issue:

####  4.13. <a name='Question13:Question'></a>Question #13: Question
- #### Answer:
    - ##### This is the cause of the issue:

    - ##### This is how to fix the issue:

####  4.14. <a name='Question14:Question'></a>Question #14: Question
- #### Answer:
    - ##### This is the cause of the issue:

    - ##### This is how to fix the issue:

####  4.15. <a name='Question15:Question'></a>Question #15: Question
- #### Answer:
    - ##### This is the cause of the issue:

    - ##### This is how to fix the issue: