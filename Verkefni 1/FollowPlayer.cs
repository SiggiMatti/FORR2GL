using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Public breyta sem tekur við bílnum
    public GameObject player;
    // Private breyta sem heldur bara um stöðu myndavélarinnar út frá bílnum
    private Vector3 offset = new Vector3(0, 5, -7);

    void Start()
    {
        
    }

    void Update()
    {
        // Finn stöðu bílsins sem byrjunarpunkt og færi síðan myndavélina fyrir aftan hann með offset breytunni
        transform.position = player.transform.position + offset;
    }
}
