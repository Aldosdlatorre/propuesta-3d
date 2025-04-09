using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public Renderer fondo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fondo.material.mainTextureOffset += new Vector2(0.1f, 0) * Time.deltaTime;
    }
}
