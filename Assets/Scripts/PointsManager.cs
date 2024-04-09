using TMPro;
using UnityEngine;
using System;

public class PointsManager : MonoBehaviour
{
    public int gamePoints;
    public TMP_Text pointsDisplay;
    private string gamePointsString;

    private void Start()
    {
        pointsDisplay = GetComponent<TMP_Text>();

        pointsDisplay.text = "Probando";
        gamePoints = 0;
    }

    public void UpdatePoints(int obtainedPoints)
    {
        gamePoints = gamePoints + obtainedPoints; 

        gamePointsString = gamePoints.ToString();
        pointsDisplay.text = gamePointsString;

        Debug.Log("Puntos: "+gamePoints);
    }
}
