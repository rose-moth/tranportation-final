using UnityEngine;
using System.Collections;

public class CubeBehavior : MonoBehaviour
{

    //because the variable is no longer global, we must refer to it here
    //does this make it so that this script has a bridge to the other???
    GameControllerScript aGameController;
    //this code tracks the position of cubes in this script?
    public int x, y;



    void OnMouseDown()
    {
        //foreach is like for, but selects each item in an array 
        //so we're defining the name of each item in the array inside the foreach conditional?

     

        //foreach (GameObject oneCube in aGameController.allCubes) //oneCube is 1 element of the array, like i. allCubes is a variable in GameControllerScript
        //{
            //you then call each item of the array and change them individually
         //   oneCube.GetComponent<Renderer>().material.color = Color.white;
        //}

//        {
  //          GetComponent<Renderer>().material.color = Color.red;
    //    }


        //'this' refers to the specific script we're using atm (CubeBehavior), and "gameObject" refers to the GameObject we're attached to.
        //these are just ways so that the code knows what it's working on, since it's not like gameMaker that knows what it's attached to already.

        //add in all the variables that will be passed to this one function, including the new x and y values
        aGameController.ProcessClickedCube(this.gameObject, x , y);


    }


    // Use this for initialization
    void Start()
    {
        //find finds the object in the scene, and the getComponent accesses its script
        aGameController = GameObject.Find("GameControllerObject").GetComponent<GameControllerScript>();

    }

    // Update is called once per frame
    void Update()
    {

    }
}