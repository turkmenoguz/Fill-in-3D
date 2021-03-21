using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAreaSpawner : MonoBehaviour
{
    [Space]
    [SerializeField]
    private Sprite image;

 
    [Space]
    [SerializeField]
    private GameObject gameArea;

    public float xoffset = 1f;
    public float yoffset = 1f;
    float size = .3f;

    Texture2D texture2D;
 

    Vector3 cubePos = Vector3.zero;

    private void Awake()
    {
        texture2D = image.texture;


        for (int x = 0; x < texture2D.width; x++)
        {
            for (int y = 0; y < texture2D.height; y++)
            {

                Color color = texture2D.GetPixel(x, y);

                if (color.a == 0)
                {
                    cubePos = new Vector3(size * (x - (texture2D.width * .5f)), 0f, size * (y - (texture2D.height) * .5f));
                    GameObject beyazkup = Instantiate(gameArea, transform);
                    beyazkup.transform.localPosition = cubePos;
                    beyazkup.GetComponent<Renderer>().material.color = Color.white;
                    beyazkup.transform.localScale = Vector3.one * size;
                    beyazkup.GetComponent<MeshRenderer>().enabled = false;
                }          

            }
        }

    }
}
