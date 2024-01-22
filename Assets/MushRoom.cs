using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushRoom : MonoBehaviour
{
    // Start is called before the first frame update
    public float left, right;
    private bool isRight;
    // Update is called once per frame
    void Update()
    {
        // lay vi tri hien tai cua nam 
        var mushRoom1 = transform.position.x;
        if (mushRoom1 < left)
        {
            isRight = true;
        }
        if (mushRoom1 > right)
        {
            isRight = false;
        }
        if (isRight)
        {
            transform.Translate(new Vector3(Time.deltaTime * 1,0,0));
        }
        else
        {
            transform.Translate(new Vector3(-Time.deltaTime * 1,0,0));
        }
    }
}
