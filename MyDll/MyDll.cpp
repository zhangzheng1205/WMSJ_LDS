// MyDll.cpp: 定义 DLL 应用程序的导出函数。
//
#include "stdafx.h"

extern "C" _declspec(dllexport) bool GetResult(char** result)
{
	*(result) = (char*)"Hello from MyDll";
	return true;
}


