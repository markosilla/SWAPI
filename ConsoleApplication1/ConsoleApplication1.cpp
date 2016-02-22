// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <conio.h>

extern "C" {
#include "C:\\ScanWorks\\ScanworksAPI\\SWProto.h"
};

int _tmain(int argc, _TCHAR* argv[])
{
	long rc = 1;

	printf("Connecting...\n");
	rc = sw_connect();
	if (rc == 0)
	{
		printf("Connect OK!\n");
	}
	else printf("FAIL during connect to ScanWorks.\n");

	//Import project

	char ImportProjectName[255];
	rc = sw_ImportProjectTo("C:\\ScanWorks\\Examples\\Scanlite2ExampleProject.zip", 255, ImportProjectName, "SL_importedFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", "");
	if (rc == 0)
	{
		printf("Project Import SL2_imported OK!\n");
	}
	else printf("FAIL during Import Project SL2_imported.\n %ld \n", rc);



	//This where to change to your project name
	rc = sw_LoadProject("SL_imported");
	if (rc == 0)
	{
		printf("Project Load SL_imported OK!\n");
	}
	else printf("FAIL during Load Project SL_imported.\n %ld \n", rc);

	//This where to change to your design name
	rc = sw_LoadDesign("Scanlite 2");
	if (rc == 0)
	{
		printf("Design Load Scanlite 2 OK!\n");
	}
	else printf("FAIL during Load Design Scanlite 2.\n %ld \n", rc);

	rc = sw_SetUserTCK(10000000);
	if (rc == 0)
	{
		printf("Set TCK OK!\n");
	}
	else printf("FAIL during Set TCK.\n");

	rc = sw_LoadAction("SPV1");
	if (rc == 0)
	{
		printf("Load Action SPV1 OK!\n");
	}
	else printf("FAIL during Load Action SPV1.\n %ld \n", rc);

	rc = sw_RunAction();
	if (rc == 0)
	{
		printf("Run Action SPV1 OK!\n");
	}
	else printf("FAIL during Run Action SPV1.\n %ld \n", rc);


	for (int q = 0; q<10; q = q + 1)
	{
		//This where to change to your action name
		rc = sw_LoadAction("MAV1");
		if (rc == 0)
		{
			printf("Load Action MAV1 OK!\n");
		}
		else printf("FAIL during Load Action MAV1.\n %ld \n", rc);

		rc = sw_RunAction();
		if (rc == 0)
		{
			printf("Run Action MAV1 OK!\n");
		}
		else printf("FAIL during Run Action MAV1.\n %ld \n", rc);
	}

	rc = sw_LoadAction("Flash1");
	if (rc == 0)
	{
		printf("Load Action Flash1 OK!\n");
	}
	else printf("FAIL during Load Action Flash1.\n %ld \n", rc);

	rc = sw_RunAction();
	if (rc == 0)
	{
		printf("Run Action Flash1 OK!\n");
	}
	else printf("FAIL during Run Action Flash1.\n %ld \n", rc);

	/*
	rc = sw_LoadAction("NAND Flash1");
	if (rc == 0)
	{
	printf("Load Action NAND_Flash1 OK!\n");
	}
	else printf("FAIL during Load Action NAND Flash1.\n");

	rc = sw_RunAction();
	if (rc == 0)
	{
	printf("Run Action NAND_Flash1 OK!\n");
	}
	else printf("FAIL during Run Action NAND Flash1.\n %ld \n",rc);

	*/
	printf("Disconnecting...\n");
	sw_disconnect();
	printf("Done!");
	_getch();
	return 0;
}
