using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    /// <summary>
    /// The score of the player.
    /// </summary>
    public int Score { get; set; }
    
    /// <summary>
    /// Speed of players.
    /// </summary>
    public float Speed { get; set; }

    /// <summary>
    ///  respawns of players.
    /// </summary>
    public Transform Respawnpoint { get; set; }

    /// <summary>
    /// and falltime of the players.
    /// </summary>
    public float FallLimit { get; set; }
}
