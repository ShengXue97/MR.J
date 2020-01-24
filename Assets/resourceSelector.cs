using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceSelector : MonoBehaviour
{
    bool mouseOver = false;
    public string selectedResource = "none";
    private MiningBehaviourScript mineManager;
    // Start is called before the first frame update
    void Start()
    {
        mineManager = GameObject.Find("GameManager").GetComponent<MiningBehaviourScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && mouseOver) {
            print("Updating");
            if (gameObject.name.Equals("stringCart")) {
                print("string mining");
                selectedResource = "String";
            } else if (gameObject.name.Equals("intCart")) {
                print("int mining");
                selectedResource = "int";
            } else if (gameObject.name.Equals("doubleCart")) {
                print("double mining");
                selectedResource = "Double";
            }
        // this object was clicked - do something
        mineManager.resourceSelected = selectedResource;
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

}
