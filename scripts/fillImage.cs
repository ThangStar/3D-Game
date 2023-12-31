using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fillImage : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isAspecratio;
    void Start()
    {
        var topRightCorner =  Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        var worldSpaceWidth = topRightCorner.x * 2;
        var worldSpaceHeight = topRightCorner.y * 2;    
        var spriteSize = GetComponent<SpriteRenderer>().bounds.size;
        var scaleFactorX = worldSpaceWidth / spriteSize.x;
        var scaleFactorY = worldSpaceHeight / spriteSize.y;
        if(isAspecratio)
        {
            if(scaleFactorX > scaleFactorY)
            {
                scaleFactorY = scaleFactorX;
            }
            else
            {
                scaleFactorX = scaleFactorY;
            }
        }
        transform.localScale = new Vector3(scaleFactorX, -scaleFactorY, 1);
    }

        }
