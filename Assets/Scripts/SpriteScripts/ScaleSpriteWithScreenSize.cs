using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ScaleSpriteWithScreenSize : MonoBehaviour
{

    SpriteRenderer sr;
    public bool keepAspect = false;
    public bool fullscreen = true;
    [Range(0.00001f, 1.0f)]
    public float width = 0.1f;
    [Range(0.00001f, 1.0f)]
    public float height = 0.1f;

    // Use this for initialization
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float worldScreenHeight = Camera.main.orthographicSize * 2;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;
        //Debug.Log("height: " + worldScreenHeight + ", " + "width: " + worldScreenWidth);

        if (fullscreen)
        {
            transform.localScale = new Vector3(
            worldScreenWidth / sr.sprite.bounds.size.x,
            worldScreenHeight / sr.sprite.bounds.size.y, 1);
        }
        else
        {
            if (keepAspect)
            {
                transform.localScale = new Vector3(
                transform.localScale.x,
                worldScreenHeight * height, 1);
            }
            else
            {
                transform.localScale = new Vector3(
                worldScreenWidth * width,
                worldScreenHeight * height, 1);
            }

        }

    }
}
