using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JackpotQTESys : MonoBehaviour
{
    [SerializeField] GameObject _displayBox;
    [SerializeField] GameObject _passBox;
    [SerializeField] int _QTEGen;
    [SerializeField] int _waitingForKey;
    [SerializeField] int _correctKey;
    [SerializeField] int _countingDown;

    private void Update()
    {
        if (_waitingForKey == 0)
        {
            _QTEGen = Random.Range(1, 4);
            _countingDown = 1;
            StartCoroutine(CountDown());

            if(_QTEGen == 1)
            {
                _waitingForKey = 1;
                _displayBox.GetComponent<TMP_Text>().text = "[E]";
            }
            if (_QTEGen == 2)
            {
                _waitingForKey = 1;
                _displayBox.GetComponent<TMP_Text>().text = "[R]";
            }
            if (_QTEGen == 3)
            {
                _waitingForKey = 1;
                _displayBox.GetComponent<TMP_Text>().text = "[T]";
            }
        }

        if(_QTEGen ==1)
        {
            if(Input.anyKeyDown)
            {
                if(Input.GetButtonDown("EKey"))
                {
                    _correctKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    _correctKey = 2;
                    StartCoroutine(KeyPressing());
                }
            }
        }

        if (_QTEGen == 2)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetButtonDown("RKey"))
                {
                    _correctKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    _correctKey = 2;
                    StartCoroutine(KeyPressing());
                }
            }
        }
        if (_QTEGen == 3)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetButtonDown("TKey"))
                {
                    _correctKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    _correctKey = 2;
                    StartCoroutine(KeyPressing());
                }
            }
        }
    }

    IEnumerator KeyPressing()
    {
        _QTEGen = 4;
        if(_correctKey == 1)
        {
            _countingDown = 2;
            _passBox.GetComponent<TMP_Text>().text = "PASS!";
            yield return new WaitForSeconds(1.5f);
            _correctKey = 0;
            _passBox.GetComponent<TMP_Text>().text = "";
            _displayBox.GetComponent<TMP_Text>().text = "";
            yield return new WaitForSeconds(1.5f);
            _waitingForKey = 0;
            _countingDown = 1;
        }
        if (_correctKey == 2)
        {
            _countingDown = 2;
            _passBox.GetComponent<TMP_Text>().text = "FAIL!";
            yield return new WaitForSeconds(1.5f);
            _correctKey = 0;
            _passBox.GetComponent<TMP_Text>().text = "";
            _displayBox.GetComponent<TMP_Text>().text = "";
            yield return new WaitForSeconds(1.5f);
            _waitingForKey = 0;
            _countingDown = 1;
        }
    }

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(3.5f);
        if(_countingDown == 1)
        {
            _QTEGen = 4;
            _countingDown = 2;
            _passBox.GetComponent<TMP_Text>().text = "FAIL!";
            yield return new WaitForSeconds(1.5f);
            _correctKey = 0;
            _passBox.GetComponent<TMP_Text>().text = "";
            _displayBox.GetComponent<TMP_Text>().text = "";
            yield return new WaitForSeconds(1.5f);
            _waitingForKey = 0;
            _countingDown = 1;
        }
    }
}
