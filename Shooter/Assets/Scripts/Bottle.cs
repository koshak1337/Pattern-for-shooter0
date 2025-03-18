using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Bottle : MonoBehaviour
{
    public List<Rigidbody> allParts = new List<Rigidbody>();
    public void Shatter()
    {
        foreach (Rigidbody part in allParts)
        {
            part.isKinematic = false;
        }
    }
}
