using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class typewriterUI : MonoBehaviour
{
    Text _text;
    TMP_Text _tmpProText;
    string writer;

    [SerializeField] float delayBeforeStart = 0f;
    [SerializeField] float timeBtwChars = 0.03f;
    [SerializeField] string leadingChar = "";
    [SerializeField] bool leadingCharBeforeDelay = false;

    // Use this for initialization
    void Start()
    {
        _text = GameObject.FindGameObjectWithTag("sub_title").GetComponent<Text>();

        if (_text != null)
        {
            writer = _text.text;
            _text.text = "";
            StartCoroutine("TypeWriterText");
        }
    }
    public void nextWord()
    {
        StopCoroutine("TypeWriterText");
        writer = "_text.text";
        StartCoroutine("TypeWriterText");
    }

    IEnumerator TypeWriterText()
    {
        _text.text = leadingCharBeforeDelay ? leadingChar : "";

        yield return new WaitForSeconds(delayBeforeStart);

        foreach (char c in writer)
        {
            if (_text.text.Length > 0)
            {
                _text.text = _text.text.Substring(0, _text.text.Length - leadingChar.Length);
            }
            _text.text += c;
            _text.text += leadingChar;
            yield return new WaitForSeconds(timeBtwChars);
        }

        if (leadingChar != "")
        {
            _text.text = _text.text.Substring(0, _text.text.Length - leadingChar.Length);
        }
    }

    IEnumerator TypeWriterTMP()
    {
        _tmpProText.text = leadingCharBeforeDelay ? leadingChar : "";

        yield return new WaitForSeconds(delayBeforeStart);

        foreach (char c in writer)
        {
            if (_tmpProText.text.Length > 0)
            {
                _tmpProText.text = _tmpProText.text.Substring(0, _tmpProText.text.Length - leadingChar.Length);
            }
            _tmpProText.text += c;
            _tmpProText.text += leadingChar;
            yield return new WaitForSeconds(timeBtwChars);
        }

        if (leadingChar != "")
        {
            _tmpProText.text = _tmpProText.text.Substring(0, _tmpProText.text.Length - leadingChar.Length);
        }
    }
}