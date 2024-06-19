using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Mission", menuName = "Mission/Create New Mission")]
public class Misiones: ScriptableObject
{
    [Header("RECOMPENSAS")]
    public int vida;
    public int oro;
    public int sigilo;
}
