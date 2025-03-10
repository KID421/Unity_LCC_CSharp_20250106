﻿using KID.Tools;
using UnityEngine;

namespace KID.Class_15
{
    /// <summary>
    /// 介面 interface
    /// </summary>
    public class Class_15_Interface : MonoBehaviour
    {
        public object invertoryFirst;

        private void Awake()
        {
            int random = Random.Range(0, 3);     // 隨機 0 ~ 3 (不會出現 3)
            LogSystem.LogWithColor($"隨機：{random}", "#f33");

            if (random == 0) invertoryFirst = new Prop();
            else if (random == 1) invertoryFirst = new Equipment();
            else if (random == 2) invertoryFirst = new Map();
        }

        private void Update()
        {
            // 按下數字鍵 1 可以使用第一個的物品
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                // 如果第一格是道具，就使用道具
                if (invertoryFirst is Prop) ((Prop)invertoryFirst).Use();

                // 如果第一格是裝備，就使用裝備
                else if (invertoryFirst is Equipment) ((Equipment)invertoryFirst).Use();

                // 如果第一格是地圖，就使用地圖
                else if (invertoryFirst is Map) ((Map)invertoryFirst).Use();

                // 當遊戲的物品種類變多的時候，這邊的判斷式會很恐怖...
            }
        }
    }

    public class Prop
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用道具，恢復體力", "#f96");
        }
    }

    public class Equipment
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用裝備，裝到對應位置", "#9f6");
        }
    }

    public class Map
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用地圖，開啟地圖功能", "#96f");
        }
    }
}
