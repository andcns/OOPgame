using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsComparer : MonoBehaviour
{
    [SerializeField] GameObject object1;
    [SerializeField] GameObject object2;

    ClassExample object1Script;
    ClassExample object2Script;

    int object1IntsSummed;
    int object2IntsSummed;


    // Start is called before the first frame update
    void Start()
    {
        object1Script = object1.GetComponent<ClassExample>();
        object2Script = object2.GetComponent<ClassExample>();

        object1IntsSummed = object1Script.GetInteger1() + object1Script.GetInteger2();
        object2IntsSummed = object2Script.GetInteger1() + object2Script.GetInteger2();

        if(object1IntsSummed > object2IntsSummed)
        {
          print("the sum of object 1 integers is greater than the sum of object 2 integers");
        }
        else if(object1IntsSummed < object2IntsSummed)
        {
          print("the sum of object 1 integers is lesser than the sum of object 2 integers");
        }
        else if(object1IntsSummed == object2IntsSummed)
        {
          print("the sum of object 1 integers is equal to the sum of object 2 integers");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
