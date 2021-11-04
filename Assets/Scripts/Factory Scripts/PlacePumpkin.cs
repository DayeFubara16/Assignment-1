using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacePumpkin : MonoBehaviour
{
    public Transform spawnPoint;
    public Sprite image;
    public void pumpkinClick()
    {
        PumpkinObject pumpkin = new PumpkinObject();
        pumpkin.createObject(spawnPoint.position, spawnPoint, image);
    }
}
