using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : Singleton<GamePlayManager>
{
    private HUD hud;
    private int points;

    public int Points
    {
        get { return points; }
        set
        {
            points = value;
            hud.UpdatePoints(points);
        }
    }

    private void Start()
    {
        hud = FindObjectOfType<HUD>();

        points = 0;
    }
}
