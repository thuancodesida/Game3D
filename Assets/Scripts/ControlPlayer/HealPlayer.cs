using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPlayer : MonoBehaviour
{
        public Transform player; // Nhân vật hoặc đối tượng mà thanh máu sẽ theo
        public Vector3 offset; // Độ lệch của thanh máu so với đối tượng

        private RectTransform healthBarRect;
        private Canvas canvas;

        void Start()
        {
            // Lấy RectTransform của thanh máu
            healthBarRect = GetComponent<RectTransform>();
            canvas = GetComponentInParent<Canvas>();
        }

        void Update()
        {
            // Chuyển đổi vị trí thế giới của đối tượng thành vị trí màn hình
            Vector3 screenPos = Camera.main.WorldToScreenPoint(player.position + offset);
            // Cập nhật vị trí của thanh máu trên Canvas
            healthBarRect.position = screenPos;
        }
    }

