using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tags
{
    private const string Ball = "Ball";
    public const string NotPlayer = "NotPlayer";

    public static bool isBall(GameObject g)
    {
        return g.CompareTag(Ball);
    }

    public static bool isNotPlayer(GameObject g)
    {
        return g.CompareTag(NotPlayer) || g.CompareTag(Ball);
    }
}
