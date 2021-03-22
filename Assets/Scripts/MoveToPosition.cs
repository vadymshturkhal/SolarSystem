using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPosition : MonoBehaviour
{
    [SerializeField]
    GameObject targetGameObject;

    Vector3 from;
    Vector3 to;


    float speed = 1f;
    float step;


    // Start is called before the first frame update
    void Awake()
    {
        if (targetGameObject != null)
        {
            to = new Vector3(0, 0, 0);
        }
        else
        {
            to = targetGameObject.transform.position;
        }

        from = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;
        from = gameObject.transform.position;

        transform.position = Vector3.MoveTowards(from, to, step);

        if (Vector3.Distance(from, to) <= 0.5f)
        {
            Destroy(gameObject);
        }
    }
}
