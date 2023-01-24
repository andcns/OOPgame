using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   enum Team { ChicagoBulls, LosAngelesLakers, GoldenStateWarriors, ClevelandCavaliers }
   [SerializeField] Team playerTeam;
   enum Position { centre, powerForward, smallForward, pointGuard, shootingGuard }
   [SerializeField] Position position;
   enum Trainer{jordan1s, airJordans, nikeAir, reebok, addidasCourt }
   [SerializeField] Trainer trainer;
   [SerializeField] string playerName;
   [Range (1, 10)]
   [SerializeField] int rating;


public int GetRating()
{
    return rating;
}
public string GetName()
{
    return playerName;
}
public string GetTeam()
{
    return playerTeam.ToString();
}
}
