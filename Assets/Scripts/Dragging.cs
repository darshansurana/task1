using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragging : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private Rigidbody _rigid;

    // Start is called before the first frame update
    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currPos = transform.position;
        currPos.z = 0;
        transform.position = currPos;
    }



    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == this.gameObject.tag)
        {
            
            if(other.rigidbody.velocity.magnitude < _rigid.velocity.magnitude)
            {
                Destroy(other.gameObject);
            }
            else
            {
                // Debug.Log("Entered here");
                Destroy(this.gameObject);
            }
            
        }
    }
}
