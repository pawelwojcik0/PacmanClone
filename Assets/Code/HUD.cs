using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI points;
    [SerializeField] private GameObject gameover;

    private void Awake()
    {
        gameover.SetActive(false);
    }

    public void UpdatePoints(int Points)
    {
        points.text = "" + Points;
    }
}
