using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class player : NetworkBehaviour
{
    private float speed = 7f;

    private void Start()
    {
        if (!isLocalPlayer) transform.Find("Main Camera").gameObject.SetActive(false);
    }

    void Update()
    {
        if (!isLocalPlayer) return;

        Vector3 dir = Vector3.zero;
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        float timeSinceLastFrame = Time.deltaTime;

        Vector3 translation = dir * timeSinceLastFrame * speed;

        transform.Translate(translation);
    }
}
