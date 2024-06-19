using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using interfaz;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public Score puntaje;
    public float speed;
    public Camera cam;
    public Collider planeCollider;
    RaycastHit hit;
    Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("coleccionable"))
        {
            puntaje.ActualizarPuntaje(10);
            Destroy(collision.gameObject);
        }
    }

    void movement()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButton(0) && Physics.Raycast(ray, out hit))
        {
            if (hit.collider == planeCollider)
            {
                transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime * speed);
                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));

            }
        }
    }
}
