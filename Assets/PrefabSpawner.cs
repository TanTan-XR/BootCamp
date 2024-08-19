using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public void Spawn(GameObject prefab)
    {
        Instantiate(prefab, transform.position, Quaternion.identity); //quaternion is kind of likes add W to x,y,z
    }

}
