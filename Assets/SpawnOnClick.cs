using UnityEngine;

public class SpawnOnClick : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = (Vector2)touchPos;
                bullet.transform.rotation = Quaternion.identity;
                bullet.SetActive(true);
            }
        }
    }
}
