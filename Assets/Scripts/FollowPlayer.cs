using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offsetTopView = new Vector3(0, 5, -7);
    private Vector3 offsetPlayerView = new Vector3(0, 2.4f, 0.4f);
    private Vector3 usedOffset;
    private float lastFrame;
    // Start is called before the first frame update
    void Start()
    {
        usedOffset = offsetTopView;
        lastFrame = Time.frameCount;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + usedOffset;
        if (Time.frameCount - lastFrame > 5)
        {
            lastFrame = Time.frameCount;
            if (Input.GetKey("c") && usedOffset != offsetPlayerView)
            {
                usedOffset = offsetPlayerView;
            }
            else if (Input.GetKey("c") && usedOffset != offsetTopView)
            {
                usedOffset = offsetTopView;
            }
        }
        
    }
}
