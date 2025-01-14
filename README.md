[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

In terms of describing the game world with objects, I would say that there are three main objects. There is the UI elements which includes a seeds remaining and a seeds planted counter that convey information to the player. The player sprite which is what the player controls and moves around and plants seeds with. And the finally the plant sprites which show up after a seed has been planted to indicate that. 

UI elements:
- Attributes: Display values that reflect the players progress in the game.
- Actions: Update its values depending on the players actions 

Player sprite:
- Attributes: The players position. Controlled by WASD keys. Can plant speeds by pressing space bar
- Actions: Can move freely in the game free, can plant a seed reducing “seeds remaining” and “seeds planted values”

Plant sprite:
- Attributes: Have a fixed position, static sprite representing the plant 
- Actions: appear at the player location when a seed is planted

Object interactions:
The player sprite directly has to interact with the UI elements to trigger updates whenever the player makes an action. That action being planting a seed which then changes the values. The player sprite affects the plant sprite by both creating it and also determining the location at which is spawns.   


## Devlog
So based on the breakdown that I did for the homework activity, my plan for recreating the game was pretty straightforward and had 4 major parts to it. First was to get the player movement working using Unity's input system. The second part was to planting mechanic and allowing the player to plant seeds at the location by pressing spacebar. The third part was to both create counters for "seeds remaining" and "seeds planted" and to update them accordingly. The final part would be to set up all the game objects like the plant prefabs and the UI elements and make sure everything works correctly. I think my plan connected pretty well with how I actually implemented the code inside of Unity. All of the UI logic is handled by the PlantCountUI script and it has the following attributes: "_plantedText, _remainingText, _plantedTextNum, and _remainingTextNum" which represent all the UI elements in the game and also the attributes which I identified the game having in breakdown. As for the actions there is the "UpdateSeeds(int seedsLeft, int seedsPlanted)" which is the method that updates the displayed text to reflect the correct values to the player. This also is the action I identified the game having  Then we can move onto the player script which is the script that handles the player's behavior. It has the following attributes: "_playerTransform (player position), _speed (movement speed), _numSeeds". As for the actions the actions I programmed are the same one that I identified the game as having which are player movement and seed planting. Movement is implement through in the "Update()" method using "Input.GetAxis". The seed planting mechanic is implemented and triggered in the "PlantSeed()" method. This methos does a couple of things such as checking if there any seeds still left and if there are then it instantiates a plant prefab at the player's location. This method also includes "_plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted)" to update the counters in the UI. Finally plant sprites are a prefab which gets assigned to "_plantPrefab" in the player gameobject. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
- [Brackeys' Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - Character and item sprites