using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hits = 0;

    void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("You've Bumped Into A Thing Many Times: " + hits);
    }
}
