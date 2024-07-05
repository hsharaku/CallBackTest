#include "pch.h"
#include "CallBackTest.h"

void SetCallback(CallbackFunc callback)
{
  g_callback = callback;
}

void TriggerCallback(int value1, int value2)
{
  if (g_callback)
  {
    g_callback(value1, value2);
  }
}