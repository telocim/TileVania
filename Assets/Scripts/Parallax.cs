using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private Transform cam;
    [SerializeField] private float relativeMove = .3f;

    private void Update()
    {
        //transform.position = new Vector2(cam.position.x * relativeMove, cam.position.y * relativeMove);
        transform.position = new Vector2(cam.position.x * relativeMove, cam.position.y);
    }

}
