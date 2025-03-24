﻿using KID.Tools;
using UnityEngine;

namespace KID.Class_19.Event
{
    /// <summary>
    /// 背景音樂管理器
    /// </summary>
    public class Class_19_BgmManager : MonoBehaviour
    {
        [SerializeField]
        private Class_19_Event class_19_event;

        // 步驟 3. 訂閱事件 (Unity 習慣在 Awake 或 Start 訂閱)
        private void Awake()
        {
            // 事件：輸入 += 可以使用 Tab 自動完成 > 命名方法後 > Enter 完成
            class_19_event.onDead += ChangeBgm;
            class_19_event.onDeadAction += ChangeBgmViaHp;
        }

        private void ChangeBgmViaHp(string arg1, float arg2)
        {
            LogSystem.LogWithColor($"{arg1} | 血量：{arg2}", "#78f");
            if (arg2 <= -5) LogSystem.LogWithColor("變更為遊戲結束音樂", "#777");
        }

        private void ChangeBgm()
        {
            LogSystem.LogWithColor("變更音樂", "#3f3");
        }
    }
}
