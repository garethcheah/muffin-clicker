using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyFirstScript : MonoBehaviour
{
    private const string MUFFIN_TEXT = " muffin";
    private const string MUFFINS_TEXT = " muffins";

    [SerializeField]
    private TextMeshProUGUI _totalMuffinsText;

    [SerializeField]
    private int _muffinsPerClick = 1;
    private int _muffinsCriticalHitMultiplier = 10;
    private int _counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateTotalMuffins();
        Debug.Log("Hello, World!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMuffinClick()
    {
        int randomNumber = Random.Range(1, 100);
        Debug.Log("randomNumber=" + randomNumber.ToString());

        if (randomNumber != 99)
        {
            _counter += _muffinsPerClick;
        } else
        {
            _counter += _muffinsPerClick * _muffinsCriticalHitMultiplier;
        }

        UpdateTotalMuffins();
        Debug.Log("counter=" + _counter.ToString());
    }

    private void UpdateTotalMuffins()
    {
        if (_counter == 1)
        {
            _totalMuffinsText.text = _counter.ToString() + MUFFIN_TEXT;
        } else
        {
            _totalMuffinsText.text = _counter.ToString() + MUFFINS_TEXT;
        }
    }
}
