using UnityEngine;
using System.Collections;

public class Lazer : MonoBehaviour {


    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
