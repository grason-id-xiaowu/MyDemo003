using UnityEngine.SceneManagement;
using UnityEngine;

public static class Utility
{
    /// <summary>
    /// 查找场景中是否存在某个类
    /// </summary>
    /// <typeparam name="T">查找对象类</typeparam>
    /// <returns></returns>
    public static bool DoesGameObjectWithScriptExist<T>() where T : MonoBehaviour
    {
        GameObject[] rootObjects = SceneManager.GetActiveScene().GetRootGameObjects();
        foreach (GameObject rootObject in rootObjects)
        {
            T foundScript = rootObject.GetComponentInChildren<T>(true);
            if (foundScript != null)
            {
                return true;
            }
        }
        return false;
    }
    /// <summary>
    /// 查找场景中是否存在某个类并返回这个值
    /// </summary>
    /// <typeparam name="T">查找对象类</typeparam>
    /// <returns></returns>
    public static T DoesGameObjectWithScriptExistAndReturn<T>() where T : MonoBehaviour
    {
        GameObject[] rootObjects = SceneManager.GetActiveScene().GetRootGameObjects();
        foreach (GameObject rootObject in rootObjects)
        {
            T foundScript = rootObject.GetComponentInChildren<T>(true);
            if (foundScript != null)
            {
                return foundScript;
            }
        }
        return null;
    }
}