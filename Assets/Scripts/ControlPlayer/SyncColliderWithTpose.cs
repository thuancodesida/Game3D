using UnityEngine;

public class SyncColliderWithTpose : MonoBehaviour
{
    public GameObject tpose; // Đối tượng Tpose
    private Collider enemyCollider; // Collider của đối tượng enemy
    private Transform tposeTransform; // Transform của đối tượng Tpose

    void Start()
    {
        // Lấy Collider của đối tượng enemy
        enemyCollider = GetComponent<Collider>();

        // Kiểm tra xem tpose và enemyCollider có tồn tại không
        if (tpose == null)
        {
            Debug.LogError("Tpose object is not assigned.");
        }

        if (enemyCollider == null)
        {
            Debug.LogError("Collider component is missing from the enemy.");
        }

        // Lấy Transform của đối tượng Tpose
        if (tpose != null)
        {
            tposeTransform = tpose.transform;
        }
    }

    void FixedUpdate()
    {
        // Đồng bộ vị trí và hướng của Collider với Tpose
        if (tposeTransform != null && enemyCollider != null)
        {
            enemyCollider.transform.position = tposeTransform.position;
            enemyCollider.transform.rotation = tposeTransform.rotation;
        }
    }
}
