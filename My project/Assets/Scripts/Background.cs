using UnityEngine;

public class Background : MonoBehaviour
{

    public float scrollSpeed = 1.0f;
    private Material mymaterial;


    void Start()
    {
        mymaterial = GetComponent<Renderer>().material;
        //mymaterial = GetComponent<Renderer>().sharedMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newOffset = mymaterial.mainTextureOffset;
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));

        mymaterial.mainTextureOffset = newOffset;
    }
}
