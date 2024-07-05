using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

	class Program
	{
		// コールバック関数のデリゲート型を定義
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate void CallbackDelegate(int value1, int value2);

		// SetCallback関数をインポート
		[DllImport("CallBackTest.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern void SetCallback(CallbackDelegate callback);

		// TriggerCallback関数をインポート
		[DllImport("CallBackTest.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern void TriggerCallback(int value1, int value2);

		// コールバック関数
		public static void MyCallback(int value1, int value2)
		{
			Console.WriteLine("Callback received with value: " + value1 + "::" + value2);
		}

		static void Main(string[] args)
		{
			// コールバックデリゲートを作成
			CallbackDelegate callbackDelegate = new CallbackDelegate(MyCallback);

			// コールバックを設定
			SetCallback(callbackDelegate);

			// コールバックをトリガー
			TriggerCallback(123, 321);

			// プログラムが終了しないようにする（コールバックを確認するため）
			Console.ReadLine();
		}
	}
}
