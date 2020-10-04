using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerInfo 
{
    public static int score = 0;            //handled by Portals.cs for when a player scores
    public static int health = 5;           //handled by FloorController.cs for when a player hits lava
                                            //handled by PlayerInfoController.cs for game over
    public static string levelTitle = "Title";

    //handled by Portals.cs
    public static float timeSinceLastTP = 0;

}
