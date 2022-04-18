using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LayerInfo
{
    public static int Player = LayerMask.NameToLayer("Player");
    public static int Cube = LayerMask.NameToLayer("Cube");

    public static int Ground = LayerMask.NameToLayer("Ground");
}
