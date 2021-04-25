using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Data.Collection.List;

public class Modify_Speed : MonoBehaviour
{

    public Vector3ObservableList mult;
    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mult.enabled = true;
        mult.RemoveAt(1);
        mult.Add(new Vector3(speed, 0, speed));
    }
}
