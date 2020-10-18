


Thanks for trying out the Space RTS - A* PathfindingProject Integration!

In order to correctly work with this pack you need to have imported in the same project:

* Space RTS Starter Pack (version 1.2.3 or above) 
* and one of the two version of A* Pathfinding Project: 
  - The FREE version that you can find at the Aron Granberg webpage (https://arongranberg.com/astar/download).
  - Or the PRO version that you can find in the AssetStore (https://www.assetstore.unity3d.com/en/#!/content/87744).

Both versions should be work perfectly with this pack so if you encounter some issue or problem please let 
me know through the SpaceRTS forum (https://forum.unity.com/threads/released-space-rts-starter-pack.498459/)
or with an email (nullpointer2017@gmail.com).

I think thi module can be a good start if you prefer the navigation system developed in the A* Pathfinding Project.
I know it can be basic if you compare with all the features that has the a* pathfinding pack but it can be a huge
start if you are going into that direction and also it's why i've decided to release it for free.

The correct way of instalation should be:
1) Create a new empty project using Unity 5.6 or above.
2) Import "Space RTS Starter Pack"
3) Import "A* Pathfinding Project"
4) Import "A* Pathfinding for Space RTS"

That's it. Try out the scene at "SpaceRTS_FreeAstarPathfinding/" called "SpaceRTS FreeAStarAIPath".

What's changed in this scene?
Well, I've changed the SpatialSystem, now it works along with the AstarPath to build the navigation areas.
(this can be found at the scene GameObject located at: "GameMap/GameSystems/SpatialSystem")
Secondly, the ships. In order to navigate this new system the navigation now will be AIPathNavigation.
(internally is derived from Navigation so the rest of the systems can still work with it without any problem)

Of course, now the gameplay prefab was changed to use this script for the navigation and because of that 
all the unit settings must reflect also that change.
