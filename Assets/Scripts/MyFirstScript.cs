using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    [SerializeField]
    private int _muffinsPerClick = 1;
    private int _counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, World!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMuffinClick()
    {
        _counter = _counter + _muffinsPerClick;
        Debug.Log(_counter);
    }
}
