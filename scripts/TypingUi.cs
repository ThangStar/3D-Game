using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System.Threading.Tasks;

public class typewriterUI : MonoBehaviour
{

    Text _text;
    TMP_Text _tmpProText;
    string writer;

    [SerializeField] float delayBeforeStart = 0f;
    [SerializeField] float timeBtwChars = 0.03f;
    [SerializeField] string leadingChar = "";
    [SerializeField] bool leadingCharBeforeDelay = false;
  
    int counterNext = 0;
    public int sceneNum = 1;
    SubTitle[] subTitles;
    public GameObject[] audioObj;
    // Use this for initialization
    void Start()
    {
        switch (sceneNum)
        {
            case 1:
                subTitles = MySubTitle.getScene1();
                break;
            case 2:
                subTitles = MySubTitle.getScene2();
                audioObj = GameObject.FindGameObjectsWithTag("audio");
                break;
        }
        _text = GameObject.FindGameObjectWithTag("sub_title").GetComponent<Text>();

        if (_text != null)
        {
            nextWord();
        }
    }
    public void nextWord()
    {
        switch (sceneNum)
        {
            case 2:
                if (counterNext == 1)
                {
                    audioObj[1].GetComponent<AudioSource>().Play();
                }
                else if (counterNext == 3)
                {
                    audioObj[2].GetComponent<AudioSource>().Play();
                }
                break;
        }

        if (counterNext >= subTitles.Length)
        {
            return;     
        }
        StopCoroutine("TypeWriterText");
        writer = subTitles[counterNext].subTitle;
        StartCoroutine("TypeWriterText");
        counterNext++;
    }

    // IEnumerable LoadLeverAsync()
    // {
    //     AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);
    //     loadOperation.allowSceneActivation = false;
    //     while (!loadOperation.isDone)
    //     {
    //         float progressValue = Mathf.Clamp01(loadOperation.progress / 0.9f);
    //         loadingSlider.value = progressValue;
    //         yield return null;
    //     }
    // }
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

}