using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MineResourceScript : MonoBehaviour
{
    private MiningBehaviourScript mineManager;

    // Start is called before the first frame update
    private bool mouseOver = false;
    private bool mouseUp = false;
    private bool prevTrigger = false;
    private bool correctResource;
    private double newValue;
    void Start()
    {
        mineManager = GameObject.Find("GameManager").GetComponent<MiningBehaviourScript>();
    }

    // Update is called once per frame
    public void onClickAction()
    {
        print("clicked");
        if (gameObject.tag.Equals("stringResource") && mineManager.resourceSelected.Equals("String")) {
            print("mined");
            gameObject.transform.GetChild(0).gameObject.GetComponent<ResourceIndicatorScript>().deplete();
            mineManager.String_val += 1;
        } else if (gameObject.tag.Equals("intResource") && mineManager.resourceSelected.Equals("int")) {
            print("mined");
            gameObject.transform.GetChild(0).gameObject.GetComponent<ResourceIndicatorScript>().deplete();
            mineManager.Int_val += 1;
        } else if (gameObject.tag.Equals("doubleResource") && mineManager.resourceSelected.Equals("Double")) {
            print("mined");
            gameObject.transform.GetChild(0).gameObject.GetComponent<ResourceIndicatorScript>().deplete();
            mineManager.Double_val += 1;
        }
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0) && mouseOver && mouseUp) {
            //print ("ingot interaction");
            onClickAction();
        // this object was clicked - do something
        }
    }

  // The mesh goes red when the mouse is over it...
    void OnMouseEnter()
    {
        mouseOver = true;
    }

    // The mesh goes red when the mouse is over it...
    void OnMouseOver()
    {
        mouseOver = true;
    }
    void OnMouseExit() {
       mouseOver = false;
   }

    void OnMouseUp() {
        print("Mouse Up");
        //print ("ingot interaction");
        onClickAction();
        // this object was clicked - do something
    }

}
