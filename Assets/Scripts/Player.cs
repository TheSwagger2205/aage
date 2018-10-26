using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public int Score { get; set; }
    public float Speed { get; set; }
    public  Transform Respawnpoint { get; set; }
    public  float FallLimit { get; set; }
}
