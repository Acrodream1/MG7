# MG7
## Devlog

Summary of TreeOfBirds

The very first thing I decided to do was create a public class called "TreeOfBirds" that takes in MonoBehvaior to allow it to be attached to a game object (or the birds in this case) as a component. Then, I added three private variables that are exposed to the inspector using [SerializeField]. One variable was an array that allowed for the bird objects to be stored in, one variable was the interaction distance between the birds and the player, and one was the player transform to check the player distance. The array variable made it easy to keep track of the bird objects because with the array, I have access to all of the birds' game object references and their transforms. After assigning the variables, I added an Update() method to constantly check if the player is close enough to the bird by the interaction distance. This distance checking applies to all birds except the starting bird. The distance is checked by using the Vector3.Distance method, which compares the magnitude between two vectors (in this case, from the bird's position to the player's position). I use the result of the distance to determine whether or not the player is in distance with the bird. If the player is close enough to the bird, the bird's game object becomes active, setting of the individual timer for the bird to appear.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
