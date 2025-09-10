using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{
    public TextMeshProUGUI GameText;
    int hits = 0;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            GameText.text = "You've Hit Something " + hits + " Times";
        }
        
    }
}
