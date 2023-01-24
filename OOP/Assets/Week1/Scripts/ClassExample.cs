using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassExample : MonoBehaviour
{
    [SerializeField] string yourMessage;
    [SerializeField] bool printMessage;
    [SerializeField] int integer1;
    [SerializeField] int integer2;
    // Start is called before the first frame update
    void Start()
    {
        if(printMessage)
        {
         print(yourMessage);

         if(integer1 > integer2)
         {
            print("integer1 is bigger than integer2");
         }

         else if(integer2 > integer1)
         {
            print("integer2 is bigger than integer1");
         }
         else if(integer1 == integer2)
         {
            print("integers are equal");
         }
            
        }
        
    }

    public int GetInteger1()
    {
        return integer1;
    }

    public int GetInteger2()
    {
        return integer2;
    }
}
