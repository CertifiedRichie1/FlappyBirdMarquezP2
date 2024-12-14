using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UIElements;
public class ColumnPool : MonoBehaviour {

    public int columnPoolSize = 5;
    public GameObject columnPrfabs;

    private GameObject[] coulms;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    // Start is called before the first frame update
    void Start()
    {
        Columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
