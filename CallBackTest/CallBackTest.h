#pragma once

#include <iostream>

// �R�[���o�b�N�֐��̌^���`
typedef void(__stdcall* CallbackFunc)(int, int);

// �R�[���o�b�N��ێ�����ϐ�
CallbackFunc g_callback = nullptr;

// �R�[���o�b�N��ݒ肷��֐�
extern "C"
{
	__declspec(dllimport) void SetCallback(CallbackFunc callback);

	__declspec(dllimport) void TriggerCallback(int value1, int value2);
}