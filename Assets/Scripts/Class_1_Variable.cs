﻿// 單行註解：程式解釋、說明、描述或者作者資訊，不被程式執行，可用任何語言
// KID 2025.01.08

/* 多行註解
 * 第二行註解
 * 第三行註解
 */

// 引用 Unity 遊戲引擎的函式庫 (開發遊戲的程式集合，命名空間)
using UnityEngine;

// 修飾詞 類別關鍵字(腳本) 類別名稱(腳本名稱)
// 在腳本後添加 : MonoBehaviour 可以讓此腳本掛在 Unity 的物件上
public class Class_1_Variable : MonoBehaviour
{
    // 程式內的括號都是成對出現 () [] {} <> '' ""
    // class {} 此類別的程式內容

    // 變數：會改變的數值，用來存放遊戲或系統內的資訊
    // 例如：英雄聯盟的玩家金幣 500，隨著遊戲改變增加，例如砲車 +90 塊
    // 定義一個記憶體內的空間用來存放資訊

    // 變數語法：
    // 修飾詞 變數資料類型 變數名稱;
    // 修飾詞 變數資料類型 變數名稱 指定 預設值; (指定 預設值 可省略)
    // 資料類型：告訴記憶體可以放入那些資料，例如：整數 int 可以放沒有小數點的數值
    // 變數名稱：習慣用小寫開頭命名，駝峰式命名，規則與腳本名稱相同
    // 公開：允許其他類別存取，顯示在屬性面板上 public 
    // 私人：禁止其他類別存取，隱藏在屬性面板上 private (預設)
    public int coin = 500;
    private int level = 3;
}

// 類別外，不要將程式寫在這裡