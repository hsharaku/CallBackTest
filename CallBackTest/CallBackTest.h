#pragma once

#include <iostream>

// コールバック関数の型を定義
typedef void(__stdcall* CallbackFunc)(int, int);

// コールバックを保持する変数
CallbackFunc g_callback = nullptr;

// コールバックを設定する関数
extern "C"
{
	__declspec(dllimport) void SetCallback(CallbackFunc callback);

	__declspec(dllimport) void TriggerCallback(int value1, int value2);
}