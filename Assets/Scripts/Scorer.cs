using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hits = 0;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've Bumped Into A Thing Many Times: " + hits);
        }
        
    }
}
