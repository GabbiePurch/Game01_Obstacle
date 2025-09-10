using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Something Hit Me!");
    }
}
