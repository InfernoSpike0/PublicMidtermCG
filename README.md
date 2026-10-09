Part1
	Utilized a sphere to represent Sonic, and cubes that will have textures added to them to create the floor and the waterfall.
Part2
	Added some rings that use a sinetime to cycle the value of the color over time. I don't think the reflection component works because the frensel node is prohibited and I didn't have a cubemap to test with.
Part3
	Utilizes a Tiling and offset + Time node to offset/scroll the texture over time. Additionally, I set the surface type to transparent and added a property to change the alpha so that I can place the waterfall in front of the stage without obscuring the player character too much. Didn't find a way to feed only one dimension of the offset in the inspector.
