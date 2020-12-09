using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// create this script so we can reuse for any object we just want one of
// ie audio manager, gamemanager

// where T : Singleton<T> means requires that the generic inherits this class
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance;

    // no setter to protect from anything external changing it
    public static T Instance
    {
        get { return instance; }
    }

    // check to see if the instance exists with having to check for null
    public static bool Initialized
    {
        get { return instance != null; }
    }

    // we may want a gameobject to do something different on awake so switch these to protected, virtual so they can be overridden
    protected virtual void Awake()
    {
        if (instance != null)
        {
            // TODO we wnat the game manager to remain so check how to do this
            Destroy(gameObject);
            //Debug.LogError("[Singleton] Trying to instantiate a second instance of a singleton class");
        }
        else
        {
            instance = (T)this;
        }
    }

    // if object is destroyed the another singleton is created
    protected virtual void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }

}

