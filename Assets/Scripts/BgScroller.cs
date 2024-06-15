using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgScroller : MonoBehaviour
     
{

    public float speed;
    private float pos;
    public RawImage image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        pos += speed;
        if(pos>0.7)
        {
            pos -= 1f;
        }
        image.uvRect = new Rect(pos, 0, 1, 1);
    }
}
