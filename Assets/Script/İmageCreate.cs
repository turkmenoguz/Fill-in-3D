using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İmageCreate : MonoBehaviour
{
    [Space]
    [SerializeField]
    private Sprite image;

    [Space]
    [SerializeField]
    private GameObject cube;
   

    [Space]
    [SerializeField]
    private GameObject spawnobj;



    public float xoffset = 1f;
    public float yoffset = 1f;
    float size = .3f;

    Texture2D texture2D;
    public int kupsayısı = 0;
   
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
                    continue;
                }
               
                cubePos = new Vector3(size * (x - (texture2D.width*.5f)) , 0f, size * (y - (texture2D.height)*.5f));
                GameObject cubeobj = Instantiate(cube, transform);
                cubeobj.transform.localPosition = cubePos;
                cubeobj.GetComponent<Renderer>().material.color = color;
                cubeobj.transform.localScale = Vector3.one*size;
                cubeobj.GetComponent<MeshRenderer>().enabled = false;
                kupsayısı++;

            }
        }

        for (int i = 0; i < kupsayısı; i++)
        {
            Instantiate(spawnobj, new Vector3(Random.Range(-3.4f, 3.66f), Random.Range(0.1f,10), Random.Range(-7, -6)), transform.rotation);
            
        }

    }

   
}
