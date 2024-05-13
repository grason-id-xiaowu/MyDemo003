using UnityEngine.SceneManagement;
using UnityEngine;

public static class Utility
{
    /// <summary>
    /// ���ҳ������Ƿ����ĳ����
    /// </summary>
    /// <typeparam name="T">���Ҷ�����</typeparam>
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
    /// ���ҳ������Ƿ����ĳ���ಢ�������ֵ
    /// </summary>
    /// <typeparam name="T">���Ҷ�����</typeparam>
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