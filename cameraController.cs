using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    public Transform player;

    private float offset;
    private float offsety;





    void Start()
    {
        transform.position = player.position;
        offset = transform.position.x - player.position.x;
        offsety = transform.position.y - player.position.y;



    }

    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x + offset, player.position.y + offsety, -10);
        
    }
}
