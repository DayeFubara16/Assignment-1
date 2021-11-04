using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract public class ObjectFactory : MonoBehaviour
{
    public abstract void createObject(Vector3 position, Transform cube, Sprite sprite);
}


public class PumpkinObject : ObjectFactory
{
    static List<Transform> pumpkins;
    public override void createObject(Vector3 position, Transform cube, Sprite sprite)
    {
        Transform newpumpkin = Instantiate(cube, position, Quaternion.identity);
        newpumpkin.gameObject.AddComponent<CircleCollider2D>();
        newpumpkin.gameObject.AddComponent<SpriteRenderer>().sprite = sprite;
        newpumpkin.gameObject.AddComponent<Rigidbody2D>();
        if (pumpkins == null)
        {
            pumpkins = new List<Transform>();
        }
        pumpkins.Add(newpumpkin);
    }
}


public class SkullObject : ObjectFactory
{
    static List<Transform> skulls;

    public override void createObject(Vector3 position, Transform cube, Sprite sprite)
    {
        Transform newSkull = Instantiate(cube, position, Quaternion.identity);
        newSkull.gameObject.AddComponent<CircleCollider2D>();
        newSkull.gameObject.AddComponent<SpriteRenderer>().sprite = sprite;
        newSkull.gameObject.AddComponent<Rigidbody2D>();
        if (skulls == null)
        {
            skulls = new List<Transform>();
        }
        skulls.Add(newSkull);
    }
}


