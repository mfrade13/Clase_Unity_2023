using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPersonaje : MonoBehaviour
{

    public Transform target;
    private Transform ownPosition;
    // Start is called before the first frame update
    void Start()
    {
        ownPosition = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ownPosition.position = new Vector3(target.position.x, target.position.y, -10f  );
    }
}
