using System.Collections;
using UnityEngine;

public class Looking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        faceMouse();
    }

    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        // screentoworldpoint makes it so that it looks where the mouse is positioned in the scene

        Vector2 direction = new Vector2
            (
                mousePosition.x - transform.position.x,
                mousePosition.y - transform.position.y
            );
        transform.up = direction;
    }
}
